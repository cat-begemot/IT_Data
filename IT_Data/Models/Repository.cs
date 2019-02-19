using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace IT_Data.Models
{
	public class Repository : IRepository
	{
		private String connectionString;
		private SqlConnection connection;
		private Orders orders = new Orders();

		public Repository()
		{
			Init_ConnectionString();
			connection = new SqlConnection(connectionString);
		}

		public String ConnectionString { get => connectionString; }
		public Orders Orders { get => orders; }

		/// <summary>
		/// Initialize connection string using parameters from config.json file
		/// </summary>
		private void Init_ConnectionString()
		{
			// Init configuration file
			var configBuilder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("config.json");
			IConfiguration config = configBuilder.Build();

			// Init connection string
			var conStrBuilder = new SqlConnectionStringBuilder();
			
			conStrBuilder.DataSource = config["connectionStringParams:ServerInstanceName"];
			conStrBuilder.InitialCatalog = config["connectionStringParams:DatabaseName"];			
			conStrBuilder.UserID = config["connectionStringParams:Login"];
			if(conStrBuilder.UserID=="")
				conStrBuilder.IntegratedSecurity = true; // Use Windows Authentication
			else
				conStrBuilder.IntegratedSecurity = false; // Use SQL Server Authentication
			conStrBuilder.Password = config["connectionStringParams:Password"];
			connectionString = conStrBuilder.ConnectionString;
		}

		/// <summary>
		/// Returns all registered users
		/// </summary>
		/// <returns></returns>
		public List<string> GetLoginList()
		{
			List<String> users = new List<String>();
			try
			{
				connection.Open();
				String sqlQuery = "SELECT userlogin FROM dbo.Users ORDER BY userlogin;";
				var command = new SqlCommand(sqlQuery, connection);
				using (var result = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
				{
					while(result.Read())
						users.Add(result.GetString(0));
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			return users;
		}

		/// <summary>
		/// Login user
		/// </summary>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public bool Login(string login, string password)
		{
			String saved_psw;
			Boolean isSuccessfull = false;
			connection.Open();
			String SQLQuery = "SELECT userpassword FROM dbo.Users WHERE userlogin=@login;";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			try
			{
				saved_psw = (String)command.ExecuteScalar();
				if (saved_psw == GetHash(password))
					isSuccessfull = true;
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return isSuccessfull;
		}

		/// <summary>
		/// Get hash from string
		/// </summary>
		/// <param name="psw"></param>
		/// <returns></returns>
		public static String GetHash(String psw)
		{
			var sha = SHA256.Create();
			var passwordWithSalt = psw;

			return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(passwordWithSalt)));
		}


		public int GetAttemptsQty(string login)
		{
			connection.Open();
			String SQLQuery = "SELECT attemptsQty FROM dbo.Users WHERE userlogin=@login;";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			Int32 qty = 0;
			try
			{
				qty = (Int32)command.ExecuteScalar();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return qty;
		}

		public void SetAttemptsQty(string login, Int32 value)
		{
			connection.Open();
			String SQLQuery = "UPDATE dbo.Users SET attemptsQty=@value WHERE userlogin=@login";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			command.Parameters.AddWithValue("value", value);
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
		}

		public bool IsBlocked(string login)
		{
			connection.Open();
			String SQLQuery = "SELECT isBlocked FROM dbo.Users WHERE userlogin=@login;";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			Boolean isBlocked=true;
			try
			{
				isBlocked= (Boolean)command.ExecuteScalar();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return isBlocked;
		}

		/// <summary>
		/// Set blockflag for user
		/// </summary>
		/// <param name="login">User's login</param>
		/// <param name="value">True - block user, False - unblock</param>
		public void SetIsBlockUser(String login, Boolean value)
		{
			connection.Open();
			String SQLQuery = "UPDATE dbo.Users SET isBlocked=@value WHERE userlogin=@login";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			command.Parameters.AddWithValue("value", value);
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
		}

		public Boolean IsAdmin(string login)
		{
			connection.Open();
			Boolean isAdmin=false;
			String SQLQuery = "SELECT adminFlag FROM dbo.Users WHERE userlogin=@login";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			try
			{
				isAdmin = (Boolean)command.ExecuteScalar();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return isAdmin;
		}

		public List<String> GetUserList()
		{
			List<String> users = new List<String>();
			try
			{
				connection.Open();
				String SQLQuery = "SELECT userlogin FROM dbo.Users ORDER BY userlogin;";
				var command = new SqlCommand(SQLQuery, connection);
				using (var result = command.ExecuteReader(CommandBehavior.CloseConnection))
				{
					while (result.Read())
						users.Add(result.GetString(0));
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			return users;
		}

		public User GetUser(string login)
		{
			User user = new User();
			try
			{
				connection.Open();
				String SQLQuery = "SELECT * FROM dbo.Users WHERE userlogin=@login;";
				var command = new SqlCommand(SQLQuery, connection);
				command.Parameters.AddWithValue("login", login);
				using (var result = command.ExecuteReader(CommandBehavior.CloseConnection))
				{
					result.Read();
					user.Manager = result.GetString(0);
					user.AdminFlag = result.GetBoolean(1);
					user.Password = result.GetString(2);
					user.Login = result.GetString(3);
					user.AtttemptsQty = result.GetInt32(4);
					user.IsBlocked = result.GetBoolean(5);
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			return user;
		}

		public void EditUser(User user, String currentLogin)
		{
			String SQLQuery = "UPDATE dbo.Users " +
				"SET manager=@manager, adminFlag=@adminFlag, " +
				"userpassword=@userpassword, userLogin=@userlogin, " +
				"isBlocked=@isBlocked " +
				"WHERE userLogin=@currentlogin;";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("manager", user.Manager);
			command.Parameters.AddWithValue("adminFlag", user.AdminFlag);
			command.Parameters.AddWithValue("userpassword", user.Password);
			command.Parameters.AddWithValue("userlogin", user.Login);
			command.Parameters.AddWithValue("isBlocked", user.IsBlocked);
			command.Parameters.AddWithValue("currentlogin", currentLogin);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
		}

		public void DeleteUser(string login)
		{
			String SQLQuery = "DELETE FROM dbo.Users WHERE userlogin=@userlogin";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("userlogin", login);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
		}

		public void CreateUser(User user)
		{
			String SQLQuery = "INSERT INTO dbo.Users VALUES (@manager, @adminFlag, @userpassword, " +
				"@userlogin, 0, @isBlocked);";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("manager", user.Manager);
			command.Parameters.AddWithValue("adminFlag", user.AdminFlag);
			command.Parameters.AddWithValue("userpassword", user.Password);
			command.Parameters.AddWithValue("userlogin", user.Login);
			command.Parameters.AddWithValue("isBlocked", user.IsBlocked);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
		}

		public bool IsLoginExists(string login, String currentLogin)
		{
			String SQLQuery= "SELECT userlogin FROM dbo.Users WHERE userlogin=@login AND NOT userlogin=@curlogin;";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("login", login);
			command.Parameters.AddWithValue("curlogin", currentLogin);
			Boolean isLoginExists = true;
			try
			{
				connection.Open();
				String result = (String)command.ExecuteScalar();
				if (result == null)
					isLoginExists = false;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return isLoginExists;
		}

		public void AddOrder(Order order)
		{
			String SQLQuery = "INSERT INTO dbo.Orders VALUES (@orderdate, @company, " +
				"@city, @country, @manager, @qty, @amount);";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("orderdate", order.OrderDate);
			command.Parameters.AddWithValue("company", order.Company);
			command.Parameters.AddWithValue("city", order.City);
			command.Parameters.AddWithValue("country", order.Country);
			command.Parameters.AddWithValue("manager", order.Manager);
			command.Parameters.AddWithValue("qty", order.Qty);
			command.Parameters.AddWithValue("amount", order.Amount);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
		}

		public bool HasUserAnyOrders(string login)
		{
			Int32 qtyOrders = 0;
			Boolean hasOrders = false;
			String SQLQuery = "SELECT COUNT(*) FROM dbo.Orders WHERE manager=@manager;";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("manager", GetUser(login).Manager);
			try
			{
				connection.Open();
				qtyOrders = (Int32)command.ExecuteScalar();
				if (qtyOrders > 0)
					hasOrders = true;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return hasOrders;
		}

		public bool HasUserOrdersInCurrentMonth(string login)
		{
			Int32 qtyOrders = 0;
			Boolean hasOrders = false;
			String SQLQuery = "SELECT COUNT(*) FROM dbo.Orders WHERE manager=@manager " +
				"AND MONTH(orderdate)=MONTH(GETDATE());";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("manager", GetUser(login).Manager);
			try
			{
				connection.Open();
				qtyOrders = (Int32)command.ExecuteScalar();
				if (qtyOrders > 0)
					hasOrders = true;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return hasOrders;
		}

		public decimal AvrAmountInCurrentMonth(string login)
		{
			Decimal avgAmount = 0;
			String SQLQuery = "SELECT AVG(amount) FROM dbo.Orders WHERE manager=@manager " +
				"AND MONTH(orderdate)=MONTH(GETDATE());";
			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("manager", GetUser(login).Manager);
			try
			{
				connection.Open();
				avgAmount = (Decimal)command.ExecuteScalar();
				if (command.ExecuteScalar()!=null)
					avgAmount = (Decimal)command.ExecuteScalar();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return avgAmount;
		}

		public decimal AvrAmountInLastMonth(string login)
		{
			Decimal avgAmount = 0;
			String SQLQuery = "DECLARE @lastOrder DATE=(SELECT TOP(1) orderdate FROM dbo.Orders WHERE manager=@manager ORDER BY orderdate DESC); " +
				"DECLARE @startDate DATE = DATEFROMPARTS(YEAR(@lastOrder), MONTH(@lastOrder), 1); " +
				"DECLARE @endDate DATE = DATEADD(DD, -1, DATEFROMPARTS(YEAR(@lastOrder), MONTH(@lastOrder) + 1, 1)); " +
				"SELECT AVG(amount) FROM dbo.Orders " +
				"WHERE manager = @manager AND orderdate BETWEEN @startDate AND @endDate;";

			var command = new SqlCommand(SQLQuery, connection);
			command.Parameters.AddWithValue("manager", GetUser(login).Manager);
			try
			{
				connection.Open();
				avgAmount = (Decimal)command.ExecuteScalar();
				if (command.ExecuteScalar() != null)
					avgAmount = (Decimal)command.ExecuteScalar();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Oops... Exception...",
					MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			connection.Close();
			return avgAmount;
		}

		/// <summary>
		/// Load orders from DB to Orders collection
		/// </summary>
		/// <returns></returns>
		public Orders RefreshOrders()
		{
			try
			{
				connection.Open();
				var command = new SqlCommand(orders.GetSQLReportString(), connection);
				using (var result = command.ExecuteReader(CommandBehavior.CloseConnection))
				{
					orders.FeelOrders(result); // Create table
				}
			}
			catch
			{
				MessageBox.Show("Couldn't connect to database...", "Access error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return orders;
		}
	}
}
