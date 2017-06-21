using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Business.CustomerEnum;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Library.MyControl;
using GZFrameworkDemo.Models;
using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library
{
    public partial class DataBinderTools
    {

        public partial class Bound
        {
            private static int GetShowSourceRows(int RowsCount)
            {
                return RowsCount > 15 ? RowsCount : 15;
            }

          
            #region bound YYYY MM DD
            /// <summary>
            /// 绑定年，指定前后年数
            /// </summary>
            /// <param name="cmb"></param>
            /// <param name="pre">之前年数</param>
            /// <param name="next">之后年数</param>
            public static void BoundYear(ComboBoxEdit cmb, int pre, int next)
            {

                int Year = bllDataCommon.Instance.GetServerTime().Year;
                for (int i = Year - pre; i <= Year + next; i++)
                {
                    cmb.Properties.Items.Add(i);
                }
                cmb.EditValue = Year;
                cmb.Properties.DropDownRows = 12;
            }

            /// <summary>
            /// 绑定年，指定前后年数
            /// </summary>
            /// <param name="cmb"></param>
            /// <param name="pre">之前年数</param>
            /// <param name="next">之后年数</param>
            public static void BoundYear(RepositoryItemComboBox cmb, int pre, int next)
            {
                int Year = bllDataCommon.Instance.GetServerTime().Year;
                for (int i = Year - pre; i <= Year + next; i++)
                {
                    cmb.Items.Add(i);
                }
                cmb.DropDownRows = 12;
            }



            /// <summary>
            /// 绑定年，指定前后年数
            /// </summary>
            /// <param name="cmb"></param>
            /// <param name="pre">之前年数</param>
            /// <param name="next">之后年数</param>
            public static void BoundYear(ComboBoxEdit cmb, int pre, int next, bool AutoSelected)
            {
                int Year = bllDataCommon.Instance.GetServerTime().Year;
                for (int i = Year - pre; i <= Year + next; i++)
                {
                    cmb.Properties.Items.Add(i);
                }
                if (AutoSelected)
                    cmb.EditValue = Year;
            }

            public static void BoundYear(ComboBoxEdit cmb, bool ADDNULL)
            {
                if (ADDNULL)
                    cmb.Properties.Items.Add("");
                BoundYear(cmb, 3, 1);
            }

            /// <summary>
            /// 绑定年，前5年到后三年
            /// </summary>
            /// <param name="cmb"></param>
            public static void BoundYear(ComboBoxEdit cmb)
            {
                BoundYear(cmb, 3, 1);

            }

            /// <summary>
            /// 绑定月
            /// </summary>
            /// <param name="cmb"></param>
            public static void BoundMonth(ComboBoxEdit cmb)
            {
                for (int i = 0; i < 12; i++)
                {
                    cmb.Properties.Items.Add(i + 1);
                }
                cmb.EditValue = bllDataCommon.Instance.GetServerTime().Month;
                cmb.Properties.DropDownRows = 12;
            }

            /// <summary>
            /// 绑定月
            /// </summary>
            /// <param name="cmb"></param>
            public static void BoundMonth(RepositoryItemComboBox cmb)
            {
                for (int i = 0; i < 12; i++)
                {
                    cmb.Items.Add(i + 1);
                }
                cmb.DropDownRows = 12;
            }

            /// <summary>
            /// 绑定月
            /// </summary>
            /// <param name="cmb"></param>
            public static void BoundMonth(ComboBoxEdit cmb, bool AutoSelected)
            {
                for (int i = 0; i < 12; i++)
                {
                    cmb.Properties.Items.Add(i + 1);
                }
                if (AutoSelected)
                    cmb.EditValue = bllDataCommon.Instance.GetServerTime().Month;
            }

            /// <summary>
            /// 绑定天
            /// </summary>
            /// <param name="cmb"></param>
            /// <param name="Year"></param>
            /// <param name="Month"></param>
            public static void BoundDay(ComboBoxEdit cmb, int Year, int Month)
            {
                DateTime tmp = DateTime.Parse(string.Format("{0}-{1}-1", Year, Month));
                int endDay = (tmp.AddMonths(1).AddDays(-1)).Day;
                for (int i = 0; i < endDay; i++)
                {
                    cmb.Properties.Items.Add(i + 1);
                }
            }

            #endregion

            private static DevExpress.XtraEditors.Controls.BestFitMode CBestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            #region InitializeControl

            private static void InitializeControl(RepositoryItemLookUpEdit lue, string[] Names, string[] FileNames)
            {
                try
                {
                    lue.Columns.Clear();
                    lue.NullText = "";
                    if (lue.Columns.Count == 0)
                    {
                        for (int i = 0; i < Names.Length; i++)
                        {
                            DevExpress.XtraEditors.Controls.LookUpColumnInfo col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                            col.Caption = Names[i];
                            col.FieldName = FileNames[i];
                            lue.Columns.Add(col);
                        }
                    }
                    lue.BestFitMode = CBestFitMode;
                }
                catch (Exception e)
                {
                    Msg.Warning(e.Message);
                }
            }




            private static void InitializeControl(RepositoryItemGridLookUpEditBase lue, string[] Names, string[] FileNames)
            {
                try
                {
                    lue.View.Columns.Clear();
                    lue.NullText = "";
                    if (lue.View.Columns.Count == 0)
                    {
                        for (int i = 0; i < Names.Length; i++)
                        {
                            var col = lue.View.Columns.Add();
                            col.Caption = Names[i];
                            col.FieldName = FileNames[i];
                            col.VisibleIndex = lue.View.Columns.Count;
                        }
                    }
                    lue.BestFitMode = CBestFitMode;
                }
                catch (Exception e)
                {
                    Msg.Warning(e.Message);
                }
            }
            #endregion

            private static void BoundDatabase(RepositoryItemGridLookUpEditBase lue, DataTable dt, bool displayCombination, bool AddNull, string DisplayFileName, string ValueFileName)
            {
                if (AddNull) dt = Common.ADDNULL(dt);
                if (displayCombination)
                {
                    Common.AddColumns(dt, new string[] { ValueFileName, DisplayFileName });
                    DisplayFileName = Common.DefNewColName;
                }
                lue.DataSource = dt;
                lue.ValueMember = ValueFileName;
                lue.DisplayMember = DisplayFileName;
            }
            private static void BoundDatabase(RepositoryItemLookUpEdit lue, DataTable dt, bool displayCombination, bool AddNull, string DisplayFileName, string ValueFileName)
            {

                if (AddNull) dt = Common.ADDNULL(dt);
                if (displayCombination)
                {
                    Common.AddColumns(dt, new string[] { ValueFileName, DisplayFileName });
                    DisplayFileName = Common.DefNewColName;
                }
                lue.DataSource = dt;
                lue.ValueMember = ValueFileName;
                lue.DisplayMember = DisplayFileName;
                lue.DropDownRows = GetShowSourceRows(dt.Rows.Count);
            }
            private static void BoundDatabase(RepositoryItemCheckedComboBoxEdit lue, DataTable dt, bool displayCombination, string DisplayFileName, string ValueFileName)
            {
                string str = DisplayFileName;
                if (displayCombination)
                {
                    Common.AddColumns(dt, ValueFileName, DisplayFileName);
                    str = Common.DefNewColName;
                }

                lue.DisplayMember = str;
                lue.ValueMember = ValueFileName;
                lue.DataSource = dt;

                lue.DropDownRows = GetShowSourceRows(dt.Rows.Count);
            }
            /// <summary>
            /// 绑定枚举
            /// </summary>
            public static void BoundEnumData(RepositoryItemLookUpEdit lue, Type emnu)
            {
                lue.Columns.Clear();
                InitializeControl(lue, new string[] { "名称" }, new string[] { "Name" });
                lue.ShowHeader = false;

                DataTable dt = Tools.EnumToDataTable(emnu, "Name", "Value");

                BoundDatabase(lue, dt, false, false, "Name", "Value");
            }
            /// <summary>
            /// 绑定枚举
            /// </summary>
            public static void BoundEnumData(LookUpEdit lue, Type emnu)
            {
                BoundEnumData(lue.Properties, emnu);
            }


            /// <summary>
            /// 绑定订单类型，挂起，提交，撤销
            /// </summary>
            /// <param name="lue"></param>
            public static void BoundDocType(RepositoryItemLookUpEdit lue)
            {
                DataTable dt = Tools.EnumToDataTable(typeof(Models.DocType), "Name", "Value");
                InitializeControl(lue, new string[] { "状态" }, new string[] { "Name" });
                BoundDatabase(lue, dt, false, false, "Name", "Value");
            }



            #region 常用用户绑定

            /// <summary>
            /// 绑定登陆账号
            /// </summary>
            /// <param name="lue"></param>
            public static void BoundUserName(RepositoryItemLookUpEdit lue)
            {
                lue.Columns.Clear();
                InitializeControl(lue, new string[] { "姓名" }, new string[] { "UserName" });

                BoundDatabase(lue, DataCache.Cache.UserName, false, false, "UserName", "Account");

            }
            /// <summary>
            /// 绑定登陆账号
            /// </summary>
            /// <param name="lue"></param>
            public static void BoundUserName(params LookUpEdit[] lues)
            {
                foreach (var lue in lues)
                {
                    BoundUserName(lue.Properties);
                }
            }

            /// <summary>
            /// 绑定用户账号
            /// </summary>
            public static void BoundUserName(RepositoryItemGridLookUpEditBase lue, bool displayCombination, bool AddNull)
            {
                lue.View.Columns.Clear();
                InitializeControl(lue, new string[] { "账号", "姓名" }, new string[] { dt_MyUser.Account, dt_MyUser.UserName });

                bool ISCustomerGirdLookUpedit = lue is RepositoryItemGZGridLookUpEdit_MultiFilter;

                if (ISCustomerGirdLookUpedit == true)
                {
                    (lue as RepositoryItemGZGridLookUpEdit_MultiFilter).FilterColumns = String.Format("{0}|{1}",
                         dt_MyUser.Account,
                         dt_MyUser.UserName
                        );
                }

                BoundDatabase(lue, DataCache.Cache.UserName, displayCombination, AddNull, dt_MyUser.UserName, dt_MyUser.Account);
            }
            /// <summary>
            /// 绑定用户账号
            /// </summary>
            public static void BoundUserName(GridLookUpEditBase lue, bool displayCombination, bool AddNull)
            {
                BoundUserName(lue.Properties, displayCombination, AddNull);
            }
            #endregion


            /// <summary>
            /// 绑定角色
            /// </summary>
            public static void BoundRoleID(RepositoryItemLookUpEdit lue, bool displayCombination, bool AddNull)
            {

                lue.Columns.Clear();
                InitializeControl(lue, new string[] { "角色编号", "角色名称" }, new string[] { dt_MyRole.RoleID, dt_MyRole.RoleName });

                BoundDatabase(lue, DataCache.Cache.dtRole, displayCombination, AddNull, dt_MyRole.RoleName, dt_MyRole.RoleID);
            }

          
            /// <summary>
            /// 绑定角色
            /// </summary>
            public static void BoundRoleID(LookUpEdit lue, bool displayCombination, bool AddNull)
            {
                BoundRoleID(lue.Properties, displayCombination, AddNull);
            }
            /// <summary>
            /// 绑定角色
            /// </summary>
            public static void BoundRoleID(RepositoryItemGridLookUpEditBase lue, bool displayCombination, bool AddNull)
            {
                lue.View.Columns.Clear();
                InitializeControl(lue, new string[] { "角色编号", "角色名称" }, new string[] { dt_MyRole.RoleID, dt_MyRole.RoleName });

                bool ISCustomerGirdLookUpedit = lue is RepositoryItemGZGridLookUpEdit_MultiFilter;

                if (ISCustomerGirdLookUpedit == true)
                {
                    (lue as RepositoryItemGZGridLookUpEdit_MultiFilter).FilterColumns = String.Format("{0}|{1}",
                          dt_MyRole.RoleID,
                          dt_MyRole.RoleName
                        );
                }

                BoundDatabase(lue, DataCache.Cache.dtRole, displayCombination, AddNull, dt_MyRole.RoleName, dt_MyRole.RoleID);
            }



            /// <summary>
            /// 绑定角色
            /// </summary>
            public static void BoundRoleID(GridLookUpEditBase lue, bool displayCombination, bool AddNull)
            {
                BoundRoleID(lue.Properties, displayCombination, AddNull);
            }


            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataID(RepositoryItemLookUpEdit lue, EnumCommonDicData E, bool displayCombination, bool AddNull)
            {
                lue.Columns.Clear();
                InitializeControl(lue, new string[] { "编号", "名称" }, new string[] { dt_CommonDicData.DataCode, dt_CommonDicData.DataName });

                BoundDatabase(lue, DataCache.Cache.GetCommonDictData(E), displayCombination, AddNull, dt_CommonDicData.DataName, dt_CommonDicData.DataCode);
            }

            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataName(RepositoryItemLookUpEdit lue, EnumCommonDicData E, bool displayCombination, bool AddNull)
            {
                lue.Columns.Clear();
                InitializeControl(lue, new string[] { "名称" }, new string[] { dt_CommonDicData.DataName });

                BoundDatabase(lue, DataCache.Cache.GetCommonDictData(E), displayCombination, AddNull, dt_CommonDicData.DataName, dt_CommonDicData.DataName);
            }


            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataName(RepositoryItemComboBox lue, EnumCommonDicData E, bool AddNull)
            {
                lue.Items.Clear();
                DataTable dt = DataCache.Cache.GetCommonDictData(E).Copy();
                if (AddNull)
                    dt.Rows.InsertAt(dt.NewRow(), 0);
                dt.AcceptChanges();
                foreach (DataRow dr in dt.Rows)
                {
                    lue.Items.Add(dr[dt_CommonDicData.DataName]);
                }

            }

            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataName(ComboBoxEdit lue, EnumCommonDicData E, bool AddNull)
            {
                BoundCommonDictDataName(lue.Properties, E, AddNull);
            }

            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataID(LookUpEdit lue, EnumCommonDicData E, bool displayCombination, bool AddNull)
            {
                BoundCommonDictDataID(lue.Properties, E, displayCombination, AddNull);
            }
            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataName(LookUpEdit lue, EnumCommonDicData E, bool displayCombination, bool AddNull)
            {
                BoundCommonDictDataName(lue.Properties, E, displayCombination, AddNull);
            }
            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataID(RepositoryItemCheckedComboBoxEdit lue, EnumCommonDicData E, bool displayCombination)
            {
                lue.Items.Clear();
                BoundDatabase(lue, DataCache.Cache.GetCommonDictData(E), displayCombination, dt_CommonDicData.DataName, dt_CommonDicData.DataCode);
            }
            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            /// <param name="AddNull"></param>
            public static void BoundCommonDictDataName(RepositoryItemCheckedComboBoxEdit lue, EnumCommonDicData E, bool displayCombination)
            {
                lue.Items.Clear();
                BoundDatabase(lue, DataCache.Cache.GetCommonDictData(E), displayCombination, dt_CommonDicData.DataName, dt_CommonDicData.DataName);
            }

            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            public static void BoundCommonDictDataID(CheckedComboBoxEdit lue, EnumCommonDicData E, bool displayCombination)
            {
                BoundCommonDictDataID(lue.Properties, E, displayCombination);
            }

            /// <summary>
            /// 绑定基础数据
            /// </summary>
            /// <param name="lue"></param>
            /// <param name="E"></param>
            /// <param name="displayCombination"></param>
            public static void BoundCommonDictDataName(CheckedComboBoxEdit lue, EnumCommonDicData E, bool displayCombination)
            {
                BoundCommonDictDataName(lue.Properties, E, displayCombination);
            }



       


        }


        private sealed class Common
        {
            public static string DefNewColName = "GZFrameworkUNIONColName";
            public static DataTable ADDNULL(DataTable tmp)
            {
                DataTable dt = tmp.Copy();
                if (dt.Rows.Count == 0) return dt;
                //插入一行空记录
                if (dt.Rows[0].IsNull(0))//判断是否已经加过空行，避免重复添加
                    return dt;
                DataRow row = dt.NewRow();
                dt.Rows.InsertAt(row, 0);
                return dt;
            }


            public static void AddColumns(DataTable dt, params string[] Cols)
            {
                if (dt.Columns[DefNewColName] != null) return;

                dt.Columns.Add(DefNewColName, Type.GetType("System.String"));
                foreach (DataRow dr in dt.Rows)
                {
                    string Combine = string.Empty;
                    foreach (string Col in Cols)
                    {
                        if (String.IsNullOrEmpty(Combine))
                            Combine = ConvertLib.ToString(dr[Col]);
                        else
                            Combine += " - " + ConvertLib.ToString(dr[Col]);
                    }
                    dr[DefNewColName] = Combine;
                }
            }


        }



    }
}
