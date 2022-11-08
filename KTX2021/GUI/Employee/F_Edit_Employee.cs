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

namespace Dormitory_Management_2021.GUI.NhanVien
{
    public partial class SuaNhanVien : Form
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public SuaNhanVien()
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
        public void LoadSuaNhanVien(string hoten, string gioitinh, string cmnd, string diachi, string quequan, string congviec, string luong, string sdt)
        {
            txthoten.Text = hoten;
            cbbgt.Text = gioitinh;
            txtcmnd.Text = cmnd;
            txtdiachi.Text = diachi;
            txtquequan.Text = quequan;
            txtcongviec.Text = congviec;
            txtluong.Text = luong;
            txtsdt.Text = sdt;
            //cb_DiaDiem.Text = diaDiem;
            //tbSDT.Text = sdt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string hoten = txthoten.Text;
            string cmnd = txtcmnd.Text;
            string sql = "delete nhanvien where hoten = @hoten and cmnd = @cmnd";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@hoten", hoten));
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string hoten = txthoten.Text;
            string gioitinh = cbbgt.Text;
            string cmnd = txtcmnd.Text;
            string diachi = txtdiachi.Text;
            string quequan = txtquequan.Text;
            string congviec = txtcongviec.Text;
            string luong = txtluong.Text;
            string sdt = txtsdt.Text;
            //string ngaysinh = dateTimePicker1.Value.ToString();
            string sql = "insert into nhanvien values(@hoten,@gioitinh,@cmnd,@diachi,@quequan,@congviec,@luong,@sdt)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@hoten", hoten));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@quequan", quequan));
            cmd.Parameters.Add(new SqlParameter("@congviec", congviec));
            cmd.Parameters.Add(new SqlParameter("@luong", luong));
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
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

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string hoten = txthoten.Text;
            string gioitinh = cbbgt.Text;
            string cmnd = txtcmnd.Text;
            string diachi = txtdiachi.Text;
            string quequan = txtquequan.Text;
            string congviec = txtcongviec.Text;
            string luong = txtluong.Text;
            string sdt = txtsdt.Text;
            string sql = "update nhanvien set hoten = @hoten ,gioitinh = @gioitinh ,cmnd = @cmnd ,diachi = @diachi,quequan = @quequan,congviec = @congviec,luong = @luong,sdt = @sdt where hoten = @hoten ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@hoten", hoten));
            cmd.Parameters.Add(new SqlParameter("@gioitinh", gioitinh));
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.Parameters.Add(new SqlParameter("@quequan", quequan));
            cmd.Parameters.Add(new SqlParameter("@congviec", congviec));
            cmd.Parameters.Add(new SqlParameter("@luong", luong));
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
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
            txthoten.Clear();
            txtcmnd.Clear();
            txtdiachi.Clear();
            txtquequan.Clear();
            txtcongviec.Clear();
            txtluong.Clear();
            txtsdt.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
