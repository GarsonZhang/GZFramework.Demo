using DevExpress.XtraBars;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.RibbonButton
{
    internal class RibbonControlGenerate : IDisposable
    {
        DevExpress.XtraBars.Ribbon.RibbonControl DefaultRbControl;
        DevExpress.XtraBars.Ribbon.RibbonPage DefaultRbPage;
        DevExpress.XtraBars.Ribbon.RibbonPageGroup DefaultRbPageGroup;
        DevExpress.XtraBars.Ribbon.RibbonPageGroup DefaultNavRbPageGroup;

        Form OnwerForm;
        public RibbonControlGenerate(Form frm)
        {
            OnwerForm = frm;
            //Control
            DefaultRbControl = new DevExpress.XtraBars.Ribbon.RibbonControl();

            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).BeginInit();
            //页  page
            DefaultRbPage = new DevExpress.XtraBars.Ribbon.RibbonPage(RibbonLoad.RibbonPageText);

            //组 关闭按钮
            var CloseRbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup("功能");
            DefaultRbPage.Groups.Add(CloseRbPageGroup);

            //var item = AddBarItem("BarItemLinkClose", "关闭", global::GZFramework.UI.Dev.Properties.Resources.hide_32x32);
            //按钮 baritem
            DevExpress.XtraBars.BarButtonItem bbiClose = getButtonItem("BarItemLinkClose", "关闭", global::GZFramework.UI.Dev.Properties.Resources.hide_32x32);

            DefaultRbControl.Items.Add(bbiClose);
            var link = CloseRbPageGroup.ItemLinks.Add(bbiClose);

            link.Item.ItemClick += Item_ItemClick;


            DefaultRbControl.Pages.Add(DefaultRbPage);
            //组 group
            DefaultRbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup(RibbonLoad.RibbonPageGroupOptionText);
            DefaultRbPage.Groups.Add(DefaultRbPageGroup);

            //组 group
            DefaultNavRbPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup(RibbonLoad.RibbonPageGroupDataNavText);
            DefaultRbPage.Groups.Add(DefaultNavRbPageGroup);


            DefaultRbControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            DefaultRbControl.ShowToolbarCustomizeItem = false;
            DefaultRbControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            DefaultRbControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            DefaultRbControl.AutoHideEmptyItems = true;
            DefaultRbControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            frm.Controls.Add(DefaultRbControl);


            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).EndInit();
            frm.Load += frm_Load;
        }

        private void Item_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (OnwerForm != null)
                OnwerForm.Close();
        }

        void frm_Load(object sender, EventArgs e)
        {
            (sender as Form).Controls.SetChildIndex(DefaultRbControl, 9999);
        }


        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="Caption"></param>
        /// <param name="LargeGlyphName"></param>
        public BarItemLink AddBarItem(string btnName, string sCaption, Image sLargeGlyph)
        {
            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).BeginInit();
            //按钮 baritem
            DevExpress.XtraBars.BarButtonItem bbi = getButtonItem(btnName, sCaption, sLargeGlyph);

            DefaultRbControl.Items.Add(bbi);
            var link = DefaultRbPageGroup.ItemLinks.Add(bbi);
            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).EndInit();
            return link;
        }

        private BarButtonItem getButtonItem(string btnName, string sCaption, Image sLargeGlyph)
        {
            return new DevExpress.XtraBars.BarButtonItem()
            {
                Name = btnName,
                Caption = sCaption,
                LargeGlyph = sLargeGlyph
            }; ;
        }

        private BarButtonItem getSmallItem(string btnName, string sCaption, Image sLargeGlyph)
        {
            return new DevExpress.XtraBars.BarButtonItem()
            {
                Name = btnName,
                Caption = sCaption,
                Glyph = sLargeGlyph
            }; ;
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="Caption"></param>
        /// <param name="LargeGlyphName"></param>
        public BarItemLink InsertBarItem(string btnName, string sCaption, Image sLargeGlyph, BarItemLink ReferItem, bool Before)
        {
            BarButtonItem CurrentItem = getButtonItem(btnName, sCaption, sLargeGlyph);
            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).BeginInit();

            DefaultRbControl.Items.Add(CurrentItem);

            int position = DefaultRbPageGroup.ItemLinks.IndexOf(ReferItem);
            if (Before == false)
                position += 1;

            var link = DefaultRbPageGroup.ItemLinks.Insert(position, CurrentItem);
            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).EndInit();
            return link;
        }


        ///// <summary>
        ///// 新增一个快捷按钮
        ///// </summary>
        ///// <param name="sCaption"></param>
        //public BarItem AddNavBarItem(string sCaption)
        //{
        //    //按钮 baritem
        //    DevExpress.XtraBars.BarButtonItem bbi = new DevExpress.XtraBars.BarButtonItem() { Caption = sCaption };
        //    DefaultRbControl.Items.Add(bbi);
        //    DefaultRbPageGroup.ItemLinks.Add(bbi);
        //    return bbi;
        //}
        /// <summary>
        /// 添加快捷按钮
        /// </summary>
        /// <param name="Caption"></param>
        /// <param name="LargeGlyphName"></param>
        public BarItemLink AddNavBarItem(string btnName, string sCaption, Image sGlyph, bool beginGroup)
        {
            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).BeginInit();
            //按钮 baritem
            DevExpress.XtraBars.BarButtonItem bbi = getSmallItem(btnName, sCaption, sGlyph);

            DefaultRbControl.Items.Add(bbi);
            BarItemLink link = DefaultNavRbPageGroup.ItemLinks.Add(bbi, beginGroup);
            ((System.ComponentModel.ISupportInitialize)(DefaultRbControl)).EndInit();
            return link;

        }

        public void Dispose()
        {
            if (DefaultRbPage != null)
            {
                DefaultRbPage.Dispose();
                DefaultRbPage = null;
            }
            if (DefaultRbPageGroup != null)
            {
                DefaultRbPageGroup.Dispose();
                DefaultRbPageGroup = null;
            }
        }


    }
}
