using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;
using ToolFunction;
namespace DataExport
{
    public partial class uctlPTManage : UserControl
    {
        private DataTable dtptsource = null;
        private DataTable dttablesource = null;
        private bool ptflag = true;
        private bool managetable = false;
        private string pt_id = "";
        public uctlPTManage()
        {
            InitializeComponent();
            InitData();
            //managetable = true;
        }

        public void InitData()
        {
            try
            {
                if (ptflag && !managetable)
                {
                    string sqlquerypt = string.Format(clsPublicProperty.sqlGetPT);
                    dtptsource = DALUse.Query(sqlquerypt).Tables[0];
                    gc_pt_dict.DataSource = dtptsource;

                }
                if (gridView1.FocusedRowHandle<0)
                {
                    return;
                }
                string sqlquerytables = string.Format("select * from pt_tables_dict where pt_id = '{0}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["PT_ID"].ToString());
                dttablesource = DALUse.Query(sqlquerytables).Tables[0];
                //if (dttablesource.Rows.Count == 0)
                //{
                //    gc_table_dict.DataSource = null;

                //}
                //else
                //{
                gc_table_dict.DataSource = dttablesource;

                //}

                ptflag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlquerytables = string.Format("select * from pt_tables_dict where pt_id = '{0}'",gridView1.GetDataRow(gridView1.FocusedRowHandle)["PT_ID"].ToString());
                dttablesource = DALUse.Query(sqlquerytables).Tables[0];
                if (dttablesource.Rows.Count == 0)
                {
                    gc_table_dict.DataSource = null;

                }
                else
                {
                    gc_table_dict.DataSource = dttablesource;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //if (gridView1.FocusedRowHandle<0)
            //{
            //    return;
            //}
            managetable = false;
            Form f = new Form();
            uctlAddpt ap = new uctlAddpt();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Size = new Size(541, 58);
            uctlAddpt.kind = "add";
            CommonFunction.AddForm(f, ap);
            InitData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            managetable = false;
            try
            {
                if (dtptsource.Rows.Count != 0 && MessageBox.Show(null, "确认删除所选平台？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pt_id =  gridView1.GetDataRow(gridView1.FocusedRowHandle)["pt_id"].ToString();
                    string sqldelpt = string.Format("delete pt_dict where pt_id = '{0}'",pt_id);
                    string sqldelpttable= string.Format("delete pt_tables_dict where pt_id = '{0}'",pt_id);
                    DALUse.ExecuteSql(sqldelpttable);
                    DALUse.ExecuteSql(sqldelpt);
                    InitData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            managetable = false;
            Form f = new Form();
            uctlAddpt ap = new uctlAddpt();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Size = new Size(541, 58);
            uctlAddpt.kind = "update";
            CommonFunction.AddForm(f, ap);
            uctlAddpt.ptid = gridView2.GetDataRow(gridView2.FocusedRowHandle)["pt_id"].ToString();
            InitData();
        }

        private void btn_tableadd_Click(object sender, EventArgs e)
        {
            managetable = true;
            uctladdtable.pt_id = gridView1.GetDataRow(gridView1.FocusedRowHandle)["pt_id"].ToString();
            uctladdtable.kind = "add";
            Form f = new Form();
            uctladdtable at = new uctladdtable();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Size = new Size(541, 58);
            CommonFunction.AddForm(f, at);
            InitData();
        }

        private void btn_tabledel_Click(object sender, EventArgs e)
        {
            managetable = true;
            try
            {

                if (dttablesource.Rows.Count != 0 && MessageBox.Show(null, "确认删除所选表？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ptflag = false;
                    string sqldeltable = string.Format("delete pt_tables_dict where id = '{0}'", gridView2.GetDataRow(gridView2.FocusedRowHandle)["id"].ToString());
                    string sqldeletefield = string.Format("delete pt_target_field where pt_id = '{0}' and table_name = '{1}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["pt_id"].ToString(), gridView2.GetDataRow(gridView2.FocusedRowHandle)["TABLE_NAME"].ToString());
                    string sqldelcomfield = string.Format("delete PT_COMPARISON where pt_id = '{0}' and table_name = '{1}'", gridView1.GetDataRow(gridView1.FocusedRowHandle)["pt_id"].ToString(), gridView2.GetDataRow(gridView2.FocusedRowHandle)["TABLE_NAME"].ToString());
                    List<string> sqllist = new List<string>();
                    sqllist.Add(sqldeltable);
                    sqllist.Add(sqldeletefield);
                    sqllist.Add(sqldelcomfield);
                    if (DALUse.ExecuteSqlTran(sqllist.ToArray()))
                    {
                        MessageBox.Show("删除成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                    InitData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_tableupdate_Click(object sender, EventArgs e)
        {
            managetable = true;
            uctladdtable.kind = "update";
            uctladdtable.pt_id = gridView2.GetDataRow(gridView2.FocusedRowHandle)["pt_id"].ToString();
            uctladdtable.table_id = gridView2.GetDataRow(gridView2.FocusedRowHandle)["id"].ToString();
            uctladdtable.oldtablename = gridView2.GetDataRow(gridView2.FocusedRowHandle)["table_name"].ToString();
            Form f = new Form();
            uctladdtable at = new uctladdtable();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Size = new Size(541, 58);
            CommonFunction.AddForm(f, at);
            InitData();
        }

        private void btn_cancelexport_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("update pt_tables_dict set exportflag = 'FALSE' where id = '{0}'", gridView2.GetDataRow(gridView2.FocusedRowHandle)["id"].ToString());
                DALUse.ExecuteSql(sql);
                InitData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()) ;
            }
        }

        private void btn_accessexport_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("update pt_tables_dict set exportflag = 'TRUE' where id = '{0}'", gridView2.GetDataRow(gridView2.FocusedRowHandle)["id"].ToString());
                DALUse.ExecuteSql(sql);
                InitData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


    }
}
