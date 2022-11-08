
namespace Dormitory_Management_2021.GUI.HopDong
{
    partial class UCHopDong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Name_Student_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.txtmaphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Name_Room = new Guna.UI2.WinForms.Guna2Button();
            this.txtmahopdong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeight = 60;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mahopdong,
            this.maphong,
            this.ten,
            this.ngaylap,
            this.ketthuc,
            this.tongtien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.dgv.HeaderForeColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(17, 146);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1839, 800);
            this.dgv.TabIndex = 42;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 80;
            // 
            // mahopdong
            // 
            this.mahopdong.DataPropertyName = "mahopdong";
            this.mahopdong.HeaderText = "Mã Hợp Đồng";
            this.mahopdong.MinimumWidth = 6;
            this.mahopdong.Name = "mahopdong";
            this.mahopdong.ReadOnly = true;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên Sinh Viên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày Lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // ketthuc
            // 
            this.ketthuc.DataPropertyName = "ketthuc";
            this.ketthuc.HeaderText = "Ngày Kết Thúc";
            this.ketthuc.MinimumWidth = 6;
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BorderRadius = 20;
            this.btn_Refresh.CheckedState.Parent = this.btn_Refresh;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.CustomImages.Parent = this.btn_Refresh;
            this.btn_Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoverState.Parent = this.btn_Refresh;
            this.btn_Refresh.Image = global::Dormitory_Management_2021.Properties.Resources.refresh_500px;
            this.btn_Refresh.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Refresh.Location = new System.Drawing.Point(1299, 16);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(275, 111);
            this.btn_Refresh.TabIndex = 48;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Dormitory_Management_2021.Properties.Resources.add_500px;
            this.btnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAdd.Location = new System.Drawing.Point(1581, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(275, 111);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Name_Student_Contract
            // 
            this.btn_Name_Student_Contract.AutoRoundedCorners = true;
            this.btn_Name_Student_Contract.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Name_Student_Contract.BorderRadius = 34;
            this.btn_Name_Student_Contract.CheckedState.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Name_Student_Contract.CustomImages.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Name_Student_Contract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Name_Student_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Name_Student_Contract.HoverState.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.Image = global::Dormitory_Management_2021.Properties.Resources.name_tag_500px;
            this.btn_Name_Student_Contract.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Name_Student_Contract.Location = new System.Drawing.Point(17, 16);
            this.btn_Name_Student_Contract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Name_Student_Contract.Name = "btn_Name_Student_Contract";
            this.btn_Name_Student_Contract.ShadowDecoration.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.Size = new System.Drawing.Size(271, 70);
            this.btn_Name_Student_Contract.TabIndex = 53;
            this.btn_Name_Student_Contract.Text = "Mã Hợp Đồng";
            this.btn_Name_Student_Contract.Click += new System.EventHandler(this.btn_Name_Student_Contract_Click);
            // 
            // txtmaphong
            // 
            this.txtmaphong.AutoRoundedCorners = true;
            this.txtmaphong.BorderRadius = 21;
            this.txtmaphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaphong.DefaultText = "";
            this.txtmaphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaphong.DisabledState.Parent = this.txtmaphong;
            this.txtmaphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaphong.FocusedState.Parent = this.txtmaphong;
            this.txtmaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphong.ForeColor = System.Drawing.Color.Black;
            this.txtmaphong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaphong.HoverState.Parent = this.txtmaphong;
            this.txtmaphong.Location = new System.Drawing.Point(347, 91);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.PasswordChar = '\0';
            this.txtmaphong.PlaceholderText = "A101";
            this.txtmaphong.SelectedText = "";
            this.txtmaphong.ShadowDecoration.Parent = this.txtmaphong;
            this.txtmaphong.Size = new System.Drawing.Size(271, 44);
            this.txtmaphong.TabIndex = 51;
            this.txtmaphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmaphong.TextChanged += new System.EventHandler(this.btn_Name_Room_Click);
            // 
            // btn_Name_Room
            // 
            this.btn_Name_Room.AutoRoundedCorners = true;
            this.btn_Name_Room.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Name_Room.BorderRadius = 34;
            this.btn_Name_Room.CheckedState.Parent = this.btn_Name_Room;
            this.btn_Name_Room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Name_Room.CustomImages.Parent = this.btn_Name_Room;
            this.btn_Name_Room.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Name_Room.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Name_Room.ForeColor = System.Drawing.Color.White;
            this.btn_Name_Room.HoverState.Parent = this.btn_Name_Room;
            this.btn_Name_Room.Image = global::Dormitory_Management_2021.Properties.Resources.hotel_room_key_500px;
            this.btn_Name_Room.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Name_Room.Location = new System.Drawing.Point(347, 16);
            this.btn_Name_Room.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Name_Room.Name = "btn_Name_Room";
            this.btn_Name_Room.ShadowDecoration.Parent = this.btn_Name_Room;
            this.btn_Name_Room.Size = new System.Drawing.Size(271, 70);
            this.btn_Name_Room.TabIndex = 50;
            this.btn_Name_Room.Text = "Mã Phòng";
            this.btn_Name_Room.Click += new System.EventHandler(this.btn_Name_Room_Click);
            // 
            // txtmahopdong
            // 
            this.txtmahopdong.AutoRoundedCorners = true;
            this.txtmahopdong.BorderRadius = 21;
            this.txtmahopdong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmahopdong.DefaultText = "";
            this.txtmahopdong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmahopdong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmahopdong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmahopdong.DisabledState.Parent = this.txtmahopdong;
            this.txtmahopdong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmahopdong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmahopdong.FocusedState.Parent = this.txtmahopdong;
            this.txtmahopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahopdong.ForeColor = System.Drawing.Color.Black;
            this.txtmahopdong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmahopdong.HoverState.Parent = this.txtmahopdong;
            this.txtmahopdong.Location = new System.Drawing.Point(17, 91);
            this.txtmahopdong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtmahopdong.Name = "txtmahopdong";
            this.txtmahopdong.PasswordChar = '\0';
            this.txtmahopdong.PlaceholderText = "dong";
            this.txtmahopdong.SelectedText = "";
            this.txtmahopdong.ShadowDecoration.Parent = this.txtmahopdong;
            this.txtmahopdong.Size = new System.Drawing.Size(271, 44);
            this.txtmahopdong.TabIndex = 54;
            this.txtmahopdong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmahopdong.TextChanged += new System.EventHandler(this.btn_Name_Student_Contract_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Excel.BorderRadius = 20;
            this.btn_Excel.CheckedState.Parent = this.btn_Excel;
            this.btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excel.CustomImages.Parent = this.btn_Excel;
            this.btn_Excel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btn_Excel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.HoverState.Parent = this.btn_Excel;
            this.btn_Excel.Image = global::Dormitory_Management_2021.Properties.Resources.microsoft_excel_500px;
            this.btn_Excel.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Excel.Location = new System.Drawing.Point(1581, 959);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(275, 91);
            this.btn_Excel.TabIndex = 58;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgv;
            // 
            // UCHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.txtmahopdong);
            this.Controls.Add(this.btn_Name_Student_Contract);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.btn_Name_Room);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCHopDong";
            this.Size = new System.Drawing.Size(1873, 1063);
            this.Load += new System.EventHandler(this.UC_HopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btn_Name_Student_Contract;
        private Guna.UI2.WinForms.Guna2TextBox txtmaphong;
        private Guna.UI2.WinForms.Guna2Button btn_Name_Room;
        private Guna.UI2.WinForms.Guna2TextBox txtmahopdong;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}
