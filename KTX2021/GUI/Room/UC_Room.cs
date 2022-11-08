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
    public partial class UCPhong : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UCPhong()
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
            dgv.DataSource = rs.Tables["phong"];
        }
        
        private void UC_Phong_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            //TaoPhong taoPhong = new TaoPhong();
            //taoPhong.ShowDialog();
            SuaPhong taoPhong = new SuaPhong();
            taoPhong.ShowDialog();
            UC_Phong_Load(sender, e);
        }

        private void dgv_Phong_DoubleClick(object sender, EventArgs e)
        {
            string toanha = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string maphong = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string loaiPhong = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string soluong = dgv.SelectedRows[0].Cells[4].Value.ToString();
            SuaPhong suaPhong = new SuaPhong();
            suaPhong.LoadSuaPhong(toanha, maphong, loaiPhong, soluong);
            suaPhong.ShowDialog();
            UC_Phong_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_Phong_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void btnLayPhongTheoToaNha_Click(object sender, EventArgs e)
        {
            string toaNha = "A";
            try
            {
                toaNha = cbToaNha.Text;
            }
            catch (Exception)
            {

            }
            finally
            {
                using (var entity = new db_Dormitory_Management_2021Entities())
                {
                    dgv.DataSource = entity.usp_Get_Room_by_The_Building_Room(toaNha);
                }
            }
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            string loaiPhong = "Nam";
            try
            {
                loaiPhong = cbLoaiPhong.Text;
            }
            catch (Exception)
            {

            }
            finally
            {
                using (var entity = new db_Dormitory_Management_2021Entities())
                {
                    dgv.DataSource = entity.usp_Get_Room_by_Type_Room(loaiPhong);
                }
            }
        }

        private void btnTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {
                int tinhTrang = cbTinhTrang.SelectedIndex;

                using (var entity = new db_Dormitory_Management_2021Entities())
                {
                    dgv.DataSource = entity.usp_Get_Room_By_Status(tinhTrang); // 0 empty, 1 available, 2 fulled
                }
            }
            catch (Exception)
            {

            }
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