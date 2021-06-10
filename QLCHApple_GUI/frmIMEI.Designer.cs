namespace QLCHApple_GUI
{
    partial class frmIMEI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMEI));
            this.gcDSIMEI = new DevExpress.XtraGrid.GridControl();
            this.gvDSIMEI = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaIMEI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhapSN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuayLai = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSIMEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSIMEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapSN.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCapNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDSIMEI
            // 
            this.gcDSIMEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSIMEI.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcDSIMEI.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcDSIMEI.Location = new System.Drawing.Point(0, 0);
            this.gcDSIMEI.MainView = this.gvDSIMEI;
            this.gcDSIMEI.Name = "gcDSIMEI";
            this.gcDSIMEI.Size = new System.Drawing.Size(327, 342);
            this.gcDSIMEI.TabIndex = 3;
            this.gcDSIMEI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSIMEI});
            this.gcDSIMEI.Load += new System.EventHandler(this.gcSN_Load);
            // 
            // gvDSIMEI
            // 
            this.gvDSIMEI.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDSIMEI.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSIMEI.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDSIMEI.Appearance.EvenRow.Options.UseFont = true;
            this.gvDSIMEI.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSIMEI.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDSIMEI.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDSIMEI.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSIMEI.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDSIMEI.Appearance.OddRow.Options.UseFont = true;
            this.gvDSIMEI.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSIMEI.Appearance.Row.Options.UseFont = true;
            this.gvDSIMEI.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSIMEI.Appearance.TopNewRow.Options.UseFont = true;
            this.gvDSIMEI.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDSIMEI.Appearance.ViewCaption.Options.UseFont = true;
            this.gvDSIMEI.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaIMEI});
            this.gvDSIMEI.GridControl = this.gcDSIMEI;
            this.gvDSIMEI.Name = "gvDSIMEI";
            this.gvDSIMEI.NewItemRowText = "Thêm Mới";
            this.gvDSIMEI.OptionsBehavior.Editable = false;
            this.gvDSIMEI.OptionsSelection.MultiSelect = true;
            this.gvDSIMEI.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDSIMEI.OptionsView.EnableAppearanceOddRow = true;
            this.gvDSIMEI.OptionsView.ShowGroupPanel = false;
            this.gvDSIMEI.OptionsView.ShowViewCaption = true;
            this.gvDSIMEI.ViewCaption = "Danh Sách Mã IMEI";
            this.gvDSIMEI.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvSN_SelectionChanged);
            // 
            // colMaIMEI
            // 
            this.colMaIMEI.Caption = "Mã IMEI";
            this.colMaIMEI.FieldName = "STR_MaIMEI";
            this.colMaIMEI.Name = "colMaIMEI";
            this.colMaIMEI.Visible = true;
            this.colMaIMEI.VisibleIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Appearance.Options.UseBackColor = true;
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Appearance.Options.UseForeColor = true;
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCapNhat.Location = new System.Drawing.Point(10, 47);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(308, 33);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapSN
            // 
            this.txtNhapSN.Location = new System.Drawing.Point(140, 16);
            this.txtNhapSN.Name = "txtNhapSN";
            this.txtNhapSN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSN.Properties.Appearance.Options.UseFont = true;
            this.txtNhapSN.Size = new System.Drawing.Size(178, 24);
            this.txtNhapSN.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Nhập Mã IMEI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblQuayLai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 39);
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
            this.lblQuayLai.Name = "lblQuayLai";
            this.lblQuayLai.Size = new System.Drawing.Size(327, 39);
            this.lblQuayLai.TabIndex = 0;
            this.lblQuayLai.Click += new System.EventHandler(this.lblQuayLai_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcDSIMEI);
            this.panel1.Controls.Add(this.panelCapNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 427);
            this.panel1.TabIndex = 11;
            // 
            // panelCapNhat
            // 
            this.panelCapNhat.Controls.Add(this.txtNhapSN);
            this.panelCapNhat.Controls.Add(this.labelControl1);
            this.panelCapNhat.Controls.Add(this.btnCapNhat);
            this.panelCapNhat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCapNhat.Location = new System.Drawing.Point(0, 342);
            this.panelCapNhat.Name = "panelCapNhat";
            this.panelCapNhat.Size = new System.Drawing.Size(327, 85);
            this.panelCapNhat.TabIndex = 7;
            // 
            // frmIMEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIMEI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeriNumber";
            this.Load += new System.EventHandler(this.frmSuaSN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSIMEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSIMEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapSN.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCapNhat.ResumeLayout(false);
            this.panelCapNhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDSIMEI;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSIMEI;
        private DevExpress.XtraGrid.Columns.GridColumn colMaIMEI;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.TextEdit txtNhapSN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblQuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCapNhat;
    }
}