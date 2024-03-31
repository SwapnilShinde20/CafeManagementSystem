namespace CafeManagementSystem
{
    partial class ItemForm
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
            this.QuantityTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.LabelAmt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerNameTb = new System.Windows.Forms.TextBox();
            this.OrderNoTb = new System.Windows.Forms.TextBox();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.CategoryTb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cafedbDataSet1 = new CafeManagementSystem.CafedbDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafedbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.QuantityTb);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrdersGV);
            this.panel1.Controls.Add(this.LabelAmt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerNameTb);
            this.panel1.Controls.Add(this.OrderNoTb);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.CategoryTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(154, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1468, 871);
            this.panel1.TabIndex = 0;
            // 
            // QuantityTb
            // 
            this.QuantityTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.QuantityTb.ForeColor = System.Drawing.Color.Silver;
            this.QuantityTb.Location = new System.Drawing.Point(736, 370);
            this.QuantityTb.Multiline = true;
            this.QuantityTb.Name = "QuantityTb";
            this.QuantityTb.Size = new System.Drawing.Size(213, 38);
            this.QuantityTb.TabIndex = 21;
            this.QuantityTb.Text = "Quantity";
            this.QuantityTb.Enter += new System.EventHandler(this.quantiy_Enter);
            this.QuantityTb.Leave += new System.EventHandler(this.quantiy_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(736, 788);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Place The Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(828, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Your Order";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OrdersGV
            // 
            this.OrdersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGV.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.Location = new System.Drawing.Point(524, 463);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersWidth = 51;
            this.OrdersGV.RowTemplate.Height = 24;
            this.OrdersGV.Size = new System.Drawing.Size(821, 291);
            this.OrdersGV.TabIndex = 18;
            // 
            // LabelAmt
            // 
            this.LabelAmt.AutoSize = true;
            this.LabelAmt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAmt.ForeColor = System.Drawing.Color.DeepPink;
            this.LabelAmt.Location = new System.Drawing.Point(1134, 788);
            this.LabelAmt.Name = "LabelAmt";
            this.LabelAmt.Size = new System.Drawing.Size(201, 32);
            this.LabelAmt.TabIndex = 17;
            this.LabelAmt.Text = "OrderAmount";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(980, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerNameTb
            // 
            this.SellerNameTb.Enabled = false;
            this.SellerNameTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.SellerNameTb.ForeColor = System.Drawing.Color.Black;
            this.SellerNameTb.Location = new System.Drawing.Point(73, 206);
            this.SellerNameTb.Multiline = true;
            this.SellerNameTb.Name = "SellerNameTb";
            this.SellerNameTb.Size = new System.Drawing.Size(213, 38);
            this.SellerNameTb.TabIndex = 15;
            this.SellerNameTb.Text = "Guest";
            this.SellerNameTb.TextChanged += new System.EventHandler(this.sellername_TextChanged);
            this.SellerNameTb.Enter += new System.EventHandler(this.sellername_Enter);
            this.SellerNameTb.Leave += new System.EventHandler(this.sellername_Leave);
            // 
            // OrderNoTb
            // 
            this.OrderNoTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNoTb.ForeColor = System.Drawing.Color.Silver;
            this.OrderNoTb.Location = new System.Drawing.Point(73, 143);
            this.OrderNoTb.Multiline = true;
            this.OrderNoTb.Name = "OrderNoTb";
            this.OrderNoTb.Size = new System.Drawing.Size(213, 38);
            this.OrderNoTb.TabIndex = 14;
            this.OrderNoTb.Text = "OrderNum";
            this.OrderNoTb.Enter += new System.EventHandler(this.orderno_Enter);
            this.OrderNoTb.Leave += new System.EventHandler(this.orderno_Leave);
            // 
            // ItemsGV
            // 
            this.ItemsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(514, 89);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersWidth = 51;
            this.ItemsGV.RowTemplate.Height = 24;
            this.ItemsGV.Size = new System.Drawing.Size(821, 220);
            this.ItemsGV.TabIndex = 13;
            this.ItemsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellClick);
            // 
            // CategoryTb
            // 
            this.CategoryTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTb.FormattingEnabled = true;
            this.CategoryTb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.CategoryTb.Location = new System.Drawing.Point(73, 89);
            this.CategoryTb.Name = "CategoryTb";
            this.CategoryTb.Size = new System.Drawing.Size(213, 35);
            this.CategoryTb.TabIndex = 12;
            this.CategoryTb.Text = "Category";
            this.CategoryTb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.CategoryTb.SelectionChangeCommitted += new System.EventHandler(this.CategoryTb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(814, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Place Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 885);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "LogOut";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1589, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 34);
            this.label6.TabIndex = 10;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cafedbDataSet1
            // 
            this.cafedbDataSet1.DataSetName = "CafedbDataSet";
            this.cafedbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepPink;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(329, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 37);
            this.button5.TabIndex = 23;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.DeepPink;
            this.DateLbl.Location = new System.Drawing.Point(1295, 29);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(79, 32);
            this.DateLbl.TabIndex = 24;
            this.DateLbl.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(1079, 788);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Rs";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1743, 1043);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafedbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CategoryTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItemsGV;
        private System.Windows.Forms.TextBox SellerNameTb;
        private System.Windows.Forms.TextBox OrderNoTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrdersGV;
        private System.Windows.Forms.Label LabelAmt;
        private System.Windows.Forms.TextBox QuantityTb;
        private System.Windows.Forms.Button button2;
        private CafedbDataSet cafedbDataSet1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label label2;
    }
}