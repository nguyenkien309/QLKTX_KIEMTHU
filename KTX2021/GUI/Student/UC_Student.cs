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
    public partial class UC_SinhVien : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UC_SinhVien()
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
            dgv.DataSource = rs.Tables["sinhvien"];

        }
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            //string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
            string masv = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string hoten = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string lop = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string ngaysinh = dgv.SelectedRows[0].Cells[4].Value.ToString();
            string gioitinh = dgv.SelectedRows[0].Cells[5].Value.ToString();
            string quequan = dgv.SelectedRows[0].Cells[6].Value.ToString();
            string nienkhoa = dgv.SelectedRows[0].Cells[7].Value.ToString();
            string maphong = dgv.SelectedRows[0].Cells[8].Value.ToString();

            SuaSinhVien suaSinhVien = new SuaSinhVien();
            suaSinhVien.LoadSuaSinhVien( masv, hoten, lop, ngaysinh, gioitinh, quequan, nienkhoa, maphong);
            suaSinhVien.ShowDialog();
            UC_SinhVien_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_SinhVien_Load(sender, e);
        }

        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btn_Name_Student_Contract_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            string hoten = txt_Name_Student_Contract.Text;
            string sql2 = "select * from sinhvien where hoten like '%' + @hoten + '%'";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql2, conn);
            da = new SqlDataAdapter(sql2, conn);
            da.SelectCommand.Parameters.Add(new SqlParameter("@hoten", hoten));
            da.Fill(rs, "sinhvien");
            dgv.DataSource = rs.Tables["sinhvien"];
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

        private void btn_Identity_Card_Student_Contract_Click(object sender, EventArgs e)
        {
            try
            {
                using (var entities = new db_Dormitory_Management_2021Entities())
                {
                    var Identity_Card_Student_Contract = Convert.ToInt64(txt_Identity_Card_Student_Contract.Text);
                    dgv.DataSource = entities.usp_Get_Student_by_Identity_Card_Student_Contract(Identity_Card_Student_Contract);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_Home_Town_Student_Contract_Click(object sender, EventArgs e)
        {
            try
            {
                using (var entities = new db_Dormitory_Management_2021Entities())
                {
                    var Home_Town_Student_Contract = txt_Home_Town_Student_Contract.Text;
                    dgv.DataSource = entities.usp_Get_Student_by_Home_Town_Student_Contract(Home_Town_Student_Contract);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_Class_Student_Contract_Click(object sender, EventArgs e)
        {
            try
            {
                using (var entities = new db_Dormitory_Management_2021Entities())
                {
                    var Class_Student_Contract = txt_Class_Student_Contract.Text;
                    dgv.DataSource = entities.usp_Get_Student_by_Class_Student_Contract(Class_Student_Contract);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_Parents_Name_Student_Contract_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            
            show();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgv.Rows[e.RowIndex].Cells["id"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
