namespace DataExport
{
    partial class uctlPTManage
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_pt_dict = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ptadd = new System.Windows.Forms.Button();
            this.btn_ptupdate = new System.Windows.Forms.Button();
            this.btn_ptdel = new System.Windows.Forms.Button();
            this.gc_table_dict = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_tableadd = new System.Windows.Forms.Button();
            this.btn_tableupdate = new System.Windows.Forms.Button();
            this.btn_tabledel = new System.Windows.Forms.Button();
            this.btn_cancelexport = new System.Windows.Forms.Button();
            this.btn_accessexport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gc_pt_dict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_table_dict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "是否导出";
            this.gridColumn6.FieldName = "EXPORTFLAG";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 160;
            // 
            // gc_pt_dict
            // 
            this.gc_pt_dict.EmbeddedNavigator.Name = "";
            this.gc_pt_dict.Location = new System.Drawing.Point(6, 7);
            this.gc_pt_dict.MainView = this.gridView1;
            this.gc_pt_dict.Name = "gc_pt_dict";
            this.gc_pt_dict.Size = new System.Drawing.Size(504, 631);
            this.gc_pt_dict.TabIndex = 0;
            this.gc_pt_dict.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn2});
            this.gridView1.GridControl = this.gc_pt_dict;
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
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "平台ID";
            this.gridColumn1.FieldName = "PT_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "平台名";
            this.gridColumn2.FieldName = "PT_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // btn_ptadd
            // 
            this.btn_ptadd.AutoSize = true;
            this.btn_ptadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ptadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ptadd.Location = new System.Drawing.Point(324, 647);
            this.btn_ptadd.Name = "btn_ptadd";
            this.btn_ptadd.Size = new System.Drawing.Size(90, 28);
            this.btn_ptadd.TabIndex = 5;
            this.btn_ptadd.Text = "添加";
            this.btn_ptadd.UseVisualStyleBackColor = true;
            this.btn_ptadd.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_ptupdate
            // 
            this.btn_ptupdate.AutoSize = true;
            this.btn_ptupdate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ptupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ptupdate.Location = new System.Drawing.Point(132, 647);
            this.btn_ptupdate.Name = "btn_ptupdate";
            this.btn_ptupdate.Size = new System.Drawing.Size(90, 28);
            this.btn_ptupdate.TabIndex = 6;
            this.btn_ptupdate.Text = "修改";
            this.btn_ptupdate.UseVisualStyleBackColor = true;
            this.btn_ptupdate.Visible = false;
            this.btn_ptupdate.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_ptdel
            // 
            this.btn_ptdel.AutoSize = true;
            this.btn_ptdel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ptdel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ptdel.Location = new System.Drawing.Point(420, 647);
            this.btn_ptdel.Name = "btn_ptdel";
            this.btn_ptdel.Size = new System.Drawing.Size(90, 28);
            this.btn_ptdel.TabIndex = 7;
            this.btn_ptdel.Text = "删除";
            this.btn_ptdel.UseVisualStyleBackColor = true;
            this.btn_ptdel.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // gc_table_dict
            // 
            this.gc_table_dict.EmbeddedNavigator.Name = "";
            this.gc_table_dict.Location = new System.Drawing.Point(516, 6);
            this.gc_table_dict.MainView = this.gridView2;
            this.gc_table_dict.Name = "gc_table_dict";
            this.gc_table_dict.Size = new System.Drawing.Size(496, 633);
            this.gc_table_dict.TabIndex = 0;
            this.gc_table_dict.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gridColumn6;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "FALSE";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.gridColumn6;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "TRUE";
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView2.GridControl = this.gc_table_dict;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowColumnMoving = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsCustomization.AllowSort = false;
            this.gridView2.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView2.OptionsFilter.AllowFilterEditor = false;
            this.gridView2.OptionsFilter.AllowMRUFilterList = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "平台ID";
            this.gridColumn3.FieldName = "PT_ID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Width = 109;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "表名";
            this.gridColumn4.FieldName = "TABLE_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 206;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // btn_tableadd
            // 
            this.btn_tableadd.AutoSize = true;
            this.btn_tableadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tableadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tableadd.Location = new System.Drawing.Point(821, 647);
            this.btn_tableadd.Name = "btn_tableadd";
            this.btn_tableadd.Size = new System.Drawing.Size(90, 28);
            this.btn_tableadd.TabIndex = 5;
            this.btn_tableadd.Text = "添加";
            this.btn_tableadd.UseVisualStyleBackColor = true;
            this.btn_tableadd.Click += new System.EventHandler(this.btn_tableadd_Click);
            // 
            // btn_tableupdate
            // 
            this.btn_tableupdate.AutoSize = true;
            this.btn_tableupdate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tableupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tableupdate.Location = new System.Drawing.Point(516, 651);
            this.btn_tableupdate.Name = "btn_tableupdate";
            this.btn_tableupdate.Size = new System.Drawing.Size(90, 28);
            this.btn_tableupdate.TabIndex = 7;
            this.btn_tableupdate.Text = "修改";
            this.btn_tableupdate.UseVisualStyleBackColor = true;
            this.btn_tableupdate.Visible = false;
            this.btn_tableupdate.Click += new System.EventHandler(this.btn_tableupdate_Click);
            // 
            // btn_tabledel
            // 
            this.btn_tabledel.AutoSize = true;
            this.btn_tabledel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tabledel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tabledel.Location = new System.Drawing.Point(918, 647);
            this.btn_tabledel.Name = "btn_tabledel";
            this.btn_tabledel.Size = new System.Drawing.Size(90, 28);
            this.btn_tabledel.TabIndex = 6;
            this.btn_tabledel.Text = "删除";
            this.btn_tabledel.UseVisualStyleBackColor = true;
            this.btn_tabledel.Click += new System.EventHandler(this.btn_tabledel_Click);
            // 
            // btn_cancelexport
            // 
            this.btn_cancelexport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancelexport.Location = new System.Drawing.Point(724, 647);
            this.btn_cancelexport.Name = "btn_cancelexport";
            this.btn_cancelexport.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelexport.TabIndex = 8;
            this.btn_cancelexport.Text = "禁止导出";
            this.btn_cancelexport.UseVisualStyleBackColor = true;
            this.btn_cancelexport.Click += new System.EventHandler(this.btn_cancelexport_Click);
            // 
            // btn_accessexport
            // 
            this.btn_accessexport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_accessexport.Location = new System.Drawing.Point(627, 647);
            this.btn_accessexport.Name = "btn_accessexport";
            this.btn_accessexport.Size = new System.Drawing.Size(90, 28);
            this.btn_accessexport.TabIndex = 9;
            this.btn_accessexport.Text = "允许导出";
            this.btn_accessexport.UseVisualStyleBackColor = true;
            this.btn_accessexport.Click += new System.EventHandler(this.btn_accessexport_Click);
            // 
            // uctlPTManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_accessexport);
            this.Controls.Add(this.btn_cancelexport);
            this.Controls.Add(this.btn_ptdel);
            this.Controls.Add(this.btn_ptupdate);
            this.Controls.Add(this.btn_ptadd);
            this.Controls.Add(this.btn_tabledel);
            this.Controls.Add(this.btn_tableupdate);
            this.Controls.Add(this.btn_tableadd);
            this.Controls.Add(this.gc_table_dict);
            this.Controls.Add(this.gc_pt_dict);
            this.Name = "uctlPTManage";
            this.Size = new System.Drawing.Size(1016, 682);
            ((System.ComponentModel.ISupportInitialize)(this.gc_pt_dict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_table_dict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_pt_dict;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gc_table_dict;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button btn_ptdel;
        private System.Windows.Forms.Button btn_ptupdate;
        private System.Windows.Forms.Button btn_ptadd;
        private System.Windows.Forms.Button btn_tableadd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Button btn_tableupdate;
        private System.Windows.Forms.Button btn_tabledel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Button btn_cancelexport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Button btn_accessexport;
    }
}
