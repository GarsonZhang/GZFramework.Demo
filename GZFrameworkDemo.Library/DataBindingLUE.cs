using DevExpress.XtraEditors;
using GZFrameworkDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library
{

    [Description("为GridView提供行号显示")]
    [ProvideProperty("Data", typeof(LookUpEdit))]
    [ProvideProperty("_DisplayCombination", typeof(LookUpEdit))]
    [ProvideProperty("_AddNull", typeof(LookUpEdit))]
    public partial class DataBindingLUE : Component, IExtenderProvider
    {
        private Dictionary<LookUpEdit, BindingDataC> ListLue = null;
        public DataBindingLUE()
        {
            InitializeComponent();
            ListLue = new Dictionary<LookUpEdit, BindingDataC>();
        }

        public DataBindingLUE(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            ListLue = new Dictionary<LookUpEdit, BindingDataC>();
        }


        #region 绑定数据类型
        [Category("扩展")]
        [Description("绑定数据类型"), DefaultValue(BusinessSQLite.CustomerEnum.EnumCommonDicData.染料名称)]
        public BusinessSQLite.CustomerEnum.EnumCommonDicData GetData(LookUpEdit lue)
        {
            if (ListLue.ContainsKey(lue))
            {
                return ListLue[lue].DataType;
            }
            return BusinessSQLite.CustomerEnum.EnumCommonDicData.染料名称;
        }
        public void SetData(LookUpEdit lue, BusinessSQLite.CustomerEnum.EnumCommonDicData _DataType)
        {
            if (!ListLue.ContainsKey(lue))
            {
                ListLue.Add(lue, new BindingDataC()
                {
                    DataType = _DataType
                });
            }
            else
            {
                ListLue[lue].DataType = _DataType;
            }
            if (CheckDesingModel.IsDesingMode) return;

            ListLue[lue].BandData(lue.Properties);

        }
        #endregion

        #region 是否添加空行
        [Category("扩展")]
        [Description("是否添加空行"), DefaultValue(false)]
        public bool Get_AddNull(LookUpEdit lue)
        {
            if (ListLue.ContainsKey(lue))
            {
                return ListLue[lue].AddNull;
            }
            return false; ;
        }
        public void Set_AddNull(LookUpEdit lue, bool addnull)
        {
            if (!ListLue.ContainsKey(lue))
            {
                ListLue.Add(lue, new BindingDataC()
                {
                    AddNull = addnull
                });
            }
            else
            {
                ListLue[lue].AddNull = addnull;
            }
        }
        #endregion

        #region 是否添加空行
        [Category("扩展")]
        [Description("是否显示组合字段"), DefaultValue(false)]
        public bool Get_DisplayCombination(LookUpEdit lue)
        {
            if (ListLue.ContainsKey(lue))
            {
                return ListLue[lue].DisplayCombination;
            }
            return false; ;
        }
        public void Set_DisplayCombination(LookUpEdit lue, bool displaycombination)
        {
            if (!ListLue.ContainsKey(lue))
            {
                ListLue.Add(lue, new BindingDataC()
                {
                    DisplayCombination = displaycombination
                });
            }
            else
            {
                ListLue[lue].DisplayCombination = displaycombination;
            }
        }
        #endregion


        #region IExtenderProvider 成员
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CanExtend(object extendee)
        {
            return (extendee is LookUpEdit);
        }
        #endregion
    }
}
