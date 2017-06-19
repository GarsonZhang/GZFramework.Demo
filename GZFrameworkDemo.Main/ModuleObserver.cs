using DevExpress.XtraNavBar;
using GZFrameworkDemo.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GZFrameworkDemo.Library.ModuleProvider;

namespace GZFrameworkDemo.Main
{
    public class ModuleObserver
    {
        //frmModuleView CurrentModule;
        public event Action<NavBarGroup> SowModule;
        public ModuleObserver(NavBarControl Nav)
        {
            Nav.ActiveGroupChanged += NavBar_ActiveGroupChanged;
            Nav.MouseClick += NavBar_MouseClick;
        }

        private void NavBar_MouseClick(object sender, MouseEventArgs e)
        {
            NavBarControl nav = (sender as NavBarControl);//取到NavBarControl对象引用
            NavBarHitInfo hh = nav.CalcHitInfo(e.Location);//计算点击区域的对象

            NavBarGroup group = hh.Group;

            bool InGroup = hh.InGroup;
            bool InGroupCaption = hh.InGroupCaption;
            if (InGroup && InGroupCaption)//点击导航分组按钮
            {
                try
                {
                    if (group != nav.ActiveGroup)
                    {
                        nav.ActiveGroup = group;
                    }

                    else
                    {
                        //if (CurrentModule != null)
                        //    CurrentModule.Activate();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        

        private void NavBar_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            
            SowModule?.Invoke(e.Group);
        }

    }
}
