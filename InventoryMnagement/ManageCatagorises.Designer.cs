namespace InventoryMnagement
{
    partial class ManageCatagorises
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.DataGridView();
            this.CatName = new System.Windows.Forms.TextBox();
            this.CatId = new System.Windows.Forms.TextBox();
            this.CategoriesId = new System.Windows.Forms.Label();
            this.CategoriesName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1480, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 23);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Manage Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 698);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1534, 45);
            this.panel2.TabIndex = 20;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1534, 100);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1495, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Categorises";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(623, 44);
            this.label4.TabIndex = 1;
            this.label4.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // Users
            // 
            this.Users.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Users.Location = new System.Drawing.Point(404, 120);
            this.Users.Name = "Users";
            this.Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Users.Size = new System.Drawing.Size(1104, 502);
            this.Users.TabIndex = 23;
            this.Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_CellContentClick);
            // 
            // CatName
            // 
            this.CatName.Location = new System.Drawing.Point(218, 206);
            this.CatName.Name = "CatName";
            this.CatName.Size = new System.Drawing.Size(164, 20);
            this.CatName.TabIndex = 25;
            // 
            // CatId
            // 
            this.CatId.Location = new System.Drawing.Point(218, 166);
            this.CatId.Name = "CatId";
            this.CatId.Size = new System.Drawing.Size(164, 20);
            this.CatId.TabIndex = 24;
            // 
            // CategoriesId
            // 
            this.CategoriesId.AutoSize = true;
            this.CategoriesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesId.Location = new System.Drawing.Point(12, 160);
            this.CategoriesId.Name = "CategoriesId";
            this.CategoriesId.Size = new System.Drawing.Size(152, 25);
            this.CategoriesId.TabIndex = 27;
            this.CategoriesId.Text = "Categories Id";
            // 
            // CategoriesName
            // 
            this.CategoriesName.AutoSize = true;
            this.CategoriesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesName.Location = new System.Drawing.Point(15, 199);
            this.CategoriesName.Name = "CategoriesName";
            this.CategoriesName.Size = new System.Drawing.Size(193, 25);
            this.CategoriesName.TabIndex = 26;
            this.CategoriesName.Text = "Categories Name";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(63, 287);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 30;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(148, 287);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 29;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(248, 287);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 28;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // ManageCatagorises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 743);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.CategoriesId);
            this.Controls.Add(this.CategoriesName);
            this.Controls.Add(this.CatName);
            this.Controls.Add(this.CatId);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCatagorises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagaeCatagorise";
            this.Load += new System.EventHandler(this.ManageCatagorises_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Users;
        private System.Windows.Forms.TextBox CatName;
        private System.Windows.Forms.TextBox CatId;
        private System.Windows.Forms.Label CategoriesId;
        private System.Windows.Forms.Label CategoriesName;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
    }
}