using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IT_Data.Models
{
		public class Order
		{
			public DateTime OrderDate { get; set; }
			public String Company { get; set; }
			public String City { get; set; }
			public String Country { get; set; }
			public String Manager { get; set; }
			public Int32 Qty { get; set; }
			public Decimal Amount { get; set; }
		}

	public class Orders
	{
		// Flags point which columns were selected
		public Boolean FlagOrderDate { get; set; } = false;
		public Boolean FlagCompany { get; set; } = false;
		public Boolean FlagCity { get; set; } = false;
		public Boolean FlagCountry { get; set; } = false;
		public Boolean FlagManager { get; set; } = false;

		// Array with columns sequence in accordance to flags
		private Int32[] columnSequence = new Int32[7];

		private List<Order> orders = new List<Order>();

		/// <summary>
		/// Instances count
		/// </summary>
		public Int64 Length { get => orders.Count; }

		/// <summary>
		/// All instances of Orders
		/// </summary>
		/// <returns></returns>
		public List<Order> GetOrders() => orders;
		public List<Order> AllOrders { get => orders; }

		/// <summary>
		/// Returns TRUE if at least one flag was choosen
		/// </summary>
		/// <returns></returns>
		public Boolean IsAnyFlagSelected()
		{
			return FlagOrderDate || FlagCompany || FlagCity || FlagCountry || FlagManager;
		}

		/// <summary>
		/// Add new instance to Orders
		/// </summary>
		public void AddOrder(DateTime orderdate, String company, String city,
			String country, String manager, Int32 qty, decimal amount)
		{
			orders.Add(new Order()
			{
				OrderDate = orderdate,
				Company = company,
				City = city,
				Country = country,
				Manager = manager,
				Qty = qty,
				Amount = amount
			});
		}

		/// <summary>
		/// Fill instance by response from DB according flags.
		/// If flag is FALSE, appropriate property will be default value
		/// </summary>
		/// <param name="dataReader">Values is returned by ExecuteReader method</param>
		public void FeelOrders(SqlDataReader dataReader)
		{
			orders = new List<Order>();
			while (dataReader.Read())
			{
				Int32 lastSequence;
				Boolean clearedFlags = !IsAnyFlagSelected();
				if (IsAnyFlagSelected())
				{
					lastSequence = -1;

					if (FlagOrderDate)
						columnSequence[0] = ++lastSequence;
					if (FlagCompany)
						columnSequence[1] = ++lastSequence;
					if (FlagCity)
						columnSequence[2] = ++lastSequence;
					if (FlagCountry)
						columnSequence[3] = ++lastSequence;
					if (FlagManager)
						columnSequence[4] = ++lastSequence;
					columnSequence[5] = ++lastSequence;
					columnSequence[6] = ++lastSequence;
				}
				else
				{
					lastSequence = 0;
					for (; lastSequence < 7; lastSequence++)
						columnSequence[lastSequence] = lastSequence;
				}

				this.AddOrder(
					FlagOrderDate || clearedFlags ? dataReader.GetDateTime(columnSequence[0]) : default(DateTime),
					FlagCompany || clearedFlags ? dataReader.GetString(columnSequence[1]) : default(string),
					FlagCity || clearedFlags ? dataReader.GetString(columnSequence[2]) : default(string),
					FlagCountry || clearedFlags ? dataReader.GetString(columnSequence[3]) : default(string),
					FlagManager || clearedFlags ? dataReader.GetString(columnSequence[4]) : default(string),
					dataReader.GetInt32(columnSequence[5]),
					dataReader.GetDecimal(columnSequence[6])
					);
			}
		}

		/// <summary>
		/// Return SQL query of report
		/// </summary>
		/// <returns></returns>
		public String GetSQLReportString()
		{
			// Check filters and create columns list
			StringBuilder columns = new StringBuilder(50);
			void BuildColList(String columnName)
			{
				if (columns.Length != 0)
					columns.Append(", ");
				columns.Append(columnName);
			}

			if (FlagOrderDate)
				BuildColList("orderdate");
			if (FlagCompany)
				BuildColList("company");
			if (FlagCity)
				BuildColList("city");
			if (FlagCountry)
				BuildColList("country");
			if (FlagManager)
				BuildColList("manager");

			StringBuilder sql=new StringBuilder(500);
			if (IsAnyFlagSelected())
			{
				sql.Append($"SELECT {columns}, SUM(qty), SUM(amount)").AppendLine();
				sql.Append($"FROM dbo.Orders").AppendLine();
				sql.Append($"GROUP BY {columns}").AppendLine();
				sql.Append($"ORDER BY {columns};");
			}
			else
				sql.Append("SELECT * FROM dbo.Orders;");

			return sql.ToString();
		}

		/// <summary>
		/// Reset all flags to False
		/// </summary>
		public void ResetFlags()
		{
			FlagOrderDate = false;
			FlagCompany = false;
			FlagCity = false;
			FlagCountry = false;
			FlagManager = false;
		}
	}
}
