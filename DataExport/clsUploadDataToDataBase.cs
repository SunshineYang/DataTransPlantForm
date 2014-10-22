using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ToolFunction;
using JHEMR.EmrSysDAL;

namespace DataExport
{

    public class clsUploadDataToDataBase
    {
        public static string  pt_id = "";
        public static void InsertDataIntoTarget1(object o)
        {
            CommonFunction cf = new CommonFunction();
            cf.WaitingThreadStart();
            try
            {DataSet ds = (DataSet)o;
                foreach (DataTable dt in ds.Tables)
                {
                    InsertDataIntoTarget(dt);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            cf.WaitingThreadStop();
        }
        public static bool InsertDataIntoTarget(DataTable source)
        {
            bool result = true;
            string errormess = "";
            string connstr = "";
            List<string> sqllist = new List<string>();
            try
            {
                //修改人:吴海龙;修改时间2014-07-19;修改原因:从pt_tables_dict 设置那些表导出
                //DataTable targettable = DALUse.Query(string.Format("select * from PT_Up_DataBase_Table where pt_id ='{0}'", pt_id)).Tables[0];
                DataTable targettable = DALUse.Query(string.Format("select * from pt_tables_dict where pt_id ='{0}' and exportflag = 'TRUE'", pt_id)).Tables[0];
                connstr = DALUse.Query(string.Format("select * from PT_Setting where pt_id ='{0}'", pt_id)).Tables[0].Rows[0]["connstr"].ToString();
                string dbType = StrConvertToDateTime.getClientConnectType(connstr);
                foreach (DataRow drtarget in targettable.Rows)
                {//修改PT_TABLE->TABLE_NAME
                    DataTable targetcolumns = DALUse.Query(string.Format("select * from PT_TARGET_FIELD where table_name = '{0}'", drtarget["TABLE_NAME"].ToString())).Tables[0];
                    string insertcolumns = "";
                    foreach (DataRow drcolumnname in targetcolumns.Rows)//拼接插入的列
                    {
                        insertcolumns += drcolumnname["FIELD"].ToString() + ",";
                    }
                    insertcolumns = insertcolumns.Trim(',');
                    foreach (DataRow drinsertdata in source.Rows)
                    {
                        string sql = "";
                        string insertvalue = "";
                        foreach (string dcitem in insertcolumns.Split(','))
                        {
                            string sqldatatype = string.Format("select * from PT_TARGET_FIELD where pt_id = '{0}' and table_name = '{1}' and field = '{2}'", pt_id, drtarget["TABLE_NAME"].ToString(), dcitem.ToString());
                            string dataType = DALUse.Query(sqldatatype).Tables[0].Rows[0]["FIELD_TYPE"].ToString();
                            bool valueflag = false;//指定列是否赋值。
                            foreach (DataColumn dcdata in source.Columns)
                            {
                                if (dcitem.ToUpper().Equals(getFieldName(pt_id, drtarget["TABLE_NAME"].ToString(), dcdata.ToString()).ToUpper()))
                                {
                                    //insertvalue += "'" + drinsertdata[dcitem].ToString() + "',";
                                    insertvalue += StrConvertToDateTime.makeInsertvalue(drinsertdata[dcdata.ToString()].ToString(), false, StrConvertToDateTime.getClientConnectType("TargetConnection"), dataType);
                                    valueflag = true;
                                    //StrConvertToDateTime.ToDate("2014-06-19 11:11:11", false, dbType);
                                }

                            }
                            if (!valueflag)
                            {
                                insertvalue += "'',";
                            }
                        }
                        insertvalue = insertvalue.Trim(',');
                        sql = string.Format("insert into {0} ({1}) values ({2})",
                            drtarget["TABLE_NAME"].ToString(),
                            insertcolumns,
                            insertvalue);
                        sqllist.Add(sql);
                        errormess = sql;
                        ToolFunction.clsProperty.insertcount = ToolFunction.clsProperty.insertcount++;
                        try//针对插入操作上传日志。
                        {
                            if (DALUseSpecial.ExecuteSql(sql, connstr) == 1)
                            {
                                result = true;
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            clsWriteErrorLogToDataBase.WriteErrorLogTodataBase(ex.ToString()+"\n"+errormess);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //CommonFunction.WriteErrotLog(ex.Message);
                throw;
            }
            return result;
        }
        /// <summary>
        /// 取出对比字段
        /// </summary>
        /// <param name="pt_id">平台名</param>
        /// <param name="table_name">表名</param>
        /// <param name="compare_name">字段名</param>
        /// <returns></returns>
        public static string getFieldName(string pt_id, string table_name,string compare_name)
        {
            string result = "";
            try
            {
                result = DALUse.Query(string.Format("select * from PT_COMPARISON where pt_id = '{0}' and table_name = '{1}' and compare_name = '{2}'", pt_id, table_name, compare_name)).Tables[0].Rows[0]["field"].ToString();
            }
            catch (Exception ex)
            {
                CommonFunction.WriteErrotLog(ex.ToString());
            }
            return result;
        }
    }
}
