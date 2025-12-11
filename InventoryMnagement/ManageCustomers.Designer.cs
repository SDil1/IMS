namespace InventoryMnagement
{
    partial class ManageCustomers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.DataGridView();
            this.custname = new System.Windows.Forms.TextBox();
            this.custphone = new System.Windows.Forms.TextBox();
            this.custId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orderslb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datelb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.amountlb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1452, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1412, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1495, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // phone_num
            // 
            this.phone_num.AutoSize = true;
            this.phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_num.Location = new System.Drawing.Point(15, 208);
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(77, 25);
            this.phone_num.TabIndex = 8;
            this.phone_num.Text = "phone";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(15, 160);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(115, 25);
            this.username.TabIndex = 7;
            this.username.Text = "username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1452, 45);
            this.panel2.TabIndex = 17;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(17, 10);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(142, 23);
            this.home.TabIndex = 14;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(55, 331);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 20;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(140, 331);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(240, 331);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 18;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // customer
            // 
            this.customer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.customer.Location = new System.Drawing.Point(336, 106);
            this.customer.Name = "customer";
            this.customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.customer.Size = new System.Drawing.Size(891, 515);
            this.customer.TabIndex = 21;
            this.customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_CellContentClick);
            // 
            // custname
            // 
            this.custname.Location = new System.Drawing.Point(140, 166);
            this.custname.Name = "custname";
            this.custname.Size = new System.Drawing.Size(164, 20);
            this.custname.TabIndex = 23;
            // 
            // custphone
            // 
            this.custphone.Location = new System.Drawing.Point(140, 208);
            this.custphone.Name = "custphone";
            this.custphone.Size = new System.Drawing.Size(164, 20);
            this.custphone.TabIndex = 25;
            // 
            // custId
            // 
            this.custId.Location = new System.Drawing.Point(140, 124);
            this.custId.Name = "custId";
            this.custId.Size = new System.Drawing.Size(164, 20);
            this.custId.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel3.Controls.Add(this.orderslb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1260, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 84);
            this.panel3.TabIndex = 28;
            // 
            // orderslb
            // 
            this.orderslb.AutoSize = true;
            this.orderslb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderslb.Location = new System.Drawing.Point(54, 36);
            this.orderslb.Name = "orderslb";
            this.orderslb.Size = new System.Drawing.Size(54, 20);
            this.orderslb.TabIndex = 4;
            this.orderslb.Text = "orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order count";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.datelb);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(1260, 422);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 84);
            this.panel4.TabIndex = 29;
            // 
            // datelb
            // 
            this.datelb.AutoSize = true;
            this.datelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.Location = new System.Drawing.Point(3, 40);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(41, 20);
            this.datelb.TabIndex = 5;
            this.datelb.Text = "date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last Order date";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Controls.Add(this.amountlb);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(1260, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 84);
            this.panel5.TabIndex = 29;
            // 
            // amountlb
            // 
            this.amountlb.AutoSize = true;
            this.amountlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlb.Location = new System.Drawing.Point(55, 36);
            this.amountlb.Name = "amountlb";
            this.amountlb.Size = new System.Drawing.Size(63, 20);
            this.amountlb.TabIndex = 5;
            this.amountlb.Text = "amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Order amount";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 672);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custId);
            this.Controls.Add(this.custphone);
            this.Controls.Add(this.custname);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label phone_num;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.DataGridView customer;
        private System.Windows.Forms.TextBox custname;
        private System.Windows.Forms.TextBox custphone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox custId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label orderslb;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label amountlb;
        private System.Windows.Forms.Label label6;
    }
}