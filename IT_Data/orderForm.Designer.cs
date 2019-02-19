namespace IT_Data
{
	partial class orderForm
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
			this.btn_create = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.dt_date = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_company = new System.Windows.Forms.TextBox();
			this.tb_city = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_country = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_qty = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_amount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_create
			// 
			this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_create.Location = new System.Drawing.Point(7, 285);
			this.btn_create.Name = "btn_create";
			this.btn_create.Size = new System.Drawing.Size(120, 29);
			this.btn_create.TabIndex = 0;
			this.btn_create.Text = "Create";
			this.btn_create.UseVisualStyleBackColor = true;
			this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Location = new System.Drawing.Point(133, 285);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(123, 29);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// dt_date
			// 
			this.dt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dt_date.Location = new System.Drawing.Point(7, 23);
			this.dt_date.Name = "dt_date";
			this.dt_date.Size = new System.Drawing.Size(249, 22);
			this.dt_date.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Company";
			// 
			// tb_company
			// 
			this.tb_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_company.Location = new System.Drawing.Point(7, 67);
			this.tb_company.Name = "tb_company";
			this.tb_company.Size = new System.Drawing.Size(249, 22);
			this.tb_company.TabIndex = 5;
			// 
			// tb_city
			// 
			this.tb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_city.Location = new System.Drawing.Point(7, 111);
			this.tb_city.Name = "tb_city";
			this.tb_city.Size = new System.Drawing.Size(249, 22);
			this.tb_city.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "City";
			// 
			// tb_country
			// 
			this.tb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_country.Location = new System.Drawing.Point(7, 155);
			this.tb_country.Name = "tb_country";
			this.tb_country.Size = new System.Drawing.Size(249, 22);
			this.tb_country.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Country";
			// 
			// tb_qty
			// 
			this.tb_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_qty.Location = new System.Drawing.Point(7, 199);
			this.tb_qty.Name = "tb_qty";
			this.tb_qty.Size = new System.Drawing.Size(249, 22);
			this.tb_qty.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Quantity";
			// 
			// tb_amount
			// 
			this.tb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_amount.Location = new System.Drawing.Point(7, 244);
			this.tb_amount.Name = "tb_amount";
			this.tb_amount.Size = new System.Drawing.Size(249, 22);
			this.tb_amount.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(7, 225);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 16);
			this.label6.TabIndex = 12;
			this.label6.Text = "Amount";
			// 
			// orderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 324);
			this.Controls.Add(this.tb_amount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_qty);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_country);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_city);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_company);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dt_date);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_create);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "orderForm";
			this.Text = "Add order";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_create;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.DateTimePicker dt_date;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_company;
		private System.Windows.Forms.TextBox tb_city;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_country;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_qty;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_amount;
		private System.Windows.Forms.Label label6;
	}
}