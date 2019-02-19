using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Data.Models
{
	public interface IRepository
	{
		String ConnectionString { get; }
		Orders Orders { get; }


		List<String> GetLoginList();
		Boolean Login(String login, String password);
		Int32 GetAttemptsQty(String login);
		void SetAttemptsQty(String login, Int32 value);
		Boolean IsBlocked(String login);
		void SetIsBlockUser(String login, Boolean value);
		Boolean IsAdmin(String login);

		List<String> GetUserList();
		User GetUser(String login);
		void EditUser(User user, String currentLogin);
		void DeleteUser(String login);
		void CreateUser(User user);
		Boolean IsLoginExists(String login, String currentLogin);

		Orders RefreshOrders();
		void AddOrder(Order order);
		Boolean HasUserAnyOrders(String login);
		Boolean HasUserOrdersInCurrentMonth(String login);
		Decimal AvrAmountInCurrentMonth(String login);
		Decimal AvrAmountInLastMonth(String login);
	}
}
