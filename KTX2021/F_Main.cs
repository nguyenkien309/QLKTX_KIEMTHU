using Dormitory_Management_2021.GUI.Chart;
using Dormitory_Management_2021.GUI.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory_Management_2021
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
            uc_Room.Hide();
            uc_Employee.Hide();
            uc_Contract.Hide();
            uc_Student.Hide();
            uc_Bill.Hide();
            uc_Statistic.Hide();
            uC_Cateen1.Hide();
        }

        #region Moveable no-border
        int mouseDownX, mouseDownY;
        bool mouseDown;
        private void pl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }

        private void pl_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseDownX, MousePosition.Y - mouseDownY);
            }
        }

        private void pl_Top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            uc_Employee.Show();
            uc_Employee.BringToFront();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            uc_Contract.Show();
            uc_Contract.BringToFront();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            uc_Student.Show();
            uc_Student.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            uc_Bill.Show();
            uc_Bill.BringToFront();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            uc_Room.Show();
            uc_Room.BringToFront();
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            using (var f_Profile = new F_Profile())
            {
                f_Profile.ShowDialog();
            }
        }

        private void btn_Statistic_Click(object sender, EventArgs e)
        {
            uC_Chart1.Show();
            uC_Chart1.BringToFront();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            uc_Statistic.Show();
            uc_Statistic.BringToFront();
        }

        private void uc_Statistic_Load(object sender, EventArgs e)
        {

        }

        private void btn_Contract_Extension_Click(object sender, EventArgs e)
        {
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 204)
            {
                panel1.Height = 40;
                panel1.Width = 200;
            }
            else panel1.Height = 204;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            uC_Cateen1.Show();
            uC_Cateen1.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
