using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using ConfirmFileName;
using JHEMR.EmrSysDAL;
using System.Configuration;
using ToolFunction;


namespace DataExport
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            //string s1 = ConfigurationManager.AppSettings["ClientConnectType"].ToString();
            //string s2 = ConfigurationManager.ConnectionStrings["ORACLE"].ToString();
            //DALUse.SetConnectString(ConfigurationManager.AppSettings["ClientConnectType"], ConfigurationManager.ConnectionStrings["ORACLE"].ToString());
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    CommonFunction.WriteErrotLog(ex.ToString());
            //    MessageBox.Show(ex.ToString());
            //}
            string s1 = ConfigurationManager.AppSettings["ClientConnectType"].ToString();
            //string s2 = ConfigurationManager.ConnectionStrings["SQLSERVER"].ToString();
            //MessageBox.Show("开始连接...");
            DALUse.SetConnectString(ConfigurationManager.AppSettings["ClientConnectType"], ConfigurationManager.ConnectionStrings["SQLSERVER"].ToString());
            //MessageBox.Show("连接完成...");
            clsPublicProperty.DATABASETYPE = s1;
        }

        private void 字段对照录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddFildName afn = new AddFildName();
            CommonFunction.AddForm3(pl_showcontains,afn);
           
        }

        private void 字段对照ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompareFieldName cfn = new CompareFieldName();
            //CommonFunction.AddForm2(cfn);
            CommonFunction.AddForm3(pl_showcontains,cfn);
        }


        private void 数据导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlDataImport id = new uctlDataImport();
            //CommonFunction.AddForm2(id);
            CommonFunction.AddForm3(pl_showcontains,id);
        }

        private void 字典对照ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uctlDetailComparisonDict dcd = new uctlDetailComparisonDict();
            //CommonFunction.AddForm2(dcd);
            CommonFunction.AddForm3(pl_showcontains,dcd);
        }

        private void 格式转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form f = new Form();
            //f.WindowState = FormWindowState.Maximized;
            uctlDataExchange de = new uctlDataExchange();
            CommonFunction.AddForm2(de);
            //CommonFunction.AddForm(f, de);
            //CommonFunction.AddTabControl(tabControl1, "格式转换", de);
        }

        private void 基础配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uctlBaseConfig bc = new uctlBaseConfig();
            //CommonFunction.AddForm2(bc);
            CommonFunction.AddForm3(pl_showcontains,bc);
        }

        private void 平台管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlPTManage ptm = new uctlPTManage();
            //CommonFunction.AddForm2(ptm);
            CommonFunction.AddForm3(pl_showcontains,ptm);
        }

        private void xML配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uctlXMLconfig xc = new uctlXMLconfig();
            //CommonFunction.AddForm2(xc);
            CommonFunction.AddForm3(pl_showcontains,xc);
        }

        //private void uctlIcon21_Click(object sender, EventArgs e)
        //{
        //    Form f = new Form();
        //    f.WindowState = FormWindowState.Maximized;
        //    AddFildName afn = new AddFildName();
        //    CommonFunction.AddForm(f, afn);
        //    //CommonFunction.AddTabControl(tabControl1, "字段对照", afn);
        //}

        //private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CommonFunction.dicpage.Remove(this.tabControl1.SelectedTab.Text);
        //    tabControl1.Controls.RemoveAt(this.tabControl1.SelectedIndex);
          
        //}

       

        //private void tabControl1_DoubleClick(object sender, EventArgs e)
        //{
        //    CommonFunction.dicpage.Remove(this.tabControl1.SelectedTab.Text);
        //    tabControl1.Controls.RemoveAt(this.tabControl1.SelectedIndex);
        //}

        private void 数据过滤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlDataFilter df = new uctlDataFilter();
            //CommonFunction.AddForm2(df);
            CommonFunction.AddForm3(pl_showcontains,df);
        }

        private void 数据导出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uctlDoExport de = new uctlDoExport();
            //CommonFunction.AddForm2(de);
            CommonFunction.AddForm3(pl_showcontains,de);
        }

        private void 导出到数据库配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlUploadDataToDatabase udd = new uctlUploadDataToDatabase();
            //CommonFunction.AddForm2(udd);
            CommonFunction.AddForm3(pl_showcontains,udd);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlPTManage ptm = new uctlPTManage();
            //CommonFunction.AddForm2(ptm);
            CommonFunction.AddForm3(pl_showcontains, ptm);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddFildName afn = new AddFildName();
            CommonFunction.AddForm3(pl_showcontains, afn);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlDataFilter df = new uctlDataFilter();
            //CommonFunction.AddForm2(df);
            CommonFunction.AddForm3(pl_showcontains, df);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CompareFieldName cfn = new CompareFieldName();
            //CommonFunction.AddForm2(cfn);
            CommonFunction.AddForm3(pl_showcontains, cfn);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlBaseConfig bc = new uctlBaseConfig();
            //CommonFunction.AddForm2(bc);
            CommonFunction.AddForm3(pl_showcontains, bc);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlXMLconfig xc = new uctlXMLconfig();
            //CommonFunction.AddForm2(xc);
            CommonFunction.AddForm3(pl_showcontains, xc);
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlUploadDataToDatabase udd = new uctlUploadDataToDatabase();
            //CommonFunction.AddForm2(udd);
            CommonFunction.AddForm3(pl_showcontains, udd);
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlDetailComparisonDict dcd = new uctlDetailComparisonDict();
            //CommonFunction.AddForm2(dcd);
            CommonFunction.AddForm3(pl_showcontains, dcd);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlDataImport id = new uctlDataImport();
            //CommonFunction.AddForm2(id);
            CommonFunction.AddForm3(pl_showcontains, id);
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctlDoExport de = new uctlDoExport();
            //CommonFunction.AddForm2(de);
            CommonFunction.AddForm3(pl_showcontains, de);
        }

      

       
       

    }
}