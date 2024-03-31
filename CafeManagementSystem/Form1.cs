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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shind\source\repos\CafeManagementSystem\CafeManagementSystem\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm guest = new ItemForm();
            guest.Show();
        }

        public static string user;
        private void button1_Click(object sender, EventArgs e)
        {/*
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();*/
            if(UnameTb.Text == ""|| UpassTb.Text == "")
            {
                MessageBox.Show("Enter A Username And Password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTbl where Uname='"+UnameTb.Text+"' and Upassword= '"+UpassTb.Text+"'",Con);
                DataTable table = new DataTable();
                sda.Fill(table);
                if (table.Rows[0][0].ToString() == "1")
                {
                    user = UnameTb.Text;
                    UserOrder userOrder = new UserOrder();
                    userOrder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");

                }
                Con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
