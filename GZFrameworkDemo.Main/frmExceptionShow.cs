using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Main
{
    public partial class frmExceptionShow : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public static void Show(Exception e)
        {
            frmExceptionShow frm = new frmExceptionShow(e);
            frm.ShowDialog();
        }
        private frmExceptionShow(Exception e)
        {
            InitializeComponent();
            groupControl1.Text = e.Message;
            this.txtContent.Text = e.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
