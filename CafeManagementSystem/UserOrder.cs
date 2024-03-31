using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shind\source\repos\CafeManagementSystem\CafeManagementSystem\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "Select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        void filterByCategory()
        {
            Con.Open();
            string query = "Select * from ItemTbl where ItemCat = '"+CategoryTb.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm form = new UsersForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm form = new ItemsForm();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void OrderNumTb_Enter(object sender, EventArgs e)
        {
            if (OrderNumTb.Text == "OrderNum") {
                OrderNumTb.Text = "";
                OrderNumTb.ForeColor = Color.Black;
            }
        }

        private void OrderNumTb_Leave(object sender, EventArgs e)
        {
            if (OrderNumTb.Text == "")
            {
                OrderNumTb.Text = "OrderNum";
                OrderNumTb.ForeColor = Color.Silver;
            }
        }

        private void SellerNameTb_Enter(object sender, EventArgs e)
        {
            if (SellerNameTb.Text == "SellerName")
            {
                SellerNameTb.Text = "";
                SellerNameTb.ForeColor = Color.Black;
            }
        }

        private void SellerNameTb_Leave(object sender, EventArgs e)
        {
            if (SellerNameTb.Text == "")
            {
                SellerNameTb.Text = "SellerName";
                SellerNameTb.ForeColor = Color.Silver;
            }
        }

        private void QuantityTb_Enter(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "Quantity")
            {
                QuantityTb.Text = "";
                QuantityTb.ForeColor = Color.Black;
            }
        }

        private void QuantityTb_Leave(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "")
            {
                QuantityTb.Text = "Quantity";
                QuantityTb.ForeColor = Color.Silver;
            }
        }
        int num = 0, price, total;

        string item, cat;
        private void button1_Click(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "") {
                MessageBox.Show("How many quantities do you want ?");
            }
            else if (flag==0) {
                MessageBox.Show("Select The Product To Be Ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QuantityTb.Text);
                table.Rows.Add(num,item,cat,price,total);
                OrdersGV.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            LabelAmt.Text = ""+ sum;
        }
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void CategoryTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            CategoryTb.Text = "Category";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrderNumTb.Text == "")
            {
                MessageBox.Show("Enter OrderNumber");
            }
            else
            {
                Con.Open();
                string query = "insert into OrdersTbl values('" + OrderNumTb.Text + "','" + DateLbl.Text + "','" + SellerNameTb.Text + "','" + LabelAmt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfully created");
                Con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewOrderes view = new ViewOrderes();
            view.Show();
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num",typeof(int));
            table.Columns.Add("Item",typeof(string));
            table.Columns.Add("Category",typeof(string));

            table.Columns.Add("UnitPrice",typeof(int));
            table.Columns.Add("Total",typeof(int));
            OrdersGV.DataSource = table;
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerNameTb.Text = Form1.user;

        }
        private void ItemsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32( ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }
        private void OrdersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
