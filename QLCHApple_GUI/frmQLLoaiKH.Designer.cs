namespace QLCHApple_GUI
{
    partial class frmQLLoaiKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLoaiKH));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaLoaiKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLoaiKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiKH = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLuuLoaiKH = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gcDSLoaiKH = new DevExpress.XtraGrid.GridControl();
            this.gvDSLoaiKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanTramGG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpTTLoaiNV = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhanTramGG = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaiKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLoaiKH = new DevExpress.XtraEditors.TextEdit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLoaiKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLoaiKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiNV)).BeginInit();
            this.grpTTLoaiNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhanTramGG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 39);
            this.panel2.TabIndex = 11;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblRefresh.Appearance.Image = global::QLCHApple_GUI.Properties.Resources.refresh;
            this.lblRefresh.Appearance.Options.UseBorderColor = true;
            this.lblRefresh.Appearance.Options.UseImage = true;
            this.lblRefresh.AppearanceHovered.Image = global::QLCHApple_GUI.Properties.Resources.refresh___hover;
            this.lblRefresh.AppearanceHovered.Options.UseImage = true;
            this.lblRefresh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRefresh.Location = new System.Drawing.Point(839, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 18;
            this.lblRefresh.ToolTip = "Làm mới";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblQuayLai
            // 
            this.lblQuayLai.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuayLai.Appearance.Image = global::QLCHApple_GUI.Properties.Resources.icons8_Back_32px;
            this.lblQuayLai.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuayLai.Appearance.Options.UseFont = true;
            this.lblQuayLai.Appearance.Options.UseImage = true;
            this.lblQuayLai.Appearance.Options.UseImageAlign = true;
            this.lblQuayLai.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.lblQuayLai.AppearanceHovered.Options.UseBackColor = true;
            this.lblQuayLai.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQuayLai.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblQuayLai.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuayLai.Location = new System.Drawing.Point(0, 0);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(180, 39);
            this.lblQuayLai.TabIndex = 0;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btnXoaLoaiKH);
            this.panel1.Controls.Add(this.btnSuaLoaiKH);
            this.panel1.Controls.Add(this.btnThemLoaiKH);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 465);
            this.panel1.TabIndex = 12;
            // 
            // btnXoaLoaiKH
            // 
            this.btnXoaLoaiKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLoaiKH.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaLoaiKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaLoaiKH.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiKH.Appearance.Options.UseBackColor = true;
            this.btnXoaLoaiKH.Appearance.Options.UseFont = true;
            this.btnXoaLoaiKH.Appearance.Options.UseForeColor = true;
            this.btnXoaLoaiKH.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaLoaiKH.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaLoaiKH.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaLoaiKH.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaLoaiKH.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoaLoaiKH.AppearanceHovered.Options.UseFont = true;
            this.btnXoaLoaiKH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaLoaiKH.Location = new System.Drawing.Point(0, 300);
            this.btnXoaLoaiKH.Name = "btnXoaLoaiKH";
            this.btnXoaLoaiKH.Size = new System.Drawing.Size(180, 55);
            this.btnXoaLoaiKH.TabIndex = 22;
            this.btnXoaLoaiKH.TabStop = false;
            this.btnXoaLoaiKH.Text = "Xóa";
            this.btnXoaLoaiKH.Click += new System.EventHandler(this.btnXoaLoaiKH_Click);
            // 
            // btnSuaLoaiKH
            // 
            this.btnSuaLoaiKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaLoaiKH.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLoaiKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiKH.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSuaLoaiKH.Appearance.Options.UseBackColor = true;
            this.btnSuaLoaiKH.Appearance.Options.UseFont = true;
            this.btnSuaLoaiKH.Appearance.Options.UseForeColor = true;
            this.btnSuaLoaiKH.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLoaiKH.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLoaiKH.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiKH.AppearanceHovered.Options.UseBackColor = true;
            this.btnSuaLoaiKH.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSuaLoaiKH.AppearanceHovered.Options.UseFont = true;
            this.btnSuaLoaiKH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaLoaiKH.Location = new System.Drawing.Point(0, 376);
            this.btnSuaLoaiKH.Name = "btnSuaLoaiKH";
            this.btnSuaLoaiKH.Size = new System.Drawing.Size(180, 55);
            this.btnSuaLoaiKH.TabIndex = 21;
            this.btnSuaLoaiKH.TabStop = false;
            this.btnSuaLoaiKH.Text = "Sửa";
            this.btnSuaLoaiKH.Click += new System.EventHandler(this.btnSuaLoaiKH_Click);
            // 
            // btnThemLoaiKH
            // 
            this.btnThemLoaiKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLoaiKH.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThemLoaiKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiKH.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiKH.Appearance.Options.UseBackColor = true;
            this.btnThemLoaiKH.Appearance.Options.UseFont = true;
            this.btnThemLoaiKH.Appearance.Options.UseForeColor = true;
            this.btnThemLoaiKH.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemLoaiKH.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemLoaiKH.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiKH.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemLoaiKH.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThemLoaiKH.AppearanceHovered.Options.UseFont = true;
            this.btnThemLoaiKH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemLoaiKH.Location = new System.Drawing.Point(0, 229);
            this.btnThemLoaiKH.Name = "btnThemLoaiKH";
            this.btnThemLoaiKH.Size = new System.Drawing.Size(180, 55);
            this.btnThemLoaiKH.TabIndex = 20;
            this.btnThemLoaiKH.TabStop = false;
            this.btnThemLoaiKH.Text = "Thêm";
            this.btnThemLoaiKH.Click += new System.EventHandler(this.btnThemLoaiKH_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblHienThi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHienThi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHienThi.Appearance.Options.UseBackColor = true;
            this.lblHienThi.Appearance.Options.UseFont = true;
            this.lblHienThi.Appearance.Options.UseForeColor = true;
            this.lblHienThi.Appearance.Options.UseTextOptions = true;
            this.lblHienThi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHienThi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblHienThi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHienThi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHienThi.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblHienThi.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblHienThi.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblHienThi.LineVisible = true;
            this.lblHienThi.Location = new System.Drawing.Point(12, 156);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(157, 57);
            this.lblHienThi.TabIndex = 16;
            this.lblHienThi.Text = "Quản Lý \r\nLoại Khách Hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCHApple_GUI.Properties.Resources.collaborator_100;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnLuuLoaiKH
            // 
            this.btnLuuLoaiKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuLoaiKH.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnLuuLoaiKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLoaiKH.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuuLoaiKH.Appearance.Options.UseBackColor = true;
            this.btnLuuLoaiKH.Appearance.Options.UseFont = true;
            this.btnLuuLoaiKH.Appearance.Options.UseForeColor = true;
            this.btnLuuLoaiKH.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuLoaiKH.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuLoaiKH.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLoaiKH.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuuLoaiKH.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLuuLoaiKH.AppearanceHovered.Options.UseFont = true;
            this.btnLuuLoaiKH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuuLoaiKH.Location = new System.Drawing.Point(391, 87);
            this.btnLuuLoaiKH.Name = "btnLuuLoaiKH";
            this.btnLuuLoaiKH.Size = new System.Drawing.Size(150, 45);
            this.btnLuuLoaiKH.TabIndex = 23;
            this.btnLuuLoaiKH.TabStop = false;
            this.btnLuuLoaiKH.Text = "Lưu";
            this.btnLuuLoaiKH.Click += new System.EventHandler(this.btnLuuLoaiNV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gcDSLoaiKH);
            this.panel3.Controls.Add(this.grpTTLoaiNV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 465);
            this.panel3.TabIndex = 13;
            // 
            // gcDSLoaiKH
            // 
            this.gcDSLoaiKH.Location = new System.Drawing.Point(9, 156);
            this.gcDSLoaiKH.MainView = this.gvDSLoaiKH;
            this.gcDSLoaiKH.Name = "gcDSLoaiKH";
            this.gcDSLoaiKH.Size = new System.Drawing.Size(715, 306);
            this.gcDSLoaiKH.TabIndex = 1;
            this.gcDSLoaiKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLoaiKH});
            // 
            // gvDSLoaiKH
            // 
            this.gvDSLoaiKH.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.Empty.Options.UseFont = true;
            this.gvDSLoaiKH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSLoaiKH.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSLoaiKH.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSLoaiKH.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSLoaiKH.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSLoaiKH.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSLoaiKH.Appearance.OddRow.Options.UseFont = true;
            this.gvDSLoaiKH.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.Row.Options.UseFont = true;
            this.gvDSLoaiKH.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.SelectedRow.Options.UseFont = true;
            this.gvDSLoaiKH.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSLoaiKH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiKH.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDSLoaiKH.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSLoaiKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiKhachHang,
            this.colLoaiKhachHang,
            this.colPhanTramGG});
            this.gvDSLoaiKH.GridControl = this.gcDSLoaiKH;
            this.gvDSLoaiKH.Name = "gvDSLoaiKH";
            this.gvDSLoaiKH.OptionsBehavior.Editable = false;
            this.gvDSLoaiKH.OptionsSelection.MultiSelect = true;
            this.gvDSLoaiKH.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDSLoaiKH.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSLoaiKH.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSLoaiKH.OptionsView.ShowAutoFilterRow = true;
            this.gvDSLoaiKH.OptionsView.ShowGroupPanel = false;
            this.gvDSLoaiKH.OptionsView.ShowIndicator = false;
            this.gvDSLoaiKH.OptionsView.ShowViewCaption = true;
            this.gvDSLoaiKH.ViewCaption = "Danh Sách Loại Khách Hàng";
            this.gvDSLoaiKH.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDSLoaiNV_SelectionChanged);
            // 
            // colMaLoaiKhachHang
            // 
            this.colMaLoaiKhachHang.Caption = "Mã Loại Khách Hàng";
            this.colMaLoaiKhachHang.FieldName = "strMaLoaiKH";
            this.colMaLoaiKhachHang.Name = "colMaLoaiKhachHang";
            this.colMaLoaiKhachHang.Visible = true;
            this.colMaLoaiKhachHang.VisibleIndex = 0;
            this.colMaLoaiKhachHang.Width = 186;
            // 
            // colLoaiKhachHang
            // 
            this.colLoaiKhachHang.Caption = "Loại Khách Hàng";
            this.colLoaiKhachHang.FieldName = "strLoaiKH";
            this.colLoaiKhachHang.Name = "colLoaiKhachHang";
            this.colLoaiKhachHang.Visible = true;
            this.colLoaiKhachHang.VisibleIndex = 1;
            this.colLoaiKhachHang.Width = 326;
            // 
            // colPhanTramGG
            // 
            this.colPhanTramGG.Caption = "Phần Trăm Giảm Giá";
            this.colPhanTramGG.FieldName = "iPhanTramGG";
            this.colPhanTramGG.Name = "colPhanTramGG";
            this.colPhanTramGG.Visible = true;
            this.colPhanTramGG.VisibleIndex = 2;
            this.colPhanTramGG.Width = 201;
            // 
            // grpTTLoaiNV
            // 
            this.grpTTLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTLoaiNV.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTLoaiNV.AppearanceCaption.Options.UseFont = true;
            this.grpTTLoaiNV.Controls.Add(this.btnLuuLoaiKH);
            this.grpTTLoaiNV.Controls.Add(this.labelControl3);
            this.grpTTLoaiNV.Controls.Add(this.txtPhanTramGG);
            this.grpTTLoaiNV.Controls.Add(this.labelControl2);
            this.grpTTLoaiNV.Controls.Add(this.txtLoaiKH);
            this.grpTTLoaiNV.Controls.Add(this.labelControl8);
            this.grpTTLoaiNV.Controls.Add(this.labelControl1);
            this.grpTTLoaiNV.Controls.Add(this.txtMaLoaiKH);
            this.grpTTLoaiNV.Location = new System.Drawing.Point(9, 6);
            this.grpTTLoaiNV.Name = "grpTTLoaiNV";
            this.grpTTLoaiNV.Size = new System.Drawing.Size(715, 144);
            this.grpTTLoaiNV.TabIndex = 0;
            this.grpTTLoaiNV.Text = "Thông Tin  Loại Khách Hàng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(221, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "%";
            // 
            // txtPhanTramGG
            // 
            this.txtPhanTramGG.Location = new System.Drawing.Point(154, 98);
            this.txtPhanTramGG.Name = "txtPhanTramGG";
            this.txtPhanTramGG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhanTramGG.Properties.Appearance.Options.UseFont = true;
            this.txtPhanTramGG.Size = new System.Drawing.Size(61, 24);
            this.txtPhanTramGG.TabIndex = 11;
            this.txtPhanTramGG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramGG_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 18);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Phần Trăm Giảm Giá";
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Location = new System.Drawing.Point(498, 48);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiKH.Properties.Appearance.Options.UseFont = true;
            this.txtLoaiKH.Size = new System.Drawing.Size(169, 24);
            this.txtLoaiKH.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(391, 51);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(101, 18);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Loại Khác Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Loại Khách Hàng";
            // 
            // txtMaLoaiKH
            // 
            this.txtMaLoaiKH.Location = new System.Drawing.Point(154, 48);
            this.txtMaLoaiKH.Name = "txtMaLoaiKH";
            this.txtMaLoaiKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLoaiKH.Properties.Appearance.Options.UseFont = true;
            this.txtMaLoaiKH.Size = new System.Drawing.Size(169, 24);
            this.txtMaLoaiKH.TabIndex = 2;
            // 
            // frmQLLoaiKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLLoaiKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLLoaiNV";
            this.Load += new System.EventHandler(this.frmQLLoaiNV_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLoaiKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLoaiKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiNV)).EndInit();
            this.grpTTLoaiNV.ResumeLayout(false);
            this.grpTTLoaiNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhanTramGG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private DevExpress.XtraEditors.SimpleButton btnSuaLoaiKH;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiKH;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiKH;
        private DevExpress.XtraEditors.SimpleButton btnLuuLoaiKH;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl grpTTLoaiNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiKH;
        private DevExpress.XtraEditors.TextEdit txtLoaiKH;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gcDSLoaiKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKhachHang;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraEditors.TextEdit txtPhanTramGG;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanTramGG;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}