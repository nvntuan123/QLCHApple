namespace QLCHApple_GUI
{
    partial class frmQLModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLModel));
            this.repositoryItemLookUpEdit_MaModel = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ItemMemoEdit_MoTaModel = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLModel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemModel = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLuuModel = new DevExpress.XtraEditors.SimpleButton();
            this.gcDSModel = new DevExpress.XtraGrid.GridControl();
            this.modelDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDSCTModel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstrMaModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstrTenModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaModel = new DevExpress.XtraEditors.TextEdit();
            this.txtTenModel = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemMemoEdit_MoTaModel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSCTModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenModel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit_MaModel
            // 
            this.repositoryItemLookUpEdit_MaModel.AutoHeight = false;
            this.repositoryItemLookUpEdit_MaModel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_MaModel.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenModel", "Tên Model")});
            this.repositoryItemLookUpEdit_MaModel.DisplayMember = "strTenModel";
            this.repositoryItemLookUpEdit_MaModel.Name = "repositoryItemLookUpEdit_MaModel";
            this.repositoryItemLookUpEdit_MaModel.NullText = "Tên Model";
            this.repositoryItemLookUpEdit_MaModel.ValueMember = "strMaModel";
            // 
            // ItemMemoEdit_MoTaModel
            // 
            this.ItemMemoEdit_MoTaModel.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ItemMemoEdit_MoTaModel.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ItemMemoEdit_MoTaModel.MaxLength = 100000;
            this.ItemMemoEdit_MoTaModel.Name = "ItemMemoEdit_MoTaModel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblRefresh);
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 39);
            this.panel2.TabIndex = 11;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
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
            this.lblRefresh.Location = new System.Drawing.Point(826, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(74, 39);
            this.lblRefresh.TabIndex = 17;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnXoaModel);
            this.panel1.Controls.Add(this.btnSuaLModel);
            this.panel1.Controls.Add(this.btnThemModel);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 461);
            this.panel1.TabIndex = 12;
            // 
            // btnXoaModel
            // 
            this.btnXoaModel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaModel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaModel.Appearance.Options.UseBackColor = true;
            this.btnXoaModel.Appearance.Options.UseFont = true;
            this.btnXoaModel.Appearance.Options.UseForeColor = true;
            this.btnXoaModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaModel.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoaModel.AppearanceHovered.Options.UseFont = true;
            this.btnXoaModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaModel.Location = new System.Drawing.Point(-1, 299);
            this.btnXoaModel.Name = "btnXoaModel";
            this.btnXoaModel.Size = new System.Drawing.Size(185, 55);
            this.btnXoaModel.TabIndex = 30;
            this.btnXoaModel.TabStop = false;
            this.btnXoaModel.Text = "Xóa";
            this.btnXoaModel.Click += new System.EventHandler(this.btnXoaModel_Click);
            // 
            // btnSuaLModel
            // 
            this.btnSuaLModel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLModel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSuaLModel.Appearance.Options.UseBackColor = true;
            this.btnSuaLModel.Appearance.Options.UseFont = true;
            this.btnSuaLModel.Appearance.Options.UseForeColor = true;
            this.btnSuaLModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLModel.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnSuaLModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSuaLModel.AppearanceHovered.Options.UseFont = true;
            this.btnSuaLModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaLModel.Location = new System.Drawing.Point(-1, 366);
            this.btnSuaLModel.Name = "btnSuaLModel";
            this.btnSuaLModel.Size = new System.Drawing.Size(185, 55);
            this.btnSuaLModel.TabIndex = 29;
            this.btnSuaLModel.TabStop = false;
            this.btnSuaLModel.Text = "Sửa";
            this.btnSuaLModel.Click += new System.EventHandler(this.btnSuaLModel_Click);
            // 
            // btnThemModel
            // 
            this.btnThemModel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThemModel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemModel.Appearance.Options.UseBackColor = true;
            this.btnThemModel.Appearance.Options.UseFont = true;
            this.btnThemModel.Appearance.Options.UseForeColor = true;
            this.btnThemModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemModel.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThemModel.AppearanceHovered.Options.UseFont = true;
            this.btnThemModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemModel.Location = new System.Drawing.Point(-1, 233);
            this.btnThemModel.Name = "btnThemModel";
            this.btnThemModel.Size = new System.Drawing.Size(185, 55);
            this.btnThemModel.TabIndex = 28;
            this.btnThemModel.TabStop = false;
            this.btnThemModel.Text = "Thêm";
            this.btnThemModel.Click += new System.EventHandler(this.btnThemModel_Click);
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
            this.lblHienThi.Location = new System.Drawing.Point(13, 161);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(157, 64);
            this.lblHienThi.TabIndex = 18;
            this.lblHienThi.Text = "Cấu Hình\r\nSản Phẩm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLCHApple_GUI.Properties.Resources.rating_1001;
            this.pictureBox2.Location = new System.Drawing.Point(23, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnLuuModel
            // 
            this.btnLuuModel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.btnLuuModel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuModel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuuModel.Appearance.Options.UseBackColor = true;
            this.btnLuuModel.Appearance.Options.UseFont = true;
            this.btnLuuModel.Appearance.Options.UseForeColor = true;
            this.btnLuuModel.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuModel.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuModel.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuModel.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuuModel.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLuuModel.AppearanceHovered.Options.UseFont = true;
            this.btnLuuModel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuuModel.Location = new System.Drawing.Point(278, 85);
            this.btnLuuModel.Name = "btnLuuModel";
            this.btnLuuModel.Size = new System.Drawing.Size(150, 45);
            this.btnLuuModel.TabIndex = 31;
            this.btnLuuModel.TabStop = false;
            this.btnLuuModel.Text = "Lưu";
            this.btnLuuModel.Click += new System.EventHandler(this.btnLuuModel_Click);
            // 
            // gcDSModel
            // 
            this.gcDSModel.DataSource = this.modelDTOBindingSource;
            this.gcDSModel.Location = new System.Drawing.Point(186, 200);
            this.gcDSModel.MainView = this.gvDSCTModel;
            this.gcDSModel.Name = "gcDSModel";
            this.gcDSModel.Size = new System.Drawing.Size(710, 295);
            this.gcDSModel.TabIndex = 16;
            this.gcDSModel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSCTModel});
            // 
            // gvDSCTModel
            // 
            this.gvDSCTModel.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSCTModel.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSCTModel.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSCTModel.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSCTModel.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSCTModel.Appearance.OddRow.Options.UseFont = true;
            this.gvDSCTModel.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSCTModel.Appearance.Row.Options.UseFont = true;
            this.gvDSCTModel.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSCTModel.Appearance.TopNewRow.Options.UseFont = true;
            this.gvDSCTModel.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSCTModel.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSCTModel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstrMaModel,
            this.colstrTenModel,
            this.colbTrangThai});
            this.gvDSCTModel.GridControl = this.gcDSModel;
            this.gvDSCTModel.Name = "gvDSCTModel";
            this.gvDSCTModel.NewItemRowText = "Thêm Mới";
            this.gvDSCTModel.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvDSCTModel.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDSCTModel.OptionsBehavior.Editable = false;
            this.gvDSCTModel.OptionsPrint.EnableAppearanceOddRow = true;
            this.gvDSCTModel.OptionsSelection.MultiSelect = true;
            this.gvDSCTModel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSCTModel.OptionsView.RowAutoHeight = true;
            this.gvDSCTModel.OptionsView.ShowAutoFilterRow = true;
            this.gvDSCTModel.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvDSCTModel.OptionsView.ShowGroupPanel = false;
            this.gvDSCTModel.OptionsView.ShowIndicator = false;
            this.gvDSCTModel.OptionsView.ShowViewCaption = true;
            this.gvDSCTModel.ViewCaption = "Chi Tiết Cấu Hình Sản Phẩm";
            this.gvDSCTModel.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDSCTModel_SelectionChanged);
            // 
            // colstrMaModel
            // 
            this.colstrMaModel.Caption = "Mã Model";
            this.colstrMaModel.FieldName = "strMaModel";
            this.colstrMaModel.Name = "colstrMaModel";
            this.colstrMaModel.Visible = true;
            this.colstrMaModel.VisibleIndex = 0;
            // 
            // colstrTenModel
            // 
            this.colstrTenModel.Caption = "Tên Model";
            this.colstrTenModel.FieldName = "strTenModel";
            this.colstrTenModel.Name = "colstrTenModel";
            this.colstrTenModel.Visible = true;
            this.colstrTenModel.VisibleIndex = 1;
            // 
            // colbTrangThai
            // 
            this.colbTrangThai.Caption = "Trạng Thái";
            this.colbTrangThai.FieldName = "bTrangThai";
            this.colbTrangThai.Name = "colbTrangThai";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtMaModel);
            this.groupControl1.Controls.Add(this.btnLuuModel);
            this.groupControl1.Controls.Add(this.txtTenModel);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Location = new System.Drawing.Point(188, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(708, 144);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtMaModel
            // 
            this.txtMaModel.Location = new System.Drawing.Point(125, 42);
            this.txtMaModel.Name = "txtMaModel";
            this.txtMaModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaModel.Properties.Appearance.Options.UseFont = true;
            this.txtMaModel.Size = new System.Drawing.Size(183, 24);
            this.txtMaModel.TabIndex = 58;
            // 
            // txtTenModel
            // 
            this.txtTenModel.Location = new System.Drawing.Point(474, 42);
            this.txtTenModel.Name = "txtTenModel";
            this.txtTenModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenModel.Properties.Appearance.Options.UseFont = true;
            this.txtTenModel.Size = new System.Drawing.Size(183, 24);
            this.txtTenModel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(42, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mã Model";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(391, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "Tên Model";
            // 
            // frmQLModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDSModel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLModel";
            this.Load += new System.EventHandler(this.frmQLModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_MaModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemMemoEdit_MoTaModel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSCTModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenModel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl gcDSModel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSCTModel;
        private DevExpress.XtraEditors.SimpleButton btnLuuModel;
        private DevExpress.XtraEditors.SimpleButton btnXoaModel;
        private DevExpress.XtraEditors.SimpleButton btnSuaLModel;
        private DevExpress.XtraEditors.SimpleButton btnThemModel;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_MaModel;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit ItemMemoEdit_MoTaModel;
        private DevExpress.XtraEditors.TextEdit txtMaModel;
        private System.Windows.Forms.BindingSource modelDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colstrMaModel;
        private DevExpress.XtraGrid.Columns.GridColumn colstrTenModel;
        private DevExpress.XtraGrid.Columns.GridColumn colbTrangThai;
    }
}