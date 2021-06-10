namespace QLCHApple_GUI
{
    partial class frmQLLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLoaiSP));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefresh = new DevExpress.XtraEditors.LabelControl();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaLoaiSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaLoaiSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiSP = new DevExpress.XtraEditors.SimpleButton();
            this.lblHienThi = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLuuLoaiSP = new DevExpress.XtraEditors.SimpleButton();
            this.grpTTLoaiSP = new DevExpress.XtraEditors.GroupControl();
            this.txtTenLoaiSP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLoaiSP = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gcDSLoaiSP = new DevExpress.XtraGrid.GridControl();
            this.gvDSLoaiSP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLoaiMaModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiSP)).BeginInit();
            this.grpTTLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiSP.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLoaiSP)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(909, 39);
            this.panel2.TabIndex = 12;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRefresh.Appearance.Image = global::QLCHApple_GUI.Properties.Resources.refresh;
            this.lblRefresh.Appearance.Options.UseFont = true;
            this.lblRefresh.Appearance.Options.UseImage = true;
            this.lblRefresh.AppearanceHovered.Image = global::QLCHApple_GUI.Properties.Resources.refresh___hover;
            this.lblRefresh.AppearanceHovered.Options.UseHoverImage = true;
            this.lblRefresh.AppearanceHovered.Options.UseImage = true;
            this.lblRefresh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRefresh.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRefresh.Location = new System.Drawing.Point(834, 0);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(75, 39);
            this.lblRefresh.TabIndex = 16;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(102)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnXoaLoaiSP);
            this.panel1.Controls.Add(this.btnSuaLoaiSP);
            this.panel1.Controls.Add(this.btnThemLoaiSP);
            this.panel1.Controls.Add(this.lblHienThi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 482);
            this.panel1.TabIndex = 13;
            // 
            // btnXoaLoaiSP
            // 
            this.btnXoaLoaiSP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaLoaiSP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaLoaiSP.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiSP.Appearance.Options.UseBackColor = true;
            this.btnXoaLoaiSP.Appearance.Options.UseFont = true;
            this.btnXoaLoaiSP.Appearance.Options.UseForeColor = true;
            this.btnXoaLoaiSP.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaLoaiSP.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnXoaLoaiSP.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaLoaiSP.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoaLoaiSP.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoaLoaiSP.AppearanceHovered.Options.UseFont = true;
            this.btnXoaLoaiSP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaLoaiSP.Location = new System.Drawing.Point(0, 298);
            this.btnXoaLoaiSP.Name = "btnXoaLoaiSP";
            this.btnXoaLoaiSP.Size = new System.Drawing.Size(180, 55);
            this.btnXoaLoaiSP.TabIndex = 26;
            this.btnXoaLoaiSP.TabStop = false;
            this.btnXoaLoaiSP.Text = "Xóa";
            this.btnXoaLoaiSP.Click += new System.EventHandler(this.btnXoaLoaiSP_Click);
            // 
            // btnSuaLoaiSP
            // 
            this.btnSuaLoaiSP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLoaiSP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiSP.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSuaLoaiSP.Appearance.Options.UseBackColor = true;
            this.btnSuaLoaiSP.Appearance.Options.UseFont = true;
            this.btnSuaLoaiSP.Appearance.Options.UseForeColor = true;
            this.btnSuaLoaiSP.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLoaiSP.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnSuaLoaiSP.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaLoaiSP.AppearanceHovered.Options.UseBackColor = true;
            this.btnSuaLoaiSP.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSuaLoaiSP.AppearanceHovered.Options.UseFont = true;
            this.btnSuaLoaiSP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaLoaiSP.Location = new System.Drawing.Point(0, 370);
            this.btnSuaLoaiSP.Name = "btnSuaLoaiSP";
            this.btnSuaLoaiSP.Size = new System.Drawing.Size(180, 57);
            this.btnSuaLoaiSP.TabIndex = 25;
            this.btnSuaLoaiSP.TabStop = false;
            this.btnSuaLoaiSP.Text = "Sửa";
            this.btnSuaLoaiSP.Click += new System.EventHandler(this.btnSuaLoaiSP_Click);
            // 
            // btnThemLoaiSP
            // 
            this.btnThemLoaiSP.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThemLoaiSP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiSP.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiSP.Appearance.Options.UseBackColor = true;
            this.btnThemLoaiSP.Appearance.Options.UseFont = true;
            this.btnThemLoaiSP.Appearance.Options.UseForeColor = true;
            this.btnThemLoaiSP.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemLoaiSP.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnThemLoaiSP.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemLoaiSP.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemLoaiSP.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThemLoaiSP.AppearanceHovered.Options.UseFont = true;
            this.btnThemLoaiSP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemLoaiSP.Location = new System.Drawing.Point(0, 228);
            this.btnThemLoaiSP.Name = "btnThemLoaiSP";
            this.btnThemLoaiSP.Size = new System.Drawing.Size(180, 55);
            this.btnThemLoaiSP.TabIndex = 24;
            this.btnThemLoaiSP.TabStop = false;
            this.btnThemLoaiSP.Text = "Thêm";
            this.btnThemLoaiSP.Click += new System.EventHandler(this.btnThemLoaiSP_Click);
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
            this.lblHienThi.TabIndex = 17;
            this.lblHienThi.Text = "Quản Lý \r\nLoại Sản Phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCHApple_GUI.Properties.Resources.icons8_Product_100px_1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnLuuLoaiSP
            // 
            this.btnLuuLoaiSP.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(102)))), ((int)(((byte)(62)))));
            this.btnLuuLoaiSP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLoaiSP.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuuLoaiSP.Appearance.Options.UseBackColor = true;
            this.btnLuuLoaiSP.Appearance.Options.UseFont = true;
            this.btnLuuLoaiSP.Appearance.Options.UseForeColor = true;
            this.btnLuuLoaiSP.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuLoaiSP.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.btnLuuLoaiSP.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuLoaiSP.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuuLoaiSP.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLuuLoaiSP.AppearanceHovered.Options.UseFont = true;
            this.btnLuuLoaiSP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuuLoaiSP.Location = new System.Drawing.Point(282, 90);
            this.btnLuuLoaiSP.Name = "btnLuuLoaiSP";
            this.btnLuuLoaiSP.Size = new System.Drawing.Size(150, 45);
            this.btnLuuLoaiSP.TabIndex = 27;
            this.btnLuuLoaiSP.TabStop = false;
            this.btnLuuLoaiSP.Text = "Lưu";
            this.btnLuuLoaiSP.Click += new System.EventHandler(this.btnLuuLoaiSP_Click);
            // 
            // grpTTLoaiSP
            // 
            this.grpTTLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTTLoaiSP.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTLoaiSP.AppearanceCaption.Options.UseFont = true;
            this.grpTTLoaiSP.Controls.Add(this.btnLuuLoaiSP);
            this.grpTTLoaiSP.Controls.Add(this.txtTenLoaiSP);
            this.grpTTLoaiSP.Controls.Add(this.labelControl8);
            this.grpTTLoaiSP.Controls.Add(this.labelControl1);
            this.grpTTLoaiSP.Controls.Add(this.txtMaLoaiSP);
            this.grpTTLoaiSP.Location = new System.Drawing.Point(9, 6);
            this.grpTTLoaiSP.Name = "grpTTLoaiSP";
            this.grpTTLoaiSP.Size = new System.Drawing.Size(711, 144);
            this.grpTTLoaiSP.TabIndex = 14;
            this.grpTTLoaiSP.Text = "Thông Tin Chi Tiết Loại Sản Phẩm";
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Location = new System.Drawing.Point(503, 60);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.txtTenLoaiSP.Size = new System.Drawing.Size(169, 24);
            this.txtTenLoaiSP.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(370, 63);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(127, 18);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Tên Loại Sản Phẩm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Loại Sản Phẩm";
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(151, 60);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.txtMaLoaiSP.Size = new System.Drawing.Size(169, 24);
            this.txtMaLoaiSP.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gcDSLoaiSP);
            this.panel3.Controls.Add(this.grpTTLoaiSP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(729, 482);
            this.panel3.TabIndex = 10;
            // 
            // gcDSLoaiSP
            // 
            this.gcDSLoaiSP.Location = new System.Drawing.Point(9, 156);
            this.gcDSLoaiSP.MainView = this.gvDSLoaiSP;
            this.gcDSLoaiSP.Name = "gcDSLoaiSP";
            this.gcDSLoaiSP.Size = new System.Drawing.Size(711, 314);
            this.gcDSLoaiSP.TabIndex = 15;
            this.gcDSLoaiSP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLoaiSP});
            // 
            // gvDSLoaiSP
            // 
            this.gvDSLoaiSP.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSLoaiSP.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSLoaiSP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSLoaiSP.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSLoaiSP.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSLoaiSP.Appearance.OddRow.Options.UseFont = true;
            this.gvDSLoaiSP.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvDSLoaiSP.Appearance.Row.Options.UseFont = true;
            this.gvDSLoaiSP.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSLoaiSP.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSLoaiSP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLoaiMaModel,
            this.colTenLoaiModel});
            this.gvDSLoaiSP.GridControl = this.gcDSLoaiSP;
            this.gvDSLoaiSP.Name = "gvDSLoaiSP";
            this.gvDSLoaiSP.OptionsBehavior.Editable = false;
            this.gvDSLoaiSP.OptionsSelection.MultiSelect = true;
            this.gvDSLoaiSP.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSLoaiSP.OptionsView.ShowAutoFilterRow = true;
            this.gvDSLoaiSP.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvDSLoaiSP.OptionsView.ShowGroupPanel = false;
            this.gvDSLoaiSP.OptionsView.ShowIndicator = false;
            this.gvDSLoaiSP.OptionsView.ShowViewCaption = true;
            this.gvDSLoaiSP.ViewCaption = "Danh Sách Loại Sản Phẩm";
            this.gvDSLoaiSP.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDSLoaiSP_SelectionChanged);
            // 
            // colLoaiMaModel
            // 
            this.colLoaiMaModel.Caption = "Mã Loại Sản Phẩm";
            this.colLoaiMaModel.FieldName = "strMaLoaiSP";
            this.colLoaiMaModel.Name = "colLoaiMaModel";
            this.colLoaiMaModel.Visible = true;
            this.colLoaiMaModel.VisibleIndex = 0;
            // 
            // colTenLoaiModel
            // 
            this.colTenLoaiModel.Caption = "Tên Loại Sản Phẩm";
            this.colTenLoaiModel.FieldName = "strTenLoaiSP";
            this.colTenLoaiModel.Name = "colTenLoaiModel";
            this.colTenLoaiModel.Visible = true;
            this.colTenLoaiModel.VisibleIndex = 1;
            // 
            // frmQLLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLLoaiSP";
            this.Load += new System.EventHandler(this.frmQLLoaiSP_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTTLoaiSP)).EndInit();
            this.grpTTLoaiSP.ResumeLayout(false);
            this.grpTTLoaiSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoaiSP.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblHienThi;
        private DevExpress.XtraEditors.SimpleButton btnLuuLoaiSP;
        private DevExpress.XtraEditors.SimpleButton btnXoaLoaiSP;
        private DevExpress.XtraEditors.SimpleButton btnSuaLoaiSP;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiSP;
        private DevExpress.XtraEditors.GroupControl grpTTLoaiSP;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiSP;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaLoaiSP;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gcDSLoaiSP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLoaiSP;
        private DevExpress.XtraEditors.LabelControl lblRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiMaModel;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiModel;
    }
}