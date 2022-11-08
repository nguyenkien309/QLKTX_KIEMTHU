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

namespace Dormitory_Management_2021.GUI.HopDong
{
    public partial class UCHopDong : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UCHopDong()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from hopdong";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "hopdong");
            dgv.DataSource = rs.Tables["hopdong"];
        }
        private void UC_HopDong_Load(object sender, EventArgs e)
        {
            show();
            this.dgv.Sort(this.dgv.Columns["maphong"], ListSortDirection.Ascending);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            string mahopdong = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string maphong = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string ten = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string ngaylap = dgv.SelectedRows[0].Cells[4].Value.ToString();
            string ketthuc = dgv.SelectedRows[0].Cells[5].Value.ToString();
            string tongtien = dgv.SelectedRows[0].Cells[6].Value.ToString();

            SuaHopDong suaHopDong = new SuaHopDong();
            suaHopDong.LoadSuaHopDong(mahopdong, maphong, ten, ngaylap, ketthuc, tongtien);
            suaHopDong.ShowDialog();
            UC_HopDong_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //ThemHopDong themHopDong = new ThemHopDong();
            //themHopDong.ShowDialog();
            SuaHopDong themHopDong = new SuaHopDong();
            themHopDong.ShowDialog();
            UC_HopDong_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_HopDong_Load(sender, e);
        }

        private void btn_Name_Student_Contract_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string mahopdong = txtmahopdong.Text;
            string sql2 = "select * from hopdong where mahopdong like '%' + @mahopdong + '%'";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, conn);
            da = new SqlDataAdapter(sql2, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@mahopdong", mahopdong));
            da.Fill(rs, "hopdong");
            dgv.DataSource = rs.Tables["hopdong"];
        }

        private void btn_Name_Room_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string maphong = txtmaphong.Text;
            string sql2 = "select * from hopdong where maphong like '%' + @maphong + '%'";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, conn);
            da = new SqlDataAdapter(sql2, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@maphong", maphong));
            da.Fill(rs, "hopdong");
            dgv.DataSource = rs.Tables["hopdong"];
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
            this.dgv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
