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
            //MessageBox.Show("��ʼ����...");
            DALUse.SetConnectString(ConfigurationManager.AppSettings["ClientConnectType"], ConfigurationManager.ConnectionStrings["SQLSERVER"].ToString());
            //MessageBox.Show("�������...");
            clsPublicProperty.DATABASETYPE = s1;
        }

        private void �ֶζ���¼��ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddFildName afn = new AddFildName();
            CommonFunction.AddForm3(pl_showcontains,afn);
           
        }

        private void �ֶζ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompareFieldName cfn = new CompareFieldName();
            //CommonFunction.AddForm2(cfn);
            CommonFunction.AddForm3(pl_showcontains,cfn);
        }


        private void ���ݵ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlDataImport id = new uctlDataImport();
            //CommonFunction.AddForm2(id);
            CommonFunction.AddForm3(pl_showcontains,id);
        }

        private void �ֵ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uctlDetailComparisonDict dcd = new uctlDetailComparisonDict();
            //CommonFunction.AddForm2(dcd);
            CommonFunction.AddForm3(pl_showcontains,dcd);
        }

        private void ��ʽת��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form f = new Form();
            //f.WindowState = FormWindowState.Maximized;
            uctlDataExchange de = new uctlDataExchange();
            CommonFunction.AddForm2(de);
            //CommonFunction.AddForm(f, de);
            //CommonFunction.AddTabControl(tabControl1, "��ʽת��", de);
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uctlBaseConfig bc = new uctlBaseConfig();
            //CommonFunction.AddForm2(bc);
            CommonFunction.AddForm3(pl_showcontains,bc);
        }

        private void ƽ̨����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlPTManage ptm = new uctlPTManage();
            //CommonFunction.AddForm2(ptm);
            CommonFunction.AddForm3(pl_showcontains,ptm);
        }

        private void xML����ToolStripMenuItem_Click(object sender, EventArgs e)
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
        //    //CommonFunction.AddTabControl(tabControl1, "�ֶζ���", afn);
        //}

        //private void �ر�ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CommonFunction.dicpage.Remove(this.tabControl1.SelectedTab.Text);
        //    tabControl1.Controls.RemoveAt(this.tabControl1.SelectedIndex);
          
        //}

       

        //private void tabControl1_DoubleClick(object sender, EventArgs e)
        //{
        //    CommonFunction.dicpage.Remove(this.tabControl1.SelectedTab.Text);
        //    tabControl1.Controls.RemoveAt(this.tabControl1.SelectedIndex);
        //}

        private void ���ݹ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctlDataFilter df = new uctlDataFilter();
            //CommonFunction.AddForm2(df);
            CommonFunction.AddForm3(pl_showcontains,df);
        }

        private void ���ݵ���ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uctlDoExport de = new uctlDoExport();
            //CommonFunction.AddForm2(de);
            CommonFunction.AddForm3(pl_showcontains,de);
        }

        private void ���������ݿ�����ToolStripMenuItem_Click(object sender, EventArgs e)
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