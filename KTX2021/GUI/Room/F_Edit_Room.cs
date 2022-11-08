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

namespace Dormitory_Management_2021.GUI.Phong
{
    public partial class SuaPhong : Form
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public SuaPhong()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from phong";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "phong");
        }
        public void LoadSuaPhong(string toanha, string maphong, string loaiphong, string soluong)
        {
            txttoanha.Text = toanha;
            txtmaphong.Text = maphong;
            cbbloaiphong.Text = loaiphong;
            txtsoluong.Text = soluong;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void check()
        {

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string toanha = txttoanha.Text;
            string maphong = txtmaphong.Text;
            string loaiphong = cbbloaiphong.Text;
            string soluong = txtsoluong.Text;
            string tinhtrang = "còn";
            //string ngaysinh = dateTimePicker1.Value.ToString();
            string sql = "insert into phong values(@toanha,@maphong,@loaiphong,@soluong,@tinhtrang)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@toanha", toanha));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            cmd.Parameters.Add(new SqlParameter("@loaiphong", loaiphong));
            cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
            cmd.Parameters.Add(new SqlParameter("@tinhtrang", tinhtrang));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs == 1)
            {
                MessageBox.Show("ok");
                show();
                this.Close();
                return;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string toanha = txttoanha.Text;
            string maphong = txtmaphong.Text;
            string loaiphong = cbbloaiphong.Text;
            string soluong = txtsoluong.Text;
            string sql = "update phong set toanha = @toanha,maphong = @maphong,loaiphong = @loaiphong,soluong = @soluong where toanha = @toanha and maphong = @maphong ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@toanha", toanha));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            cmd.Parameters.Add(new SqlParameter("@loaiphong", loaiphong));
            cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                MessageBox.Show("ok");
                show();
                this.Close();
                return;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string toanha = txttoanha.Text;
            string maphong = txtmaphong.Text;
            string sql = "delete phong where toanha = @toanha and maphong = @maphong";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@toanha", toanha));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                MessageBox.Show("Đã Xóa");
                show();
                this.Close();
            }
            else
            {
                MessageBox.Show("SAI");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            txttoanha.Clear();
            txtmaphong.Clear();
        }
    }
}
