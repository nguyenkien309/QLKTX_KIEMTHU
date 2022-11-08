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

namespace Dormitory_Management_2021.GUI.Statistic
{
    public partial class UC_Statistic : UserControl
    {
        string con_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
        SqlConnection conn = null;
        public UC_Statistic()
        {
            InitializeComponent();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            //DGVPrinter printer = new DGVPrinter();
            //printer.Title = $"THỐNG KÊ CHI TIẾT";
            //string temp = $"{lb_Total_Buiding_Room.Text}\r\n" +
            //                $"{lb_Total_Room.Text}\r\n" +
            //                $"{lb_Total_Room_Empty.Text}\r\n" +
            //                $"{lb_Total_Employee.Text}\r\n" +
            //                $"{lb_Total_Contract.Text}\r\n" +
            //                $"{lb_Total_Student.Text}\r\n" +
            //                $"{lb_Total_Bill.Text}\r\n" +
            //                $"{lb_Total_Bill_Unpaid.Text}\r\n";
            //printer.SubTitle = temp + $"Ngày in: {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "Quản Lý Ký Túc Xá Đại Học Hải Phòng 2021";
            //printer.FooterSpacing = 15;

            //using (var entity = new db_Dormitory_Management_2021Entities())
            //{
            //    //var AllTable = new List<DataGridView>();

            //    //var tbl_Room = new DataGridView();
            //    //tbl_Room.DataSource = entity.usp_Get_Room();

            //    //var tbl_Employee = new DataGridView();
            //    //tbl_Employee.DataSource = entity.usp_Get_Employee();

            //    //var tbl_Contract = new DataGridView();
            //    //tbl_Contract.DataSource = entity.usp_Get_Contract();

            //    //var tbl_Student = new DataGridView();
            //    //tbl_Student.DataSource = entity.usp_Get_Student();

            //    //var tbl_Bill = new DataGridView();
            //    //tbl_Bill.DataSource = entity.usp_Get_Bill();

            //    //AllTable.Add(tbl_Room);
            //    //AllTable.Add(tbl_Employee);
            //    //AllTable.Add(tbl_Contract);
            //    //AllTable.Add(tbl_Student);
            //    //AllTable.Add(tbl_Bill);

            //    //foreach (var item in AllTable)
            //    //{
                    
            //    //}
            //}
            //printer.Print();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UC_Statistic_Load(sender, e);
        }

        string Total_Buiding_Room, Total_Room, Total_Room_Empty, Total_Employee, Total_Contract, Total_Student, Total_Bill, Total_Bill_Unpaid;

        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(con_str);
            //string sql = "select COUNT(maphong) from hopdong";
            string sql = "SELECT COUNT(maphong) FROM hopdong WHERE EXISTS(SELECT maphong FROM phong WHERE phong.maphong = hopdong.maphong); ";
            string sql2 = "select COUNT(maphong) from phong";
            string sql3 = "select COUNT(masv) from sinhvien";
            string sql4 = "select COUNT(cmnd) from nhanvien";
            string sql5 = "select COUNT(mahd) from hoadon";
            string sql6 = "select COUNT(*) from hoadon where trangthai = N'Chưa Thanh Toán'";
            string sql7 = "select COUNT(mahopdong) from hopdong";

            //string sql8 = "select COUNT(maphong) from phong where tinhtrang = N'còn'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            SqlCommand cmd4 = new SqlCommand(sql4, conn);
            SqlCommand cmd5 = new SqlCommand(sql5, conn);
            SqlCommand cmd6 = new SqlCommand(sql6, conn);
            SqlCommand cmd7 = new SqlCommand(sql7, conn);
            //SqlCommand cmd8 = new SqlCommand(sql8, conn);
            lb_Total_Buiding_Room.Text = "Phòng đang sử dụng : " + cmd.ExecuteScalar().ToString();
            lb_Total_Room.Text = "Tổng số phòng : " + cmd2.ExecuteScalar().ToString();
            string x = cmd.ExecuteScalar().ToString();
            string y = cmd2.ExecuteScalar().ToString();
            lb_Total_Room_Empty.Text = "Phòng trống : "  + (Convert.ToInt32(y) - Convert.ToInt32(x)).ToString();
            //lb_Total_Room_Empty.Text = "Phòng trống : " + cmd8.ExecuteScalar().ToString();
            lb_Total_Student.Text = "Sinh viên : " + cmd3.ExecuteScalar().ToString();
            lb_Total_Employee.Text = "Nhân viên : " + cmd4.ExecuteScalar().ToString();
            lb_Total_Bill.Text = "Hóa đơn : " + cmd5.ExecuteScalar().ToString();
            lb_Total_Bill_Unpaid.Text = "Hóa đơn chưa thanh toán: " + cmd6.ExecuteScalar().ToString();
            lb_Total_Contract.Text = "Hợp đồng: " + cmd7.ExecuteScalar().ToString();
        }
    }
}
