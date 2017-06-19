using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
//======================================================================
//        版权所有@GarsonZhang
//        文件名 :frmModuleView              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-11 10:09:51
//        描述 :窗体
//======================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClothingPSISQLite.Library;
using ClothingPSISQLite.Library.ModuleFun;

namespace ClothingPSISQLite.Main
{



    public partial class frmModuleView : GZFramework.UI.Dev.LibForm.frmBaseChild
    {
        IMain MDIForm;
        GZFunctionLayout _GZTable;
        public frmModuleView(IMain MDIfrm)
        {
            InitializeComponent();
            MDIForm = MDIfrm;
            _GZTable = new GZFunctionLayout(pan_Container, 90, 103);
        }

        public void UpdateModule(NavBarGroup group)
        {
          
            _GZTable.ClearControl();
            this.Text = group.Caption;
            this.SuspendLayout();
            if (group != null)
            {
                NavBarItem item;

                List<Control> lstAdd = new List<Control>();

                foreach (NavBarItemLink itemLink in group.VisibleItemLinks)
                {
                    item = itemLink.Item;
                    var fun = item.Tag as ModuleFunction;


                    SimpleButton btn = new SimpleButton();
                    btn.Text = fun.FunctionName;

                    btn.Appearance.Options.UseTextOptions = true;
                    btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    btn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
                    btn.Image = ClothingPSISQLite.Library.MyClass.LoadUIImage.LoadFunctionButtonImg(fun.FunctionPngLarge);
                    btn.Margin = new System.Windows.Forms.Padding(5);
                    btn.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
                    btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;

                    btn.Tag = fun;
                    btn.Click += btn_Click;

                    if (fun.IsNew == true)
                    {
                        lstAdd.Add(btn);

                        btn.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                        btn.Font = new Font(btn.Font, FontStyle.Bold);

                        continue;
                    }

                    _GZTable.SetControl(fun.GroupIndex, fun.ItemIndex, btn);
                }

                if (lstAdd.Count > 0)
                {
                    for (int i = 0; i < _GZTable.GT.RowCount; i++)
                    {
                        for (int j = 0; j < _GZTable.GT.CellCount; j++)
                        {
                            if (_GZTable.GT[i][j].IsUsed == false)
                            {
                                _GZTable.SetControl(i, j, lstAdd[0]);
                                lstAdd.RemoveAt(0);
                            }
                            if (lstAdd.Count == 0) break;
                        }
                        if (lstAdd.Count == 0) break;
                    }
                }
            }
            this.Activate();
            this.ResumeLayout();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            ModuleFunction fun = (sender as SimpleButton).Tag as ModuleFunction;

            MDIForm.ShowChildForm(fun);
        }
    }

}
