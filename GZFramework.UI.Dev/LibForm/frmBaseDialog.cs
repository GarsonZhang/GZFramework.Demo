using GZFramework.UI.Core.FormInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.LibForm
{
    public partial class frmBaseDialog : DevExpress.XtraEditors.XtraForm, IFormDialog
    {



        public frmBaseDialog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }


        private void frmBaseDialog_Load(object sender, EventArgs e)
        {

        }

        public virtual object GetResult() { return null; }
    }


}
