using DevExpress.XtraEditors.Repository;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library
{

    internal class BindingDataC
    {
        private BusinessSQLite.CustomerEnum.EnumCommonDicData datatype;

        public BusinessSQLite.CustomerEnum.EnumCommonDicData DataType
        {
            get { return datatype; }
            set { datatype = value; }
        }

        private bool addnull = false;
        public bool AddNull { get { return addnull; } set { addnull = value; } }

        private bool displaycombination = false;
        public bool DisplayCombination { get { return displaycombination; } set { displaycombination = value; } }


        public void BandData(RepositoryItemLookUpEdit lue)
        {
            DataBinderTools.Bound.BoundCommonDictDataName(lue, datatype, displaycombination, addnull);
            //switch (datatype)
            //{
            //    case BindingDataList.尺码:
            //        {
                        
            //        }; break;
            //    case BindingDataList.用户名:
            //        {
            //            DataBinderTools.Bound.BoundUserName(lue);
            //        }; break;
            //}
        }
    }
}
