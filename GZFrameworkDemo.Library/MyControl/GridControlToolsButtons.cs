using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyControl
{

    [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
    public class RepositoryItemGridControlTools
    {
        //[TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public ColumnView View { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public GridControlToolsButtons Buttons { get; set; }
    }

    [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
    public class GridControlToolsButtons
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_Import { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_Add { get; set; }
        
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_Delete { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_MoveFirst { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_MovePre { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_MoveNext { get; set; }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_MoveLast { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter("System.ComponentModel.ExpandableObjectConverter, System")]
        public SimpleButton Tools_Save { get; set; }

    }
}
