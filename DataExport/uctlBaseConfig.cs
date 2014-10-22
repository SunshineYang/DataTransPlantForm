using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using JHEMR.EmrSysDAL;

namespace DataExport
{
    public partial class uctlBaseConfig : UserControl
    {
        DataTable dtsource = null;
        public uctlBaseConfig()
        {
            InitializeComponent();
            //DateTime date = DateTime.Parse(DALUse.Query("select sysdate from dual").Tables[0].Rows[0]["SYSDATE"].ToString());
            //txt_servertime.Text = date.ToString("yyyy-MM-dd HH:mm");
            cmb_pt.DataSource = DALUse.Query(clsPublicProperty.sqlGetPT).Tables[0];
            cmb_pt.DisplayMember = "pt_name";
            cmb_pt.ValueMember = "pt_id";
            //InitData(); 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            if (dtsource == null)
            {
                return;
            }
            else if (HasData() == 1)
            {
                UpdateData();
            }
            else if (HasData() == 0)
            {
                SaveData();
            }
            else
            {
                MessageBox.Show("数据有误！");
            }

        }

        public void SaveData()
        {
            try
            {
                string sqlinsert = string.Format("insert into pt_setting(PLATFORM_ADDRESS,LOGIN,PASSWORD,ORGANIZATION_NAME,ORGANIZATION_CODE,ORGANIZATION_PASSWORD,STORAGE_LOCATION,UPDATE_TIME,DBFPATH,PT_ID,EXPORTFILETYPE,CONNSTR) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", 
                    txt_PLATFORM_ADDRESS.Text, 
                    txt_logonname.Text, 
                    txt_password.Text, 
                    txt_ORGANIZATION_NAME.Text, 
                    txt_Organization_code.Text, 
                    txt_ORGANIZATION_PASSWORD.Text, 
                    txt_STORAGE_LOCATION.Text, 
                    txt_UPDATE_TIME.Text, 
                    txt_dbfpath.Text, 
                    cmb_pt.SelectedValue.ToString(),
                    cmb_type.Text.ToString());
                DALUse.ExecuteSql(sqlinsert);
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd_path.ShowDialog();
            txt_STORAGE_LOCATION.Text = ofd_path.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd_path.ShowDialog();
            txt_dbfpath.Text = ofd_path.FileName;
        }
        public int HasData()
        {
            try
            {
                if (cmb_pt.SelectedItem == null)
                {
                    return 99999;
                }
                string sqlinitdate = string.Format("select * from pt_setting where pt_id = '{0}'", ((DataRowView)cmb_pt.SelectedItem).Row["pt_id"].ToString());
                dtsource = DALUse.Query(sqlinitdate).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dtsource.Rows.Count;
        }
        private void InitData()
        {
            if (HasData() == 0)
            {
                txt_PLATFORM_ADDRESS.Text = "";
                txt_logonname.Text = "";
                txt_password.Text = "";
                txt_ORGANIZATION_NAME.Text = "";
                txt_Organization_code.Text = "";
                txt_ORGANIZATION_PASSWORD.Text = "";
                txt_STORAGE_LOCATION.Text = "";
                txt_UPDATE_TIME.Text = "";
                txt_dbfpath.Text = "";
                cmb_type.SelectedIndex = -1;
            }
            else if (HasData() == 1)
            {
                DataRow drsource = null;
                drsource = dtsource.Rows[0];
                txt_PLATFORM_ADDRESS.Text = drsource["PLATFORM_ADDRESS"].ToString();
                txt_logonname.Text = drsource["LOGIN"].ToString();
                txt_password.Text = drsource["PASSWORD"].ToString();
                txt_ORGANIZATION_NAME.Text = drsource["ORGANIZATION_NAME"].ToString();
                txt_Organization_code.Text = drsource["Organization_code"].ToString();
                txt_ORGANIZATION_PASSWORD.Text = drsource["ORGANIZATION_PASSWORD"].ToString();
                txt_STORAGE_LOCATION.Text = drsource["STORAGE_LOCATION"].ToString();
                txt_UPDATE_TIME.Text = drsource["UPDATE_TIME"].ToString();
                txt_dbfpath.Text = drsource["DBFPATH"].ToString();
                cmb_type.Text = drsource["EXPORTFILETYPE"].ToString();
                txt_connstr.Text = drsource["CONNSTR"].ToString();
            }
            else
            {
                MessageBox.Show("数据重复！");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtsource == null)
                {
                    return;
                }
                else if (HasData() == 1)
                {
                    DALUse.ExecuteSql(string.Format("delete from pt_setting where pt_id ={0}", cmb_pt.SelectedValue.ToString()));
                    MessageBox.Show("清空成功！");
                    InitData();
                }
                else
                {
                    MessageBox.Show("清空失败！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateData()
        {
            try
            {
                string sqlupdate = string.Format("update pt_setting set PLATFORM_ADDRESS = '{0}',LOGIN = '{1}',PASSWORD = '{2}',UPDATE_TIME = '{3}',ORGANIZATION_CODE = '{4}',STORAGE_LOCATION = '{5}',ORGANIZATION_PASSWORD = '{6}',ORGANIZATION_NAME = '{7}',DBFPATH = '{8}',EXPORTFILETYPE = '{10}' where pt_id ='{9}'",
                    txt_PLATFORM_ADDRESS.Text,
                    txt_logonname.Text,
                    txt_password.Text,
                    txt_UPDATE_TIME.Text,
                    txt_Organization_code.Text,
                    txt_STORAGE_LOCATION.Text,
                    txt_ORGANIZATION_PASSWORD.Text,
                    txt_ORGANIZATION_NAME.Text,
                    txt_dbfpath.Text,
                    cmb_pt.SelectedValue.ToString(),
                    cmb_type.Text);
                if (DALUse.ExecuteSql(sqlupdate) == 1)
                {
                    MessageBox.Show("修改成功！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void cmb_pt_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitData();
        }

      

    }
}
