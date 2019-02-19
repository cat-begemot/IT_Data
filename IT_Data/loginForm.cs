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
	public partial class loginForm : Form
	{
		private IRepository repository;
		private readonly Int32 maxFailedLoginAttempts = 3;

		public loginForm()
		{
			InitializeComponent();
			repository = (new Repository()); // Injecting interface realization
			Init_LoginList();	
		}

		public void UpdateInfoLabel()
		{
			if (!repository.IsBlocked(cb_login.Text)) // User isn't blocked
			{
				Int32 leftAttempts = maxFailedLoginAttempts - repository.GetAttemptsQty(cb_login.Text);
				if (leftAttempts == 1)
					lbl_info.Text = $"You have got {leftAttempts} attempt to login.";
				else
					lbl_info.Text = $"You have got {leftAttempts} attempts to login.";
			}
			else // User is blocked
			{
				lbl_info.Text = "Your account is blocked. \nContact your administrator.";
			}
		}

		// Init login list for combobox
		public void Init_LoginList()
		{
			cb_login.DataSource = repository.GetLoginList();
		}

		/// <summary>
		/// It checks user credentials and allows access to program interface
		/// </summary>
		private void Login()
		{
			if (!repository.IsBlocked(cb_login.Text)) // User isn't blocked
			{
				if (repository.Login(cb_login.Text, tb_password.Text))
				{ // if credentials are OK
					tb_password.Clear();
					repository.SetAttemptsQty(cb_login.Text, 0);
					this.Visible = false;
					var mainForm = new mainForm(this, cb_login.Text);
					mainForm.Show();
				}
				else
				{ // if credentials are invlalid
					Int32 currentAttempts = repository.GetAttemptsQty(cb_login.Text);
					repository.SetAttemptsQty(cb_login.Text, ++currentAttempts);
					Int32 leftAttempts = maxFailedLoginAttempts - currentAttempts;
					if (leftAttempts == 0)
					{
						repository.SetIsBlockUser(cb_login.Text, true);
						MessageBox.Show("You failed login with maximum attempts so this account was been blocked. Please contact your administrator.", "Account is blocked",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						MessageBox.Show("Password is invalid.", "Invalid credentials",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					UpdateInfoLabel();
					tb_password.Clear();
				}
			}
			else // User is blocked
			{
				MessageBox.Show("This account is blocked. Please contact your administrator.", "Account is blocked",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void cb_login_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateInfoLabel();
			tb_password.Clear();
		}

		private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Login();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
	}
}
