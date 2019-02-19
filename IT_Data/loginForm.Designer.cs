namespace IT_Data
{
	partial class loginForm
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
			this.cb_login = new System.Windows.Forms.ComboBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.lbl_info = new System.Windows.Forms.Label();
			this.btn_login = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cb_login
			// 
			this.cb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_login.FormattingEnabled = true;
			this.cb_login.Location = new System.Drawing.Point(5, 12);
			this.cb_login.Name = "cb_login";
			this.cb_login.Size = new System.Drawing.Size(238, 24);
			this.cb_login.TabIndex = 0;
			this.cb_login.SelectedIndexChanged += new System.EventHandler(this.cb_login_SelectedIndexChanged);
			// 
			// tb_password
			// 
			this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_password.Location = new System.Drawing.Point(5, 42);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(238, 22);
			this.tb_password.TabIndex = 1;
			this.tb_password.WordWrap = false;
			this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
			// 
			// lbl_info
			// 
			this.lbl_info.AutoSize = true;
			this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_info.Location = new System.Drawing.Point(5, 77);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(175, 16);
			this.lbl_info.TabIndex = 2;
			this.lbl_info.Text = "You have 3 attempts to login";
			// 
			// btn_login
			// 
			this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_login.Location = new System.Drawing.Point(5, 117);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(82, 26);
			this.btn_login.TabIndex = 3;
			this.btn_login.Text = "Log in";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn_Exit.Location = new System.Drawing.Point(161, 117);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(82, 26);
			this.btn_Exit.TabIndex = 4;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 151);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.cb_login);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "loginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log in";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_login;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label lbl_info;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Button btn_Exit;
	}
}