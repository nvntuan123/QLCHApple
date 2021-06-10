namespace QLCHApple_GUI
{
    partial class frmQLSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSP));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpThongTinChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.btnCTSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemMaSN = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.dtNamSX = new DevExpress.XtraEditors.DateEdit();
            this.cmbMaLoaiSP = new DevExpress.XtraEditors.LookUpEdit();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnImportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gcDSSP = new DevExpress.XtraGrid.GridControl();
            this.gvDSSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_LoaiSP = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemDateEdit_NamSX = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.LookUpEdit_MauSac = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinChiTiet)).BeginInit();
            this.grpThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSX.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_LoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_MauSac)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCHApple_GUI.Properties.Resources.apple_logo_PNG19679;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpThongTinChiTiet
            // 
            this.grpThongTinChiTiet.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinChiTiet.AppearanceCaption.Options.UseFont = true;
            this.grpThongTinChiTiet.Controls.Add(this.btnCTSP);
            this.grpThongTinChiTiet.Controls.Add(this.btnXemMaSN);
            this.grpThongTinChiTiet.Controls.Add(this.label3);
            this.grpThongTinChiTiet.Controls.Add(this.txtTenSP);
            this.grpThongTinChiTiet.Controls.Add(this.dtNamSX);
            this.grpThongTinChiTiet.Controls.Add(this.cmbMaLoaiSP);
            this.grpThongTinChiTiet.Controls.Add(this.txtGiaBan);
            this.grpThongTinChiTiet.Controls.Add(this.txtSL);
            this.grpThongTinChiTiet.Controls.Add(this.txtMaSP);
            this.grpThongTinChiTiet.Controls.Add(this.label5);
            this.grpThongTinChiTiet.Controls.Add(this.label8);
            this.grpThongTinChiTiet.Controls.Add(this.label7);
            this.grpThongTinChiTiet.Controls.Add(this.label1);
            this.grpThongTinChiTiet.Controls.Add(this.label2);
            this.grpThongTinChiTiet.Location = new System.Drawing.Point(9, 9);
            this.grpThongTinChiTiet.Name = "grpThongTinChiTiet";
            this.grpThongTinChiTiet.Size = new System.Drawing.Size(768, 158);
            this.grpThongTinChiTiet.TabIndex = 0;
            this.grpThongTinChiTiet.Text = "Thông Tin Sản Phẩm";
            // 
            // btnCTSP
            // 
            this.btnCTSP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCTSP.Appearance.Options.UseFont = true;
            this.btnCTSP.Location = new System.Drawing.Point(604, 109);
            this.btnCTSP.Name = "btnCTSP";
            this.btnCTSP.Size = new System.Drawing.Size(153, 33);
            this.btnCTSP.TabIndex = 51;
            this.btnCTSP.Text = "Cấu Hình Chi Tiết";
            this.btnCTSP.Click += new System.EventHandler(this.btnCTSP_Click);
            // 
            // btnXemMaSN
            // 
            this.btnXemMaSN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemMaSN.Appearance.Options.UseFont = true;
            this.btnXemMaSN.Location = new System.Drawing.Point(436, 109);
            this.btnXemMaSN.Name = "btnXemMaSN";
            this.btnXemMaSN.Size = new System.Drawing.Size(109, 33);
            this.btnXemMaSN.TabIndex = 50;
            this.btnXemMaSN.Text = "Mã IMEI";
            this.btnXemMaSN.Click += new System.EventHandler(this.btnXemMaSN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(422, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Năm sản xuất";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(126, 58);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenSP.Size = new System.Drawing.Size(219, 24);
            this.txtTenSP.TabIndex = 48;
            // 
            // dtNamSX
            // 
            this.dtNamSX.EditValue = new System.DateTime(2019, 5, 24, 14, 39, 31, 102);
            this.dtNamSX.Location = new System.Drawing.Point(538, 58);
            this.dtNamSX.Name = "dtNamSX";
            this.dtNamSX.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtNamSX.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNamSX.Properties.Appearance.Options.UseBackColor = true;
            this.dtNamSX.Properties.Appearance.Options.UseFont = true;
            this.dtNamSX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNamSX.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNamSX.Size = new System.Drawing.Size(150, 24);
            this.dtNamSX.TabIndex = 7;
            // 
            // cmbMaLoaiSP
            // 
            this.cmbMaLoaiSP.Location = new System.Drawing.Point(126, 88);
            this.cmbMaLoaiSP.Name = "cmbMaLoaiSP";
            this.cmbMaLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.cmbMaLoaiSP.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaLoaiSP.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbMaLoaiSP.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMaLoaiSP.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbMaLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaLoaiSP.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenLoaiSP", "Loại Sản Phẩm")});
            this.cmbMaLoaiSP.Properties.NullText = "Loại Sản Phẩm";
            this.cmbMaLoaiSP.Size = new System.Drawing.Size(219, 24);
            this.cmbMaLoaiSP.TabIndex = 2;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(538, 28);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Properties.Appearance.Options.UseFont = true;
            this.txtGiaBan.Size = new System.Drawing.Size(219, 24);
            this.txtGiaBan.TabIndex = 5;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(126, 118);
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSL.Properties.Appearance.Options.UseFont = true;
            this.txtSL.Size = new System.Drawing.Size(174, 24);
            this.txtSL.TabIndex = 6;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(126, 28);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Properties.Appearance.Options.UseFont = true;
            this.txtMaSP.Size = new System.Drawing.Size(174, 24);
            this.txtMaSP.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(466, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Giá bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã sản phẩm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lblRefresh);
            this.panel3.Controls.Add(this.lblQuayLai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 39);
            this.panel3.TabIndex = 8;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
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
            this.lblRefresh.Location = new System.Drawing.Point(1056, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 15;
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
            this.lblQuayLai.Size = new System.Drawing.Size(182, 39);
            this.lblQuayLai.TabIndex = 0;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.lblHienThi);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 561);
            this.panel4.TabIndex = 9;
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
            this.lblHienThi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHienThi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHienThi.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblHienThi.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblHienThi.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblHienThi.LineVisible = true;
            this.lblHienThi.Location = new System.Drawing.Point(14, 180);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(157, 38);
            this.lblHienThi.TabIndex = 23;
            this.lblHienThi.Text = "Quản Lý Sản Phẩm";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnSua.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.AppearanceHovered.Options.UseBackColor = true;
            this.btnSua.AppearanceHovered.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSua.Location = new System.Drawing.Point(0, 405);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(183, 97);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnXoa.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoa.AppearanceHovered.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoa.Location = new System.Drawing.Point(0, 324);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 97);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnThem.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThem.AppearanceHovered.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.Options.UseFont = true;
            this.btnThem.AppearanceHovered.Options.UseForeColor = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.Location = new System.Drawing.Point(0, 243);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 62);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnLuu.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.Location = new System.Drawing.Point(791, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 45);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnImportExcel);
            this.panel1.Controls.Add(this.gcDSSP);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.grpThongTinChiTiet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(183, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 561);
            this.panel1.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnExportExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Appearance.Options.UseBackColor = true;
            this.btnExportExcel.Appearance.Options.UseFont = true;
            this.btnExportExcel.Appearance.Options.UseForeColor = true;
            this.btnExportExcel.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnExportExcel.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.AppearanceHovered.Options.UseBackColor = true;
            this.btnExportExcel.AppearanceHovered.Options.UseFont = true;
            this.btnExportExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExportExcel.Location = new System.Drawing.Point(791, 122);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(144, 45);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnImportExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImportExcel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Appearance.Options.UseBackColor = true;
            this.btnImportExcel.Appearance.Options.UseFont = true;
            this.btnImportExcel.Appearance.Options.UseForeColor = true;
            this.btnImportExcel.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnImportExcel.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnImportExcel.AppearanceHovered.Options.UseBackColor = true;
            this.btnImportExcel.AppearanceHovered.Options.UseFont = true;
            this.btnImportExcel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnImportExcel.Location = new System.Drawing.Point(791, 63);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(144, 45);
            this.btnImportExcel.TabIndex = 2;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // gcDSSP
            // 
            this.gcDSSP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcDSSP.Location = new System.Drawing.Point(9, 173);
            this.gcDSSP.MainView = this.gvDSSP;
            this.gcDSSP.Name = "gcDSSP";
            this.gcDSSP.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_LoaiSP,
            this.ItemDateEdit_NamSX,
            this.LookUpEdit_MauSac});
            this.gcDSSP.Size = new System.Drawing.Size(935, 376);
            this.gcDSSP.TabIndex = 1;
            this.gcDSSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSSP});
            // 
            // gvDSSP
            // 
            this.gvDSSP.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvDSSP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSSP.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSSP.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSSP.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSSP.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSSP.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDSSP.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvDSSP.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gvDSSP.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvDSSP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSSP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSSP.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSSP.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSSP.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSSP.Appearance.OddRow.Options.UseFont = true;
            this.gvDSSP.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSSP.Appearance.Row.Options.UseFont = true;
            this.gvDSSP.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSSP.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.gvDSSP.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDSSP.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSSP.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSSP.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gvDSSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP,
            this.colGiaBan,
            this.colSoLuong,
            this.colNamSX});
            this.gvDSSP.GridControl = this.gcDSSP;
            this.gvDSSP.Name = "gvDSSP";
            this.gvDSSP.OptionsBehavior.Editable = false;
            this.gvDSSP.OptionsSelection.MultiSelect = true;
            this.gvDSSP.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSSP.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSSP.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gvDSSP.OptionsView.ShowAutoFilterRow = true;
            this.gvDSSP.OptionsView.ShowFooter = true;
            this.gvDSSP.OptionsView.ShowGroupPanel = false;
            this.gvDSSP.OptionsView.ShowIndicator = false;
            this.gvDSSP.OptionsView.ShowViewCaption = true;
            this.gvDSSP.ViewCaption = "Danh Sách Sản Phẩm";
            this.gvDSSP.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDSSP_SelectionChanged);
            // 
            // colMaSP
            // 
            this.colMaSP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colMaSP.AppearanceCell.Options.UseFont = true;
            this.colMaSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colMaSP.AppearanceHeader.Options.UseFont = true;
            this.colMaSP.Caption = "Mã Sản Phẩm";
            this.colMaSP.FieldName = "strMaSP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            this.colMaSP.Width = 110;
            // 
            // colTenSP
            // 
            this.colTenSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.colTenSP.AppearanceHeader.Options.UseFont = true;
            this.colTenSP.Caption = "Tên Sản Phẩm";
            this.colTenSP.FieldName = "strTenSP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            this.colTenSP.Width = 332;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.Caption = "Loại Sản Phẩm";
            this.colLoaiSP.ColumnEdit = this.LookUpEdit_LoaiSP;
            this.colLoaiSP.FieldName = "strMaLoaiSP";
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.Visible = true;
            this.colLoaiSP.VisibleIndex = 2;
            this.colLoaiSP.Width = 127;
            // 
            // LookUpEdit_LoaiSP
            // 
            this.LookUpEdit_LoaiSP.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_LoaiSP.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_LoaiSP.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_LoaiSP.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_LoaiSP.AutoHeight = false;
            this.LookUpEdit_LoaiSP.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_LoaiSP.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaLoaiSP", "Mã Loại Sản Phẩm", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenLoaiSP", "Loại Sản Phẩm")});
            this.LookUpEdit_LoaiSP.DisplayMember = "strTenLoaiSP";
            this.LookUpEdit_LoaiSP.Name = "LookUpEdit_LoaiSP";
            this.LookUpEdit_LoaiSP.NullText = "Loại Sản Phẩm";
            this.LookUpEdit_LoaiSP.ValueMember = "strMaLoaiSP";
            // 
            // colGiaBan
            // 
            this.colGiaBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colGiaBan.AppearanceHeader.Options.UseFont = true;
            this.colGiaBan.Caption = "Giá Bán";
            this.colGiaBan.DisplayFormat.FormatString = "c";
            this.colGiaBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiaBan.FieldName = "decGiaBan";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "decGiaBan", "Tổng Tiền = {0:c}")});
            this.colGiaBan.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 3;
            this.colGiaBan.Width = 204;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "SL";
            this.colSoLuong.FieldName = "iSoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 45;
            // 
            // colNamSX
            // 
            this.colNamSX.Caption = "Năm Sản Xuất";
            this.colNamSX.ColumnEdit = this.ItemDateEdit_NamSX;
            this.colNamSX.FieldName = "dtNamSX";
            this.colNamSX.Name = "colNamSX";
            this.colNamSX.Visible = true;
            this.colNamSX.VisibleIndex = 5;
            this.colNamSX.Width = 115;
            // 
            // ItemDateEdit_NamSX
            // 
            this.ItemDateEdit_NamSX.AutoHeight = false;
            this.ItemDateEdit_NamSX.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit_NamSX.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit_NamSX.Name = "ItemDateEdit_NamSX";
            // 
            // LookUpEdit_MauSac
            // 
            this.LookUpEdit_MauSac.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_MauSac.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_MauSac.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_MauSac.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_MauSac.AutoHeight = false;
            this.LookUpEdit_MauSac.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_MauSac.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaMau", "Mã Màu", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenMau", "Tên Màu")});
            this.LookUpEdit_MauSac.DisplayMember = "strTenMau";
            this.LookUpEdit_MauSac.Name = "LookUpEdit_MauSac";
            this.LookUpEdit_MauSac.NullText = "Màu Sắc";
            this.LookUpEdit_MauSac.ValueMember = "iMaMau";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add File_25px.png");
            this.imageList1.Images.SetKeyName(1, "Delete File_25px.png");
            this.imageList1.Images.SetKeyName(2, "Edit File_25px.png");
            this.imageList1.Images.SetKeyName(3, "Save_25px.png");
            // 
            // frmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apple Store Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinChiTiet)).EndInit();
            this.grpThongTinChiTiet.ResumeLayout(false);
            this.grpThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSX.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNamSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_LoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_MauSac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.GroupControl grpThongTinChiTiet;
        private DevExpress.XtraEditors.LookUpEdit cmbMaLoaiSP;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private DevExpress.XtraGrid.GridControl gcDSSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSSP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_LoaiSP;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraEditors.DateEdit dtNamSX;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSX;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ItemDateEdit_NamSX;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnXemMaSN;
        private DevExpress.XtraEditors.SimpleButton btnCTSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_MauSac;
        private DevExpress.XtraEditors.SimpleButton btnImportExcel;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

