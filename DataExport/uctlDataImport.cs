using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ToolFunction;
using System.Diagnostics;
using System.Data.OleDb;
using JHEMR.EmrSysDAL;
using System.Xml;
using System.IO;

namespace DataExport
{
    public partial class uctlDataImport : UserControl
    {
        CommonFunction t = new CommonFunction();
        private DataSet myDs = new DataSet();
        private string excel = "Provider=Microsoft.Ace.OleDb.12.0;data source='{0}';Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
        //private string connectionStringFormat = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = '{0}';Extended Properties=Excel 8.0";
        public uctlDataImport()
        {
            InitializeComponent();
            InitComboxDatasource();
        }
        public void InitComboxDatasource()
        {
            cmb_pt.DataSource = DALUse.Query(clsPublicProperty.sqlGetPT).Tables[0];
            cmb_pt.ValueMember = "pt_id";
            cmb_pt.DisplayMember = "pt_name";
        }
        private void lnkExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                const string helpfile = "资料导入模板.xls";
                Process.Start(helpfile);
            }
            catch (Exception)
            {
                MessageBox.Show("打开文件失败！");
            }
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "F:\\工作文档";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtFilePath.Text = openFileDialog1.FileName;
                this.txt_dict_name.Text = openFileDialog1.SafeFileName.Split('.')[0];
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {

            if (this.txtFilePath.Text == "")
            {
                MessageBox.Show("请选择文件！");
                return;
            }
            if (txtFilePath.Text.ToString().Contains("xml"))
            {
                gridView1.Columns.Clear();
                gc_excel.DataSource = ConvertToDateSetByXmlString().Tables[0];
            }
            else
            {
                string connectString = string.Format(excel, this.txtFilePath.Text);
                try
                {
                    t.WaitingThreadStart();
                    myDs.Tables.Clear();
                    myDs.Clear();
                    OleDbConnection cnnxls = new OleDbConnection(connectString);
                    OleDbDataAdapter myDa = new OleDbDataAdapter("select * from [Sheet1$]", cnnxls);
                    myDa.Fill(myDs, "c");
                    gridView1.Columns.Clear();
                    gc_excel.RefreshDataSource();
                    gc_excel.DataSource = myDs.Tables[0];
                    t.WaitingThreadStop();
                }
                catch (Exception ex)
                {
                    t.WaitingThreadStop();
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        public void InisertIntoDict()
        {
        
        
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (this.txtFilePath.Text == "")
            {
                MessageBox.Show("请选择指定文件");
                return;
            }
            if (gc_excel.DataSource == null)
            {
                MessageBox.Show("请先点击【查看数据】检验数据正确性。");
                return;
            }
            string tablename = "";
            if (cmb_table_name.Text == "本地字典表")
            {
                tablename = "pt_local_dict";
            }
            else if (cmb_table_name.Text == "目标字典表")
            {
                tablename = "PT_COMPARISON_DETAIL_DICT";
            }
            else
            {
                MessageBox.Show("请选择插入的表！");
                return;
            }
            if (MessageBox.Show(null, "该操作将把数据导入到系统的用户数据库中，您确定是否继续？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //if (txtFilePath.Text.Contains("xml"))//将xml文件导入数据库
                //{

                //    InsertIntoTable(ConvertToDateSetByXmlString());
                //}
                //else
                //{
                t.WaitingThreadStart();
                string insertSql = "";
                if (myDs != null && myDs.Tables[0].Rows.Count > 0)
                {
                    string insertColumnString = "pt_id,id,type_name,field_code,field";
                    DataTable dt = myDs.Tables[0];
                    try
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0].ToString() == "")
                            {
                                continue;
                            }
                            string insertValueString = "";
                            insertValueString = "'" + cmb_pt.SelectedValue.ToString() + "','" + Guid.NewGuid().ToString() + "','"+txt_dict_name.Text+"',";
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                insertValueString += string.Format("'{0}',", dr[i].ToString().Replace("'", "''"));
                            }
                            insertValueString = insertValueString.Trim(',');
                            insertSql = string.Format(@"INSERT INTO {0} ({1}) VALUES({2})", tablename, insertColumnString, insertValueString);
                            DALUse.ExecuteSql(insertSql);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
            }
                    t.WaitingThreadStop();
                //}
                    string sqlgetinsertdata = (string.Format("select type_name,field_code,field from {0} where pt_id = '{1}' and type_name = '{2}'", tablename,cmb_pt.SelectedValue.ToString(),txt_dict_name.Text.ToString()));
                DataTable insertdata = DALUse.Query(sqlgetinsertdata).Tables[0];
                gc_database.DataSource = insertdata;
                string tips = string.Format("共导入{0}条数据", ((DataTable)gc_excel.DataSource).Rows.Count);
                MessageBox.Show(tips);
            }
        }

        private bool CheckIsDate(string columnName)
        {
            string str = ",PREPARE_DATE,COPY_DATE,COPY_VALIDITY,BUSINESS_VALIDITY,OPENING_APPROVAL_DATE,OPENING_DATE,EDITTIME,LICENSE_DATE,LICENSE_VALIDITY,TEMP_OPENING_DATE,LICENSE_START_DATE,ADDTIME,EDITTIME,";
            return str.Contains("," + columnName.ToUpper() + ",");
        }

        private bool CheckIsNumeric(string columnName)
        {
            string str = ",FIXED_CAPITAL,REG_CAPITAL,MARGIN,PARK_AREA,PARK_SPACE_NUMBER,";
            return str.Contains("," + columnName.ToUpper() + ",");
        }

        /// <summary>
        /// 将xml数据导入到数据库
        /// </summary>
        private void ImportDataToDataBase(string tablename)
        {
           
            
        }

        public void InsertIntoTable(DataSet ds)
        {
            #region 将生成的dataset存入数据库
            List<string> sqllist = new List<string>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string sql = "";
                string insertValueString = "";
                string insertColumnString = "";
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    ///读取信息 然后导入到数据库 
                    insertValueString += string.Format("'{0}',", dr[dc].ToString());
                    insertColumnString += string.Format("{0},", dc.ToString());
                }
                insertColumnString = insertColumnString.Trim(',');
                insertValueString = insertValueString.Trim(',');
                sql = string.Format(@"insert into {0}({1}) values({2})", txt_dict_name.Text, insertColumnString, insertValueString);
                sqllist.Add(sql);
            }

            try
            {
                DALUse.ExecuteSqlTran(sqllist.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        /// <summary>
        /// 将XML字符串转换成DATASET
        /// </summary>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public DataSet ConvertToDateSetByXmlString()
        {
            XmlDocument x = new XmlDocument();
            x.Load(txtFilePath.Text);///xml路径  
            string xmlStr = x.InnerXml;
            if (xmlStr.Length > 0)
            {
                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try
                {
                    DataSet ds = new DataSet();
                    //读取字符串中的信息
                    StrStream = new StringReader(xmlStr);
                    //获取StrStream中的数据
                    Xmlrdr = new XmlTextReader(StrStream);
                    //ds获取Xmlrdr中的数据 
                    //ds.ReadXmlSchema(Xmlrdr);
                    ds.ReadXml(Xmlrdr);
                    return ds;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    //释放资源
                    if (Xmlrdr != null)
                    {
                        Xmlrdr.Close();
                        StrStream.Close();
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public void EasyReadXML()
        {

        }

        public bool XMLDataImport()
        {

            List<string> sqllist = new List<string>();
            try
            {
                XmlDocument x = new XmlDocument();
                x.Load(txtFilePath.Text);///xml路径  

                foreach (XmlNode xn in x.ChildNodes)
                {

                    foreach (XmlNode xn1 in xn.ChildNodes)
                    {
                        string sql = "";
                        string insertValueString = "";
                        string insertColumnString = "";
                        foreach (XmlNode xn2 in xn1.ChildNodes)
                        {
                            ///读取信息 然后导入到数据库 
                            insertValueString += string.Format("'{0}',", xn2.InnerText.ToString());
                            insertColumnString += string.Format("{0},", xn2.Name.ToString());
                        }
                        insertColumnString = insertColumnString.Trim(',');
                        insertValueString = insertValueString.Trim(',');
                        sql = string.Format(@"insert into {0}({1}) values({2})", txt_dict_name.Text, insertColumnString, insertValueString);
                        sqllist.Add(sql);
                    }

                }
                DALUse.ExecuteSqlTran(sqllist.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
    }
}
