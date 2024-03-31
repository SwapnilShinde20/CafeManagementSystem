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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
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
        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
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
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNumTb.Text == "" || ItemPriceTb.Text == "")
            {
                MessageBox.Show("Fill All Data");

            }
            else
            {
                Con.Open();
                string query = "insert into ItemTbl values('" + ItemNumTb.Text + "','" + ItemNameTb.Text + "','" + CatCb.SelectedItem.ToString() + "','" + ItemPriceTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully created");
                Con.Close();
                populate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ItemsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNumTb.Text = ItemsGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemNameTb.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.SelectedItem = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPriceTb.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Select The Item to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from ItemTbl where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Deleted");
                Con.Close();
                ItemNumTb.Text = string.Empty;
                ItemNameTb.Text = string.Empty;
                CatCb.Text = "Category";
                ItemPriceTb.Text= string.Empty;
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || CatCb.Text == "" || ItemPriceTb.Text == "")
            {
                MessageBox.Show("Fill All the fields");
            }
            else
            {
                Con.Open();
                string query = "update ItemTbl set ItemName='" + ItemNameTb.Text + "',ItemPrice='" + ItemPriceTb.Text + "',ItemCat='" + CatCb.SelectedItem.ToString() + "' where ItemNum='" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Updated");
                Con.Close();
                populate();
            }
        }
    }
}
