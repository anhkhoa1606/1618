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
using System.Data.SqlClient;

namespace asm2_1618
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Acer\Documents\asm2_1618.mdf;Integrated Security = True; Connect Timeout = 30");
        private void populate()
        {
            con.Open();
            string query = "select * from SystemTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SystemDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Maphong.Text == "" || Typeroom.Text == "" || Floor.Text == "" || price.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into SystemTable values('" + Maphong.Text + "','" + Typeroom.Text + "','" + Floor.Text + "','" + price.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SystemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Maphong.Text = SystemDGV.SelectedRows[0].Cells[0].Value.ToString();
            Typeroom.Text = SystemDGV.SelectedRows[0].Cells[1].Value.ToString();
            Floor.Text = SystemDGV.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = SystemDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Maphong.Text = "";
            Typeroom.Text = "";
            Floor.Text = "";
            price.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Maphong.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from SystemTable where IDphongsystem=" + Maphong.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Hethongbtn_Click(object sender, EventArgs e)
        {
            PhieuDatPhong phieuDatPhong = new PhieuDatPhong();
            phieuDatPhong.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Maphong.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update SystemTable set TypeofRoom='" + Typeroom.Text + "',Floor='" + Floor.Text + "',Price='" + price.Text +"' where IDphongsystem=" + Maphong.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
