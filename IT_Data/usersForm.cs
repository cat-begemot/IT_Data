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
	public partial class usersForm : Form
	{
		private IRepository repository;

		public usersForm()
		{
			InitializeComponent();
			repository = new Repository();
			UpdateUserList();
			LoadUserInfo(lb_users.Text);
		}


		private void UpdateUserList()
		{
			lb_users.DataSource = repository.GetUserList();
		}

		private void LoadUserInfo(String login)
		{
			User user = repository.GetUser(login);
			tb_manager.Text = user.Manager;
			cb_adminFlag.Checked = user.AdminFlag;
			tb_userpassword.Clear();
			tb_userlogin.Text = user.Login;
			cb_isBlocked.Checked = user.IsBlocked;
		}

		private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadUserInfo(lb_users.Text);
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			if (tb_userlogin.Text.Length == 0)
			{
				MessageBox.Show("Login isn't assigned!", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!repository.IsLoginExists(tb_userlogin.Text, lb_users.Text)) // login is unique, except current. Let to proceed
			{
				User oldUserInfo = repository.GetUser(lb_users.Text);
				User newUserInfo = new User();
				newUserInfo.Manager = tb_manager.Text;
				newUserInfo.AdminFlag = cb_adminFlag.Checked;
				newUserInfo.Login = tb_userlogin.Text;
				newUserInfo.IsBlocked = cb_isBlocked.Checked;

				if (tb_userpassword.TextLength==0)
					newUserInfo.Password = oldUserInfo.Password;
				else
					newUserInfo.Password = Repository.GetHash(tb_userpassword.Text);

				repository.EditUser(newUserInfo, lb_users.Text);

				if (!cb_isBlocked.Checked)
					repository.SetAttemptsQty(tb_userlogin.Text, 0);

				Int32 ind = lb_users.SelectedIndex;
				UpdateUserList();
				lb_users.SelectedIndex = ind;
				MessageBox.Show("User was successfully updated.", "Operation is completed",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else // login is exists
			{
				MessageBox.Show($"Login '{tb_userlogin.Text}' is exists. Please choose another one.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_NewUser_Click(object sender, EventArgs e)
		{
			if (tb_userlogin.Text.Length == 0)
			{
				MessageBox.Show($"Login isn't assigned!", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (tb_userpassword.Text.Length == 0)
			{
				MessageBox.Show($"Password isn't assigned!", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!repository.IsLoginExists(tb_userlogin.Text, "")) // login is unique in generel, let to proceed
			{
				User newUserInfo = new User();
				newUserInfo.Manager = tb_manager.Text;
				newUserInfo.AdminFlag = cb_adminFlag.Checked;
				newUserInfo.Login = tb_userlogin.Text;
				newUserInfo.IsBlocked = cb_isBlocked.Checked;
				newUserInfo.Password = Repository.GetHash(tb_userpassword.Text);

				repository.CreateUser(newUserInfo);

				if (!cb_isBlocked.Checked)
					repository.SetAttemptsQty(tb_userlogin.Text, 0);

				UpdateUserList();
				lb_users.SelectedIndex = lb_users.Items.Count-1;
				MessageBox.Show("User was successfully created.", "Operation is completed",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else // login is exists
			{
				MessageBox.Show($"Login '{tb_userlogin.Text}' is exists. Please choose another one.", "Validation error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			repository.DeleteUser(tb_userlogin.Text);
			UpdateUserList();
			MessageBox.Show("User was successfully deleted.", "Operation is completed",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
