using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagementSystem
{
    public partial class UsersForm : Form
    {
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shind\source\repos\CafeManagementSystem\CafeManagementSystem\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        public UsersForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "Select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);  
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemsForm itemsOrder = new ItemsForm();
            itemsOrder.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UsersTbl values('" + UnameTb.Text + "','" + UphoneTb.Text + "','" + UpassTb.Text + "')";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully created");
            Con.Close();
            populate();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void UsersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            UphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Select The User to be deleted");
            }
            else { 
                Con.Open();
                string query = "delete from UsersTbl where Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                UnameTb.Text = string.Empty;
                UphoneTb.Text = string.Empty; 
                UpassTb.Text= string.Empty;
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UphoneTb.Text == "" || UpassTb.Text == "")
            {
                MessageBox.Show("Fill All the fields");
            }
            else { 
                Con.Open();
                string query = "update UsersTbl set Uname='" + UnameTb.Text + "',Upassword='" + UpassTb.Text + "' where Uphone='"+UphoneTb.Text+"'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();
            }
        }
    }
}
