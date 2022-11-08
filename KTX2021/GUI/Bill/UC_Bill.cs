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

namespace Dormitory_Management_2021.GUI.HoaDon
{
    public partial class UCHoaDon : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UCHoaDon()
        {
            InitializeComponent();
            
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from hoadon";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "hoadon");
            dgv.DataSource = rs.Tables["hoadon"];
        }
        private void UCHoaDon_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addBill = new Bill.F_Edit_Bill();
            addBill.ShowDialog();
            UCHoaDon_Load(sender, e);
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UCHoaDon_Load(sender, e);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            string mahd = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string maphong = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string sonuoc = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string sodien = dgv.SelectedRows[0].Cells[4].Value.ToString();
            string ngaylap = dgv.SelectedRows[0].Cells[5].Value.ToString();
            string trangthai = dgv.SelectedRows[0].Cells[6].Value.ToString();
            string tongtien = dgv.SelectedRows[0].Cells[7].Value.ToString();

            var editBill = new Bill.F_Edit_Bill();
            editBill.LoadEditBill(mahd, maphong, sonuoc, sodien, ngaylap, trangthai, tongtien);
            editBill.ShowDialog();
            UCHoaDon_Load(sender, e);
        }

        private void btn_Month_Bill_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Name_Room_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string maphong = txtmaphong.Text;
            string sql = "select * from hoadon where maphong like '%' + @maphong + '%'";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@maphong", maphong));
            da.Fill(rs, "hoadon");
            dgv.DataSource = rs.Tables["hoadon"];
        }

        private void btn_Status_Bill_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgv.Rows[e.RowIndex].Cells["id"].Value = (e.RowIndex + 1).ToString();
        }

        private void dtp_Month_Bill_ValueChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string ngaylap = datetimepickerX.Value.ToString();
            string sql2 = "select * from hoadon where ngaylap like '%' + @ngaylap + '%'";
            string sql = "select * from hoadon where ngaylap = @ngaylap";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, conn);
            da = new SqlDataAdapter(sql2, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            da.Fill(rs, "hoadon");
            dgv.DataSource = rs.Tables["hoadon"];
        }

        private void cb_Status_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string ngaylap = datetimepickerX.Value.ToString();
            string trangthai = cbbtrangthai.Text;
            string sql = "select * from hoadon where trangthai = @trangthai and ngaylap = @ngaylap";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@trangthai", trangthai));
            da.SelectCommand.Parameters.Add(new SqlParameter("@ngaylap", ngaylap));
            da.Fill(rs, "hoadon");
            dgv.DataSource = rs.Tables["hoadon"];
        }
    }
}
