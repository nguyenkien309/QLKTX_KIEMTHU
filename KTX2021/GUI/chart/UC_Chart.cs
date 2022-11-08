using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Linq;
using Guna.UI2.WinForms.Suite;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dormitory_Management_2021.GUI.Chart
{
    public partial class uC_Chart1 : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public uC_Chart1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = (DateTime.Now.Month)-1;
        }
        private void checkloai()
        {

        }
        private void show()
        {

            string loai = cbbloai.Text;
            string ngaylap = comboBox1.Text;
            SqlConnection con = new SqlConnection("Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456");
            if (loai == "Sinh Viên")
            {
                //txttongtien.Visible = true;
                string sql = "select lop,COUNT(masv) as SL from sinhvien group by lop";
                SqlDataAdapter ad2 = new SqlDataAdapter(sql, con);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                chart1.DataSource = dt2;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Sinh Viên";
                chart1.Series["Series1"].XValueMember = "lop";
                chart1.Series["Series1"].YValueMembers = "SL";
            }
            else
            {
                string sql = "select maphong,SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' group by maphong";
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Hóa Đơn";
                chart1.Series["Series1"].XValueMember = "maphong";
                chart1.Series["Series1"].YValueMembers = "tongtien";
            }

        }
        private void show2()
        {
            string loai = cbbloai.Text;
            string ngaylap = comboBox1.Text;
            SqlConnection con = new SqlConnection("Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456");
            if (loai == "Sinh Viên")
            {
                string sql = "select lop,COUNT(masv) as SL from sinhvien group by lop";
                SqlDataAdapter ad2 = new SqlDataAdapter(sql, con);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                chart2.DataSource = dt2;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Sinh Viên";
                chart2.Series["Series1"].XValueMember = "lop";
                chart2.Series["Series1"].YValueMembers = "SL";
            }
            else
            {
                string sql = "select maphong,SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' group by maphong";
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart2.DataSource = dt;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tổng Tiền";
                chart2.Series["Series1"].XValueMember = "maphong";
                chart2.Series["Series1"].YValueMembers = "tongtien";
            }
        }
        private void showtotal()
        {
            conn = new SqlConnection(con_str);
            string ngaylap = comboBox1.Text;
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            //string a = double.Parse("12345").ToString("#,###", cul.NumberFormat);
            //currencyTest.Text = a;
     

            string sql = "select SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' and trangthai= N'Chưa Thanh Toán' ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {

                txttongtien.Text = reader["tongtien"].ToString();
                if (String.IsNullOrEmpty(txttongtien.Text))
                {
                    currencyTest.Text = "0";
                }
                else
                {
                    string a = double.Parse(reader["tongtien"].ToString()).ToString("#,###", cul.NumberFormat);
                    currencyTest.Text = a;
                }
            }
        }
        private void showbill()
        {
            string ngaylap = comboBox1.Text;
            string currentYear = DateTime.Now.Year.ToString();
            conn = new SqlConnection(con_str);
            string sql = "select * from hoadon where  MONTH(ngaylap) = '" + ngaylap + "' and YEAR(ngaylap) = '" + currentYear + "'";
            DataSet rs = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(rs, "hoadon");
            dgv.DataSource = rs.Tables["hoadon"];
        }

        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
     

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }


        private void uC_Chart1_Load(object sender, EventArgs e)
        {
           
            cbbloai.SelectedIndex = 0;
            showbill();
            show();
            //show2();
            showtotal();
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
    
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            var collectionx = chart2.Series.Select(series => series.Points.Where(point => point.XValue == 1).ToString()).ToString();
            MessageBox.Show(collectionx);
        }

        private void btn_Excel_Click_1(object sender, EventArgs e)
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
                        xcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void cbbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbbloai.SelectedItem.ToString();
            if (selectedType == "Sinh Viên")
            {
                txttongtien.Visible = false;
                currencyTest.Visible = false;
                dgv.Visible = false;
                btnthang.Visible = false;
                guna2Button2.Visible = false;
                comboBox1.Visible = false;
            }
            else
            {
                //txttongtien.Visible = true;
                currencyTest.Visible = true;
                dgv.Visible = true;
                btnthang.Visible = true;
                guna2Button2.Visible = true;
                comboBox1.Visible = true;
            }
            string loai = cbbloai.Text;
            string ngaylap = comboBox1.Text;
            string currentYear = DateTime.Now.Year.ToString();
            SqlConnection con = new SqlConnection("Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456");
            if (loai == "Sinh Viên")
            {
                string sql = "select lop,COUNT(masv) as SL from sinhvien group by lop";
                SqlDataAdapter ad2 = new SqlDataAdapter(sql, con);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                chart1.DataSource = dt2;
                chart2.DataSource = dt2;

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Sinh Viên";
                chart1.Series["Series1"].XValueMember = "lop";
                chart1.Series["Series1"].YValueMembers = "SL";

                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Sinh Viên";
                chart2.Series["Series1"].XValueMember = "lop";
                chart2.Series["Series1"].YValueMembers = "SL";
            }
            else
            {
                string sql = "select maphong,SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' and YEAR(ngaylap) = '" + currentYear + "'  group by maphong";
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                chart1.DataSource = dt;
                chart2.DataSource = dt; 

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tổng Tiền";
                chart1.Series["Series1"].XValueMember = "maphong";
                chart1.Series["Series1"].YValueMembers = "tongtien";

                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tổng Tiền";
                chart2.Series["Series1"].XValueMember = "maphong";
                chart2.Series["Series1"].YValueMembers = "tongtien";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cbbloai.Text;
            string ngaylap = comboBox1.Text;
            string currentYear = DateTime.Now.Year.ToString();
            showbill();
            showtotal();
            SqlConnection con = new SqlConnection("Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456");
            string sql = "select maphong,SUM(tongtien) as tongtien from hoadon where MONTH(ngaylap) = '" + ngaylap + "' and YEAR(ngaylap) = '" + currentYear + "'  group by maphong";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tổng Tiền";
            chart1.Series["Series1"].XValueMember = "maphong";
            chart1.Series["Series1"].YValueMembers = "tongtien";

            chart2.DataSource = dt;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Mã Phòng";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Tổng Tiền";
            chart2.Series["Series1"].XValueMember = "maphong";
            chart2.Series["Series1"].YValueMembers = "tongtien";
        }
    }

  
    //comboBox1.Items.Clear()
}
