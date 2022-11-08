
namespace Dormitory_Management_2021.GUI.Phong
{
    partial class UCPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tbTimTenPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbToaNha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLayPhongTheoToaNha = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimTenPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoaiPhong = new Guna.UI2.WinForms.Guna2Button();
            this.cbLoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTinhTrang = new Guna.UI2.WinForms.Guna2Button();
            this.cbTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toanha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 60;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.toanha,
            this.maphong,
            this.loaiphong,
            this.soluong,
            this.tinhtrang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1839, 800);
            this.dgv.TabIndex = 33;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_Phong_DoubleClick);
            // 
            // tbTimTenPhong
            // 
            this.tbTimTenPhong.AutoRoundedCorners = true;
            this.tbTimTenPhong.BorderRadius = 21;
            this.tbTimTenPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTimTenPhong.DefaultText = "";
            this.tbTimTenPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTimTenPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTimTenPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimTenPhong.DisabledState.Parent = this.tbTimTenPhong;
            this.tbTimTenPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTimTenPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimTenPhong.FocusedState.Parent = this.tbTimTenPhong;
            this.tbTimTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimTenPhong.ForeColor = System.Drawing.Color.Black;
            this.tbTimTenPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTimTenPhong.HoverState.Parent = this.tbTimTenPhong;
            this.tbTimTenPhong.Location = new System.Drawing.Point(347, 91);
            this.tbTimTenPhong.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbTimTenPhong.Name = "tbTimTenPhong";
            this.tbTimTenPhong.PasswordChar = '\0';
            this.tbTimTenPhong.PlaceholderText = "A101";
            this.tbTimTenPhong.SelectedText = "";
            this.tbTimTenPhong.ShadowDecoration.Parent = this.tbTimTenPhong;
            this.tbTimTenPhong.Size = new System.Drawing.Size(271, 44);
            this.tbTimTenPhong.TabIndex = 46;
            this.tbTimTenPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTimTenPhong.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbToaNha
            // 
            this.cbToaNha.AutoRoundedCorners = true;
            this.cbToaNha.BackColor = System.Drawing.Color.Transparent;
            this.cbToaNha.BorderRadius = 17;
            this.cbToaNha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToaNha.FocusedColor = System.Drawing.Color.Empty;
            this.cbToaNha.FocusedState.Parent = this.cbToaNha;
            this.cbToaNha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbToaNha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbToaNha.FormattingEnabled = true;
            this.cbToaNha.HoverState.Parent = this.cbToaNha;
            this.cbToaNha.ItemHeight = 30;
            this.cbToaNha.ItemsAppearance.Parent = this.cbToaNha;
            this.cbToaNha.Location = new System.Drawing.Point(17, 91);
            this.cbToaNha.Margin = new System.Windows.Forms.Padding(4);
            this.cbToaNha.Name = "cbToaNha";
            this.cbToaNha.ShadowDecoration.Parent = this.cbToaNha;
            this.cbToaNha.Size = new System.Drawing.Size(269, 36);
            this.cbToaNha.TabIndex = 48;
            // 
            // btnLayPhongTheoToaNha
            // 
            this.btnLayPhongTheoToaNha.AutoRoundedCorners = true;
            this.btnLayPhongTheoToaNha.BorderColor = System.Drawing.Color.Transparent;
            this.btnLayPhongTheoToaNha.BorderRadius = 34;
            this.btnLayPhongTheoToaNha.CheckedState.Parent = this.btnLayPhongTheoToaNha;
            this.btnLayPhongTheoToaNha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLayPhongTheoToaNha.CustomImages.Parent = this.btnLayPhongTheoToaNha;
            this.btnLayPhongTheoToaNha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLayPhongTheoToaNha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayPhongTheoToaNha.ForeColor = System.Drawing.Color.White;
            this.btnLayPhongTheoToaNha.HoverState.Parent = this.btnLayPhongTheoToaNha;
            this.btnLayPhongTheoToaNha.Image = global::Dormitory_Management_2021.Properties.Resources.building_500px;
            this.btnLayPhongTheoToaNha.ImageSize = new System.Drawing.Size(60, 60);
            this.btnLayPhongTheoToaNha.Location = new System.Drawing.Point(17, 16);
            this.btnLayPhongTheoToaNha.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayPhongTheoToaNha.Name = "btnLayPhongTheoToaNha";
            this.btnLayPhongTheoToaNha.ShadowDecoration.Parent = this.btnLayPhongTheoToaNha;
            this.btnLayPhongTheoToaNha.Size = new System.Drawing.Size(271, 70);
            this.btnLayPhongTheoToaNha.TabIndex = 49;
            this.btnLayPhongTheoToaNha.Text = "Toà Nhà";
            this.btnLayPhongTheoToaNha.Click += new System.EventHandler(this.btnLayPhongTheoToaNha_Click);
            // 
            // btnTimTenPhong
            // 
            this.btnTimTenPhong.AutoRoundedCorners = true;
            this.btnTimTenPhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimTenPhong.BorderRadius = 34;
            this.btnTimTenPhong.CheckedState.Parent = this.btnTimTenPhong;
            this.btnTimTenPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimTenPhong.CustomImages.Parent = this.btnTimTenPhong;
            this.btnTimTenPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnTimTenPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTimTenPhong.ForeColor = System.Drawing.Color.White;
            this.btnTimTenPhong.HoverState.Parent = this.btnTimTenPhong;
            this.btnTimTenPhong.Image = global::Dormitory_Management_2021.Properties.Resources.hotel_room_key_500px;
            this.btnTimTenPhong.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTimTenPhong.Location = new System.Drawing.Point(347, 16);
            this.btnTimTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimTenPhong.Name = "btnTimTenPhong";
            this.btnTimTenPhong.ShadowDecoration.Parent = this.btnTimTenPhong;
            this.btnTimTenPhong.Size = new System.Drawing.Size(271, 70);
            this.btnTimTenPhong.TabIndex = 45;
            this.btnTimTenPhong.Text = "Mã Phòng";
            this.btnTimTenPhong.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(1300, 16);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(275, 119);
            this.btnRefresh.TabIndex = 44;
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
            this.btnAdd.Location = new System.Drawing.Point(1583, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(275, 119);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.AutoRoundedCorners = true;
            this.btnLoaiPhong.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoaiPhong.BorderRadius = 34;
            this.btnLoaiPhong.CheckedState.Parent = this.btnLoaiPhong;
            this.btnLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiPhong.CustomImages.Parent = this.btnLoaiPhong;
            this.btnLoaiPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.btnLoaiPhong.HoverState.Parent = this.btnLoaiPhong;
            this.btnLoaiPhong.Image = global::Dormitory_Management_2021.Properties.Resources.hotel_bed_500px;
            this.btnLoaiPhong.ImageSize = new System.Drawing.Size(60, 60);
            this.btnLoaiPhong.Location = new System.Drawing.Point(676, 16);
            this.btnLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.ShadowDecoration.Parent = this.btnLoaiPhong;
            this.btnLoaiPhong.Size = new System.Drawing.Size(271, 70);
            this.btnLoaiPhong.TabIndex = 51;
            this.btnLoaiPhong.Text = "Loại Phòng";
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.AutoRoundedCorners = true;
            this.cbLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiPhong.BorderRadius = 17;
            this.cbLoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoaiPhong.FocusedState.Parent = this.cbLoaiPhong;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.HoverState.Parent = this.cbLoaiPhong;
            this.cbLoaiPhong.ItemHeight = 30;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbLoaiPhong.ItemsAppearance.Parent = this.cbLoaiPhong;
            this.cbLoaiPhong.Location = new System.Drawing.Point(676, 91);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.ShadowDecoration.Parent = this.cbLoaiPhong;
            this.cbLoaiPhong.Size = new System.Drawing.Size(269, 36);
            this.cbLoaiPhong.TabIndex = 50;
            // 
            // btnTinhTrang
            // 
            this.btnTinhTrang.AutoRoundedCorners = true;
            this.btnTinhTrang.BorderColor = System.Drawing.Color.Transparent;
            this.btnTinhTrang.BorderRadius = 34;
            this.btnTinhTrang.CheckedState.Parent = this.btnTinhTrang;
            this.btnTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTrang.CustomImages.Parent = this.btnTinhTrang;
            this.btnTinhTrang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnTinhTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTrang.ForeColor = System.Drawing.Color.White;
            this.btnTinhTrang.HoverState.Parent = this.btnTinhTrang;
            this.btnTinhTrang.Image = global::Dormitory_Management_2021.Properties.Resources.family_500px;
            this.btnTinhTrang.ImageSize = new System.Drawing.Size(60, 60);
            this.btnTinhTrang.Location = new System.Drawing.Point(1005, 16);
            this.btnTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhTrang.Name = "btnTinhTrang";
            this.btnTinhTrang.ShadowDecoration.Parent = this.btnTinhTrang;
            this.btnTinhTrang.Size = new System.Drawing.Size(271, 70);
            this.btnTinhTrang.TabIndex = 53;
            this.btnTinhTrang.Text = "Tình Trạng";
            this.btnTinhTrang.Click += new System.EventHandler(this.btnTinhTrang_Click);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.AutoRoundedCorners = true;
            this.cbTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cbTinhTrang.BorderRadius = 17;
            this.cbTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.FocusedColor = System.Drawing.Color.Empty;
            this.cbTinhTrang.FocusedState.Parent = this.cbTinhTrang;
            this.cbTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.HoverState.Parent = this.cbTinhTrang;
            this.cbTinhTrang.ItemHeight = 30;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Trống",
            "Còn chỗ",
            "Đầy"});
            this.cbTinhTrang.ItemsAppearance.Parent = this.cbTinhTrang;
            this.cbTinhTrang.Location = new System.Drawing.Point(1005, 91);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.ShadowDecoration.Parent = this.cbTinhTrang;
            this.cbTinhTrang.Size = new System.Drawing.Size(269, 36);
            this.cbTinhTrang.TabIndex = 52;
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
            this.btn_Excel.Location = new System.Drawing.Point(1583, 960);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(275, 91);
            this.btn_Excel.TabIndex = 58;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 81;
            // 
            // toanha
            // 
            this.toanha.DataPropertyName = "toanha";
            this.toanha.FillWeight = 19.51219F;
            this.toanha.HeaderText = "Tòa Nhà";
            this.toanha.MinimumWidth = 6;
            this.toanha.Name = "toanha";
            this.toanha.ReadOnly = true;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.FillWeight = 19.51219F;
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.FillWeight = 19.51219F;
            this.loaiphong.HeaderText = "Loại Phòng";
            this.loaiphong.MinimumWidth = 6;
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.FillWeight = 19.51219F;
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình Trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.ReadOnly = true;
            // 
            // UCPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btnTinhTrang);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.btnLoaiPhong);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.btnLayPhongTheoToaNha);
            this.Controls.Add(this.cbToaNha);
            this.Controls.Add(this.tbTimTenPhong);
            this.Controls.Add(this.btnTimTenPhong);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPhong";
            this.Size = new System.Drawing.Size(1873, 1063);
            this.Load += new System.EventHandler(this.UC_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Guna.UI2.WinForms.Guna2TextBox tbTimTenPhong;
        private Guna.UI2.WinForms.Guna2Button btnTimTenPhong;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbToaNha;
        private Guna.UI2.WinForms.Guna2Button btnLayPhongTheoToaNha;
        private Guna.UI2.WinForms.Guna2Button btnLoaiPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiPhong;
        private Guna.UI2.WinForms.Guna2Button btnTinhTrang;
        private Guna.UI2.WinForms.Guna2ComboBox cbTinhTrang;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn toanha;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
    }
}
