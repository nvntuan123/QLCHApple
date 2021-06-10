namespace QLCHApple_GUI
{
    partial class frmPhanQuyen
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpNguoiSungDung = new DevExpress.XtraEditors.GroupControl();
            this.cmbLoaiNV = new DevExpress.XtraEditors.LookUpEdit();
            this.gcPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Frm = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFull = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Full = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colThem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Them = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colXem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Xem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.chkFull_Them_gvPQ = new DevExpress.XtraEditors.CheckEdit();
            this.chkFull_Xoa_gvPQ = new DevExpress.XtraEditors.CheckEdit();
            this.chkFull_Sua_gvPQ = new DevExpress.XtraEditors.CheckEdit();
            this.chkFull_Xem_gvPQ = new DevExpress.XtraEditors.CheckEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNguoiSungDung)).BeginInit();
            this.grpNguoiSungDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Frm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Them_gvPQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Xoa_gvPQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Sua_gvPQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Xem_gvPQ.Properties)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1031, 39);
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
            this.lblQuayLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuayLai.Location = new System.Drawing.Point(0, 0);
            this.lblQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(1031, 39);
            this.lblQuayLai.TabIndex = 0;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // grpNguoiSungDung
            // 
            this.grpNguoiSungDung.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNguoiSungDung.Appearance.Options.UseFont = true;
            this.grpNguoiSungDung.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNguoiSungDung.AppearanceCaption.Options.UseFont = true;
            this.grpNguoiSungDung.Controls.Add(this.cmbLoaiNV);
            this.grpNguoiSungDung.Location = new System.Drawing.Point(0, 45);
            this.grpNguoiSungDung.Margin = new System.Windows.Forms.Padding(4);
            this.grpNguoiSungDung.Name = "grpNguoiSungDung";
            this.grpNguoiSungDung.Size = new System.Drawing.Size(261, 383);
            this.grpNguoiSungDung.TabIndex = 14;
            this.grpNguoiSungDung.Text = "Người Sử Dụng";
            // 
            // cmbLoaiNV
            // 
            this.cmbLoaiNV.Location = new System.Drawing.Point(6, 39);
            this.cmbLoaiNV.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaiNV.Name = "cmbLoaiNV";
            this.cmbLoaiNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiNV.Properties.Appearance.Options.UseFont = true;
            this.cmbLoaiNV.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiNV.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cmbLoaiNV.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiNV.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmbLoaiNV.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiNV.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.cmbLoaiNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaiNV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenLoaiNV", "Loại Nhân Viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaLoaiNV", "Mã Loại Nhân Viên", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cmbLoaiNV.Properties.NullText = "Loại Nhân Viên";
            this.cmbLoaiNV.Size = new System.Drawing.Size(251, 24);
            this.cmbLoaiNV.TabIndex = 8;
            this.cmbLoaiNV.EditValueChanged += new System.EventHandler(this.cmbLoaiNV_EditValueChanged);
            // 
            // gcPhanQuyen
            // 
            this.gcPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPhanQuyen.Location = new System.Drawing.Point(267, 44);
            this.gcPhanQuyen.MainView = this.gvPhanQuyen;
            this.gcPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.gcPhanQuyen.Name = "gcPhanQuyen";
            this.gcPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_Them,
            this.repositoryItemCheckEdit_Sua,
            this.repositoryItemCheckEdit_Xoa,
            this.repositoryItemCheckEdit_Xem,
            this.repositoryItemLookUpEdit_Frm,
            this.repositoryItemCheckEdit_Full});
            this.gcPhanQuyen.Size = new System.Drawing.Size(762, 383);
            this.gcPhanQuyen.TabIndex = 11;
            this.gcPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanQuyen});
            // 
            // gvPhanQuyen
            // 
            this.gvPhanQuyen.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvPhanQuyen.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPhanQuyen.Appearance.EvenRow.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPhanQuyen.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPhanQuyen.Appearance.OddRow.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.Row.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.TopNewRow.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvPhanQuyen.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvPhanQuyen.Appearance.ViewCaption.Options.UseFont = true;
            this.gvPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiNV,
            this.colChucNang,
            this.colFull,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colXem});
            this.gvPhanQuyen.GridControl = this.gcPhanQuyen;
            this.gvPhanQuyen.Name = "gvPhanQuyen";
            this.gvPhanQuyen.NewItemRowText = "Thêm Mới";
            this.gvPhanQuyen.OptionsSelection.MultiSelect = true;
            this.gvPhanQuyen.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPhanQuyen.OptionsView.EnableAppearanceOddRow = true;
            this.gvPhanQuyen.OptionsView.ShowGroupPanel = false;
            this.gvPhanQuyen.OptionsView.ShowViewCaption = true;
            this.gvPhanQuyen.ViewCaption = "Phân Quyền Nhân Viên";
            this.gvPhanQuyen.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvPhanQuyen_CustomDrawRowIndicator);
            this.gvPhanQuyen.RowCountChanged += new System.EventHandler(this.gvPhanQuyen_RowCountChanged);
            // 
            // colMaLoaiNV
            // 
            this.colMaLoaiNV.Caption = "Mã Loại Nhân Viên";
            this.colMaLoaiNV.FieldName = "strMaLoaiNV";
            this.colMaLoaiNV.Name = "colMaLoaiNV";
            // 
            // colChucNang
            // 
            this.colChucNang.AppearanceCell.Options.UseTextOptions = true;
            this.colChucNang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChucNang.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colChucNang.Caption = "Chức Năng";
            this.colChucNang.ColumnEdit = this.repositoryItemLookUpEdit_Frm;
            this.colChucNang.FieldName = "strMaFrm";
            this.colChucNang.Name = "colChucNang";
            this.colChucNang.OptionsColumn.AllowEdit = false;
            this.colChucNang.Visible = true;
            this.colChucNang.VisibleIndex = 0;
            this.colChucNang.Width = 227;
            // 
            // repositoryItemLookUpEdit_Frm
            // 
            this.repositoryItemLookUpEdit_Frm.AutoHeight = false;
            this.repositoryItemLookUpEdit_Frm.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Frm.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaFrm", "Mã Form"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenFrm", "Chức Năng")});
            this.repositoryItemLookUpEdit_Frm.DisplayMember = "strTenFrm";
            this.repositoryItemLookUpEdit_Frm.Name = "repositoryItemLookUpEdit_Frm";
            this.repositoryItemLookUpEdit_Frm.NullText = "Chức Năng";
            this.repositoryItemLookUpEdit_Frm.ValueMember = "strMaFrm";
            // 
            // colFull
            // 
            this.colFull.Caption = "Full";
            this.colFull.ColumnEdit = this.repositoryItemCheckEdit_Full;
            this.colFull.FieldName = "bFull";
            this.colFull.Name = "colFull";
            // 
            // repositoryItemCheckEdit_Full
            // 
            this.repositoryItemCheckEdit_Full.AutoHeight = false;
            this.repositoryItemCheckEdit_Full.Name = "repositoryItemCheckEdit_Full";
            // 
            // colThem
            // 
            this.colThem.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colThem.AppearanceCell.Options.UseBackColor = true;
            this.colThem.AppearanceHeader.BackColor = System.Drawing.Color.Transparent;
            this.colThem.AppearanceHeader.Options.UseBackColor = true;
            this.colThem.Caption = "Thêm";
            this.colThem.ColumnEdit = this.repositoryItemCheckEdit_Them;
            this.colThem.FieldName = "bThem";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 1;
            this.colThem.Width = 131;
            // 
            // repositoryItemCheckEdit_Them
            // 
            this.repositoryItemCheckEdit_Them.AutoHeight = false;
            this.repositoryItemCheckEdit_Them.Name = "repositoryItemCheckEdit_Them";
            this.repositoryItemCheckEdit_Them.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.repositoryItemCheckEdit_Sua;
            this.colSua.FieldName = "bSua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 3;
            this.colSua.Width = 131;
            // 
            // repositoryItemCheckEdit_Sua
            // 
            this.repositoryItemCheckEdit_Sua.AutoHeight = false;
            this.repositoryItemCheckEdit_Sua.Name = "repositoryItemCheckEdit_Sua";
            this.repositoryItemCheckEdit_Sua.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.ColumnEdit = this.repositoryItemCheckEdit_Xoa;
            this.colXoa.FieldName = "bXoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 2;
            this.colXoa.Width = 131;
            // 
            // repositoryItemCheckEdit_Xoa
            // 
            this.repositoryItemCheckEdit_Xoa.AutoHeight = false;
            this.repositoryItemCheckEdit_Xoa.Name = "repositoryItemCheckEdit_Xoa";
            this.repositoryItemCheckEdit_Xoa.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colXem
            // 
            this.colXem.Caption = "Xem";
            this.colXem.ColumnEdit = this.repositoryItemCheckEdit_Xem;
            this.colXem.FieldName = "bXem";
            this.colXem.Name = "colXem";
            this.colXem.Visible = true;
            this.colXem.VisibleIndex = 4;
            this.colXem.Width = 131;
            // 
            // repositoryItemCheckEdit_Xem
            // 
            this.repositoryItemCheckEdit_Xem.AutoHeight = false;
            this.repositoryItemCheckEdit_Xem.Name = "repositoryItemCheckEdit_Xem";
            this.repositoryItemCheckEdit_Xem.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnLuu.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseFont = true;
            this.btnLuu.BackgroundImage = global::QLCHApple_GUI.Properties.Resources._1825471;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.ImageOptions.Image = global::QLCHApple_GUI.Properties.Resources.checked_user_32;
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuu.Location = new System.Drawing.Point(436, 437);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(163, 46);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // chkFull_Them_gvPQ
            // 
            this.chkFull_Them_gvPQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Them_gvPQ.Location = new System.Drawing.Point(608, 75);
            this.chkFull_Them_gvPQ.Name = "chkFull_Them_gvPQ";
            this.chkFull_Them_gvPQ.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Them_gvPQ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Them_gvPQ.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Them_gvPQ.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Them_gvPQ.Properties.Caption = "";
            this.chkFull_Them_gvPQ.Size = new System.Drawing.Size(21, 19);
            this.chkFull_Them_gvPQ.TabIndex = 16;
            this.chkFull_Them_gvPQ.Visible = false;
            // 
            // chkFull_Xoa_gvPQ
            // 
            this.chkFull_Xoa_gvPQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Xoa_gvPQ.Location = new System.Drawing.Point(736, 76);
            this.chkFull_Xoa_gvPQ.Name = "chkFull_Xoa_gvPQ";
            this.chkFull_Xoa_gvPQ.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Xoa_gvPQ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Xoa_gvPQ.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Xoa_gvPQ.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Xoa_gvPQ.Properties.Caption = "";
            this.chkFull_Xoa_gvPQ.Size = new System.Drawing.Size(24, 19);
            this.chkFull_Xoa_gvPQ.TabIndex = 17;
            this.chkFull_Xoa_gvPQ.Visible = false;
            // 
            // chkFull_Sua_gvPQ
            // 
            this.chkFull_Sua_gvPQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Sua_gvPQ.Location = new System.Drawing.Point(867, 76);
            this.chkFull_Sua_gvPQ.Name = "chkFull_Sua_gvPQ";
            this.chkFull_Sua_gvPQ.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Sua_gvPQ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Sua_gvPQ.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Sua_gvPQ.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Sua_gvPQ.Properties.Caption = "";
            this.chkFull_Sua_gvPQ.Size = new System.Drawing.Size(24, 19);
            this.chkFull_Sua_gvPQ.TabIndex = 18;
            this.chkFull_Sua_gvPQ.Visible = false;
            // 
            // chkFull_Xem_gvPQ
            // 
            this.chkFull_Xem_gvPQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFull_Xem_gvPQ.Location = new System.Drawing.Point(995, 76);
            this.chkFull_Xem_gvPQ.Name = "chkFull_Xem_gvPQ";
            this.chkFull_Xem_gvPQ.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkFull_Xem_gvPQ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkFull_Xem_gvPQ.Properties.Appearance.Options.UseBackColor = true;
            this.chkFull_Xem_gvPQ.Properties.Appearance.Options.UseFont = true;
            this.chkFull_Xem_gvPQ.Properties.Caption = "";
            this.chkFull_Xem_gvPQ.Size = new System.Drawing.Size(24, 19);
            this.chkFull_Xem_gvPQ.TabIndex = 19;
            this.chkFull_Xem_gvPQ.Visible = false;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1031, 491);
            this.Controls.Add(this.chkFull_Xem_gvPQ);
            this.Controls.Add(this.chkFull_Sua_gvPQ);
            this.Controls.Add(this.chkFull_Xoa_gvPQ);
            this.Controls.Add(this.chkFull_Them_gvPQ);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gcPhanQuyen);
            this.Controls.Add(this.grpNguoiSungDung);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNguoiSungDung)).EndInit();
            this.grpNguoiSungDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Frm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Them_gvPQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Xoa_gvPQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Sua_gvPQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFull_Xem_gvPQ.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpNguoiSungDung;
        private DevExpress.XtraEditors.LookUpEdit cmbLoaiNV;
        private DevExpress.XtraGrid.GridControl gcPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colChucNang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Frm;
        private DevExpress.XtraGrid.Columns.GridColumn colFull;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Full;
        private DevExpress.XtraGrid.Columns.GridColumn colThem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Them;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn colXem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Xem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit chkFull_Them_gvPQ;
        private DevExpress.XtraEditors.CheckEdit chkFull_Xoa_gvPQ;
        private DevExpress.XtraEditors.CheckEdit chkFull_Sua_gvPQ;
        private DevExpress.XtraEditors.CheckEdit chkFull_Xem_gvPQ;
    }
}