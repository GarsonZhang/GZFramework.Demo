using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    [ProvideProperty("Data", typeof(RepositoryItemLookUpEdit))]
    [ProvideProperty("_DisplayCombination", typeof(RepositoryItemLookUpEdit))]
    [ProvideProperty("_AddNull", typeof(RepositoryItemLookUpEdit))]
    public partial class DataBindingRILUE : Component, IExtenderProvider
    {
        private Dictionary<RepositoryItemLookUpEdit, BindingDataC> StyleList = null;
        public DataBindingRILUE()
        {
            InitializeComponent();
            StyleList = new Dictionary<RepositoryItemLookUpEdit, BindingDataC>();
        }

        public DataBindingRILUE(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            StyleList = new Dictionary<RepositoryItemLookUpEdit, BindingDataC>();
        }

        #region 绑定数据类型
        [Category("扩展")]
        [Description("绑定数据类型"), DefaultValue(Business.CustomerEnum.EnumCommonDicData.染料名称)]
        public Business.CustomerEnum.EnumCommonDicData GetData(RepositoryItemLookUpEdit lue)
        {
            if (StyleList.ContainsKey(lue))
            {
                return StyleList[lue].DataType;
            }
            return Business.CustomerEnum.EnumCommonDicData.染料名称;
        }
        public void SetData(RepositoryItemLookUpEdit lue, Business.CustomerEnum.EnumCommonDicData _DataType)
        {
            if (!StyleList.ContainsKey(lue))
            {
                StyleList.Add(lue, new BindingDataC()
                {
                    DataType = _DataType
                });
            }
            else
            {
                StyleList[lue].DataType = _DataType;
            }
            if (CheckDesingModel.IsDesingMode) return;

            StyleList[lue].BandData(lue);

        }
        #endregion

        #region 是否添加空行
        [Category("扩展")]
        [Description("是否添加空行"), DefaultValue(false)]
        public bool Get_AddNull(RepositoryItemLookUpEdit lue)
        {
            if (StyleList.ContainsKey(lue))
            {
                return StyleList[lue].AddNull;
            }
            return false; ;
        }
        public void Set_AddNull(RepositoryItemLookUpEdit lue, bool addnull)
        {
            if (!StyleList.ContainsKey(lue))
            {
                StyleList.Add(lue, new BindingDataC()
                {
                    AddNull = addnull
                });
            }
            else
            {
                StyleList[lue].AddNull = addnull;
            }
        }
        #endregion

        #region 是否添加空行
        [Category("扩展")]
        [Description("是否显示组合字段"), DefaultValue(false)]
        public bool Get_DisplayCombination(RepositoryItemLookUpEdit lue)
        {
            if (StyleList.ContainsKey(lue))
            {
                return StyleList[lue].DisplayCombination;
            }
            return false; ;
        }
        public void Set_DisplayCombination(RepositoryItemLookUpEdit lue, bool displaycombination)
        {
            if (!StyleList.ContainsKey(lue))
            {
                StyleList.Add(lue, new BindingDataC()
                {
                    DisplayCombination = displaycombination
                });
            }
            else
            {
                StyleList[lue].DisplayCombination = displaycombination;
            }
        }
        #endregion




        #region IExtenderProvider 成员
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CanExtend(object extendee)
        {
            return (extendee is RepositoryItemLookUpEdit) || (extendee is LookUpEdit);
        }
        #endregion
    }

}
