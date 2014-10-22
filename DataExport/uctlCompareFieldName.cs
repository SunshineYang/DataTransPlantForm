using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DataExport;
using ToolFunction;

namespace ConfirmFileName
{
    public partial class CompareFieldName : UserControl
    {
        public static string pt_id = "";
        public static string table_name = "";
        private bool isopenflag = false;
        private DataTable dtcompare = null;
        private string sourceflag = "";
        public CompareFieldName()
        {
            InitializeComponent();
            InitComboxDataSource();
            isopenflag = true;
            getMoniterCode();
        }

        #region 本来是用来初始化用户界面数据用的，但后来发现跟许多代码功能重复
        /// <summary>
        /// 
        /// </summary>
        public void InitData()
        {
            try
            {
                //cmb_ptname.DataSource = DALUse.Query(publicProperty.sqlGetPT).Tables[0];
                //cmb_ptname.DisplayMember = "pt_name";
                //cmb_ptname.ValueMember = "pt_id";
                //pt_id = cmb_ptname.SelectedValue.ToString();
                //cmb_tablename.DataSource = DALUse.Query(string.Format("select * from pt_tables_dict where pt_id = {0}", cmb_ptname.SelectedValue.ToString())).Tables[0];
                //cmb_tablename.DisplayMember = "table_name";
                //cmb_tablename.ValueMember = "table_name";
                string sql = string.Format("select  PT_ID,PT_NAME,TABLE_NAME,FIELD_NAME,FIELD,FIELD_TYPE,COMPARE_NAME,COMPARE_ID from PT_TARGET_FIELD n where pt_id ={0} and n.compare_id not in (select compare_id from pt_comparison where pt_id = {1}) and table_name='{2}'", cmb_ptname.SelectedValue.ToString(), cmb_ptname.SelectedValue.ToString(), cmb_tablename.SelectedValue.ToString());
                dtcompare = DALUse.Query(sql).Tables[0];
                gc_comparelist.DataSource = dtcompare;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        /// <summary>
        /// 初始化cmb_ptname的数据源并设置displaymember和valuemember
        /// </summary>
        public void InitComboxDataSource()
        {
            try
            {
                cmb_ptname.DataSource = DALUse.Query(clsPublicProperty.sqlGetPT).Tables[0];
                cmb_ptname.DisplayMember = "pt_name";
                cmb_ptname.ValueMember = "pt_id";
                if (cmb_ptname.SelectedItem == null)
                {
                    return;
                }
                DataTable DTtable = DALUse.Query(string.Format("select * from pt_tables_dict where pt_id = '{0}'", ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"])).Tables[0];
               
                cmb_tablename.DisplayMember = "table_name";
                cmb_tablename.ValueMember = "table_name";
                pt_id = cmb_ptname.SelectedValue.ToString();
                table_name = ((DataRowView)cmb_tablename.SelectedItem).Row["table_name"].ToString();
                getSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 初始化未绑定gridview控件数据
        /// </summary>
        public void InitGridViewDataSource()
        {
            try
            {
                string sql = string.Format("select  PT_ID,PT_NAME,TABLE_NAME,FIELD_NAME,FIELD,FIELD_TYPE,COMPARE_NAME,COMPARE_ID from PT_TARGET_FIELD n where pt_id ='{0}' and n.compare_id not in (select compare_id from pt_comparison where pt_id = '{1}') and table_name='{2}'", cmb_ptname.SelectedValue.ToString(), cmb_ptname.SelectedValue.ToString(), cmb_tablename.SelectedValue.ToString());
                dtcompare = DALUse.Query(sql).Tables[0];
                gc_comparelist.DataSource = dtcompare.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 将sql语句中的字段摘取出来，填写到gc_comparelist中去。
        /// </summary>
        public void PickUpField()
        {
            try
            {
                string sqlfield = rtb_sql.Text.Trim().Replace("@PATIENT_ID", "1").Replace("@VISIT_ID", "1");
                DataTable dt = DALUse.Query(sqlfield).Tables[0];
                if (dt.Columns.Count == 0)
                {
                    return;
                }
                else
                {
                    DataTable tablefield = new DataTable();
                    DataColumn dc = new DataColumn("FIELD");
                    tablefield.Columns.Add(dc);
                    foreach (DataColumn strdc in dt.Columns)
                    {
                        DataRow dr = tablefield.NewRow();
                        dr["field"] = strdc.Caption.ToString();
                        tablefield.Rows.Add(dr);
                    }
                    gc_fieldlist.DataSource = tablefield.DefaultView;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("SQL语句有误！" + e.ToString());
                gc_fieldlist.DataSource = null;
                rtb_sql.Focus();
            }
        }
        private void bnt_exe_Click(object sender, EventArgs e)
        {
            //if (rtb_sql.Text.Contains("as"))
            //{
            //    MessageBox.Show("语句中不可以有as");
            //    return;
            //}
            PickUpField();
            //uctlAddSQLName.sql = rtb_sql.Text;
            //uctlAddSQLName.ptid = cmb_ptname.SelectedValue.ToString();
            //Form f = new Form();
            //f.Size = new Size(489, 60);
            //f.FormBorderStyle = FormBorderStyle.None;
            //uctlAddSQLName sn = new uctlAddSQLName();
            //CommonFunction.AddForm(f, sn);
            tc_field.SelectedTabPage = tp1;
        }

        private void gc_fieldlist_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                GridHitInfo info = this.gridView2.CalcHitInfo(e.Location);
                if (info != null && info.InRow)
                {
                    object j = gridView2.GetRow(info.RowHandle);
                    if (j != null)
                    {
                        DataRowView view = (DataRowView)j;
                        DataRow dr = view.Row;
                        DataRow drcompare = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                        drcompare["COMPARE_NAME"] = dr["field"].ToString();
                        gridView3.RefreshData();
                        //gridView2.DeleteRow(info.RowHandle);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gc_fieldlist_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.FocusedRowHandle >= 0 && gridView3.DataRowCount != 0)
            {
                DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                DataRow drcompare = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                drcompare["COMPARE_NAME"] = dr["field"].ToString();
            }

        }

        private void gc_comparelist_MouseDown(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    GridHitInfo info = this.gridView2.CalcHitInfo(e.Location);
            //    if (info != null && info.InRow)
            //    {
            //        object j = gridView2.GetRow(info.RowHandle);
            //        if (j != null)
            //        {
            //            DataRowView view = (DataRowView)j;
            //            DataRow dr = view.Row;
            //            gridView2.DeleteRow(info.RowHandle);
            //            DataRow drcompare = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            //        }
            //    }
            //}
            //catch (Exception ex) { }
        }



        /// <summary>
        /// 保存comparename字段
        /// </summary>
        public void SaveCompareName()
        {
            foreach (DataRow dr in dtcompare.Rows)
            {
                if (dr.RowState == DataRowState.Modified)
                {
                    try
                    {
                        string sql = string.Format("insert into pt_comparison (pt_id,pt_name,table_name,field_name,field,field_type,compare_name,compare_id, sourcetype) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", dr["pt_id"].ToString(), dr["pt_name"].ToString(), dr["table_name"].ToString(), dr["field_name"].ToString(), dr["field"].ToString(), dr["field_type"].ToString(), dr["compare_name"].ToString(), dr["compare_id"].ToString(),sourceflag);
                        DALUse.ExecuteSql(sql);
                        InitGridViewDataSource();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }

                }
            }
            MessageBox.Show("保存成功！");
            gridView3.RefreshData();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveCompareName();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //DataRow drcompare = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            //drcompare["COMPARE_NAME"] = "";
            //gridView3.RefreshData();
            Form f = new Form();
            f.Size = new Size(760, 401);
            f.FormBorderStyle = FormBorderStyle.None;
            uctlCancelCompare cc = new uctlCancelCompare();
            if (CommonFunction.AddForm(f, cc) == DialogResult.Cancel)
            {
                InitGridViewDataSource();
            }
        }

        private void cmb_ptname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pt_id = cmb_ptname.SelectedValue.ToString();
                gc_comparelist.DataSource = null;
                cmb_tablename.DataSource = DALUse.Query(string.Format("select * from pt_tables_dict where pt_id = '{0}'", ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString())).Tables[0];
                cmb_tablename.DisplayMember = "table_name";
                //string getsql = string.Format("select * from pt_sql where pt_id = '{0}'",((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString());
                getSQL();
                //DataTable dtsql = DALUse.Query(getsql).Tables[0];
                //if (dtsql.Rows.Count==1)
                //{
                //    rtb_sql.Text = dtsql.Rows[0]["sql"].ToString();
                //}
                if (((DataTable)cmb_tablename.DataSource).Rows.Count != 0)
                {
                    table_name = cmb_tablename.SelectedValue.ToString();
                }
                if (tc_field.SelectedTabPage == tp2)
                {
                    try
                    {
                        getMoniterCode();
                        getTempField();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getCompareList()
        {
            try
            {
                string sql = string.Format("select  PT_ID,PT_NAME,TABLE_NAME,FIELD_NAME,FIELD,FIELD_TYPE,COMPARE_NAME,COMPARE_ID from PT_TARGET_FIELD n where pt_id ='{0}' and n.compare_id not in (select compare_id from pt_comparison where pt_id = '{1}') and table_name='{2}'", ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString(), ((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString(), ((DataRowView)cmb_tablename.SelectedItem).Row["TABLE_NAME"].ToString());
                dtcompare = DALUse.Query(sql).Tables[0];
                pt_id = cmb_ptname.SelectedValue.ToString();
                table_name = cmb_tablename.SelectedValue.ToString();
                gc_comparelist.DataSource = dtcompare;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void cmb_tablename_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCompareList();
        }


        private void tc_field_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tc_field.SelectedTabPage == tp2)
            {
                sourceflag = "templet";
                try
                {
                    getTempField();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                sourceflag = "database";
            }
        }

        private void gc_temp_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0 && gridView3.DataRowCount != 0)
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                DataRow drcompare = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                drcompare["COMPARE_NAME"] = dr["名称"].ToString();
                //}
                //else if (dr["标识"].ToString() == "1")
                //{
                //    drcompare["COMPARE_NAME"] = dr["名称"].ToString();
                //}
                //else if (dr["标识"].ToString() == "2")
                //{
                //    drcompare["COMPARE_NAME"] = dr["名称"].ToString();
                //}
                gridView1.RefreshData();
            }
        }

        public void getSQL()
        {
            try
            {
                gc_sql.DataSource = DALUse.Query(string.Format("select * from pt_sql where pt_id ='{0}'",cmb_ptname.SelectedValue.ToString())).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 获取监控代码字段
        /// </summary>
        public void getTempField()
        {
            try
            {
                gc_temp.DataSource = null;
                if (gridView4.FocusedRowHandle<0)
                {
                    return;
                }
                string sqltemp = string.Format("select item_name as 项目名称,field_name as 名称,cengci_code as 层次号,SOURCETYPE as 标识 from pt_temp_field where pt_name = '{0}' and class_name = '{1}'", cmb_ptname.Text, gridView4.GetDataRow(gridView4.FocusedRowHandle)["CLASS_NAME"].ToString());
                gc_temp.DataSource = DALUse.Query(sqltemp).Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

       

        /// <summary>
        /// 获取监控代码列表
        /// </summary>
        public void getMoniterCode()
        {
            try
            {
                if (cmb_ptname.SelectedItem==null)
                {
                    return;
                }
                gc_monitor.DataSource = DALUse.Query(string.Format("select distinct CLASS_NAME from pt_temp_field where pt_id = '{0}'",((DataRowView)cmb_ptname.SelectedItem).Row["pt_id"].ToString())).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView4_Click(object sender, EventArgs e)
        {
            if (gridView4.FocusedRowHandle>=0)
            {
                getTempField();
            }
        }

        private void btn_savesql_Click(object sender, EventArgs e)
        {
            uctlAddSQLName.sql = rtb_sql.Text;
            uctlAddSQLName.ptid = cmb_ptname.SelectedValue.ToString();
            Form f = new Form();
            f.Size = new Size(510, 60);
            f.FormBorderStyle = FormBorderStyle.None;
            uctlAddSQLName sn = new uctlAddSQLName();
            CommonFunction.AddForm(f, sn);
            getSQL();
        }

        private void btn_delsql_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete from pt_sql where sql_name = '{0}'", gridView5.GetDataRow(gridView5.FocusedRowHandle)["sql_name"].ToString());
                if (DALUse.ExecuteSql(sql) == 1)
                {
                    getSQL();
                    MessageBox.Show("删除成功！");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void gridView5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            if (gridView5.FocusedRowHandle < 0)
            {
                return;
            }
            try
            {
                string getsql = string.Format("select * from pt_sql where sql_name = '{0}'", gridView5.GetDataRow(gridView5.FocusedRowHandle)["SQL_NAME"].ToString());
                DataTable dtsql = DALUse.Query(getsql).Tables[0];
                if (dtsql.Rows.Count == 1)
                {
                    rtb_sql.Text = dtsql.Rows[0]["sql"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
