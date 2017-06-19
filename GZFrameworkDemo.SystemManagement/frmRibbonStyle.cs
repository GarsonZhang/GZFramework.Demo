using GZFrameworkDemo.Library;
using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmRibbonStyle : frmBaseFunction
    {
        public frmRibbonStyle()
        {
            InitializeComponent();
        }

        private void frmRibbonStyle_Load(object sender, EventArgs e)
        {
            //var v = (this.ParentForm) as IMain;
            //propertyGrid1.SelectedObject = v.MainRibbonControl;
        }
    }
}
