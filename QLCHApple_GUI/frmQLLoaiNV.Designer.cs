namespace QLCHApple_GUI
{
    partial class frmQLLoaiNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLoaiNV));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuuLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiNV = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gcDSLoaiNV = new DevExpress.XtraGrid.GridControl();
            this.gvDSLoaiNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpTTLoaiNV = new DevExpress.XtraEditors.GroupControl();
            this.txtTenLoaiNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLoaiNV = new DevExpress.XtraEditors.TextEdit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLoaiNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLoaiNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiNV)).BeginInit();
            this.grpTTLoaiNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiNV.Properties)).BeginInit();
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
            this.panel1.Controls.Add(this.btnXoaLoaiNV);
            this.panel1.Controls.Add(this.btnSuaLoaiNV);
            this.panel1.Controls.Add(this.btnThemLoaiNV);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 465);
            this.panel1.TabIndex = 12;
            // 
            // btnLuuLoaiNV
            // 
            this.btnLuuLoaiNV.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(73)))));
            this.btnLuuLoaiNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLoaiNV.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuuLoaiNV.Appearance.Options.UseBackColor = true;
            this.btnLuuLoaiNV.Appearance.Options.UseFont = true;
            this.btnLuuLoaiNV.Appearance.Options.UseForeColor = true;
            this.btnLuuLoaiNV.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuLoaiNV.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuLoaiNV.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLoaiNV.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuuLoaiNV.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLuuLoaiNV.AppearanceHovered.Options.UseFont = true;
            this.btnLuuLoaiNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuuLoaiNV.Location = new System.Drawing.Point(273, 86);
            this.btnLuuLoaiNV.Name = "btnLuuLoaiNV";
            this.btnLuuLoaiNV.Size = new System.Drawing.Size(150, 45);
            this.btnLuuLoaiNV.TabIndex = 23;
            this.btnLuuLoaiNV.TabStop = false;
            this.btnLuuLoaiNV.Text = "Lưu";
            this.btnLuuLoaiNV.Click += new System.EventHandler(this.btnLuuLoaiNV_Click);
            // 
            // btnXoaLoaiNV
            // 
            this.btnXoaLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLoaiNV.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaLoaiNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaLoaiNV.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiNV.Appearance.Options.UseBackColor = true;
            this.btnXoaLoaiNV.Appearance.Options.UseFont = true;
            this.btnXoaLoaiNV.Appearance.Options.UseForeColor = true;
            this.btnXoaLoaiNV.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaLoaiNV.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaLoaiNV.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaLoaiNV.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaLoaiNV.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoaLoaiNV.AppearanceHovered.Options.UseFont = true;
            this.btnXoaLoaiNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaLoaiNV.Location = new System.Drawing.Point(0, 298);
            this.btnXoaLoaiNV.Name = "btnXoaLoaiNV";
            this.btnXoaLoaiNV.Size = new System.Drawing.Size(180, 55);
            this.btnXoaLoaiNV.TabIndex = 22;
            this.btnXoaLoaiNV.TabStop = false;
            this.btnXoaLoaiNV.Text = "Xóa";
            this.btnXoaLoaiNV.Click += new System.EventHandler(this.btnXoaLoaiNV_Click);
            // 
            // btnSuaLoaiNV
            // 
            this.btnSuaLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaLoaiNV.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLoaiNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiNV.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSuaLoaiNV.Appearance.Options.UseBackColor = true;
            this.btnSuaLoaiNV.Appearance.Options.UseFont = true;
            this.btnSuaLoaiNV.Appearance.Options.UseForeColor = true;
            this.btnSuaLoaiNV.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLoaiNV.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLoaiNV.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiNV.AppearanceHovered.Options.UseBackColor = true;
            this.btnSuaLoaiNV.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSuaLoaiNV.AppearanceHovered.Options.UseFont = true;
            this.btnSuaLoaiNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaLoaiNV.Location = new System.Drawing.Point(0, 372);
            this.btnSuaLoaiNV.Name = "btnSuaLoaiNV";
            this.btnSuaLoaiNV.Size = new System.Drawing.Size(180, 55);
            this.btnSuaLoaiNV.TabIndex = 21;
            this.btnSuaLoaiNV.TabStop = false;
            this.btnSuaLoaiNV.Text = "Sửa";
            this.btnSuaLoaiNV.Click += new System.EventHandler(this.btnSuaLoaiNV_Click);
            // 
            // btnThemLoaiNV
            // 
            this.btnThemLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLoaiNV.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThemLoaiNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiNV.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiNV.Appearance.Options.UseBackColor = true;
            this.btnThemLoaiNV.Appearance.Options.UseFont = true;
            this.btnThemLoaiNV.Appearance.Options.UseForeColor = true;
            this.btnThemLoaiNV.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemLoaiNV.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemLoaiNV.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiNV.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemLoaiNV.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThemLoaiNV.AppearanceHovered.Options.UseFont = true;
            this.btnThemLoaiNV.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemLoaiNV.Location = new System.Drawing.Point(0, 224);
            this.btnThemLoaiNV.Name = "btnThemLoaiNV";
            this.btnThemLoaiNV.Size = new System.Drawing.Size(180, 55);
            this.btnThemLoaiNV.TabIndex = 20;
            this.btnThemLoaiNV.TabStop = false;
            this.btnThemLoaiNV.Text = "Thêm";
            this.btnThemLoaiNV.Click += new System.EventHandler(this.btnThemLoaiNV_Click);
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
            this.lblHienThi.Text = "Quản Lý \r\nLoại Nhân Viên";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.gcDSLoaiNV);
            this.panel3.Controls.Add(this.grpTTLoaiNV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 465);
            this.panel3.TabIndex = 13;
            // 
            // gcDSLoaiNV
            // 
            this.gcDSLoaiNV.Location = new System.Drawing.Point(9, 156);
            this.gcDSLoaiNV.MainView = this.gvDSLoaiNV;
            this.gcDSLoaiNV.Name = "gcDSLoaiNV";
            this.gcDSLoaiNV.Size = new System.Drawing.Size(715, 306);
            this.gcDSLoaiNV.TabIndex = 1;
            this.gcDSLoaiNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLoaiNV});
            // 
            // gvDSLoaiNV
            // 
            this.gvDSLoaiNV.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.Empty.Options.UseFont = true;
            this.gvDSLoaiNV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSLoaiNV.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSLoaiNV.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSLoaiNV.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSLoaiNV.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSLoaiNV.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSLoaiNV.Appearance.OddRow.Options.UseFont = true;
            this.gvDSLoaiNV.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.Row.Options.UseFont = true;
            this.gvDSLoaiNV.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.SelectedRow.Options.UseFont = true;
            this.gvDSLoaiNV.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSLoaiNV.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiNV.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDSLoaiNV.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSLoaiNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiNhanVien,
            this.colLoaiNhanVien});
            this.gvDSLoaiNV.GridControl = this.gcDSLoaiNV;
            this.gvDSLoaiNV.Name = "gvDSLoaiNV";
            this.gvDSLoaiNV.OptionsBehavior.Editable = false;
            this.gvDSLoaiNV.OptionsSelection.MultiSelect = true;
            this.gvDSLoaiNV.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDSLoaiNV.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSLoaiNV.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSLoaiNV.OptionsView.ShowAutoFilterRow = true;
            this.gvDSLoaiNV.OptionsView.ShowGroupPanel = false;
            this.gvDSLoaiNV.OptionsView.ShowIndicator = false;
            this.gvDSLoaiNV.OptionsView.ShowViewCaption = true;
            this.gvDSLoaiNV.ViewCaption = "Danh Sách Loại Nhân Viên";
            this.gvDSLoaiNV.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDSLoaiNV_SelectionChanged);
            // 
            // colMaLoaiNhanVien
            // 
            this.colMaLoaiNhanVien.Caption = "Mã Loại Nhân Viên";
            this.colMaLoaiNhanVien.FieldName = "strMaLoaiNV";
            this.colMaLoaiNhanVien.Name = "colMaLoaiNhanVien";
            this.colMaLoaiNhanVien.Visible = true;
            this.colMaLoaiNhanVien.VisibleIndex = 0;
            // 
            // colLoaiNhanVien
            // 
            this.colLoaiNhanVien.Caption = "Loại Nhân Viên";
            this.colLoaiNhanVien.FieldName = "strTenLoaiNV";
            this.colLoaiNhanVien.Name = "colLoaiNhanVien";
            this.colLoaiNhanVien.Visible = true;
            this.colLoaiNhanVien.VisibleIndex = 1;
            // 
            // grpTTLoaiNV
            // 
            this.grpTTLoaiNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTLoaiNV.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTLoaiNV.AppearanceCaption.Options.UseFont = true;
            this.grpTTLoaiNV.Controls.Add(this.btnLuuLoaiNV);
            this.grpTTLoaiNV.Controls.Add(this.txtTenLoaiNV);
            this.grpTTLoaiNV.Controls.Add(this.labelControl8);
            this.grpTTLoaiNV.Controls.Add(this.labelControl1);
            this.grpTTLoaiNV.Controls.Add(this.txtMaLoaiNV);
            this.grpTTLoaiNV.Location = new System.Drawing.Point(9, 6);
            this.grpTTLoaiNV.Name = "grpTTLoaiNV";
            this.grpTTLoaiNV.Size = new System.Drawing.Size(715, 144);
            this.grpTTLoaiNV.TabIndex = 0;
            this.grpTTLoaiNV.Text = "Thông Tin Chi Tiết Loại Nhân Viên";
            // 
            // txtTenLoaiNV
            // 
            this.txtTenLoaiNV.Location = new System.Drawing.Point(476, 40);
            this.txtTenLoaiNV.Name = "txtTenLoaiNV";
            this.txtTenLoaiNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoaiNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiNV.Size = new System.Drawing.Size(169, 24);
            this.txtTenLoaiNV.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(357, 43);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 18);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Loại Nhân Viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Loại Nhân Viên";
            // 
            // txtMaLoaiNV
            // 
            this.txtMaLoaiNV.Location = new System.Drawing.Point(151, 40);
            this.txtMaLoaiNV.Name = "txtMaLoaiNV";
            this.txtMaLoaiNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLoaiNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaLoaiNV.Size = new System.Drawing.Size(169, 24);
            this.txtMaLoaiNV.TabIndex = 2;
            // 
            // frmQLLoaiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLLoaiNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLLoaiNV";
            this.Load += new System.EventHandler(this.frmQLLoaiNV_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLoaiNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLoaiNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiNV)).EndInit();
            this.grpTTLoaiNV.ResumeLayout(false);
            this.grpTTLoaiNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private DevExpress.XtraEditors.SimpleButton btnSuaLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiNV;
        private DevExpress.XtraEditors.SimpleButton btnLuuLoaiNV;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl grpTTLoaiNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiNV;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiNV;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gcDSLoaiNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiNhanVien;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
    }
}