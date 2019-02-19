namespace IT_Data
{
	partial class usersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lb_users = new System.Windows.Forms.ListBox();
			this.cb_adminFlag = new System.Windows.Forms.CheckBox();
			this.tb_manager = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_userlogin = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_userpassword = new System.Windows.Forms.TextBox();
			this.cb_isBlocked = new System.Windows.Forms.CheckBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_NewUser = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_users
			// 
			this.lb_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_users.FormattingEnabled = true;
			this.lb_users.ItemHeight = 16;
			this.lb_users.Location = new System.Drawing.Point(6, 6);
			this.lb_users.Name = "lb_users";
			this.lb_users.Size = new System.Drawing.Size(138, 196);
			this.lb_users.TabIndex = 1;
			this.lb_users.SelectedIndexChanged += new System.EventHandler(this.lb_users_SelectedIndexChanged);
			// 
			// cb_adminFlag
			// 
			this.cb_adminFlag.AutoSize = true;
			this.cb_adminFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_adminFlag.Location = new System.Drawing.Point(150, 159);
			this.cb_adminFlag.Name = "cb_adminFlag";
			this.cb_adminFlag.Size = new System.Drawing.Size(131, 20);
			this.cb_adminFlag.TabIndex = 2;
			this.cb_adminFlag.Text = "Administrator role";
			this.cb_adminFlag.UseVisualStyleBackColor = true;
			// 
			// tb_manager
			// 
			this.tb_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_manager.Location = new System.Drawing.Point(150, 25);
			this.tb_manager.Name = "tb_manager";
			this.tb_manager.Size = new System.Drawing.Size(162, 22);
			this.tb_manager.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(150, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Manager name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(150, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Login";
			// 
			// tb_userlogin
			// 
			this.tb_userlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_userlogin.Location = new System.Drawing.Point(150, 73);
			this.tb_userlogin.Name = "tb_userlogin";
			this.tb_userlogin.Size = new System.Drawing.Size(162, 22);
			this.tb_userlogin.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(150, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "New password";
			// 
			// tb_userpassword
			// 
			this.tb_userpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_userpassword.Location = new System.Drawing.Point(150, 122);
			this.tb_userpassword.Name = "tb_userpassword";
			this.tb_userpassword.PasswordChar = '*';
			this.tb_userpassword.Size = new System.Drawing.Size(162, 22);
			this.tb_userpassword.TabIndex = 7;
			// 
			// cb_isBlocked
			// 
			this.cb_isBlocked.AutoSize = true;
			this.cb_isBlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_isBlocked.Location = new System.Drawing.Point(150, 185);
			this.cb_isBlocked.Name = "cb_isBlocked";
			this.cb_isBlocked.Size = new System.Drawing.Size(77, 20);
			this.cb_isBlocked.TabIndex = 9;
			this.cb_isBlocked.Text = "Blocked";
			this.cb_isBlocked.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Save.Location = new System.Drawing.Point(6, 220);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(152, 37);
			this.btn_Save.TabIndex = 10;
			this.btn_Save.Text = "Save changes";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Delete.ForeColor = System.Drawing.Color.Black;
			this.btn_Delete.Location = new System.Drawing.Point(160, 220);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(152, 37);
			this.btn_Delete.TabIndex = 11;
			this.btn_Delete.Text = "Delete manager";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_NewUser
			// 
			this.btn_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_NewUser.Location = new System.Drawing.Point(6, 259);
			this.btn_NewUser.Name = "btn_NewUser";
			this.btn_NewUser.Size = new System.Drawing.Size(152, 37);
			this.btn_NewUser.TabIndex = 12;
			this.btn_NewUser.Text = "Save as a new";
			this.btn_NewUser.UseVisualStyleBackColor = true;
			this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn_Exit.Location = new System.Drawing.Point(160, 259);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(152, 37);
			this.btn_Exit.TabIndex = 13;
			this.btn_Exit.Text = "Cancel";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// usersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 301);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_NewUser);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.cb_isBlocked);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_userpassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_userlogin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_manager);
			this.Controls.Add(this.cb_adminFlag);
			this.Controls.Add(this.lb_users);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "usersForm";
			this.Text = "Managers";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lb_users;
		private System.Windows.Forms.CheckBox cb_adminFlag;
		private System.Windows.Forms.TextBox tb_manager;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_userlogin;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_userpassword;
		private System.Windows.Forms.CheckBox cb_isBlocked;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_NewUser;
		private System.Windows.Forms.Button btn_Exit;
	}
}