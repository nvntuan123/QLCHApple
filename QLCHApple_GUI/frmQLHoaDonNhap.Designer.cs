namespace QLCHApple_GUI
{
    partial class frmQLHoaDonNhap
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHoaDonNhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDSHDNhap = new DevExpress.XtraGrid.GridControl();
            this.gvDSHDNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_gvColMaNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_gvColMaKH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtToDate = new DevExpress.XtraEditors.DateEdit();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.btnCTHDNhap = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHDNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).BeginInit();
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
            // gcDSHDNhap
            // 
            this.gcDSHDNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcDSHDNhap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcDSHDNhap.Location = new System.Drawing.Point(1, 98);
            this.gcDSHDNhap.MainView = this.gvDSHDNhap;
            this.gcDSHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gcDSHDNhap.Name = "gcDSHDNhap";
            this.gcDSHDNhap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_gvColMaNV,
            this.LookUpEdit_gvColMaKH});
            this.gcDSHDNhap.Size = new System.Drawing.Size(956, 626);
            this.gcDSHDNhap.TabIndex = 11;
            this.gcDSHDNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSHDNhap});
            // 
            // gvDSHDNhap
            // 
            this.gvDSHDNhap.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSHDNhap.Appearance.Empty.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSHDNhap.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHDNhap.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSHDNhap.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSHDNhap.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvDSHDNhap.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHDNhap.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSHDNhap.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvDSHDNhap.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHDNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHDNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDSHDNhap.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHDNhap.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSHDNhap.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHDNhap.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSHDNhap.Appearance.OddRow.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHDNhap.Appearance.Row.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.Row.Options.UseTextOptions = true;
            this.gvDSHDNhap.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHDNhap.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHDNhap.Appearance.TopNewRow.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSHDNhap.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHDNhap.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDSHDNhap.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSHDNhap.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvDSHDNhap.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHDNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHDN,
            this.colNgayNhap,
            this.colMaNV,
            this.colTongTien});
            this.gvDSHDNhap.GridControl = this.gcDSHDNhap;
            this.gvDSHDNhap.Name = "gvDSHDNhap";
            this.gvDSHDNhap.NewItemRowText = "Thêm Mới";
            this.gvDSHDNhap.OptionsBehavior.Editable = false;
            this.gvDSHDNhap.OptionsSelection.MultiSelect = true;
            this.gvDSHDNhap.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSHDNhap.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSHDNhap.OptionsView.ShowAutoFilterRow = true;
            this.gvDSHDNhap.OptionsView.ShowFooter = true;
            this.gvDSHDNhap.OptionsView.ShowGroupPanel = false;
            this.gvDSHDNhap.OptionsView.ShowViewCaption = true;
            this.gvDSHDNhap.ViewCaption = "Danh Sách Hóa Đơn";
            this.gvDSHDNhap.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvPhanQuyen_CustomDrawRowIndicator);
            this.gvDSHDNhap.RowCountChanged += new System.EventHandler(this.gvPhanQuyen_RowCountChanged);
            // 
            // colMaHDN
            // 
            this.colMaHDN.Caption = "Mã Hóa Đơn";
            this.colMaHDN.FieldName = "I_MaHDN";
            this.colMaHDN.Name = "colMaHDN";
            this.colMaHDN.Visible = true;
            this.colMaHDN.VisibleIndex = 0;
            this.colMaHDN.Width = 136;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Caption = "Ngày Nhập";
            this.colNgayNhap.FieldName = "DT_NgayLap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 1;
            this.colNgayNhap.Width = 121;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Nhân Viên";
            this.colMaNV.ColumnEdit = this.LookUpEdit_gvColMaNV;
            this.colMaNV.FieldName = "STR_MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            this.colMaNV.Width = 191;
            // 
            // LookUpEdit_gvColMaNV
            // 
            this.LookUpEdit_gvColMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaNV.Appearance.Options.UseFont = true;
            this.LookUpEdit_gvColMaNV.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaNV.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_gvColMaNV.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaNV.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_gvColMaNV.AutoHeight = false;
            this.LookUpEdit_gvColMaNV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_gvColMaNV.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenNV", "Tên Nhân Viên")});
            this.LookUpEdit_gvColMaNV.DisplayMember = "strHoTen";
            this.LookUpEdit_gvColMaNV.Name = "LookUpEdit_gvColMaNV";
            this.LookUpEdit_gvColMaNV.NullText = "Nhân Viên";
            this.LookUpEdit_gvColMaNV.ValueMember = "strMaNV";
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.DisplayFormat.FormatString = "c0";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongTien.FieldName = "DEC_TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DEC_TongTien", "{0:c0}")});
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 3;
            this.colTongTien.Width = 298;
            // 
            // LookUpEdit_gvColMaKH
            // 
            this.LookUpEdit_gvColMaKH.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaKH.Appearance.Options.UseFont = true;
            this.LookUpEdit_gvColMaKH.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaKH.AppearanceDropDown.Options.UseFont = true;
            this.LookUpEdit_gvColMaKH.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LookUpEdit_gvColMaKH.AppearanceDropDownHeader.Options.UseFont = true;
            this.LookUpEdit_gvColMaKH.AutoHeight = false;
            this.LookUpEdit_gvColMaKH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_gvColMaKH.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenKH", "Tên Khách Hàng")});
            this.LookUpEdit_gvColMaKH.DisplayMember = "strHoTenKH";
            this.LookUpEdit_gvColMaKH.Name = "LookUpEdit_gvColMaKH";
            this.LookUpEdit_gvColMaKH.NullText = "Khách Hàng";
            this.LookUpEdit_gvColMaKH.ValueMember = "strMaKH";
            // 
            // dtFromDate
            // 
            this.dtFromDate.EditValue = new System.DateTime(2019, 5, 24, 14, 39, 31, 102);
            this.dtFromDate.Location = new System.Drawing.Point(427, 58);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtFromDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.dtFromDate.Properties.Appearance.Options.UseFont = true;
            this.dtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtFromDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtFromDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtFromDate.Size = new System.Drawing.Size(184, 24);
            this.dtFromDate.TabIndex = 16;
            // 
            // dtToDate
            // 
            this.dtToDate.EditValue = new System.DateTime(2019, 5, 24, 0, 0, 0, 0);
            this.dtToDate.Location = new System.Drawing.Point(767, 58);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtToDate.Properties.Appearance.Options.UseBackColor = true;
            this.dtToDate.Properties.Appearance.Options.UseFont = true;
            this.dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtToDate.Size = new System.Drawing.Size(170, 24);
            this.dtToDate.TabIndex = 17;
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
            this.btnThongKe.Location = new System.Drawing.Point(617, 47);
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
            this.btnCTHDNhap.Location = new System.Drawing.Point(51, 46);
            this.btnCTHDNhap.Name = "btnCTHDNhap";
            this.btnCTHDNhap.Size = new System.Drawing.Size(144, 45);
            this.btnCTHDNhap.TabIndex = 19;
            this.btnCTHDNhap.Text = "Chi Tiết Hóa Đơn";
            this.btnCTHDNhap.Visible = false;
            this.btnCTHDNhap.Click += new System.EventHandler(this.btnCTHDNhap_Click);
            // 
            // frmQLHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(959, 725);
            this.Controls.Add(this.btnCTHDNhap);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.gcDSHDNhap);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHDNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcDSHDNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSHDNhap;
        private DevExpress.XtraEditors.DateEdit dtFromDate;
        private DevExpress.XtraEditors.DateEdit dtToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDN;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_gvColMaNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_gvColMaKH;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraEditors.SimpleButton btnCTHDNhap;
    }
}