namespace QLCHApple_GUI
{
    partial class frmQLCTHDNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLCTHDNhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.btnCTHDNhap = new DevExpress.XtraEditors.SimpleButton();
            this.grpThongTinHDBan = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit_TenNV = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaHDNhap = new DevExpress.XtraEditors.TextEdit();
            this.gcDSCTHDNhap = new DevExpress.XtraGrid.GridControl();
            this.gvDSCTHDNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_LoaiSP = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNamSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemDateEdit_NamSX = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.LookUpEdit_MauSac = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinHDBan)).BeginInit();
            this.grpThongTinHDBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHDNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSCTHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSCTHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_LoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_MauSac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 39);
            this.panel2.TabIndex = 10;
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
            this.lblQuayLai.Location = new System.Drawing.Point(0, 0);
            this.lblQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(195, 39);
            this.lblQuayLai.TabIndex = 0;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.EditValue = null;
            this.dtNgayLap.Location = new System.Drawing.Point(105, 55);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayLap.Properties.Appearance.Options.UseBackColor = true;
            this.dtNgayLap.Properties.Appearance.Options.UseFont = true;
            this.dtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayLap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtNgayLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayLap.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtNgayLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayLap.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtNgayLap.Size = new System.Drawing.Size(184, 24);
            this.dtNgayLap.TabIndex = 16;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Appearance.Options.UseBackColor = true;
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Appearance.Options.UseForeColor = true;
            this.btnThongKe.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnThongKe.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKe.AppearanceHovered.Options.UseFont = true;
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThongKe.Location = new System.Drawing.Point(150, 147);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(144, 45);
            this.btnThongKe.TabIndex = 18;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnCTHDNhap
            // 
            this.btnCTHDNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCTHDNhap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCTHDNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCTHDNhap.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCTHDNhap.Appearance.Options.UseBackColor = true;
            this.btnCTHDNhap.Appearance.Options.UseFont = true;
            this.btnCTHDNhap.Appearance.Options.UseForeColor = true;
            this.btnCTHDNhap.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnCTHDNhap.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCTHDNhap.AppearanceHovered.Options.UseBackColor = true;
            this.btnCTHDNhap.AppearanceHovered.Options.UseFont = true;
            this.btnCTHDNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCTHDNhap.Location = new System.Drawing.Point(0, 147);
            this.btnCTHDNhap.Name = "btnCTHDNhap";
            this.btnCTHDNhap.Size = new System.Drawing.Size(144, 45);
            this.btnCTHDNhap.TabIndex = 19;
            this.btnCTHDNhap.Text = "Chi Tiết Hóa Đơn";
            this.btnCTHDNhap.Click += new System.EventHandler(this.btnCTHDBan_Click);
            // 
            // grpThongTinHDBan
            // 
            this.grpThongTinHDBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinHDBan.Appearance.Options.UseFont = true;
            this.grpThongTinHDBan.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinHDBan.AppearanceCaption.Options.UseFont = true;
            this.grpThongTinHDBan.Controls.Add(this.labelControl5);
            this.grpThongTinHDBan.Controls.Add(this.txtTongTien);
            this.grpThongTinHDBan.Controls.Add(this.lookUpEdit_TenNV);
            this.grpThongTinHDBan.Controls.Add(this.labelControl3);
            this.grpThongTinHDBan.Controls.Add(this.labelControl2);
            this.grpThongTinHDBan.Controls.Add(this.labelControl1);
            this.grpThongTinHDBan.Controls.Add(this.txtMaHDNhap);
            this.grpThongTinHDBan.Controls.Add(this.dtNgayLap);
            this.grpThongTinHDBan.Location = new System.Drawing.Point(608, 44);
            this.grpThongTinHDBan.Name = "grpThongTinHDBan";
            this.grpThongTinHDBan.Size = new System.Drawing.Size(349, 148);
            this.grpThongTinHDBan.TabIndex = 20;
            this.grpThongTinHDBan.Text = "Thông Tin Hóa Đơn Bán";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(32, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 18);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.EditValue = "";
            this.txtTongTien.Location = new System.Drawing.Point(105, 115);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTongTien.Properties.DisplayFormat.FormatString = "c0";
            this.txtTongTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTongTien.Properties.EditFormat.FormatString = "c0";
            this.txtTongTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTongTien.Properties.Mask.EditMask = "c0";
            this.txtTongTien.Size = new System.Drawing.Size(184, 24);
            this.txtTongTien.TabIndex = 23;
            // 
            // lookUpEdit_TenNV
            // 
            this.lookUpEdit_TenNV.Location = new System.Drawing.Point(105, 85);
            this.lookUpEdit_TenNV.Name = "lookUpEdit_TenNV";
            this.lookUpEdit_TenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit_TenNV.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_TenNV.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit_TenNV.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit_TenNV.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit_TenNV.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookUpEdit_TenNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenNV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenNV", "Tên Nhân Viên")});
            this.lookUpEdit_TenNV.Properties.DisplayMember = "strHoTen";
            this.lookUpEdit_TenNV.Properties.NullText = "";
            this.lookUpEdit_TenNV.Properties.ValueMember = "strMaNV";
            this.lookUpEdit_TenNV.Size = new System.Drawing.Size(184, 24);
            this.lookUpEdit_TenNV.TabIndex = 19;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 18);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Nhân Viên Lập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 18);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Ngày Lập";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Hóa Đơn";
            // 
            // txtMaHDNhap
            // 
            this.txtMaHDNhap.Location = new System.Drawing.Point(105, 25);
            this.txtMaHDNhap.Name = "txtMaHDNhap";
            this.txtMaHDNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDNhap.Properties.Appearance.Options.UseFont = true;
            this.txtMaHDNhap.Size = new System.Drawing.Size(184, 24);
            this.txtMaHDNhap.TabIndex = 0;
            // 
            // gcDSCTHDNhap
            // 
            this.gcDSCTHDNhap.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gcDSCTHDNhap.Location = new System.Drawing.Point(0, 198);
            this.gcDSCTHDNhap.MainView = this.gvDSCTHDNhap;
            this.gcDSCTHDNhap.Name = "gcDSCTHDNhap";
            this.gcDSCTHDNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_LoaiSP,
            this.ItemDateEdit_NamSX,
            this.LookUpEdit_MauSac});
            this.gcDSCTHDNhap.Size = new System.Drawing.Size(957, 524);
            this.gcDSCTHDNhap.TabIndex = 21;
            this.gcDSCTHDNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSCTHDNhap});
            // 
            // gvDSCTHDNhap
            // 
            this.gvDSCTHDNhap.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvDSCTHDNhap.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSCTHDNhap.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSCTHDNhap.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSCTHDNhap.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSCTHDNhap.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSCTHDNhap.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDSCTHDNhap.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvDSCTHDNhap.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gvDSCTHDNhap.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvDSCTHDNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSCTHDNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSCTHDNhap.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSCTHDNhap.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSCTHDNhap.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSCTHDNhap.Appearance.OddRow.Options.UseFont = true;
            this.gvDSCTHDNhap.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSCTHDNhap.Appearance.Row.Options.UseFont = true;
            this.gvDSCTHDNhap.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSCTHDNhap.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.gvDSCTHDNhap.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDSCTHDNhap.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSCTHDNhap.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gvDSCTHDNhap.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gvDSCTHDNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP,
            this.colGiaBan,
            this.colSoLuong,
            this.colNamSX});
            this.gvDSCTHDNhap.GridControl = this.gcDSCTHDNhap;
            this.gvDSCTHDNhap.Name = "gvDSCTHDNhap";
            this.gvDSCTHDNhap.OptionsBehavior.Editable = false;
            this.gvDSCTHDNhap.OptionsSelection.MultiSelect = true;
            this.gvDSCTHDNhap.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSCTHDNhap.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSCTHDNhap.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gvDSCTHDNhap.OptionsView.ShowAutoFilterRow = true;
            this.gvDSCTHDNhap.OptionsView.ShowFooter = true;
            this.gvDSCTHDNhap.OptionsView.ShowGroupPanel = false;
            this.gvDSCTHDNhap.OptionsView.ShowIndicator = false;
            this.gvDSCTHDNhap.OptionsView.ShowViewCaption = true;
            this.gvDSCTHDNhap.ViewCaption = "Danh Sách Sản Phẩm";
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
            this.colMaSP.Width = 111;
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
            this.colTenSP.Width = 162;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.Caption = "Loại Sản Phẩm";
            this.colLoaiSP.ColumnEdit = this.LookUpEdit_LoaiSP;
            this.colLoaiSP.FieldName = "strMaLoaiSP";
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.Visible = true;
            this.colLoaiSP.VisibleIndex = 2;
            this.colLoaiSP.Width = 144;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaLoaiSP", "Mã Loại Sản Phẩm", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
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
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 3;
            this.colGiaBan.Width = 230;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "SL";
            this.colSoLuong.FieldName = "iSoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 44;
            // 
            // colNamSX
            // 
            this.colNamSX.Caption = "Năm Sản Xuất";
            this.colNamSX.ColumnEdit = this.ItemDateEdit_NamSX;
            this.colNamSX.FieldName = "dtNamSX";
            this.colNamSX.Name = "colNamSX";
            this.colNamSX.Visible = true;
            this.colNamSX.VisibleIndex = 5;
            this.colNamSX.Width = 140;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaMau", "Mã Màu", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenMau", "Tên Màu")});
            this.LookUpEdit_MauSac.DisplayMember = "strTenMau";
            this.LookUpEdit_MauSac.Name = "LookUpEdit_MauSac";
            this.LookUpEdit_MauSac.NullText = "Màu Sắc";
            this.LookUpEdit_MauSac.ValueMember = "iMaMau";
            // 
            // frmQLCTHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(959, 725);
            this.Controls.Add(this.gcDSCTHDNhap);
            this.Controls.Add(this.grpThongTinHDBan);
            this.Controls.Add(this.btnCTHDNhap);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLCTHDNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThongTinHDBan)).EndInit();
            this.grpThongTinHDBan.ResumeLayout(false);
            this.grpThongTinHDBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHDNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSCTHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSCTHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_LoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit_NamSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_MauSac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtNgayLap;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraEditors.SimpleButton btnCTHDNhap;
        private DevExpress.XtraEditors.GroupControl grpThongTinHDBan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaHDNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_TenNV;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraGrid.GridControl gcDSCTHDNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSCTHDNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_LoaiSP;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNamSX;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ItemDateEdit_NamSX;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_MauSac;
    }
}