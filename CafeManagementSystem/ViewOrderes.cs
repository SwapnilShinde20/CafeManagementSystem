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
    public partial class ViewOrderes : Form
    {
        public ViewOrderes()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shind\source\repos\CafeManagementSystem\CafeManagementSystem\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "Select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewOrdersGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewOrderes_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrdersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MyCafe ", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(370,40));
            e.Graphics.DrawString("====== Order Summary =======", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208,70));
            e.Graphics.DrawString("Number : " + ViewOrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120,135));
            e.Graphics.DrawString("Date : " + ViewOrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120,170));
            e.Graphics.DrawString("Seller : " + ViewOrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120,205));
            e.Graphics.DrawString("Amount : " + ViewOrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120,240));
            e.Graphics.DrawString("====== PoweredByFlix =======", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208, 340));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
