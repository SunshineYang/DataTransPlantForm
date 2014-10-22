namespace ConfirmFileName
{
    partial class CompareFieldName
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
            this.rtb_sql = new System.Windows.Forms.RichTextBox();
            this.bnt_exe = new System.Windows.Forms.Button();
            this.gc_fieldlist = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_comparelist = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ptname = new System.Windows.Forms.ComboBox();
            this.cmb_tablename = new System.Windows.Forms.ComboBox();
            this.btn_savesql = new System.Windows.Forms.Button();
            this.btn_delsql = new System.Windows.Forms.Button();
            this.gc_sql = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_field = new DevExpress.XtraTab.XtraTabControl();
            this.tp1 = new DevExpress.XtraTab.XtraTabPage();
            this.tp2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.gc_monitor = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_temp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gc_fieldlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_comparelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_sql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tc_field)).BeginInit();
            this.tc_field.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_sql
            // 
            this.rtb_sql.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_sql.Location = new System.Drawing.Point(10, 65);
            this.rtb_sql.Name = "rtb_sql";
            this.rtb_sql.Size = new System.Drawing.Size(602, 191);
            this.rtb_sql.TabIndex = 0;
            this.rtb_sql.Text = "";
            // 
            // bnt_exe
            // 
            this.bnt_exe.AutoSize = true;
            this.bnt_exe.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bnt_exe.ForeColor = System.Drawing.Color.Black;
            this.bnt_exe.Location = new System.Drawing.Point(618, 65);
            this.bnt_exe.Name = "bnt_exe";
            this.bnt_exe.Size = new System.Drawing.Size(90, 28);
            this.bnt_exe.TabIndex = 1;
            this.bnt_exe.Text = "执行SQL";
            this.bnt_exe.UseVisualStyleBackColor = true;
            this.bnt_exe.Click += new System.EventHandler(this.bnt_exe_Click);
            // 
            // gc_fieldlist
            // 
            this.gc_fieldlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_fieldlist.EmbeddedNavigator.Name = "";
            this.gc_fieldlist.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gc_fieldlist.Location = new System.Drawing.Point(0, 0);
            this.gc_fieldlist.MainView = this.gridView2;
            this.gc_fieldlist.Name = "gc_fieldlist";
            this.gc_fieldlist.Size = new System.Drawing.Size(504, 392);
            this.gc_fieldlist.TabIndex = 3;
            this.gc_fieldlist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gc_fieldlist.DoubleClick += new System.EventHandler(this.gc_fieldlist_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.gridView2.GridControl = this.gc_fieldlist;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowColumnMoving = false;
            this.gridView2.OptionsCustomization.AllowColumnResizing = false;
            this.gridView2.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView2.OptionsFilter.AllowFilterEditor = false;
            this.gridView2.OptionsFilter.AllowMRUFilterList = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "对照名";
            this.gridColumn4.FieldName = "FIELD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gc_comparelist
            // 
            this.gc_comparelist.EmbeddedNavigator.Name = "";
            this.gc_comparelist.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gc_comparelist.Location = new System.Drawing.Point(11, 262);
            this.gc_comparelist.MainView = this.gridView3;
            this.gc_comparelist.Name = "gc_comparelist";
            this.gc_comparelist.Size = new System.Drawing.Size(482, 427);
            this.gc_comparelist.TabIndex = 4;
            this.gc_comparelist.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gc_comparelist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gc_comparelist_MouseDown);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView3.GridControl = this.gc_comparelist;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsCustomization.AllowColumnMoving = false;
            this.gridView3.OptionsCustomization.AllowFilter = false;
            this.gridView3.OptionsCustomization.AllowGroup = false;
            this.gridView3.OptionsCustomization.AllowSort = false;
            this.gridView3.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView3.OptionsFilter.AllowFilterEditor = false;
            this.gridView3.OptionsFilter.AllowMRUFilterList = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "字段名";
            this.gridColumn1.FieldName = "FIELD_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "字段";
            this.gridColumn2.FieldName = "FIELD";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "对照名";
            this.gridColumn3.FieldName = "COMPARE_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(618, 179);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 28);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "对照字段";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " 平台名:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = " 表   名:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ptname
            // 
            this.cmb_ptname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ptname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_ptname.FormattingEnabled = true;
            this.cmb_ptname.Location = new System.Drawing.Point(64, 6);
            this.cmb_ptname.Name = "cmb_ptname";
            this.cmb_ptname.Size = new System.Drawing.Size(416, 25);
            this.cmb_ptname.TabIndex = 0;
            this.cmb_ptname.SelectedIndexChanged += new System.EventHandler(this.cmb_ptname_SelectedIndexChanged);
            // 
            // cmb_tablename
            // 
            this.cmb_tablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tablename.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_tablename.FormattingEnabled = true;
            this.cmb_tablename.Location = new System.Drawing.Point(64, 35);
            this.cmb_tablename.Name = "cmb_tablename";
            this.cmb_tablename.Size = new System.Drawing.Size(416, 25);
            this.cmb_tablename.TabIndex = 1;
            this.cmb_tablename.SelectedIndexChanged += new System.EventHandler(this.cmb_tablename_SelectedIndexChanged);
            // 
            // btn_savesql
            // 
            this.btn_savesql.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_savesql.Location = new System.Drawing.Point(618, 103);
            this.btn_savesql.Name = "btn_savesql";
            this.btn_savesql.Size = new System.Drawing.Size(90, 28);
            this.btn_savesql.TabIndex = 9;
            this.btn_savesql.Text = "保存sql";
            this.btn_savesql.UseVisualStyleBackColor = true;
            this.btn_savesql.Click += new System.EventHandler(this.btn_savesql_Click);
            // 
            // btn_delsql
            // 
            this.btn_delsql.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delsql.Location = new System.Drawing.Point(618, 141);
            this.btn_delsql.Name = "btn_delsql";
            this.btn_delsql.Size = new System.Drawing.Size(90, 28);
            this.btn_delsql.TabIndex = 10;
            this.btn_delsql.Text = "删除sql";
            this.btn_delsql.UseVisualStyleBackColor = true;
            this.btn_delsql.Click += new System.EventHandler(this.btn_delsql_Click);
            // 
            // gc_sql
            // 
            this.gc_sql.EmbeddedNavigator.Name = "";
            this.gc_sql.Location = new System.Drawing.Point(716, 65);
            this.gc_sql.MainView = this.gridView5;
            this.gc_sql.Name = "gc_sql";
            this.gc_sql.Size = new System.Drawing.Size(296, 191);
            this.gc_sql.TabIndex = 0;
            this.gc_sql.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView5.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView5.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView5.Appearance.Row.Options.UseFont = true;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6});
            this.gridView5.GridControl = this.gc_sql;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsCustomization.AllowFilter = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.DoubleClick += new System.EventHandler(this.gridView5_DoubleClick);
            this.gridView5.Click += new System.EventHandler(this.gridView5_Click);
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.Caption = "SQL名称";
            this.gridColumn6.FieldName = "SQL_NAME";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowMove = false;
            this.gridColumn6.OptionsColumn.AllowSize = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // tc_field
            // 
            this.tc_field.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tc_field.Location = new System.Drawing.Point(498, 262);
            this.tc_field.Name = "tc_field";
            this.tc_field.SelectedTabPage = this.tp1;
            this.tc_field.Size = new System.Drawing.Size(513, 430);
            this.tc_field.TabIndex = 4;
            this.tc_field.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp1,
            this.tp2});
            this.tc_field.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tc_field_SelectedPageChanged);
            // 
            // tp1
            // 
            this.tp1.Appearance.Header.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp1.Appearance.Header.Options.UseFont = true;
            this.tp1.Controls.Add(this.gc_fieldlist);
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(504, 392);
            this.tp1.Text = "表 字 段";
            // 
            // tp2
            // 
            this.tp2.Appearance.Header.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp2.Appearance.Header.Options.UseFont = true;
            this.tp2.Controls.Add(this.splitContainer5);
            this.tp2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(504, 392);
            this.tp2.Text = "模板字段";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.gc_monitor);
            this.splitContainer5.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.gc_temp);
            this.splitContainer5.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer5.Size = new System.Drawing.Size(504, 392);
            this.splitContainer5.SplitterDistance = 126;
            this.splitContainer5.TabIndex = 1;
            // 
            // gc_monitor
            // 
            this.gc_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_monitor.EmbeddedNavigator.Name = "";
            this.gc_monitor.Location = new System.Drawing.Point(0, 0);
            this.gc_monitor.MainView = this.gridView4;
            this.gc_monitor.Name = "gc_monitor";
            this.gc_monitor.Size = new System.Drawing.Size(126, 392);
            this.gc_monitor.TabIndex = 0;
            this.gc_monitor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gridView4.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView4.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView4.Appearance.Row.Options.UseFont = true;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5});
            this.gridView4.GridControl = this.gc_monitor;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsCustomization.AllowColumnMoving = false;
            this.gridView4.OptionsCustomization.AllowFilter = false;
            this.gridView4.OptionsCustomization.AllowGroup = false;
            this.gridView4.OptionsCustomization.AllowSort = false;
            this.gridView4.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView4.OptionsFilter.AllowFilterEditor = false;
            this.gridView4.OptionsFilter.AllowMRUFilterList = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.Click += new System.EventHandler(this.gridView4_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.Caption = "监控代码";
            this.gridColumn5.FieldName = "CLASS_NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gc_temp
            // 
            this.gc_temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_temp.EmbeddedNavigator.Name = "";
            this.gc_temp.Location = new System.Drawing.Point(0, 0);
            this.gc_temp.MainView = this.gridView1;
            this.gc_temp.Name = "gc_temp";
            this.gc_temp.Size = new System.Drawing.Size(374, 392);
            this.gc_temp.TabIndex = 0;
            this.gc_temp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gc_temp.DoubleClick += new System.EventHandler(this.gc_temp_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gc_temp;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(618, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "撤销";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 21);
            this.textBox1.TabIndex = 2;
            // 
            // CompareFieldName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gc_sql);
            this.Controls.Add(this.bnt_exe);
            this.Controls.Add(this.btn_savesql);
            this.Controls.Add(this.rtb_sql);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delsql);
            this.Controls.Add(this.cmb_ptname);
            this.Controls.Add(this.cmb_tablename);
            this.Controls.Add(this.gc_comparelist);
            this.Controls.Add(this.tc_field);
            this.Name = "CompareFieldName";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1018, 692);
            ((System.ComponentModel.ISupportInitialize)(this.gc_fieldlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_comparelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_sql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tc_field)).EndInit();
            this.tc_field.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_sql;
        private System.Windows.Forms.Button bnt_exe;
        private DevExpress.XtraGrid.GridControl gc_fieldlist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gc_comparelist;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_ptname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tablename;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraTab.XtraTabControl tc_field;
        private DevExpress.XtraTab.XtraTabPage tp1;
        private DevExpress.XtraTab.XtraTabPage tp2;
        private DevExpress.XtraGrid.GridControl gc_temp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private DevExpress.XtraGrid.GridControl gc_monitor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Button btn_savesql;
        private System.Windows.Forms.Button btn_delsql;
        private DevExpress.XtraGrid.GridControl gc_sql;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.TextBox textBox1;
    }
}
