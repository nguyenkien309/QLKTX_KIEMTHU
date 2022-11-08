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
    public partial class UCNhanVien : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UCNhanVien()
        {
            InitializeComponent();
        }
        private void show()
        {
            conn = new SqlConnection(con_str);
            string sql = "select * from nhanvien";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "nhanvien");
            dgv.DataSource = rs.Tables["nhanvien"];
        }
        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
            UC_NhanVien_Load(sender, e);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            //string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
            string hoten = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string gioitinh = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string cmnd = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string diachi = dgv.SelectedRows[0].Cells[4].Value.ToString();
            string quequan = dgv.SelectedRows[0].Cells[5].Value.ToString();
            string congviec = dgv.SelectedRows[0].Cells[6].Value.ToString();
            string luong = dgv.SelectedRows[0].Cells[7].Value.ToString();
            string sdt = dgv.SelectedRows[0].Cells[8].Value.ToString();

            SuaNhanVien suaNhanVien = new SuaNhanVien();
            suaNhanVien.LoadSuaNhanVien(hoten ,gioitinh,cmnd ,diachi ,quequan ,congviec ,luong ,sdt);
            suaNhanVien.ShowDialog();
            UC_NhanVien_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_NhanVien_Load(sender, e);
        }

        private void btn_Home_Town_Employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Work_Employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Workplace_Employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Name_Employee_Click(object sender, EventArgs e)
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
    }
}
