using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

namespace Dormitory_Management_2021.GUI.Cateen
{
    public partial class F_Edit_Cateen : Form
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public F_Edit_Cateen()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from canteen";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "canteen");
        }
        public void LoadEditCateen(string mahd, string mada, string masv, string soluong, string ngaylap, string tongtien)
        {
            txtmahd.Text = mahd;
            txtmada.Text = mada;
            txtmasv.Text = masv;
            txtsoluong.Text = soluong;
            dtpngaylap.Value = Convert.ToDateTime(ngaylap);
            txttongtien.Text = tongtien;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahd = txtmahd.Text;
            string mada = txtmada.Text;
            string masv = txtmasv.Text;
            string soluong = txtsoluong.Text;
            string ngaylap = dtpngaylap.Value.ToString();
            string tongtien = txttongtien.Text;
            //string ngaysinh = dateTimePicker1.Value.ToString();
            string sql = "insert into canteen values(@mahd,@mada,@masv,@soluong,@ngaylap,@tongtien)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
            cmd.Parameters.Add(new SqlParameter("@mada", mada));
            cmd.Parameters.Add(new SqlParameter("@masv", masv));
            cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
            cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
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

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahd = txtmahd.Text;
            string mada = txtmada.Text;
            string masv = txtmasv.Text;
            string soluong = txtsoluong.Text;
            string ngaylap = dtpngaylap.Value.ToString();
            string tongtien = txttongtien.Text;
            string sql = "update canteen set mahd = @mahd,mada = @mada,masv = @masv,soluong = @soluong ,ngaylap=@ngaylap where mahd = @mahd and mada = @mada ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
            cmd.Parameters.Add(new SqlParameter("@mada", mada));
            cmd.Parameters.Add(new SqlParameter("@masv", masv));
            cmd.Parameters.Add(new SqlParameter("@soluong", soluong));
            cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
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
            string mahd = txtmahd.Text;
            string mada = txtmada.Text;
            string sql = "delete canteen where mahd = @mahd and mada = @mada";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
            cmd.Parameters.Add(new SqlParameter("@mada", mada));
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
            Random number = new Random();
            int value = number.Next(0, 1000000000);
            txtmahd.Enabled = true;
            txtmahd.Text = "HD" + value.ToString();
            txtmasv.Clear();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmahd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
