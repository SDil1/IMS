namespace InventoryMnagement
{
    partial class ManageProducts
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
            System.Windows.Forms.Label label1;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.TextBox();
            this.productQty = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.TextBox();
            this.labe9 = new System.Windows.Forms.Label();
            this.product_Qty = new System.Windows.Forms.Label();
            this.Product_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 386);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 25);
            label1.TabIndex = 35;
            label1.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 100);
            this.panel1.TabIndex = 24;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1435, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1495, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Products";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 703);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 49);
            this.panel2.TabIndex = 23;
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
            // Products
            // 
            this.Products.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Products.Location = new System.Drawing.Point(359, 149);
            this.Products.Name = "Products";
            this.Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.Products.Size = new System.Drawing.Size(1104, 522);
            this.Products.TabIndex = 25;
            this.Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_CellContentClick);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(189, 188);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(164, 20);
            this.productName.TabIndex = 29;
            // 
            // productQty
            // 
            this.productQty.Location = new System.Drawing.Point(189, 241);
            this.productQty.Name = "productQty";
            this.productQty.Size = new System.Drawing.Size(164, 20);
            this.productQty.TabIndex = 28;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(189, 290);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(164, 20);
            this.productPrice.TabIndex = 27;
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(189, 149);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(164, 20);
            this.productId.TabIndex = 26;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(189, 340);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(164, 20);
            this.productDescription.TabIndex = 30;
            // 
            // labe9
            // 
            this.labe9.AutoSize = true;
            this.labe9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe9.Location = new System.Drawing.Point(12, 149);
            this.labe9.Name = "labe9";
            this.labe9.Size = new System.Drawing.Size(112, 25);
            this.labe9.TabIndex = 34;
            this.labe9.Text = "ProductId";
            // 
            // product_Qty
            // 
            this.product_Qty.AutoSize = true;
            this.product_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Qty.Location = new System.Drawing.Point(15, 241);
            this.product_Qty.Name = "product_Qty";
            this.product_Qty.Size = new System.Drawing.Size(175, 25);
            this.product_Qty.TabIndex = 33;
            this.product_Qty.Text = "Product Quntity";
            // 
            // Product_price
            // 
            this.Product_price.AutoSize = true;
            this.Product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_price.Location = new System.Drawing.Point(8, 284);
            this.Product_price.Name = "Product_price";
            this.Product_price.Size = new System.Drawing.Size(154, 25);
            this.Product_price.TabIndex = 32;
            this.Product_price.Text = "Product Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Description";
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(185, 386);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(168, 21);
            this.categories.TabIndex = 37;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(68, 492);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 40;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(153, 492);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 39;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(253, 492);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 38;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // searchCombo
            // 
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Location = new System.Drawing.Point(1119, 106);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(168, 21);
            this.searchCombo.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1293, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1374, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 752);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.label10);
            this.Controls.Add(label1);
            this.Controls.Add(this.labe9);
            this.Controls.Add(this.product_Qty);
            this.Controls.Add(this.Product_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productQty);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox productQty;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.TextBox productDescription;
        private System.Windows.Forms.Label labe9;
        private System.Windows.Forms.Label product_Qty;
        private System.Windows.Forms.Label Product_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}