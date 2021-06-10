namespace QLCHApple_GUI
{
    partial class frmQLHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHoaDonBan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDSHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvDSHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_gvColMaNV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_gvColMaKH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtToDate = new DevExpress.XtraEditors.DateEdit();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.btnCTHDBan = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTatCaHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnUpdateHDBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaHDBan = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit_TenKH = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit_TenNV = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaHDB = new DevExpress.XtraEditors.TextEdit();
            this.dtNgayBan = new DevExpress.XtraEditors.DateEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBan.Properties)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1252, 39);
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
            // gcDSHoaDon
            // 
            this.gcDSHoaDon.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcDSHoaDon.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcDSHoaDon.Location = new System.Drawing.Point(190, 222);
            this.gcDSHoaDon.MainView = this.gvDSHoaDon;
            this.gcDSHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.gcDSHoaDon.Name = "gcDSHoaDon";
            this.gcDSHoaDon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_gvColMaNV,
            this.LookUpEdit_gvColMaKH});
            this.gcDSHoaDon.Size = new System.Drawing.Size(1062, 503);
            this.gcDSHoaDon.TabIndex = 11;
            this.gcDSHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSHoaDon});
            // 
            // gvDSHoaDon
            // 
            this.gvDSHoaDon.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSHoaDon.Appearance.Empty.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSHoaDon.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHoaDon.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSHoaDon.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSHoaDon.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gvDSHoaDon.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHoaDon.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSHoaDon.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gvDSHoaDon.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHoaDon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHoaDon.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDSHoaDon.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHoaDon.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSHoaDon.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHoaDon.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSHoaDon.Appearance.OddRow.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHoaDon.Appearance.Row.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.Row.Options.UseTextOptions = true;
            this.gvDSHoaDon.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHoaDon.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHoaDon.Appearance.TopNewRow.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSHoaDon.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSHoaDon.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvDSHoaDon.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSHoaDon.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvDSHoaDon.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDSHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHDB,
            this.colNgayBan,
            this.colMaNV,
            this.colMaKH,
            this.colTongTien});
            this.gvDSHoaDon.GridControl = this.gcDSHoaDon;
            this.gvDSHoaDon.Name = "gvDSHoaDon";
            this.gvDSHoaDon.NewItemRowText = "Thêm Mới";
            this.gvDSHoaDon.OptionsBehavior.Editable = false;
            this.gvDSHoaDon.OptionsSelection.MultiSelect = true;
            this.gvDSHoaDon.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSHoaDon.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSHoaDon.OptionsView.ShowAutoFilterRow = true;
            this.gvDSHoaDon.OptionsView.ShowFooter = true;
            this.gvDSHoaDon.OptionsView.ShowGroupPanel = false;
            this.gvDSHoaDon.OptionsView.ShowViewCaption = true;
            this.gvDSHoaDon.ViewCaption = "Danh Sách Hóa Đơn";
            this.gvDSHoaDon.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gv_CustomDrawRowIndicator);
            this.gvDSHoaDon.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDSHoaDon_SelectionChanged);
            this.gvDSHoaDon.RowCountChanged += new System.EventHandler(this.gv_RowCountChanged);
            // 
            // colMaHDB
            // 
            this.colMaHDB.Caption = "Mã Hóa Đơn";
            this.colMaHDB.FieldName = "I_MaHDB";
            this.colMaHDB.Name = "colMaHDB";
            this.colMaHDB.Visible = true;
            this.colMaHDB.VisibleIndex = 0;
            this.colMaHDB.Width = 136;
            // 
            // colNgayBan
            // 
            this.colNgayBan.Caption = "Ngày Bán";
            this.colNgayBan.FieldName = "DT_NgayBan";
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.Visible = true;
            this.colNgayBan.VisibleIndex = 1;
            this.colNgayBan.Width = 121;
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
            // colMaKH
            // 
            this.colMaKH.Caption = "Khách Hàng";
            this.colMaKH.ColumnEdit = this.LookUpEdit_gvColMaKH;
            this.colMaKH.FieldName = "STR_MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 3;
            this.colMaKH.Width = 192;
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
            this.colTongTien.VisibleIndex = 4;
            this.colTongTien.Width = 298;
            // 
            // dtFromDate
            // 
            this.dtFromDate.EditValue = new System.DateTime(2019, 5, 24, 14, 39, 31, 102);
            this.dtFromDate.Location = new System.Drawing.Point(80, 32);
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
            this.dtFromDate.Size = new System.Drawing.Size(115, 24);
            this.dtFromDate.TabIndex = 16;
            // 
            // dtToDate
            // 
            this.dtToDate.EditValue = new System.DateTime(2019, 5, 24, 0, 0, 0, 0);
            this.dtToDate.Location = new System.Drawing.Point(80, 62);
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
            this.dtToDate.Size = new System.Drawing.Size(115, 24);
            this.dtToDate.TabIndex = 17;
            // 
            // btnThongKe
            // 
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
            this.btnThongKe.Location = new System.Drawing.Point(201, 37);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(144, 45);
            this.btnThongKe.TabIndex = 18;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnCTHDBan
            // 
            this.btnCTHDBan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCTHDBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCTHDBan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCTHDBan.Appearance.Options.UseBackColor = true;
            this.btnCTHDBan.Appearance.Options.UseFont = true;
            this.btnCTHDBan.Appearance.Options.UseForeColor = true;
            this.btnCTHDBan.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnCTHDBan.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCTHDBan.AppearanceHovered.Options.UseBackColor = true;
            this.btnCTHDBan.AppearanceHovered.Options.UseFont = true;
            this.btnCTHDBan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCTHDBan.Location = new System.Drawing.Point(413, 95);
            this.btnCTHDBan.Name = "btnCTHDBan";
            this.btnCTHDBan.Size = new System.Drawing.Size(184, 65);
            this.btnCTHDBan.TabIndex = 19;
            this.btnCTHDBan.Text = "Chi Tiết Hóa Đơn";
            this.btnCTHDBan.Click += new System.EventHandler(this.btnCTHDBan_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnTatCaHoaDon);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dtFromDate);
            this.groupControl1.Controls.Add(this.dtToDate);
            this.groupControl1.Controls.Add(this.btnThongKe);
            this.groupControl1.Location = new System.Drawing.Point(895, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 172);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Thống Kê Hóa Đơn";
            // 
            // btnTatCaHoaDon
            // 
            this.btnTatCaHoaDon.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnTatCaHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTatCaHoaDon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTatCaHoaDon.Appearance.Options.UseBackColor = true;
            this.btnTatCaHoaDon.Appearance.Options.UseFont = true;
            this.btnTatCaHoaDon.Appearance.Options.UseForeColor = true;
            this.btnTatCaHoaDon.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnTatCaHoaDon.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTatCaHoaDon.AppearanceHovered.Options.UseBackColor = true;
            this.btnTatCaHoaDon.AppearanceHovered.Options.UseFont = true;
            this.btnTatCaHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnTatCaHoaDon.Location = new System.Drawing.Point(9, 118);
            this.btnTatCaHoaDon.Name = "btnTatCaHoaDon";
            this.btnTatCaHoaDon.Size = new System.Drawing.Size(162, 45);
            this.btnTatCaHoaDon.TabIndex = 21;
            this.btnTatCaHoaDon.Text = "Tất Cả Hóa Đơn";
            this.btnTatCaHoaDon.Click += new System.EventHandler(this.btnTatCaHoaDon_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 18);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Đến Ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 18);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Từ Ngày";
            // 
            // btnUpdateHDBan
            // 
            this.btnUpdateHDBan.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateHDBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateHDBan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdateHDBan.Appearance.Options.UseBackColor = true;
            this.btnUpdateHDBan.Appearance.Options.UseFont = true;
            this.btnUpdateHDBan.Appearance.Options.UseForeColor = true;
            this.btnUpdateHDBan.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateHDBan.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateHDBan.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdateHDBan.AppearanceHovered.Options.UseFont = true;
            this.btnUpdateHDBan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdateHDBan.Location = new System.Drawing.Point(0, 259);
            this.btnUpdateHDBan.Name = "btnUpdateHDBan";
            this.btnUpdateHDBan.Size = new System.Drawing.Size(184, 65);
            this.btnUpdateHDBan.TabIndex = 21;
            this.btnUpdateHDBan.Text = "Cập Nhật Hóa Đơn";
            this.btnUpdateHDBan.Click += new System.EventHandler(this.btnUpdateHDBan_Click);
            // 
            // btnXoaHDBan
            // 
            this.btnXoaHDBan.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaHDBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHDBan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaHDBan.Appearance.Options.UseBackColor = true;
            this.btnXoaHDBan.Appearance.Options.UseFont = true;
            this.btnXoaHDBan.Appearance.Options.UseForeColor = true;
            this.btnXoaHDBan.AppearanceHovered.BackColor = System.Drawing.Color.DimGray;
            this.btnXoaHDBan.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHDBan.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaHDBan.AppearanceHovered.Options.UseFont = true;
            this.btnXoaHDBan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaHDBan.Location = new System.Drawing.Point(0, 357);
            this.btnXoaHDBan.Name = "btnXoaHDBan";
            this.btnXoaHDBan.Size = new System.Drawing.Size(184, 65);
            this.btnXoaHDBan.TabIndex = 22;
            this.btnXoaHDBan.Text = "Xóa Hóa Đơn";
            this.btnXoaHDBan.Click += new System.EventHandler(this.btnXoaHDBan_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.btnXoaHDBan);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnUpdateHDBan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 686);
            this.panel4.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(2, 180);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 38);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Quản Lý Hóa Đơn Bán";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLCHApple_GUI.Properties.Resources.apple_logo_PNG19679;
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txtTongTien);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.btnCTHDBan);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.lookUpEdit_TenKH);
            this.groupControl2.Controls.Add(this.lookUpEdit_TenNV);
            this.groupControl2.Controls.Add(this.txtMaHDB);
            this.groupControl2.Controls.Add(this.dtNgayBan);
            this.groupControl2.Location = new System.Drawing.Point(189, 46);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(700, 169);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Thông Tin Hóa Đơn Bán";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(406, 32);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTongTien.Properties.DisplayFormat.FormatString = "c0";
            this.txtTongTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTongTien.Properties.EditFormat.FormatString = "c0";
            this.txtTongTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTongTien.Size = new System.Drawing.Size(191, 24);
            this.txtTongTien.TabIndex = 27;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(51, 61);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 18);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Ngày Bán";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(333, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 18);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Tổng Tiền";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(110, 18);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "Tên Khách Hàng";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 18);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Tên Nhân Viên";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(33, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 18);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Mã Hóa Đơn";
            // 
            // lookUpEdit_TenKH
            // 
            this.lookUpEdit_TenKH.Location = new System.Drawing.Point(121, 119);
            this.lookUpEdit_TenKH.Name = "lookUpEdit_TenKH";
            this.lookUpEdit_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit_TenKH.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_TenKH.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit_TenKH.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit_TenKH.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit_TenKH.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lookUpEdit_TenKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_TenKH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenKH", "Tên Khách Hàng")});
            this.lookUpEdit_TenKH.Properties.DisplayMember = "strHoTenKH";
            this.lookUpEdit_TenKH.Properties.NullText = "Tên Khách Hàng";
            this.lookUpEdit_TenKH.Properties.ValueMember = "strMaKH";
            this.lookUpEdit_TenKH.Size = new System.Drawing.Size(192, 24);
            this.lookUpEdit_TenKH.TabIndex = 21;
            // 
            // lookUpEdit_TenNV
            // 
            this.lookUpEdit_TenNV.Location = new System.Drawing.Point(121, 89);
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
            this.lookUpEdit_TenNV.Properties.NullText = "Tên Nhân Viên";
            this.lookUpEdit_TenNV.Properties.ValueMember = "strMaNV";
            this.lookUpEdit_TenNV.Size = new System.Drawing.Size(192, 24);
            this.lookUpEdit_TenNV.TabIndex = 20;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(121, 29);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDB.Properties.Appearance.Options.UseFont = true;
            this.txtMaHDB.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHDB.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtMaHDB.Size = new System.Drawing.Size(192, 24);
            this.txtMaHDB.TabIndex = 19;
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.EditValue = null;
            this.dtNgayBan.Location = new System.Drawing.Point(121, 59);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dtNgayBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayBan.Properties.Appearance.Options.UseBackColor = true;
            this.dtNgayBan.Properties.Appearance.Options.UseFont = true;
            this.dtNgayBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayBan.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtNgayBan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayBan.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtNgayBan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayBan.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtNgayBan.Size = new System.Drawing.Size(191, 24);
            this.dtNgayBan.TabIndex = 18;
            // 
            // frmQLHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1252, 725);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDSHoaDon);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_gvColMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_TenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayBan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcDSHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSHoaDon;
        private DevExpress.XtraEditors.DateEdit dtFromDate;
        private DevExpress.XtraEditors.DateEdit dtToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDB;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_gvColMaNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_gvColMaKH;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraEditors.SimpleButton btnCTHDBan;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnUpdateHDBan;
        private DevExpress.XtraEditors.SimpleButton btnXoaHDBan;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_TenNV;
        private DevExpress.XtraEditors.TextEdit txtMaHDB;
        private DevExpress.XtraEditors.DateEdit dtNgayBan;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_TenKH;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.SimpleButton btnTatCaHoaDon;
    }
}