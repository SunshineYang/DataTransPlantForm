using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ToolFunction;
using DataExport;
using System.Threading;
using System.Data.OleDb;
namespace ConfirmFileName
{
    public partial class AddFildName : UserControl
    {
        CommonFunction t = new CommonFunction();
        private DataTable dttargetsource = null;
        private DataTable dttabledetail = null;
        private bool isopenflag = false;
        private string excel = "Provider=Microsoft.Ace.OleDb.12.0;data source='{0}';Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
        private DataSet myDs = new DataSet();
        public AddFildName()
        {
            InitializeComponent();
            InitComBoxDataSource();
            InitData();
            isopenflag = true;
            cmb_ptname.Focus();
        }

        private void InitData()
        {
            if (cmb_ptname.SelectedValue == null || gridView1.FocusedRowHandle < 0)
            {
                return;
            }
            string sql = string.Format("select * from PT_TABLES_DICT where pt_id = '{0}'", cmb_ptname.SelectedValue.ToString());
            dttabledetail = DALUse.Query(sql).Tables[0];
            gc_table_detail.DataSource = dttabledetail;
            string sqltrget = string.Format("select * from pt_target_field where table_name ='{0}' and pt_id = '{1}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString(), cmb_ptname.SelectedValue.ToString());
            dttargetsource = DALUse.Query(sqltrget).Tables[0];
            gc_pt_target.DataSource = dttargetsource;
        }

        public void InitComBoxDataSource()
        {
            try
            {
                cmb_ptname.DataSource = DALUse.Query(clsPublicProperty.sqlGetPT).Tables[0];
                cmb_ptname.DisplayMember = "PT_NAME";
                cmb_ptname.ValueMember = "PT_ID";
                //string sql = "select * from pt_dict";
                //cmb_ptname.DataSource = DALUse.Query(sql).Tables[0];
                //cmb_ptname.DisplayMember = "PT_NAME";
                //cmb_ptname.ValueMember = "PT_ID";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (gridView2.FocusedRowHandle < 0)
            {
                return;
            }
            string sql = string.Format("delete from PT_TARGET_FIELD where compare_id='{0}'", gridView2.GetDataRow(gridView2.FocusedRowHandle)["compare_id"].ToString());
            if (DialogResult.Yes == MessageBox.Show(null, "确定删除所选项！", "删除", MessageBoxButtons.YesNo))
            {
                DALUse.ExecuteSql(sql);
            }
            RefreshContent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_ptname.SelectedItem == null)
            {
                return;
            }
            uctlManageField.actionflag = "add";
            uctlManageField.pt_id = cmb_ptname.SelectedValue.ToString();
            uctlManageField.pt_name = cmb_ptname.Text.Trim();
            if (gridView1.FocusedRowHandle < 0)
            {
                return;
            }
            uctlManageField.table_name = gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString();
            Form f = new Form();
            f.Size = new Size(531, 102);
            f.FormBorderStyle = FormBorderStyle.None;
            uctlManageField mf = new uctlManageField();
            CommonFunction.AddForm(f, mf);
            RefreshContent();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((gridView1.FocusedRowHandle < 0) || gridView2.FocusedRowHandle < 0)
            {
                return;
            }
            uctlManageField.actionflag = "update";
            uctlManageField.pt_id = cmb_ptname.SelectedValue.ToString();
            uctlManageField.pt_name = cmb_ptname.Text.Trim();
            uctlManageField.table_name = gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString();
            uctlManageField.compare_id = gridView2.GetDataRow(gridView2.FocusedRowHandle)["COMPARE_ID"].ToString();
            Form f = new Form();
            f.Size = new Size(531, 102);
            f.FormBorderStyle = FormBorderStyle.None;
            uctlManageField mf = new uctlManageField();
            CommonFunction.AddForm(f, mf);

            RefreshContent();

        }



        /// <summary>
        /// 每当修改，删除，保存操作后进行刷新操作，跟新实时数据。
        /// </summary>
        public void RefreshContent()
        {
            string sql = string.Format("select * from pt_target_field where table_name ='{0}' and pt_id ='{1}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString(), ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString());
            dttargetsource = DALUse.Query(sql).Tables[0];
            gc_pt_target.DataSource = dttargetsource;
        }


        private void gc_table_detail_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                GridHitInfo info = this.gridView1.CalcHitInfo(e.Location);
                if (info != null && info.InRow)
                {
                    //gridView1.get
                    object j = gridView1.GetRow(info.RowHandle);
                    if (j != null)
                    {
                        DataRowView view = (DataRowView)j;
                        DataRow dr = view.Row;
                        if (dr["CHK"].ToString() == "×")
                        {
                            //gridView1.getr
                            dr["CHK"] = "√";
                        }
                        else if (dr["CHK"].ToString() == "√")
                        {
                            dr["CHK"] = "√";
                        }
                    }
                    gridView1.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_ptname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                gc_pt_target.DataSource = null;
                string sql = string.Format("select * from PT_TABLES_DICT where pt_id = '{0}'", ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString());
                dttabledetail = DALUse.Query(sql).Tables[0];
                gc_table_detail.DataSource = dttabledetail;
                if (dttabledetail.Rows.Count != 0)
                {
                    string sqltrget = string.Format("select * from pt_target_field where table_name ='{0}' and pt_id = '{1}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString(), ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString());
                    dttargetsource = DALUse.Query(sqltrget).Tables[0];
                    gc_pt_target.DataSource = dttargetsource;
                }



            }
            catch (Exception)
            {

                throw;
            }

        }



        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dttabledetail.Rows.Count != 0)
                {
                    string sql = string.Format("select * from pt_target_field where table_name ='{0}' and pt_id = '{1}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString(), ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString());
                    dttargetsource = DALUse.Query(sql).Tables[0];
                    gc_pt_target.DataSource = dttargetsource;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AddFildName_Load(object sender, EventArgs e)
        {

        }

        private void excel_import_Click(object sender, EventArgs e)
        {
           
            //t.WaitingThreadStart();
            //string insertSql = "";
            //if (myDs != null && myDs.Tables[0].Rows.Count > 0)
            //{
            //    string insertColumnString = "pt_id,pt_name,table_name,compare_id,field_name,field,field_type";
            //    DataTable dt = myDs.Tables[0];
            //    try
            //    {
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            if (dr[0].ToString() == "")
            //            {
            //                continue;
            //            }
            //            string insertValueString = "";
            //            insertValueString = "'" + cmb_ptname.SelectedValue.ToString() + "','" + cmb_ptname.Text.ToString() + "','" + gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString() + "','" + Guid.NewGuid().ToString() +"',";
            //            for (int i = 0; i < dt.Columns.Count; i++)
            //            {
            //                insertValueString += string.Format("'{0}',", dr[i].ToString().Replace("'", "''"));
            //            }
            //            insertValueString = insertValueString.Trim(',');
            //            insertSql = string.Format(@"INSERT INTO {0} ({1}) VALUES({2})", "pt_target_field", insertColumnString, insertValueString);
            //            DALUse.ExecuteSql(insertSql);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
            //t.WaitingThreadStop();
        }

        private void btn_sel_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string connectString = string.Format(excel, openFileDialog1.FileName);
            try
            {
                //t.WaitingThreadStart();
                myDs.Tables.Clear();
                myDs.Clear();
                OleDbConnection cnnxls = new OleDbConnection(connectString);
                OleDbDataAdapter myDa = new OleDbDataAdapter("select * from [Sheet1$]", cnnxls);
                myDa.Fill(myDs, "c");
                //t.WaitingThreadStop();
                Form f = new Form();
                f.Size = new Size(549, 446);
                f.FormBorderStyle = FormBorderStyle.None;
                uctlShowImportField sif = new uctlShowImportField();
                sif.myDs = myDs;
                sif.table_name = gridView1.GetDataRow(gridView1.FocusedRowHandle)["TABLE_NAME"].ToString();
                sif.pt_name = cmb_ptname.Text.ToString();
                sif.pt_id = cmb_ptname.SelectedValue.ToString();
                CommonFunction.AddForm(f, sif);
                //MessageBox.Show("数据载入完成！");
            }
            catch (Exception ex)
            {
                //t.WaitingThreadStop();
                MessageBox.Show(ex.Message);
            }

        }
    }
}