
namespace Dormitory_Management_2021.GUI.Phong
{
    partial class SuaPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtsoluong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbbloaiphong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtmaphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_SoNguoiToiDa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttoanha = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_LoaiPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.btncapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtsoluong
            // 
            this.txtsoluong.AutoRoundedCorners = true;
            this.txtsoluong.BackColor = System.Drawing.Color.White;
            this.txtsoluong.BorderRadius = 33;
            this.txtsoluong.BorderThickness = 0;
            this.txtsoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoluong.DisabledState.Parent = this.txtsoluong;
            this.txtsoluong.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtsoluong.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtsoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoluong.FocusedState.Parent = this.txtsoluong;
            this.txtsoluong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.ForeColor = System.Drawing.Color.Black;
            this.txtsoluong.Location = new System.Drawing.Point(589, 139);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtsoluong.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.ShadowDecoration.Parent = this.txtsoluong;
            this.txtsoluong.Size = new System.Drawing.Size(311, 68);
            this.txtsoluong.TabIndex = 72;
            // 
            // cbbloaiphong
            // 
            this.cbbloaiphong.AutoRoundedCorners = true;
            this.cbbloaiphong.BackColor = System.Drawing.Color.White;
            this.cbbloaiphong.BorderRadius = 17;
            this.cbbloaiphong.BorderThickness = 0;
            this.cbbloaiphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbloaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbloaiphong.DropDownWidth = 236;
            this.cbbloaiphong.FocusedColor = System.Drawing.Color.Empty;
            this.cbbloaiphong.FocusedState.Parent = this.cbbloaiphong;
            this.cbbloaiphong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbloaiphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbloaiphong.FormattingEnabled = true;
            this.cbbloaiphong.HoverState.Parent = this.cbbloaiphong;
            this.cbbloaiphong.ItemHeight = 30;
            this.cbbloaiphong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbloaiphong.ItemsAppearance.Parent = this.cbbloaiphong;
            this.cbbloaiphong.Location = new System.Drawing.Point(589, 49);
            this.cbbloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbloaiphong.Name = "cbbloaiphong";
            this.cbbloaiphong.ShadowDecoration.Parent = this.cbbloaiphong;
            this.cbbloaiphong.Size = new System.Drawing.Size(325, 36);
            this.cbbloaiphong.TabIndex = 70;
            // 
            // txtmaphong
            // 
            this.txtmaphong.AutoRoundedCorners = true;
            this.txtmaphong.BorderRadius = 36;
            this.txtmaphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaphong.DefaultText = "";
            this.txtmaphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmaphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmaphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaphong.DisabledState.Parent = this.txtmaphong;
            this.txtmaphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmaphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaphong.FocusedState.Parent = this.txtmaphong;
            this.txtmaphong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaphong.ForeColor = System.Drawing.Color.Black;
            this.txtmaphong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmaphong.HoverState.Parent = this.txtmaphong;
            this.txtmaphong.IconLeft = global::Dormitory_Management_2021.Properties.Resources.hotel_room_key_500px;
            this.txtmaphong.IconLeftSize = new System.Drawing.Size(60, 60);
            this.txtmaphong.Location = new System.Drawing.Point(34, 137);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.PasswordChar = '\0';
            this.txtmaphong.PlaceholderText = "Tên phòng";
            this.txtmaphong.SelectedText = "";
            this.txtmaphong.ShadowDecoration.Parent = this.txtmaphong;
            this.txtmaphong.Size = new System.Drawing.Size(427, 74);
            this.txtmaphong.TabIndex = 69;
            // 
            // tb_SoNguoiToiDa
            // 
            this.tb_SoNguoiToiDa.AutoRoundedCorners = true;
            this.tb_SoNguoiToiDa.BorderRadius = 36;
            this.tb_SoNguoiToiDa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SoNguoiToiDa.DefaultText = "";
            this.tb_SoNguoiToiDa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_SoNguoiToiDa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_SoNguoiToiDa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SoNguoiToiDa.DisabledState.Parent = this.tb_SoNguoiToiDa;
            this.tb_SoNguoiToiDa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_SoNguoiToiDa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SoNguoiToiDa.FocusedState.Parent = this.tb_SoNguoiToiDa;
            this.tb_SoNguoiToiDa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoNguoiToiDa.ForeColor = System.Drawing.Color.Black;
            this.tb_SoNguoiToiDa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_SoNguoiToiDa.HoverState.Parent = this.tb_SoNguoiToiDa;
            this.tb_SoNguoiToiDa.IconLeft = global::Dormitory_Management_2021.Properties.Resources.family_500px;
            this.tb_SoNguoiToiDa.IconLeftSize = new System.Drawing.Size(60, 60);
            this.tb_SoNguoiToiDa.Location = new System.Drawing.Point(501, 137);
            this.tb_SoNguoiToiDa.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tb_SoNguoiToiDa.Name = "tb_SoNguoiToiDa";
            this.tb_SoNguoiToiDa.PasswordChar = '\0';
            this.tb_SoNguoiToiDa.PlaceholderText = "Số người tối đa";
            this.tb_SoNguoiToiDa.SelectedText = "";
            this.tb_SoNguoiToiDa.ShadowDecoration.Parent = this.tb_SoNguoiToiDa;
            this.tb_SoNguoiToiDa.Size = new System.Drawing.Size(427, 74);
            this.tb_SoNguoiToiDa.TabIndex = 68;
            // 
            // txttoanha
            // 
            this.txttoanha.AutoRoundedCorners = true;
            this.txttoanha.BorderRadius = 36;
            this.txttoanha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttoanha.DefaultText = "";
            this.txttoanha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttoanha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttoanha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttoanha.DisabledState.Parent = this.txttoanha;
            this.txttoanha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttoanha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttoanha.FocusedState.Parent = this.txttoanha;
            this.txttoanha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoanha.ForeColor = System.Drawing.Color.Black;
            this.txttoanha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttoanha.HoverState.Parent = this.txttoanha;
            this.txttoanha.IconLeft = global::Dormitory_Management_2021.Properties.Resources.building_500px;
            this.txttoanha.IconLeftSize = new System.Drawing.Size(60, 60);
            this.txttoanha.Location = new System.Drawing.Point(34, 33);
            this.txttoanha.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txttoanha.Name = "txttoanha";
            this.txttoanha.PasswordChar = '\0';
            this.txttoanha.PlaceholderText = "Toà nhà";
            this.txttoanha.SelectedText = "";
            this.txttoanha.ShadowDecoration.Parent = this.txttoanha;
            this.txttoanha.Size = new System.Drawing.Size(427, 74);
            this.txttoanha.TabIndex = 67;
            // 
            // tb_LoaiPhong
            // 
            this.tb_LoaiPhong.AutoRoundedCorners = true;
            this.tb_LoaiPhong.BorderRadius = 36;
            this.tb_LoaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_LoaiPhong.DefaultText = "";
            this.tb_LoaiPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_LoaiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_LoaiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_LoaiPhong.DisabledState.Parent = this.tb_LoaiPhong;
            this.tb_LoaiPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_LoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_LoaiPhong.FocusedState.Parent = this.tb_LoaiPhong;
            this.tb_LoaiPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.tb_LoaiPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_LoaiPhong.HoverState.Parent = this.tb_LoaiPhong;
            this.tb_LoaiPhong.IconLeft = global::Dormitory_Management_2021.Properties.Resources.hotel_bed_500px;
            this.tb_LoaiPhong.IconLeftSize = new System.Drawing.Size(60, 60);
            this.tb_LoaiPhong.Location = new System.Drawing.Point(501, 33);
            this.tb_LoaiPhong.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.tb_LoaiPhong.Name = "tb_LoaiPhong";
            this.tb_LoaiPhong.PasswordChar = '\0';
            this.tb_LoaiPhong.PlaceholderText = "Tên phòng";
            this.tb_LoaiPhong.SelectedText = "";
            this.tb_LoaiPhong.ShadowDecoration.Parent = this.tb_LoaiPhong;
            this.tb_LoaiPhong.Size = new System.Drawing.Size(427, 74);
            this.tb_LoaiPhong.TabIndex = 71;
            // 
            // Refresh
            // 
            this.Refresh.AutoRoundedCorners = true;
            this.Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.Refresh.BorderRadius = 36;
            this.Refresh.CheckedState.Parent = this.Refresh;
            this.Refresh.CustomImages.Parent = this.Refresh;
            this.Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.HoverState.Parent = this.Refresh;
            this.Refresh.Image = global::Dormitory_Management_2021.Properties.Resources.restart_500px;
            this.Refresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Refresh.ImageSize = new System.Drawing.Size(60, 60);
            this.Refresh.Location = new System.Drawing.Point(658, 386);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh.Name = "Refresh";
            this.Refresh.ShadowDecoration.Parent = this.Refresh;
            this.Refresh.Size = new System.Drawing.Size(270, 74);
            this.Refresh.TabIndex = 308;
            this.Refresh.Text = "Làm mới";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnthem
            // 
            this.btnthem.AutoRoundedCorners = true;
            this.btnthem.BorderColor = System.Drawing.Color.Transparent;
            this.btnthem.BorderRadius = 36;
            this.btnthem.CheckedState.Parent = this.btnthem;
            this.btnthem.CustomImages.Parent = this.btnthem;
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.HoverState.Parent = this.btnthem;
            this.btnthem.Image = global::Dormitory_Management_2021.Properties.Resources.restart_500px;
            this.btnthem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnthem.ImageSize = new System.Drawing.Size(60, 60);
            this.btnthem.Location = new System.Drawing.Point(34, 270);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.ShadowDecoration.Parent = this.btnthem;
            this.btnthem.Size = new System.Drawing.Size(270, 74);
            this.btnthem.TabIndex = 307;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnback
            // 
            this.btnback.AutoRoundedCorners = true;
            this.btnback.BorderColor = System.Drawing.Color.Transparent;
            this.btnback.BorderRadius = 36;
            this.btnback.CheckedState.Parent = this.btnback;
            this.btnback.CustomImages.Parent = this.btnback;
            this.btnback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.HoverState.Parent = this.btnback;
            this.btnback.Image = global::Dormitory_Management_2021.Properties.Resources.back_500px;
            this.btnback.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnback.ImageSize = new System.Drawing.Size(60, 60);
            this.btnback.Location = new System.Drawing.Point(34, 386);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Parent = this.btnback;
            this.btnback.Size = new System.Drawing.Size(270, 74);
            this.btnback.TabIndex = 306;
            this.btnback.Text = "Trở lại";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.AutoRoundedCorners = true;
            this.btncapnhat.BorderColor = System.Drawing.Color.Transparent;
            this.btncapnhat.BorderRadius = 36;
            this.btncapnhat.CheckedState.Parent = this.btncapnhat;
            this.btncapnhat.CustomImages.Parent = this.btncapnhat;
            this.btncapnhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncapnhat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.ForeColor = System.Drawing.Color.White;
            this.btncapnhat.HoverState.Parent = this.btncapnhat;
            this.btncapnhat.Image = global::Dormitory_Management_2021.Properties.Resources.restart_500px;
            this.btncapnhat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncapnhat.ImageSize = new System.Drawing.Size(60, 60);
            this.btncapnhat.Location = new System.Drawing.Point(332, 270);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ShadowDecoration.Parent = this.btncapnhat;
            this.btncapnhat.Size = new System.Drawing.Size(297, 74);
            this.btncapnhat.TabIndex = 305;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AutoRoundedCorners = true;
            this.btnxoa.BorderColor = System.Drawing.Color.Transparent;
            this.btnxoa.BorderRadius = 36;
            this.btnxoa.CheckedState.Parent = this.btnxoa;
            this.btnxoa.CustomImages.Parent = this.btnxoa;
            this.btnxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.HoverState.Parent = this.btnxoa;
            this.btnxoa.Image = global::Dormitory_Management_2021.Properties.Resources.delete_500px;
            this.btnxoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnxoa.ImageSize = new System.Drawing.Size(60, 60);
            this.btnxoa.Location = new System.Drawing.Point(658, 270);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ShadowDecoration.Parent = this.btnxoa;
            this.btnxoa.Size = new System.Drawing.Size(270, 74);
            this.btnxoa.TabIndex = 304;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // SuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(975, 738);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.cbbloaiphong);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.tb_SoNguoiToiDa);
            this.Controls.Add(this.txttoanha);
            this.Controls.Add(this.tb_LoaiPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuaPhong";
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtsoluong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbloaiphong;
        private Guna.UI2.WinForms.Guna2TextBox txtmaphong;
        private Guna.UI2.WinForms.Guna2TextBox tb_SoNguoiToiDa;
        private Guna.UI2.WinForms.Guna2TextBox txttoanha;
        private Guna.UI2.WinForms.Guna2TextBox tb_LoaiPhong;
        private Guna.UI2.WinForms.Guna2Button Refresh;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2Button btncapnhat;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
    }
}