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

namespace asm2_1618
{
    public partial class PhieuDatPhong : Form
    {
        public PhieuDatPhong()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Acer\Documents\asm2_1618.mdf;Integrated Security = True; Connect Timeout = 30");
        private void populate()
        {
            con.Open();
            string query = "select * from PhieuDatPhongTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PhieuDatPhongDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void systemmaphongcb()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select IDphongsystem from SystemTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IDphongsystem", typeof(int));
            dt.Load(rdr);
            MaPhongCb.ValueMember = "IDphongsystem";
            MaPhongCb.DataSource = dt;
            con.Close() ;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenkhachhang.Text == "" || txtSodienthoai.Text == "" || txtTiencoc.Text == "" || txtNgaysinh.Text == "" || txtSonguoi.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into PhieuDatPhongTable values('" + txtTenkhachhang.Text + "','" + MaPhongCb.SelectedValue.ToString() + "','" + txtSodienthoai.Text + "','" + txtTiencoc.Text + "','" + txtNgaysinh.Value.Date.ToString() + "','" + txtSonguoi.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    con.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenkhachhang.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update PhieuDatPhongTable set PhoneNumber='" + txtSodienthoai.Text + "',Tiencoc='" + txtTiencoc.Text + "',Ngaysinh='" + txtNgaysinh.Value.Date.ToString() + "',Songuoi='" + txtSonguoi.Text + "'where Name='" + txtTenkhachhang.Text+ "';";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenkhachhang.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from PhieuDatPhongTable where Name='" + txtTenkhachhang.Text + "';";
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

        private void PhieuDatPhong_Load(object sender, EventArgs e)
        {
            populate();
            systemmaphongcb();
        }

        private void PhieuDatPhongDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenkhachhang.Text = PhieuDatPhongDGV.SelectedRows[0].Cells[0].Value.ToString();
            MaPhongCb.SelectedItem = PhieuDatPhongDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtSodienthoai.Text = PhieuDatPhongDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtTiencoc.Text = PhieuDatPhongDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtNgaysinh.Text = PhieuDatPhongDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtSonguoi.Text = PhieuDatPhongDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTenkhachhang.Text = "";
            MaPhongCb.SelectedItem = "";
            txtSodienthoai.Text = "";
            txtTiencoc.Text = "";
            txtSonguoi.Text = "";
        }

        private void Hethongbtn_Click(object sender, EventArgs e)
        {
            HeThong heThong = new HeThong();
            heThong.Show();
            this.Hide();
        }
    }
}
