using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Data.Models;

namespace IT_Data
{
	public partial class orderForm : Form
	{
		private String current_login;
		private IRepository repository;
		private mainForm form;

		public orderForm(String login, mainForm formRef)
		{
			InitializeComponent();
			repository = new Repository();
			current_login = login;
			form = formRef;
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			Order order = new Order();
			Int32 qty;
			Decimal amount;

			// Chech whether all fields is specifed with appropriate types
			if (tb_company.Text.Length == 0)
			{
				MessageBox.Show("Company name isn't specified.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}				
			if (tb_city.Text.Length == 0)
			{
				MessageBox.Show("City isn't specified.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}				
			if (tb_country.Text.Length == 0)
			{
				MessageBox.Show("Country isn't specified.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (tb_qty.Text.Length == 0)
			{
				MessageBox.Show("Quantity isn't specified.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if(!Int32.TryParse(tb_qty.Text, out qty))
			{
				MessageBox.Show("Quantity must be a numeric type.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (tb_amount.Text.Length == 0)
			{
				MessageBox.Show("Amount isn't specified.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Decimal.TryParse(tb_amount.Text, out amount))
			{
				MessageBox.Show("Amount must be a numeric type.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check restrictions
			order.OrderDate = dt_date.Value.Date;
			if(order.OrderDate!=DateTime.Now.Date)
			{
				MessageBox.Show("Only current date is allowed.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(repository.HasUserAnyOrders(current_login))
			{
				if(repository.HasUserOrdersInCurrentMonth(current_login))
				{ // Comparing with orders in current month
					Decimal limitAmount = repository.AvrAmountInCurrentMonth(current_login) + 500;
					if (amount > limitAmount)
					{ // Overlimit
						MessageBox.Show("Order amount is greater than averrage order in current month.\n" +
							$"Allow order amount up to {limitAmount}", "Restriction error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else
				{ // Comparing with orders in previous month where user had sales
					Decimal limitAmount = repository.AvrAmountInLastMonth(current_login) + 500;
					if (amount > limitAmount)
					{ // Overlimit
						MessageBox.Show("Order amount is greater than averrage order in previous month.\n" +
							$"Allow order amount up to {limitAmount}", "Restriction error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}

			// Write order
			order.Company = tb_company.Text;
			order.City = tb_city.Text;
			order.Country = tb_country.Text;
			order.Manager = repository.GetUser(current_login).Manager;
			order.Qty = qty;
			order.Amount = amount;
			repository.AddOrder(order);

			form.Fill_Grid();

			this.Close();
			this.Dispose();
		}
	}
}
