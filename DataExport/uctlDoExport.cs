using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;
using ToolFunction;
using System.IO;
using JHEMR;
using JHEMR.EmrSysCom;
using System.Runtime.InteropServices;
using System.Threading;

namespace DataExport
{
    public partial class uctlDoExport : UserControl
    {
        [DllImport("EMRAssist.dll")]
        private static extern bool SaveFileToFieldElem(string strOpenFileName, string strSaveFileName, int nDocumentMode);

        [DllImport("EMRAssist.dll")]
        private static extern bool GetXmlNodeContent(string strOpenFileName, int nDocumentMode, int nType, string strFindText, short nLayerNo, short nFindType, [Out, MarshalAs(UnmanagedType.LPArray)]char[] strBuff, int nBufSize);//
        DataTable testpat = null;
        DataTable finaldata = new DataTable();
        DataTable Dtexporttables = new DataTable();
        public uctlDoExport()
        {
            InitializeComponent();
            InitComboxDataSource();
            //Dtexporttables = InitData();
        }
        /// <summary>
        /// ��ʼ��������
        /// </summary>
        /// <returns>����һ��datatableΪ����Դ</returns>
        public DataTable InitData()
        {
            string sql = "";// string.Format("select  distinct 0 CHK, t.* from pt_comparison t where pt_id ='{0}' and table_name = '{1}'", CompareFieldName.pt_id, CompareFieldName.table_name);
            return DALUse.Query(sql).Tables[0];
        }

        public void InitComboxDataSource()
        {
            try
            {
                cmb_pt.DataSource = DALUse.Query(clsPublicProperty.sqlGetPT).Tables[0];
                cmb_pt.ValueMember = "pt_id";
                cmb_pt.DisplayMember = "pt_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            #region ��ȡ����discharge_date_time
            string datatype = "";
            if (rb_inhospital.Checked)//��Ժ����
            {
                datatype = "discharge_date_time";
            }
            else if (rb_outhospital.Checked)//��Ժ����
            {
                datatype = "discharge_date_time";
            }
            string sql = string.Format("select m.PATIENT_ID,m.VISIT_ID ,n.NAME from  pat_visit m ,pat_master_index n where {0} >'{1}' and {0}< '{2}' and m.patient_id = n.patient_id", datatype, dt_sta.Text, dt_end.Text);

            try
            {
                testpat = DALUse.Query(sql).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            gc_patients.DataSource = testpat;
            #endregion


            #region ���Բ���
            //DataTable testpat = new DataTable();
            //DataColumn testdc = new DataColumn("PATIENT_ID");
            //testpat.Columns.Add(testdc);
            //DataRow testdr = testpat.NewRow();
            //testpat.Rows.Add(testdr);
            //testdr["PATIENT_ID"] = "134791";

            //DataTable dtestdata = new DataTable();
            //DataColumn d = new DataColumn("PATIENT_ID");
            //DataColumn d1 = new DataColumn("minzu");
            //dtestdata.Columns.Add(d);
            //dtestdata.Columns.Add(d1);

            //DataRow t1 = dtestdata.NewRow();
            //dtestdata.Rows.Add(t1);
            //t1["PATIENT_ID"] = "134791";
            //t1["minzu"] = "��";
            #endregion



        }

        public DataSet ExchangeData(DataSet exportdata)
        {
            uctlDataExchange de = new uctlDataExchange();
            return de.DoExchange(exportdata, cmb_pt.SelectedValue.ToString());
        }
        #region ��ȡģ�����ݲ�����ģ������ת����



        public string getFileName(string patient_id, string monitor_code)
        {
            DataTable dt = null;
            try
            {
                // Dictionary<string, string> dic = new Dictionary<string, string>();
                // dic.Add("patient_id",patient_id);
                // dic.Add("visit_id",visit_id);
                // dic.Add("monitor_code",monitor_code);
                // string sql = "select * from mr_file_index a ,mr_templet_index b where a.mr_code=b.mr_code and b.monitor_code=@monitor_code AND PATIENT_ID=@patient_id and VISIT_ID = @visit_id";
                //dt = CommonFunction.ExecuteBySQL(sql,dic,"filename");
                string sql = string.Format("select * from mr_file_index a ,mr_templet_index b where a.mr_code=b.mr_code and b.monitor_code='{0}' AND PATIENT_ID='{1}'", monitor_code, patient_id);
                dt = DALUse.Query(sql).Tables[0];
                if (dt == null)
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            if (dt.Rows.Count != 1)
            {
                return "";
            }
            else
            {
                return dt.Rows[0]["FILE_NAME"].ToString();
            }
        }

        /// <summary>
        /// �������ݼ�ת������  
        /// </summary>
        /// <param name="dt">�����б�</param>
        /// <returns>��ѯ���Ĳ�����Ϣ����</returns>
        public DataTable GetDataFromTemplet(DataTable dt)
        {
            //DataTable dttemplet = DALUse.Query(string.Format("select * from pt_comparison t where pt_id = '{0}' and sourcetype='templet'", cmb_pt.SelectedValue.ToString())).Tables[0];
            //DataTable dttempletfield = DALUse.Query(string.Format("select * from pt_temp_field where pt_id = '{0}'", cmb_pt.SelectedValue.ToString())).Tables[0];
            //DataTable dtdata = new DataTable();//���ص�dataset
            //foreach (DataRow drtemp in dttemplet.Rows)
            //{
            //    DataColumn dc = new DataColumn(drtemp["field"].ToString());
            //    dtdata.Columns.Add(dc);//������
            //}
            //foreach (DataRow dr in dt.Rows)
            //{
            //    DataRow drtempdata = dtdata.NewRow();
            //    foreach (DataRow drtemp in dttempletfield.Rows)
            //    {
            //        short cengci_code = 0;
            //        if (drtemp["SOURCETYPE"].ToString() == "0")
            //        {
            //            cengci_code = short.Parse(drtemp["CENGCI_CODE"].ToString());
            //        }
            //        string result = ExportFile.GetXmlNodeStr("fileroot/"+getFileName(dr["PATIENT_ID"].ToString(), drtemp["ITEM_CODE"].ToString()), drtemp["FIELD_NAME"].ToString(), cengci_code);
            //        drtempdata[drtemp["field"].ToString()] = result;//�е�ÿ��cell��ֵ
            //    }
            //    dtdata.Rows.Add(drtempdata);
            //}
            //return dtdata;

            //�ӷ�������ȡ�ļ�·��
            string serverfilepath = DALUse.Query("select * from mr_work_path").Tables[0].Rows[0]["MR_PATH"].ToString();//������Ŀ¼��ַ
            string targetfileroot = Application.StartupPath + "\\mr_file";//�����ļ�Ŀ¼��ַ
            DataTable dttempletfield = DALUse.Query(string.Format("select * from pt_temp_field where pt_id = '{0}'", cmb_pt.SelectedValue.ToString())).Tables[0];
            DataTable dtdata = new DataTable();//���ص�dataset
            foreach (DataRow drtemp in dttempletfield.Rows)
            {
                DataColumn dc = new DataColumn(drtemp["FIELD_NAME"].ToString());
                dtdata.Columns.Add(dc);//������
            }
            foreach (DataRow drpat in dt.Rows)
            {
                DataRow drtempdata = dtdata.NewRow();
                string fileroot = clsExportFile.genMrPaths(drpat["PATIENT_ID"].ToString());//���˲����ļ��ṹĿ¼
                foreach (DataRow drtemp in dttempletfield.Rows)
                {
                    string findtxt = getFileName(drpat["PATIENT_ID"].ToString(), drtemp["ITEM_CODE"].ToString());
                    string apath = serverfilepath + "\\" + fileroot + findtxt;
                    string bpath = targetfileroot + "\\" + findtxt;
                    clsExportFile.CopyFile(apath, bpath);//���������ļ����Ƶ�����
                    short cengci_code = 0;
                    if (drtemp["SOURCETYPE"].ToString() == "0")//��κ�ȡֵ
                    {
                        cengci_code = short.Parse(drtemp["CENGCI_CODE"].ToString());
                        string result = clsExportFile.GetXmlNodeStr(bpath, drtemp["FIELD_NAME"].ToString(), cengci_code);
                        drtempdata[drtemp["FIELD_NAME"].ToString()] = result.Trim('\0');//�е�ÿ��cell��ֵ
                    }
                }
                dtdata.Rows.Add(drtempdata);
            }
            return dtdata;
        }
        #endregion

       
        #region �����ݿ��ģ��ȡ����
        private void btn_done_Click(object sender, EventArgs e)
        {
           
            DataSet exportdata = new DataSet();
            if (cmb_pt.SelectedItem == null)
            {
                return;
            }
            DataTable sqls = DALUse.Query(string.Format("select * from pt_sql where pt_id = '{0}'", cmb_pt.SelectedValue.ToString())).Tables[0];
            string serverfilepath = DALUse.Query("select * from mr_work_path").Tables[0].Rows[0]["MR_PATH"].ToString();//������Ŀ¼��ַ
            string targetfileroot = Application.StartupPath + "\\mr_file";//�����ļ�Ŀ¼��ַ
            DataTable dttempletfield = DALUse.Query(string.Format("select * from pt_temp_field where pt_id = '{0}'", cmb_pt.SelectedValue.ToString())).Tables[0];
            DataTable dttempdata = new DataTable("ģ�����ݼ���");//���ص�datatable
            foreach (DataRow drtemp in dttempletfield.Rows)
            {
                DataColumn dc = new DataColumn(drtemp["FIELD_NAME"].ToString());
                dttempdata.Columns.Add(dc);//������
            }
            if (testpat.Rows.Count != 0 && sqls.Rows.Count != 0)
            {
                foreach (DataRow drpat in testpat.Rows)
                {
                    #region ģ��
                    //DataRow drtempdata = dttempdata.NewRow();
                    //string fileroot = ExportFile.genMrPaths(drpat["PATIENT_ID"].ToString());//���˲����ļ��ṹĿ¼
                    //foreach (DataRow drtemp in dttempletfield.Rows)
                    //{
                    //    string findtxt = getFileName(drpat["PATIENT_ID"].ToString(), drtemp["ITEM_CODE"].ToString());
                    //    string apath = serverfilepath + "\\" + fileroot + findtxt;
                    //    string bpath = targetfileroot + "\\" + findtxt;
                    //    ExportFile.CopyFile(apath, bpath);//���������ļ����Ƶ�����
                    //    short cengci_code = 0;
                    //    if (drtemp["SOURCETYPE"].ToString() == "0")//��κ�ȡֵ
                    //    {
                    //        cengci_code = short.Parse(drtemp["CENGCI_CODE"].ToString());
                    //        string result = ExportFile.GetXmlNodeStr(bpath, drtemp["FIELD_NAME"].ToString(), cengci_code);
                    //        drtempdata[drtemp["FIELD_NAME"].ToString()] = result.Trim('\0');//�е�ÿ��cell��ֵ
                    //    }
                    //}
                    //dttempdata.Rows.Add(drtempdata);
                    //exportdata.Tables.Add(dttempdata.Copy());
                    #endregion

                    #region ���ݿ�
                    foreach (DataRow dr in sqls.Rows)
                    {
                        string sqldatabase = string.Format(dr["sql"].ToString().Replace("@PATIENT_ID",drpat["PATIENT_ID"].ToString()).Replace("@VISIT_ID",drpat["VISIT_ID"].ToString()));
                        string tablename = dr["SQL_NAME"].ToString();
                        DataTable dtdatabasedata = new DataTable();
                        dtdatabasedata = DALUse.Query(sqldatabase).Tables[0];
                        //dtdatabasedata.TableName = tablename;
                        dtdatabasedata.TableName = drpat["PATIENT_ID"].ToString() + "/" + drpat["VISIT_ID"].ToString();
                        exportdata.Tables.Add(dtdatabasedata.Copy());
                    }
                    #endregion
                }
            }
            DataSet dsexchanged = ExchangeData(exportdata);
            DataTable finaldatacolumns = DALUse.Query(string.Format("SELECT FIELD FROM PT_TARGET_FIELD WHERE TABLE_NAME = (SELECT TABLE_NAME FROM PT_TABLES_DICT WHERE EXPORTFLAG = 'TRUE' AND PT_ID = '{0}') AND PT_ID = '{0}'", cmb_pt.SelectedValue.ToString())).Tables[0];
            foreach (DataRow drcolumns in finaldatacolumns.Rows)
            {
                DataColumn dcfinal = new DataColumn(drcolumns["FIELD"].ToString());
                finaldata.Columns.Add(dcfinal);
            }
            if (dsexchanged.Tables.Count == 0)
            {
                return;
            }
            finaldata = dsexchanged.Tables[0].Copy();
            string sqlgetexporttype = string.Format("select * from pt_setting where pt_id = '{0}'", cmb_pt.SelectedValue.ToString());//������������
            string exporttype = DALUse.Query(sqlgetexporttype).Tables[0].Rows[0]["EXPORTFILETYPE"].ToString();
            if (exporttype == "EXCEL")
            {

            }
            else if (exporttype == "XML")
            {
                if (sfd_save.ShowDialog(this) == DialogResult.OK)
                {
                    //ConvertDataToXML.DoConvert(finaldata,cmb_pt.SelectedValue.ToString(), sfd_save.FileName);
                    clsConvertDataToXML cdm = new clsConvertDataToXML();
                    cdm.DoConvert1(finaldata, cmb_pt.SelectedValue.ToString(), sfd_save.FileName);
                }
            }
            else if (exporttype == "PDF")
            {


            }
            else if (exporttype == "���뵽���ݿ�")
            {
                //bool result = true;
             
                //foreach (DataTable DTUpload in dsexchanged.Tables)
                //{
                //    try
                //    {
                        clsUploadDataToDataBase.pt_id = cmb_pt.SelectedValue.ToString();
                        Thread t = new Thread(new ParameterizedThreadStart(clsUploadDataToDataBase.InsertDataIntoTarget1));
                        t.Start(dsexchanged);
                        //result = result & clsUploadDataToDataBase.InsertDataIntoTarget(DTUpload, cmb_pt.SelectedValue.ToString());
                    //}
                    //catch (Exception ex)
                    //{
                        //cf.WaitingThreadStop();
                        //MessageBox.Show(ex.Message);
                    //}
                }
             
                //if (!result)
                //{
                //    MessageBox.Show("���ݵ���ʧ�ܣ�����鿴��־��");
                //}
                //else
                //{
                //    MessageBox.Show("���ݵ����ɹ���");
                //}
            }

        }
        #endregion
    
}
