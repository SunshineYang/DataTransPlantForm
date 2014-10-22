namespace DataExport
{
    partial class uctlBaseConfig
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
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_pt = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_servertime = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_dbfpath = new System.Windows.Forms.TextBox();
            this.btn_testconn = new System.Windows.Forms.Button();
            this.txt_UPDATE_TIME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_STORAGE_LOCATION = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ORGANIZATION_PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Organization_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PLATFORM_ADDRESS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_logonname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_ORGANIZATION_NAME = new System.Windows.Forms.TextBox();
            this.ofd_path = new System.Windows.Forms.OpenFileDialog();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_connstr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_type.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(391, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(391, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "HH:mm";
            // 
            // cmb_pt
            // 
            this.cmb_pt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_pt.FormattingEnabled = true;
            this.cmb_pt.Location = new System.Drawing.Point(110, 6);
            this.cmb_pt.Name = "cmb_pt";
            this.cmb_pt.Size = new System.Drawing.Size(375, 25);
            this.cmb_pt.TabIndex = 0;
            this.cmb_pt.SelectedIndexChanged += new System.EventHandler(this.cmb_pt_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(391, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_del.Location = new System.Drawing.Point(393, 469);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(90, 28);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "清空";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_servertime
            // 
            this.txt_servertime.Enabled = false;
            this.txt_servertime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_servertime.Location = new System.Drawing.Point(110, 435);
            this.txt_servertime.Name = "txt_servertime";
            this.txt_servertime.Size = new System.Drawing.Size(375, 23);
            this.txt_servertime.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(254, 469);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 28);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_dbfpath
            // 
            this.txt_dbfpath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_dbfpath.Location = new System.Drawing.Point(110, 400);
            this.txt_dbfpath.Name = "txt_dbfpath";
            this.txt_dbfpath.Size = new System.Drawing.Size(275, 23);
            this.txt_dbfpath.TabIndex = 2;
            // 
            // btn_testconn
            // 
            this.btn_testconn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_testconn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_testconn.Location = new System.Drawing.Point(110, 469);
            this.btn_testconn.Name = "btn_testconn";
            this.btn_testconn.Size = new System.Drawing.Size(90, 28);
            this.btn_testconn.TabIndex = 1;
            this.btn_testconn.Text = "测试连接";
            this.btn_testconn.UseVisualStyleBackColor = true;
            // 
            // txt_UPDATE_TIME
            // 
            this.txt_UPDATE_TIME.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UPDATE_TIME.Location = new System.Drawing.Point(110, 365);
            this.txt_UPDATE_TIME.Name = "txt_UPDATE_TIME";
            this.txt_UPDATE_TIME.Size = new System.Drawing.Size(275, 23);
            this.txt_UPDATE_TIME.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "平台名:";
            // 
            // txt_STORAGE_LOCATION
            // 
            this.txt_STORAGE_LOCATION.Enabled = false;
            this.txt_STORAGE_LOCATION.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_STORAGE_LOCATION.Location = new System.Drawing.Point(110, 330);
            this.txt_STORAGE_LOCATION.Name = "txt_STORAGE_LOCATION";
            this.txt_STORAGE_LOCATION.Size = new System.Drawing.Size(275, 23);
            this.txt_STORAGE_LOCATION.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "导出数据类型：";
            // 
            // txt_ORGANIZATION_PASSWORD
            // 
            this.txt_ORGANIZATION_PASSWORD.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ORGANIZATION_PASSWORD.Location = new System.Drawing.Point(110, 295);
            this.txt_ORGANIZATION_PASSWORD.Name = "txt_ORGANIZATION_PASSWORD";
            this.txt_ORGANIZATION_PASSWORD.Size = new System.Drawing.Size(373, 23);
            this.txt_ORGANIZATION_PASSWORD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "平台默认网址：";
            // 
            // txt_Organization_code
            // 
            this.txt_Organization_code.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Organization_code.Location = new System.Drawing.Point(110, 256);
            this.txt_Organization_code.Name = "txt_Organization_code";
            this.txt_Organization_code.Size = new System.Drawing.Size(375, 23);
            this.txt_Organization_code.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "平台登录名：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(10, 438);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "服务器时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "平台登陆密码：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(10, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "DBF路径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "医疗机构名称：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(10, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "执行时间：";
            // 
            // cmb_type
            // 
            this.cmb_type.Location = new System.Drawing.Point(110, 42);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_type.Properties.Appearance.Options.UseFont = true;
            this.cmb_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_type.Properties.Items.AddRange(new object[] {
            "XML",
            "EXCEL",
            "PDF",
            "导入到数据库"});
            this.cmb_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_type.Size = new System.Drawing.Size(375, 23);
            this.cmb_type.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "保存路径：";
            // 
            // txt_PLATFORM_ADDRESS
            // 
            this.txt_PLATFORM_ADDRESS.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_PLATFORM_ADDRESS.Location = new System.Drawing.Point(110, 112);
            this.txt_PLATFORM_ADDRESS.Name = "txt_PLATFORM_ADDRESS";
            this.txt_PLATFORM_ADDRESS.Size = new System.Drawing.Size(375, 23);
            this.txt_PLATFORM_ADDRESS.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(10, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "医院秘钥：";
            // 
            // txt_logonname
            // 
            this.txt_logonname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_logonname.Location = new System.Drawing.Point(110, 147);
            this.txt_logonname.Name = "txt_logonname";
            this.txt_logonname.Size = new System.Drawing.Size(375, 23);
            this.txt_logonname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "医疗机构代码：";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(110, 182);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(375, 23);
            this.txt_password.TabIndex = 3;
            // 
            // txt_ORGANIZATION_NAME
            // 
            this.txt_ORGANIZATION_NAME.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ORGANIZATION_NAME.Location = new System.Drawing.Point(110, 217);
            this.txt_ORGANIZATION_NAME.Name = "txt_ORGANIZATION_NAME";
            this.txt_ORGANIZATION_NAME.Size = new System.Drawing.Size(375, 23);
            this.txt_ORGANIZATION_NAME.TabIndex = 3;
            // 
            // ofd_path
            // 
            this.ofd_path.FileName = "openFileDialog1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "数据库连接串：";
            // 
            // txt_connstr
            // 
            this.txt_connstr.Enabled = false;
            this.txt_connstr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_connstr.Location = new System.Drawing.Point(110, 77);
            this.txt_connstr.Name = "txt_connstr";
            this.txt_connstr.Size = new System.Drawing.Size(375, 23);
            this.txt_connstr.TabIndex = 3;
            // 
            // uctlBaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmb_pt);
            this.Controls.Add(this.txt_ORGANIZATION_NAME);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_servertime);
            this.Controls.Add(this.txt_logonname);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_dbfpath);
            this.Controls.Add(this.txt_connstr);
            this.Controls.Add(this.txt_PLATFORM_ADDRESS);
            this.Controls.Add(this.btn_testconn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_UPDATE_TIME);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_STORAGE_LOCATION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_ORGANIZATION_PASSWORD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_Organization_code);
            this.Controls.Add(this.label2);
            this.Name = "uctlBaseConfig";
            this.Size = new System.Drawing.Size(1018, 692);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_type.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_logonname;
        private System.Windows.Forms.TextBox txt_PLATFORM_ADDRESS;
        private System.Windows.Forms.TextBox txt_ORGANIZATION_PASSWORD;
        private System.Windows.Forms.TextBox txt_Organization_code;
        private System.Windows.Forms.TextBox txt_ORGANIZATION_NAME;
        private System.Windows.Forms.TextBox txt_STORAGE_LOCATION;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_servertime;
        private System.Windows.Forms.TextBox txt_dbfpath;
        private System.Windows.Forms.TextBox txt_UPDATE_TIME;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog ofd_path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_testconn;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_type;
        private System.Windows.Forms.ComboBox cmb_pt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txt_connstr;
    }
}
