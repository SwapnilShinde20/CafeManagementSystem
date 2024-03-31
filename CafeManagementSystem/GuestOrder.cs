using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ItemForm : Form
    {
        public ItemForm()
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
            string query = "Select * from ItemTbl where ItemCat = '" + CategoryTb.SelectedItem.ToString() + "'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void quantiy_Enter(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "Quantity")
            {
                QuantityTb.Text = "";
                QuantityTb.ForeColor = Color.Black;
            }
        }

        private void orderno_Enter(object sender, EventArgs e)
        {
            if(OrderNoTb.Text == "OrderNum")
            {
                OrderNoTb.Text = "";
                OrderNoTb.ForeColor = Color.Black;
            }
        }

        private void orderno_Leave(object sender, EventArgs e)
        {
            if (OrderNoTb.Text == "")
            {
                OrderNoTb.Text = "OrderNum";
                OrderNoTb.ForeColor = Color.Silver;
            }
        }

        private void sellername_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void sellername_Enter(object sender, EventArgs e)
        {
            if (SellerNameTb.Text == "SellerName")
            {
                SellerNameTb.Text = "";
                SellerNameTb.ForeColor = Color.Black;
            }
        }

        private void sellername_Leave(object sender, EventArgs e)
        {
            if(SellerNameTb.Text == "")
            {
                SellerNameTb.Text = "SellerName";
                SellerNameTb.ForeColor = Color.Silver;
            }
        }

        private void quantiy_Leave(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "")
            {
                QuantityTb.Text = "Quantity";
                QuantityTb.ForeColor = Color.Silver;
            }
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGV.DataSource = table;
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int num = 0, price, total;

        private void button1_Click(object sender, EventArgs e)
        {
            if (QuantityTb.Text == "")
            {
                MessageBox.Show("How many quantities do you want ?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product To Be Ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QuantityTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGV.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            LabelAmt.Text = ""+sum;
        }

        string item, cat;
        DataTable table = new DataTable();

        private void ItemsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
            CategoryTb.Text = "Category";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrderNoTb.Text == "")
            {
                MessageBox.Show("Enter OrderNumber");
            }
            else {
                Con.Open();
                string query = "insert into OrdersTbl values('" + OrderNoTb.Text + "','" + DateLbl.Text + "','" + SellerNameTb.Text + "','" + LabelAmt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfully created");
                Con.Close();
            }
        }

        int flag = 0;
        int sum = 0;
        private void CategoryTb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }
    }
}
