using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dormitory_Management_2021
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bn_Login_Click(object sender, EventArgs e)
        {
            string conn_str = "Data Source = NVK309; Initial catalog= KTXSV;User ID =sa;Password = 123456";
            SqlConnection conn = new SqlConnection(conn_str);
            try
            {
                conn.Open();
                String tk = txt_Username.Text;
                String mk = txt_Password.Text;
                String str = "select count(*) from NguoiDung where tk=@tk and mk=@mk";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                int rs = (int)cmd.ExecuteScalar();
                conn.Close();
                if (rs == 1)
                {
                    MessageBox.Show("thanh cong");
                    this.Hide();
                    F_Main form6 = new F_Main();
                    form6.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
