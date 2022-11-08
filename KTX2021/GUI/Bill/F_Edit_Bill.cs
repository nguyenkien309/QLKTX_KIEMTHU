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
using Guna.UI2.WinForms.Suite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;

namespace Dormitory_Management_2021.GUI.Bill
{
    public partial class F_Edit_Bill : Form
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public F_Edit_Bill()
        {
            InitializeComponent();
            datetimepicker.Value = DateTime.Now;
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from hoadon";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "hoadon");
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }

        public void LoadEditBill(string mahd, string maphong, string sonuoc, string sodien, string ngaylap, string trangthai, string tongtien)
        {
            txtmahd.Text = mahd;
            txtmaphong.Text = maphong;
            txtsonuoc.Text = sonuoc;
            txtsodien.Text = sodien;
            datetimepicker.Value = Convert.ToDateTime(ngaylap);
            cbbtrangthai.Text = trangthai;
            txttongtien.Text = tongtien;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahd = txtmahd.Text;
            string maphong = txtmaphong.Text;
            string sonuoc = txtsonuoc.Text;
            string sodien = txtsodien.Text;
            string ngaylap = datetimepicker.Value.ToString("yyyy-MM-dd");
            string trangthai = cbbtrangthai.Text;
            int tongtien = 0;
            string sql = "insert into hoadon values(@mahd,@maphong,@sonuoc,@sodien,@ngaylap,@trangthai,@tongtien)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            cmd.Parameters.Add(new SqlParameter("@sonuoc", sonuoc));
            cmd.Parameters.Add(new SqlParameter("@sodien", sodien));
            cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
            cmd.Parameters.Add(new SqlParameter("@tongtien", tongtien));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                MessageBox.Show("ok");
                this.Close();
                show();
                return;
            }
            
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahd = txtmahd.Text;
            string maphong = txtmaphong.Text;
            string sonuoc = txtsonuoc.Text;
            string sodien = txtsodien.Text;
            string ngaylap = datetimepicker.Value.ToString("yyyy-MM-dd");
            string trangthai = cbbtrangthai.Text;
            string sql = "update hoadon set mahd = @mahd ,maphong = @maphong ,sonuoc = @sonuoc ,sodien = @sodien,ngaylap = @ngaylap,trangthai = @trangthai where mahd = @mahd ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
            cmd.Parameters.Add(new SqlParameter("@maphong", maphong));
            cmd.Parameters.Add(new SqlParameter("@sonuoc", sonuoc));
            cmd.Parameters.Add(new SqlParameter("@sodien", sodien));
            cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
            int rs = (int)cmd.ExecuteNonQuery();
            if (rs > 0)
            {
                MessageBox.Show("ok");
                this.Close();
                show();
                return;
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahd = txtmahd.Text;
            string ngaylap = datetimepicker.Value.ToString();
            string sql = "delete hoadon where mahd = @mahd and ngaylap = @ngaylap";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@mahd", mahd));
            cmd.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            int rs = (int)cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0)
            {
                MessageBox.Show("ok");
                this.Close();
                show();
                return;
            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            int value = number.Next(0, 1000000000);
            txtmahd.Enabled = true;
            txtmaphong.Enabled = true;
            txtmahd.Text = "DN" + value.ToString();
            txtmaphong.Clear();
            txtsodien.Clear();
            txtsonuoc.Clear();
            cbbtrangthai.SelectedIndex = 0;

    }

    private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Edit_Bill_Load(object sender, EventArgs e)
        {
            txtmahd.Enabled = false;
            txttongtien.Enabled = false;
            conn = new SqlConnection(con_str);
            string sql = "select maphong from phong";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            LISTDATATEST.DisplayMember = "maphong";
            LISTDATATEST.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
