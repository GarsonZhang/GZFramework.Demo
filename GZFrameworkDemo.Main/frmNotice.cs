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
    public partial class frmNotice : GZFramework.UI.Dev.LibForm.frmBaseChild
    {
        public static void ShowForm(Form MdiParent)
        {
            frmNotice frm = new frmNotice()
            {
                MdiParent = MdiParent,
                ControlBox = false,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private frmNotice()
        {
            InitializeComponent();
        }

        private void frmNotice_Load(object sender, EventArgs e)
        {


        }

    }
}
