namespace IT_Data
{
	partial class mainForm
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
			this.btn_Apply = new System.Windows.Forms.Button();
			this.cb_orderDate = new System.Windows.Forms.CheckBox();
			this.cb_company = new System.Windows.Forms.CheckBox();
			this.cb_city = new System.Windows.Forms.CheckBox();
			this.cb_country = new System.Windows.Forms.CheckBox();
			this.cb_Manager = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.grid_data = new System.Windows.Forms.DataGridView();
			this.tb_query = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_logout = new System.Windows.Forms.Button();
			this.btn_users = new System.Windows.Forms.Button();
			this.add_Order = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_data)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Apply
			// 
			this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Apply.Location = new System.Drawing.Point(185, 12);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(61, 30);
			this.btn_Apply.TabIndex = 0;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.UseVisualStyleBackColor = true;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// cb_orderDate
			// 
			this.cb_orderDate.AutoSize = true;
			this.cb_orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_orderDate.Location = new System.Drawing.Point(9, 19);
			this.cb_orderDate.Name = "cb_orderDate";
			this.cb_orderDate.Size = new System.Drawing.Size(93, 20);
			this.cb_orderDate.TabIndex = 1;
			this.cb_orderDate.Text = "Order Date";
			this.cb_orderDate.UseVisualStyleBackColor = true;
			this.cb_orderDate.CheckedChanged += new System.EventHandler(this.cb_orderDate_CheckedChanged);
			// 
			// cb_company
			// 
			this.cb_company.AutoSize = true;
			this.cb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_company.Location = new System.Drawing.Point(9, 40);
			this.cb_company.Name = "cb_company";
			this.cb_company.Size = new System.Drawing.Size(85, 20);
			this.cb_company.TabIndex = 2;
			this.cb_company.Text = "Company";
			this.cb_company.UseVisualStyleBackColor = true;
			this.cb_company.CheckedChanged += new System.EventHandler(this.cb_company_CheckedChanged);
			// 
			// cb_city
			// 
			this.cb_city.AutoSize = true;
			this.cb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_city.Location = new System.Drawing.Point(9, 63);
			this.cb_city.Name = "cb_city";
			this.cb_city.Size = new System.Drawing.Size(49, 20);
			this.cb_city.TabIndex = 3;
			this.cb_city.Text = "City";
			this.cb_city.UseVisualStyleBackColor = true;
			this.cb_city.CheckedChanged += new System.EventHandler(this.cb_city_CheckedChanged);
			// 
			// cb_country
			// 
			this.cb_country.AutoSize = true;
			this.cb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_country.Location = new System.Drawing.Point(9, 86);
			this.cb_country.Name = "cb_country";
			this.cb_country.Size = new System.Drawing.Size(72, 20);
			this.cb_country.TabIndex = 4;
			this.cb_country.Text = "Country";
			this.cb_country.UseVisualStyleBackColor = true;
			this.cb_country.CheckedChanged += new System.EventHandler(this.cb_country_CheckedChanged);
			// 
			// cb_Manager
			// 
			this.cb_Manager.AutoSize = true;
			this.cb_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_Manager.Location = new System.Drawing.Point(9, 109);
			this.cb_Manager.Name = "cb_Manager";
			this.cb_Manager.Size = new System.Drawing.Size(81, 20);
			this.cb_Manager.TabIndex = 5;
			this.cb_Manager.Text = "Manager";
			this.cb_Manager.UseVisualStyleBackColor = true;
			this.cb_Manager.CheckedChanged += new System.EventHandler(this.cb_Manager_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cb_orderDate);
			this.groupBox1.Controls.Add(this.cb_Manager);
			this.groupBox1.Controls.Add(this.cb_company);
			this.groupBox1.Controls.Add(this.cb_country);
			this.groupBox1.Controls.Add(this.cb_city);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 132);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Set columns for report";
			// 
			// btn_Clear
			// 
			this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Clear.Location = new System.Drawing.Point(249, 12);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(61, 30);
			this.btn_Clear.TabIndex = 7;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// grid_data
			// 
			this.grid_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grid_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_data.Location = new System.Drawing.Point(3, 143);
			this.grid_data.Name = "grid_data";
			this.grid_data.Size = new System.Drawing.Size(566, 324);
			this.grid_data.TabIndex = 8;
			// 
			// tb_query
			// 
			this.tb_query.Location = new System.Drawing.Point(185, 68);
			this.tb_query.Multiline = true;
			this.tb_query.Name = "tb_query";
			this.tb_query.Size = new System.Drawing.Size(384, 66);
			this.tb_query.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(182, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Query string";
			// 
			// btn_logout
			// 
			this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn_logout.Location = new System.Drawing.Point(499, 12);
			this.btn_logout.Name = "btn_logout";
			this.btn_logout.Size = new System.Drawing.Size(70, 30);
			this.btn_logout.TabIndex = 11;
			this.btn_logout.Text = "Log out";
			this.btn_logout.UseVisualStyleBackColor = true;
			this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
			// 
			// btn_users
			// 
			this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_users.ForeColor = System.Drawing.Color.Navy;
			this.btn_users.Location = new System.Drawing.Point(425, 12);
			this.btn_users.Name = "btn_users";
			this.btn_users.Size = new System.Drawing.Size(70, 30);
			this.btn_users.TabIndex = 12;
			this.btn_users.Text = "Users";
			this.btn_users.UseVisualStyleBackColor = true;
			this.btn_users.Visible = false;
			this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
			// 
			// add_Order
			// 
			this.add_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_Order.ForeColor = System.Drawing.Color.Green;
			this.add_Order.Location = new System.Drawing.Point(315, 12);
			this.add_Order.Name = "add_Order";
			this.add_Order.Size = new System.Drawing.Size(88, 30);
			this.add_Order.TabIndex = 13;
			this.add_Order.Text = "Add order";
			this.add_Order.UseVisualStyleBackColor = true;
			this.add_Order.Click += new System.EventHandler(this.add_Order_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 472);
			this.Controls.Add(this.add_Order);
			this.Controls.Add(this.btn_users);
			this.Controls.Add(this.btn_logout);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_query);
			this.Controls.Add(this.grid_data);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_Apply);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Orders";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.CheckBox cb_orderDate;
		private System.Windows.Forms.CheckBox cb_company;
		private System.Windows.Forms.CheckBox cb_city;
		private System.Windows.Forms.CheckBox cb_country;
		private System.Windows.Forms.CheckBox cb_Manager;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.DataGridView grid_data;
		private System.Windows.Forms.TextBox tb_query;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_logout;
		private System.Windows.Forms.Button btn_users;
		private System.Windows.Forms.Button add_Order;
	}
}

