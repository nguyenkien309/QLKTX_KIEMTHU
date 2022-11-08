
namespace Dormitory_Management_2021.GUI.HoaDon
{
    partial class UCHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtmaphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbtrangthai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datetimepickerX = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Status_Bill = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Month_Bill = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Name_Room = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv.ColumnHeadersHeight = 60;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mahd,
            this.maphong,
            this.sonuoc,
            this.sodien,
            this.ngaylap,
            this.trangthai,
            this.tongtien});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1839, 800);
            this.dgv.TabIndex = 34;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
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
            this.txtmaphong.Location = new System.Drawing.Point(17, 91);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.PasswordChar = '\0';
            this.txtmaphong.PlaceholderText = "A101";
            this.txtmaphong.SelectedText = "";
            this.txtmaphong.ShadowDecoration.Parent = this.txtmaphong;
            this.txtmaphong.Size = new System.Drawing.Size(271, 44);
            this.txtmaphong.TabIndex = 53;
            this.txtmaphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmaphong.TextChanged += new System.EventHandler(this.btn_Name_Room_Click);
            // 
            // cbbtrangthai
            // 
            this.cbbtrangthai.AutoRoundedCorners = true;
            this.cbbtrangthai.BackColor = System.Drawing.Color.Transparent;
            this.cbbtrangthai.BorderRadius = 17;
            this.cbbtrangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbtrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtrangthai.FocusedColor = System.Drawing.Color.Empty;
            this.cbbtrangthai.FocusedState.Parent = this.cbbtrangthai;
            this.cbbtrangthai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbtrangthai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbtrangthai.FormattingEnabled = true;
            this.cbbtrangthai.HoverState.Parent = this.cbbtrangthai;
            this.cbbtrangthai.ItemHeight = 30;
            this.cbbtrangthai.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cbbtrangthai.ItemsAppearance.Parent = this.cbbtrangthai;
            this.cbbtrangthai.Location = new System.Drawing.Point(701, 91);
            this.cbbtrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtrangthai.Name = "cbbtrangthai";
            this.cbbtrangthai.ShadowDecoration.Parent = this.cbbtrangthai;
            this.cbbtrangthai.Size = new System.Drawing.Size(269, 36);
            this.cbbtrangthai.TabIndex = 54;
            this.cbbtrangthai.SelectedIndexChanged += new System.EventHandler(this.cb_Status_Bill_SelectedIndexChanged);
            // 
            // datetimepickerX
            // 
            this.datetimepickerX.AutoRoundedCorners = true;
            this.datetimepickerX.BorderRadius = 21;
            this.datetimepickerX.CheckedState.Parent = this.datetimepickerX;
            this.datetimepickerX.CustomFormat = "dd/MM/yyyy";
            this.datetimepickerX.FillColor = System.Drawing.Color.White;
            this.datetimepickerX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerX.HoverState.Parent = this.datetimepickerX;
            this.datetimepickerX.Location = new System.Drawing.Point(347, 91);
            this.datetimepickerX.Margin = new System.Windows.Forms.Padding(4);
            this.datetimepickerX.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepickerX.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepickerX.Name = "datetimepickerX";
            this.datetimepickerX.ShadowDecoration.Parent = this.datetimepickerX;
            this.datetimepickerX.Size = new System.Drawing.Size(271, 44);
            this.datetimepickerX.TabIndex = 56;
            this.datetimepickerX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datetimepickerX.Value = new System.DateTime(2021, 10, 16, 20, 34, 4, 437);
            this.datetimepickerX.ValueChanged += new System.EventHandler(this.dtp_Month_Bill_ValueChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgv;
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
            this.btn_Excel.Location = new System.Drawing.Point(1581, 960);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(275, 91);
            this.btn_Excel.TabIndex = 57;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Status_Bill
            // 
            this.btn_Status_Bill.AutoRoundedCorners = true;
            this.btn_Status_Bill.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Status_Bill.BorderRadius = 34;
            this.btn_Status_Bill.CheckedState.Parent = this.btn_Status_Bill;
            this.btn_Status_Bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Status_Bill.CustomImages.Parent = this.btn_Status_Bill;
            this.btn_Status_Bill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Status_Bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Status_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Status_Bill.HoverState.Parent = this.btn_Status_Bill;
            this.btn_Status_Bill.Image = global::Dormitory_Management_2021.Properties.Resources.hotel_bed_500px;
            this.btn_Status_Bill.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Status_Bill.Location = new System.Drawing.Point(701, 16);
            this.btn_Status_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Status_Bill.Name = "btn_Status_Bill";
            this.btn_Status_Bill.ShadowDecoration.Parent = this.btn_Status_Bill;
            this.btn_Status_Bill.Size = new System.Drawing.Size(271, 70);
            this.btn_Status_Bill.TabIndex = 55;
            this.btn_Status_Bill.Text = "Trạng Thái";
            this.btn_Status_Bill.Click += new System.EventHandler(this.btn_Status_Bill_Click);
            // 
            // btn_Month_Bill
            // 
            this.btn_Month_Bill.AutoRoundedCorners = true;
            this.btn_Month_Bill.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Month_Bill.BorderRadius = 34;
            this.btn_Month_Bill.CheckedState.Parent = this.btn_Month_Bill;
            this.btn_Month_Bill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Month_Bill.CustomImages.Parent = this.btn_Month_Bill;
            this.btn_Month_Bill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Month_Bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Month_Bill.ForeColor = System.Drawing.Color.White;
            this.btn_Month_Bill.HoverState.Parent = this.btn_Month_Bill;
            this.btn_Month_Bill.Image = global::Dormitory_Management_2021.Properties.Resources.hotel_bed_500px;
            this.btn_Month_Bill.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Month_Bill.Location = new System.Drawing.Point(347, 16);
            this.btn_Month_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Month_Bill.Name = "btn_Month_Bill";
            this.btn_Month_Bill.ShadowDecoration.Parent = this.btn_Month_Bill;
            this.btn_Month_Bill.Size = new System.Drawing.Size(271, 70);
            this.btn_Month_Bill.TabIndex = 55;
            this.btn_Month_Bill.Text = "Tháng";
            this.btn_Month_Bill.Click += new System.EventHandler(this.btn_Month_Bill_Click);
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
            this.btn_Name_Room.Location = new System.Drawing.Point(17, 16);
            this.btn_Name_Room.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Name_Room.Name = "btn_Name_Room";
            this.btn_Name_Room.ShadowDecoration.Parent = this.btn_Name_Room;
            this.btn_Name_Room.Size = new System.Drawing.Size(271, 70);
            this.btn_Name_Room.TabIndex = 52;
            this.btn_Name_Room.Text = "Mã Phòng";
            this.btn_Name_Room.Click += new System.EventHandler(this.btn_Name_Room_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::Dormitory_Management_2021.Properties.Resources.refresh_500px;
            this.btnRefresh.ImageSize = new System.Drawing.Size(60, 60);
            this.btnRefresh.Location = new System.Drawing.Point(1299, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(275, 119);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.btnAdd.Size = new System.Drawing.Size(275, 119);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 65;
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            // 
            // sonuoc
            // 
            this.sonuoc.DataPropertyName = "sonuoc";
            this.sonuoc.HeaderText = "Số Nước";
            this.sonuoc.MinimumWidth = 6;
            this.sonuoc.Name = "sonuoc";
            this.sonuoc.ReadOnly = true;
            // 
            // sodien
            // 
            this.sodien.DataPropertyName = "sodien";
            this.sodien.HeaderText = "Số Điện";
            this.sodien.MinimumWidth = 6;
            this.sodien.Name = "sodien";
            this.sodien.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày Lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // UCHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.datetimepickerX);
            this.Controls.Add(this.btn_Status_Bill);
            this.Controls.Add(this.cbbtrangthai);
            this.Controls.Add(this.btn_Month_Bill);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.btn_Name_Room);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCHoaDon";
            this.Size = new System.Drawing.Size(1873, 1063);
            this.Load += new System.EventHandler(this.UCHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btn_Month_Bill;
        private Guna.UI2.WinForms.Guna2TextBox txtmaphong;
        private Guna.UI2.WinForms.Guna2Button btn_Name_Room;
        private Guna.UI2.WinForms.Guna2ComboBox cbbtrangthai;
        private Guna.UI2.WinForms.Guna2Button btn_Status_Bill;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepickerX;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}
