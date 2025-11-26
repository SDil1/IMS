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
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.DataGridView();
            this.Ufullname = new System.Windows.Forms.TextBox();
            this.Uname = new System.Windows.Forms.TextBox();
            this.Upassword = new System.Windows.Forms.TextBox();
            this.Uphone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
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
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(12, 121);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(118, 25);
            this.FullName.TabIndex = 10;
            this.FullName.Text = "Full Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(15, 213);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(112, 25);
            this.password.TabIndex = 9;
            this.password.Text = "password";
            // 
            // phone_num
            // 
            this.phone_num.AutoSize = true;
            this.phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_num.Location = new System.Drawing.Point(15, 262);
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
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(55, 331);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 20;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(140, 331);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(240, 331);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 18;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.Users.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Users.Location = new System.Drawing.Point(336, 106);
            this.Users.Name = "Users";
            this.Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Users.Size = new System.Drawing.Size(1104, 515);
            this.Users.TabIndex = 21;
            // 
            // Ufullname
            // 
            this.Ufullname.Location = new System.Drawing.Point(140, 126);
            this.Ufullname.Name = "Ufullname";
            this.Ufullname.Size = new System.Drawing.Size(164, 20);
            this.Ufullname.TabIndex = 22;
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(140, 166);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(164, 20);
            this.Uname.TabIndex = 23;
            // 
            // Upassword
            // 
            this.Upassword.Location = new System.Drawing.Point(140, 219);
            this.Upassword.Name = "Upassword";
            this.Upassword.Size = new System.Drawing.Size(164, 20);
            this.Upassword.TabIndex = 24;
            // 
            // Uphone
            // 
            this.Uphone.Location = new System.Drawing.Point(140, 268);
            this.Uphone.Name = "Uphone";
            this.Uphone.Size = new System.Drawing.Size(164, 20);
            this.Uphone.TabIndex = 25;
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
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 672);
            this.Controls.Add(this.Uphone);
            this.Controls.Add(this.Upassword);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.Ufullname);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.Text = "ManageCustomers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label phone_num;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.DataGridView Users;
        private System.Windows.Forms.TextBox Ufullname;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox Upassword;
        private System.Windows.Forms.TextBox Uphone;
        private System.Windows.Forms.Button button1;
    }
}