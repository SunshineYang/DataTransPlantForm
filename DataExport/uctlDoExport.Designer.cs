namespace DataExport
{
    partial class uctlDoExport
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_sta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dt_end = new DevExpress.XtraEditors.DateEdit();
            this.cmb_pt = new System.Windows.Forms.ComboBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.gc_patients = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sfd_save = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_inhospital = new System.Windows.Forms.RadioButton();
            this.rb_outhospital = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_end.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_patients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(235, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "开始日期：";
            // 
            // dt_sta
            // 
            this.dt_sta.EditValue = null;
            this.dt_sta.Location = new System.Drawing.Point(301, 36);
            this.dt_sta.Name = "dt_sta";
            this.dt_sta.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_sta.Properties.Appearance.Options.UseFont = true;
            this.dt_sta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_sta.Properties.DisplayFormat.FormatString = "G";
            this.dt_sta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_sta.Properties.Mask.EditMask = "G";
            this.dt_sta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dt_sta.Size = new System.Drawing.Size(175, 23);
            this.dt_sta.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(482, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "结束日期：";
            // 
            // dt_end
            // 
            this.dt_end.EditValue = null;
            this.dt_end.Location = new System.Drawing.Point(548, 36);
            this.dt_end.Name = "dt_end";
            this.dt_end.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_end.Properties.Appearance.Options.UseFont = true;
            this.dt_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_end.Properties.DisplayFormat.FormatString = "G";
            this.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_end.Properties.Mask.EditMask = "G";
            this.dt_end.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dt_end.Size = new System.Drawing.Size(167, 23);
            this.dt_end.TabIndex = 3;
            // 
            // cmb_pt
            // 
            this.cmb_pt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_pt.FormattingEnabled = true;
            this.cmb_pt.Location = new System.Drawing.Point(64, 6);
            this.cmb_pt.Name = "cmb_pt";
            this.cmb_pt.Size = new System.Drawing.Size(416, 25);
            this.cmb_pt.TabIndex = 0;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.Location = new System.Drawing.Point(721, 33);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(90, 28);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "查询";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gc_patients
            // 
            this.gc_patients.EmbeddedNavigator.Name = "";
            this.gc_patients.Location = new System.Drawing.Point(8, 67);
            this.gc_patients.MainView = this.gridView1;
            this.gc_patients.Name = "gc_patients";
            this.gc_patients.Size = new System.Drawing.Size(534, 619);
            this.gc_patients.TabIndex = 0;
            this.gc_patients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gc_patients;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "病人ID";
            this.gridColumn1.FieldName = "PATIENT_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 95;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "入院次数";
            this.gridColumn2.FieldName = "VISIT_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 67;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "病人姓名";
            this.gridColumn3.FieldName = "NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 125;
            // 
            // sfd_save
            // 
            this.sfd_save.Filter = "所有文件|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "平台名:";
            // 
            // rb_inhospital
            // 
            this.rb_inhospital.AutoSize = true;
            this.rb_inhospital.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_inhospital.Location = new System.Drawing.Point(75, 37);
            this.rb_inhospital.Name = "rb_inhospital";
            this.rb_inhospital.Size = new System.Drawing.Size(74, 21);
            this.rb_inhospital.TabIndex = 5;
            this.rb_inhospital.Text = "入院时间";
            this.rb_inhospital.UseVisualStyleBackColor = true;
            // 
            // rb_outhospital
            // 
            this.rb_outhospital.AutoSize = true;
            this.rb_outhospital.Checked = true;
            this.rb_outhospital.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_outhospital.Location = new System.Drawing.Point(155, 37);
            this.rb_outhospital.Name = "rb_outhospital";
            this.rb_outhospital.Size = new System.Drawing.Size(74, 21);
            this.rb_outhospital.TabIndex = 6;
            this.rb_outhospital.TabStop = true;
            this.rb_outhospital.Text = "出院时间";
            this.rb_outhospital.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "时间过滤:";
            // 
            // btn_done
            // 
            this.btn_done.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_done.Location = new System.Drawing.Point(818, 33);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(90, 28);
            this.btn_done.TabIndex = 8;
            this.btn_done.Text = "导出";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // uctlDoExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_outhospital);
            this.Controls.Add(this.rb_inhospital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gc_patients);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dt_sta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.cmb_pt);
            this.Name = "uctlDoExport";
            this.Size = new System.Drawing.Size(1011, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dt_sta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_sta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_end.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_patients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_end;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dt_sta;
        private DevExpress.XtraGrid.GridControl gc_patients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ComboBox cmb_pt;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.SaveFileDialog sfd_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_inhospital;
        private System.Windows.Forms.RadioButton rb_outhospital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_done;
    }
}
