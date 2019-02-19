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
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace IT_Data
{
	public partial class mainForm : Form
	{
		private loginForm form;
		private IRepository repository; // Interface which provide contract for working with DB
		private String current_login; // Current user in program

		#region Constructors
		public mainForm()
		{
			InitializeComponent();

			repository = new Repository();

			repository.Orders.ResetFlags(); // Reset all flags in Orders instance to False
			Init_CBs(); // Initialiaze checkboxes on forms according to Orders instance (all are false now)
			Fill_Grid(); // Fill grid with Orders records

			// Format grid
			grid_data.Columns["OrderDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			grid_data.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid_data.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		public mainForm(loginForm callingForm, String login) : this()
		{
			form = callingForm;
			current_login = login;
			btn_users.Visible = repository.IsAdmin(current_login);
		}
		#endregion

		/// <summary>
		/// Fill grid
		/// </summary>
		public void Fill_Grid()
		{
			grid_data.DataSource = repository.RefreshOrders().AllOrders; // Provided through IList interface
			tb_query.Text = repository.Orders.GetSQLReportString();
			// Choose appropriate columns for showing report
			Boolean fullReport = !repository.Orders.IsAnyFlagSelected();
			grid_data.Columns["OrderDate"].Visible = repository.Orders.FlagOrderDate || fullReport;
			grid_data.Columns["Company"].Visible = repository.Orders.FlagCompany || fullReport;
			grid_data.Columns["City"].Visible = repository.Orders.FlagCity || fullReport;
			grid_data.Columns["Country"].Visible = repository.Orders.FlagCountry || fullReport;
			grid_data.Columns["Manager"].Visible = repository.Orders.FlagManager || fullReport;
		}

		/// <summary>
		/// Initialize checkboxes
		/// </summary>
		private void Init_CBs()
		{
			cb_orderDate.Checked = repository.Orders.FlagOrderDate;
			cb_company.Checked = repository.Orders.FlagCompany;
			cb_city.Checked = repository.Orders.FlagCity;
			cb_country.Checked = repository.Orders.FlagCountry;
			cb_Manager.Checked = repository.Orders.FlagManager;
		}

		#region Checkboxes
		private void cb_orderDate_CheckedChanged(object sender, EventArgs e)
		{
			repository.Orders.FlagOrderDate = cb_orderDate.Checked;
		}

		private void cb_company_CheckedChanged(object sender, EventArgs e)
		{
			repository.Orders.FlagCompany=cb_company.Checked;
		}

		private void cb_city_CheckedChanged(object sender, EventArgs e)
		{
			repository.Orders.FlagCity=cb_city.Checked;
		}

		private void cb_country_CheckedChanged(object sender, EventArgs e)
		{
			repository.Orders.FlagCountry=cb_country.Checked;
		}

		private void cb_Manager_CheckedChanged(object sender, EventArgs e)
		{
			repository.Orders.FlagManager = cb_Manager.Checked;
		}
		#endregion

		#region Buttons
		private void btn_Apply_Click(object sender, EventArgs e)
		{
			Fill_Grid();
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			repository.Orders.ResetFlags();
			Init_CBs();
			Fill_Grid();
		}

		private void btn_logout_Click(object sender, EventArgs e)
		{
			this.Close();
			form.UpdateInfoLabel();
			form.Visible = true;
			form.Init_LoginList();
			this.Dispose();
		}
		#endregion

		private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			form.Visible = true;
		}

		private void btn_users_Click(object sender, EventArgs e)
		{
			var form = new usersForm();
			form.Show();
		}

		private void add_Order_Click(object sender, EventArgs e)
		{
			var newOrderForm = new orderForm(current_login, this);
			newOrderForm.Show();
		}
	}
}
