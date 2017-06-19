using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingPSISQLite.PSIModule
{
    public partial class frmMain : Library.ModuleProvider.frmModuleBase
    {
        public frmMain()
        {
            InitializeComponent();
            this.AddFunction(btnPO, typeof(frmPO), "入库");
            this.AddFunction(btnProductInventory, typeof(frmProductInventory), "库存信息");
            this.AddFunction(btnSale, typeof(frmSale), "销售");
            this.AddFunction(btnSaleReport, typeof(frmSaleReport), "销售统计");
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmPO));
        }

        private void btnProductInventory_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmProductInventory));
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmSale));
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmSaleReport));
        }
    }
}
