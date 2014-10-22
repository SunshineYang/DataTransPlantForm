using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using System.Threading;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace ToolFunction
{
    public class CommonFunction
    {
        #region ����
        private DataSet myDs = new DataSet();
        private static string excelstring = "Provider=Microsoft.Ace.OleDb.12.0;data source='{0}';Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
        private Thread t = null;
        public static string ErrorLogPath = null;
        public static Dictionary<string, TabPage> dicpage = new Dictionary<string, TabPage>();
        #endregion

        #region ���캯��
        public CommonFunction()
        {

        }
        #endregion

        #region ��������������string����
        //        public static strng SetKey()
        //        {
        //            DateTime currentTime = DateTime.Now;
        //            string strtime = currentTime.Minute.ToString() + ":"
        //                              + currentTime.Second.ToString() + ":"
        //                              + currentTime.Millisecond.ToString();
        //            return int.p
        //strtime;
        //        }
        #endregion

        #region ������־
        /// <summary>
        /// ͳһ��������־������Ժ�Ͳ���ÿ��������дtry...catch�ˣ�Ŀǰ����Ҫ��ȡ����ֵ�ķ���֧�ֻ�������
        /// </summary>
        /// <param name="obj">������</param>
        /// <param name="mymethod">������</param>
        /// <param name="param">���������б�</param>
        public static void WriteErrorLog(Object obj, string mymethod, object[] param)
        {
            try
            {
                Type t = obj.GetType();
                MethodInfo mi = t.GetMethod(mymethod);
                mi.Invoke(obj, param);
            }
            catch (Exception ex)
            {
                StreamWriter sw = new StreamWriter(@"D:\ErrorLog.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + "-----------------------------\n");
                sw.WriteLine(ex.ToString());
                sw.Close();
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// ��FileStreamд�ļ�
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static void FileStreamWriteFile(string str)
        {
            byte[] byData;
            //char[] charData;
            try
            {
                FileStream nFile = new FileStream(Application.StartupPath + @"\ErrorLog.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite);
                ////����ַ�����
                //charData = str.ToCharArray();
                ////��ʼ���ֽ�����
                //byData = new byte[charData.Length];
                //���ַ�����ת��Ϊ��ȷ���ֽڸ�ʽ
                //Encoder enc = Encoding.UTF8.GetEncoder();
                //enc.GetBytes(charData, 0, charData.Length, byData, 0, true);
                //nFile.Seek(0, SeekOrigin.Begin);
                byData = Encoding.UTF8.GetBytes(str);
                nFile.Write(byData, 0, 1000);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void WriteErrotLog(string mess)
        {
            //StreamWriter sw = null;
            try
            {
                //System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath + @"\ErrorLog.txt", System.IO.FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite);
                ////fs.write
                //using (StreamWriter sw = new StreamWriter(fs))
                //{
                //sw = new StreamWriter(Application.StartupPath + @"\ErrorLog.txt", true);
                //sw.WriteLine(DateTime.Now.ToString() + "-----------------------------\n");
                //sw.WriteLine(mess);
                //sw.Flush();
                //sw.Close();
                //sw.Dispose();
                //}

                //FileStreamWriteFile(mess);
            }
            catch (Exception)
            {
                //if (sw != null)
                //{
                //    sw.Close();
                //}
                throw;
            }

        }
        #endregion

        #region ������usercontrol�İ�
        /// <summary>
        /// �򵥵Ĵ������á���Ϊÿ����ʾ����Ĵ��붼��һ���ġ�
        /// </summary>
        /// <param name="f">��������</param>
        /// <param name="uc">��������</param>
        public static DialogResult AddForm(Form f, UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            f.StartPosition = FormStartPosition.CenterParent;
            //f.TopMost = true;
            f.Controls.Add(uc);
            return f.ShowDialog();
        }

        public static void AddForm2(UserControl uc)
        {
            Form f = new Form();
            //f.TopMost = true;
            f.Size = new Size(1024, 730);
            f.StartPosition = FormStartPosition.Manual;
            f.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            f.ShowDialog();
        }
        /// <summary>
        /// ��panel��������ӿؼ�
        /// </summary>
        /// <param name="p">����panel</param>
        /// <param name="uc">��ʾ��usercontrol</param>
        public static void AddForm3(Panel p, UserControl uc)
        {
            p.Controls.Clear();
            p.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;

        }
        #endregion

        #region �ȴ�����
        /// <summary>
        /// ��tabcontrol���翨Ƭ��
        /// </summary>
        /// <param name="tc">ָ����tabcontrol</param>
        public static void AddTabControl(TabControl tc, string title, Control c)
        {
            if (dicpage.ContainsKey(title))
            {
                tc.SelectTab(title);
                return;
            }
            TabPage tp = new TabPage(title);
            tp.Name = title;
            dicpage.Add(title, tp);
            tp.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            tc.TabPages.Add(dicpage[title]);
            tc.SelectTab(title);           
        }

        /// <summary>
        /// ���ô�����ʽ�������ؼ����뵽������
        /// </summary>
        private static void ShowWaiting()
        {
            Form f = new Form();
            f.TopMost = true;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.Size = new Size(339, 88);
            f.FormBorderStyle = FormBorderStyle.None;
            uctlPleaseWaiting pw = new uctlPleaseWaiting();
            AddForm(f, pw);
        }
        /// <summary>
        /// ����һ���µ��̣߳���������
        /// </summary>
        public void WaitingThreadStart()
        {
            t = new Thread(new ThreadStart(ShowWaiting));
            t.Start();
        }
        /// <summary>
        /// ��ֹ����
        /// </summary>
        public void WaitingThreadStop()
        {
            t.Abort();
        }
        #endregion

        #region EXCEL��datatable�໥ת��
        /// <summary>
        /// �����ݼ�������Ϊexcel
        /// </summary>
        /// <param name="name">����excel������</param>
        /// <param name="ds">�����������ݼ�</param>
        public static void AddExcel(string name, DataTable dt)
        {
            string fileName = name + ".xls";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            int rowIndex = 1;
            int colIndex = 0;
            excel.Application.Workbooks.Add(true);
            foreach (DataColumn col in dt.Columns)
            {
                colIndex++;
                excel.Cells[1, colIndex] = col.ColumnName;
            }

            foreach (DataRow row in dt.Rows)
            {
                rowIndex++;
                colIndex = 0;
                for (colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                {
                    excel.Cells[rowIndex, colIndex + 1] = row[colIndex].ToString();
                }
            }

            excel.Visible = false;
            excel.ActiveWorkbook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel7, null, null, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
            excel.Quit();
            excel = null;
            GC.Collect();//�������� 
        }

        public static void SaveAsExcel(string name, DataTable dt)
        {
            OleDbConnection cnnxls = new OleDbConnection(string.Format(excelstring, name));
            string insertsql = "";
            string insertcolumnstring = "";
            string insertvaluestring = "";
            string fileName = name + ".xls";
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            excel.Application.Workbooks.Add(true);
            int colIndex = 0;
            foreach (DataColumn col in dt.Columns)
            {
                colIndex++;
                excel.Cells[1, colIndex] = col.ColumnName;
                insertcolumnstring += string.Format("{0},", col.ColumnName);
            }
            excel.ActiveWorkbook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel7, null, null, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);

            //������¼  
            //conn.execute(sql);

            insertcolumnstring = insertcolumnstring.Trim(',');
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    row[dc].ToString();
                    insertvaluestring += string.Format("'{0}',", row[dc].ToString().Replace("'", "''"));
                }
                string sql = string.Format("insert into [Sheet1$]({0}) values({1})", insertcolumnstring, insertvaluestring);
                OleDbDataAdapter myDa = new OleDbDataAdapter(sql, cnnxls);
                myDa.InsertCommand.ExecuteNonQuery();
            }
            excel.Visible = false;
            //excel.ActiveWorkbook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel7, null, null, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
            excel.Quit();
            excel = null;
            GC.Collect();//�������� 
        }

        #endregion

        #region XML��dataset�໥ת��
        /// <summary>
        /// ��xml���������ַ���ת��ΪDataSet
        /// </summary>
        /// <param name="xmlData">�ַ���</param>
        /// <returns>����dataset����</returns>
        public static DataSet ConvertXMLToDataSet(string xmlData)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                //��streamװ�ص�XmlTextReader
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }


        /// <summary>
        ///  ��xml�ļ�ת��ΪDataSet
        /// </summary>
        /// <param name="xmlFile">xml�ļ���ַ</param>
        /// <returns>dataset����</returns>
        public static DataSet ConvertXMLFileToDataSet(string xmlFile)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                XmlDocument xmld = new XmlDocument();
                xmld.Load(xmlFile);

                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmld.InnerXml);
                //��streamװ�ص�XmlTextReader
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                //xmlDS.ReadXml(xmlFile);
                return xmlDS;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }


        /// <summary>
        ///  ��DataSetת��Ϊxml�����ַ���
        /// </summary>
        /// <param name="xmlDS">dataset����</param>
        /// <returns>xml�ַ���</returns>
        public static string ConvertDataSetToXML(DataSet xmlDS)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;

            try
            {
                stream = new MemoryStream();
                //��streamװ�ص�XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //��WriteXml����д���ļ�.
                xmlDS.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                UnicodeEncoding utf = new UnicodeEncoding();
                return utf.GetString(arr).Trim();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static void SetXMLValue(string xmlFile)
        {
            //XmlDocument xmld = new XmlDocument();
            //xmld.Load(xmlFile);
            //XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmld.NameTable);
            //XmlNodeList xmln = xmld.SelectNodes(xmlFile, nsmgr);
            //XmlNode newnode = new XmlNode("www");
            //xmln.AppendChild(newnode);
        }

        /// <summary>
        /// �����ݼ�ת��ΪptNameָ���ĸ�ʽ�洢��xmlFile·����
        /// </summary>
        /// <param name="xmlDS">��Ҫת��������</param>
        /// <param name="xmlFile">���·��</param>
        /// <param name="sqlgetlayout">��ȡ��ʽ</param>
        /// <param name="doc">xml�ļ�</param>
        public static System.Collections.Generic.Dictionary<string, XmlElement> ConverDataToXMLFile(XmlDocument doc, DataSet xmlDS, DataTable dtgetlayout)
        {
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "GB2312", null);
            doc.AppendChild(dec);
            Dictionary<string, XmlElement> xmldic = new Dictionary<string, XmlElement>();
            try
            {
                foreach (DataRow drlayout in dtgetlayout.Rows)
                {
                    foreach (DataRow drxml in xmlDS.Tables[0].Rows)
                    {
                        foreach (DataColumn dcxml in xmlDS.Tables[0].Columns)
                        {
                            if (drlayout["field_name"].ToString().Equals(dcxml.ToString()))
                            {
                                XmlElement xe1 = doc.CreateElement((drlayout["field_name"].ToString()));
                                xe1.InnerText = drxml[dcxml].ToString();
                                xmldic.Add(dcxml.ToString(), xe1);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return xmldic;
        }

        public static void ConverDataSetToXMLFile(string strxml, string xmlFile)
        {
            try
            {
                StreamWriter sw = new StreamWriter(xmlFile);
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine(strxml.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// ��xml���ݼ�תת��Ϊxml�ļ�
        /// </summary>
        /// <param name="dsxml">���ݼ�</param>
        /// <param name="xmlFile">·��</param>
        /// <returns>�����ַ���</returns>
        public static string ConverDataSetToXMLFile(DataSet dsxml, string xmlFile)
        {
            try
            {
                StringBuilder strxml = new StringBuilder(ConvertDataSetToXML(dsxml));
                StreamWriter sw = new StreamWriter(xmlFile);
                strxml.Replace("NewDataSet", "��һ��");
                strxml.Replace("ds", "�ڶ���");
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine(strxml.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return "";
        }

        /// <summary>
        /// ��DataSetת��Ϊxml�ļ�
        /// </summary>
        /// <param name="xmlDS">dtaset����</param>
        /// <param name="xmlFile">�ļ����·��</param>
        public static void ConvertDataSetToXMLFile(DataSet xmlDS, string xmlFile)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;

            try
            {
                stream = new MemoryStream();
                //��streamװ�ص�XmlTextReader
                writer = new XmlTextWriter(stream, Encoding.Unicode);

                //��WriteXml����д���ļ�.
                xmlDS.WriteXml(writer);
                int count = (int)stream.Length;
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                stream.Read(arr, 0, count);

                //����Unicode������ı�
                UnicodeEncoding utf = new UnicodeEncoding();
                StreamWriter sw = new StreamWriter(xmlFile);
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine(utf.GetString(arr).Trim());
                sw.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        #endregion

        #region �������ݿ�

        /// <summary>
        /// ִ�в�ѯ����
        /// </summary>
        /// <param name="sql">��ѯsql���</param>
        /// <param name="dictionary">�ֵ����</param>
        /// <param name="tablename">������datatable����</param>
        /// <param name="cmd">cmd</param>
        /// <returns>���ر�</returns>
        static public DataTable ExecuteBySQL(string sql, Dictionary<string, string> dictionary, string tablename)
        {
            OleDbConnection conn = new OleDbConnection(GetConnString());
            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            DataTable table = new DataTable(tablename);
            ChangeSelectCommand(sql, dictionary, ref cmd);
            try
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                conn.Dispose();
                cmd.Dispose();
            }

            return table;
        }

        /// <summary>
        /// ִ������ɾ���Ĳ���
        /// </summary>
        /// <param name="sql">������sql</param>
        /// <param name="dictionary">�ֵ����</param>
        /// <param name="cmd">cmd</param>
        /// <returns>���ؽ��</returns>
        static public int ExecutenonQuery(string sql, Dictionary<string, string> dictionary)
        {
            OleDbConnection conn = new OleDbConnection(GetConnString());
            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            int n = 0;
            ChangeSelectCommand(sql, dictionary, ref cmd);
            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                n = 0;
            }
            finally
            {
                conn.Dispose();
                cmd.Dispose();
            }
            return n;
        }

        private static string GetConnString()
        {
            string strconn = System.Configuration.ConfigurationSettings.AppSettings["StrConn"].ToString();
            return strconn;
        }

        /// <summary>
        /// �滻sql������������cmd��ֵ
        /// </summary>
        /// <param name="sql">sql���</param>
        /// <param name="dictionary">�����ֵ�</param>
        /// <param name="cmd">cmd</param>
        /// <returns>�����Ƿ��滻�����ɹ�</returns>
        static public bool ChangeSelectCommand(string sql, Dictionary<string, string> dictionary, ref OleDbCommand cmd)
        {

            cmd.Parameters.Clear();
            string sqltxt = sql;
            int nIndex = sqltxt.IndexOf('@');
            while (-1 != nIndex)
            {
                if (nIndex > -1)
                {
                    foreach (object obj in dictionary.Keys)
                    {
                        string strParm = "@" + obj.ToString();
                        if (nIndex == sqltxt.IndexOf(strParm, nIndex))
                        {
                            string values;
                            dictionary.TryGetValue(obj.ToString(), out values);
                            cmd.Parameters.Add(nIndex.ToString(), OleDbType.VarChar).Value = values;
                        }
                    }
                }
                if (sqltxt.Length > nIndex)
                {
                    nIndex = sqltxt.IndexOf('@', nIndex + 1);
                }
                else
                    nIndex = -1;
            }
            if (dictionary != null)
            {
                foreach (object obj in dictionary.Keys)
                {
                    string strParm = "@" + obj.ToString();
                    sqltxt = sqltxt.Replace(strParm, "?");
                }
            }
            cmd.CommandText = sqltxt;
            return true;
        }

        #endregion

        #region ����Ƿ�Ϊ��
        public static DataTable CheckNULL(DataTable source)
        {
            if (source == null)
            {
                MessageBox.Show("����ԴΪ��");
                return null;
            }
            else
            {
                return source;
            }
        }
        #endregion
    }
}
