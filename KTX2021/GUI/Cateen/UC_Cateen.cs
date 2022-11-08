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
    public partial class UC_Cateen : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UC_Cateen()
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
            dgv.DataSource = rs.Tables["canteen"];
        }

        private void UC_Cateen_Load(object sender, EventArgs e)
        {
            show();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            string mahd = dgv.SelectedRows[0].Cells[1].Value.ToString();
            string mada = dgv.SelectedRows[0].Cells[2].Value.ToString();
            string masv = dgv.SelectedRows[0].Cells[3].Value.ToString();
            string soluong = dgv.SelectedRows[0].Cells[4].Value.ToString();
            string ngaylap = dgv.SelectedRows[0].Cells[5].Value.ToString();
            string tongtien = dgv.SelectedRows[0].Cells[6].Value.ToString();

            F_Edit_Cateen suacanteen = new F_Edit_Cateen();
            suacanteen.LoadEditCateen(mahd, mada, masv, soluong, ngaylap, tongtien);
            suacanteen.ShowDialog();
            UC_Cateen_Load(sender, e);
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
