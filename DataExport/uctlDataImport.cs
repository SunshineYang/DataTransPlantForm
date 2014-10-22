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
                const string helpfile = "���ϵ���ģ��.xls";
                Process.Start(helpfile);
            }
            catch (Exception)
            {
                MessageBox.Show("���ļ�ʧ�ܣ�");
            }
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "F:\\�����ĵ�";
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
                MessageBox.Show("��ѡ���ļ���");
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
                MessageBox.Show("��ѡ��ָ���ļ�");
                return;
            }
            if (gc_excel.DataSource == null)
            {
                MessageBox.Show("���ȵ�����鿴���ݡ�����������ȷ�ԡ�");
                return;
            }
            string tablename = "";
            if (cmb_table_name.Text == "�����ֵ��")
            {
                tablename = "pt_local_dict";
            }
            else if (cmb_table_name.Text == "Ŀ���ֵ��")
            {
                tablename = "PT_COMPARISON_DETAIL_DICT";
            }
            else
            {
                MessageBox.Show("��ѡ�����ı�");
                return;
            }
            if (MessageBox.Show(null, "�ò����������ݵ��뵽ϵͳ���û����ݿ��У���ȷ���Ƿ������", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //if (txtFilePath.Text.Contains("xml"))//��xml�ļ��������ݿ�
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
                string tips = string.Format("������{0}������", ((DataTable)gc_excel.DataSource).Rows.Count);
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
        /// ��xml���ݵ��뵽���ݿ�
        /// </summary>
        private void ImportDataToDataBase(string tablename)
        {
           
            
        }

        public void InsertIntoTable(DataSet ds)
        {
            #region �����ɵ�dataset�������ݿ�
            List<string> sqllist = new List<string>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string sql = "";
                string insertValueString = "";
                string insertColumnString = "";
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    ///��ȡ��Ϣ Ȼ���뵽���ݿ� 
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
        /// ��XML�ַ���ת����DATASET
        /// </summary>
        /// <param name="xmlStr"></param>
        /// <returns></returns>
        public DataSet ConvertToDateSetByXmlString()
        {
            XmlDocument x = new XmlDocument();
            x.Load(txtFilePath.Text);///xml·��  
            string xmlStr = x.InnerXml;
            if (xmlStr.Length > 0)
            {
                StringReader StrStream = null;
                XmlTextReader Xmlrdr = null;
                try
                {
                    DataSet ds = new DataSet();
                    //��ȡ�ַ����е���Ϣ
                    StrStream = new StringReader(xmlStr);
                    //��ȡStrStream�е�����
                    Xmlrdr = new XmlTextReader(StrStream);
                    //ds��ȡXmlrdr�е����� 
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
                    //�ͷ���Դ
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
                x.Load(txtFilePath.Text);///xml·��  

                foreach (XmlNode xn in x.ChildNodes)
                {

                    foreach (XmlNode xn1 in xn.ChildNodes)
                    {
                        string sql = "";
                        string insertValueString = "";
                        string insertColumnString = "";
                        foreach (XmlNode xn2 in xn1.ChildNodes)
                        {
                            ///��ȡ��Ϣ Ȼ���뵽���ݿ� 
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
