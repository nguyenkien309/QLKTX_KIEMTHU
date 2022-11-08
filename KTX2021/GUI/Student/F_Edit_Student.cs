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

namespace Dormitory_Management_2021.GUI.SinhVien
{
    public partial class SuaSinhVien : Form
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public SuaSinhVien()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from sinhvien";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "sinhvien");
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string masv = txtmasv.Text;
            string hoten = txthoten.Text;
            string lop = txtlop.Text;
            string ngaysinh = txtns.Text;
            string gioitinh = cbbgt.Text;
            string quequan = txtquequan.Text;
            string nienkhoa =txtnienkhoa.Text;
            string maphong = txtmaphong.Text;
            string sql = "update sinhvien set masv = @masv ,hoten = @hoten ,lop = @lop ,ngaysinh = @ngaysinh,gioitinh = @gioitinh,quequan = @quequan,nienkhoa = @nienkhoa,maphong = @maphong where masv = @masv ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@masv", masv));
            cmd.Parameters.Add(new SqlParameter("@hoten", hoten));
            cmd.Parameters.Add(new SqlParameter("@lop", lop));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@quequan", quequan));
            cmd.Parameters.Add(new SqlParameter("@nienkhoa", nienkhoa));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void LoadSuaSinhVien( string masv, string hoten, string lop, string ngaysinh, string gioitinh, string quequan, string nienkhoa, string maphong)
        {
            txthoten.Text = hoten;
            txtns.Text = ngaysinh;
            cbbgt.Text = gioitinh;
            txtnienkhoa.Text = nienkhoa;
            txtmasv.Text = masv;
            txtlop.Text = lop;
            txtquequan.Text = quequan;
            txtmaphong.Text = maphong;
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string hoten = txthoten.Text;
            string masv = txtmasv.Text;
            string sql = "delete sinhvien where hoten = @hoten and masv = @masv";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@hoten", hoten));
            cmd.Parameters.Add(new SqlParameter("@masv", masv));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs == 1)
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string masv = txtmasv.Text;
            string hoten = txthoten.Text;
            string lop = txtlop.Text;
            string ngaysinh = txtns.Text;
            string gioitinh = cbbgt.Text;
            string quequan = txtquequan.Text;
            string nienkhoa = txtnienkhoa.Text;
            string maphong = txtmaphong.Text;
            string sql = "insert into sinhvien values(@masv,@hoten,@lop,@ngaysinh,@gioitinh,@quequan,@nienkhoa,@maphong)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@masv", masv));
            cmd.Parameters.Add(new SqlParameter("@hoten", hoten));
            cmd.Parameters.Add(new SqlParameter("@lop", lop));
            cmd.Parameters.Add(new SqlParameter("@ngaysinh", ngaysinh));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@quequan", quequan));
            cmd.Parameters.Add(new SqlParameter("@nienkhoa", nienkhoa));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            txtmasv.Clear();
            txthoten.Clear();
            txtlop.Clear();
            txtns.Clear();
            txtquequan.Clear();
            txtnienkhoa.Clear();
            txtmaphong.Clear();
        }
    }
}
