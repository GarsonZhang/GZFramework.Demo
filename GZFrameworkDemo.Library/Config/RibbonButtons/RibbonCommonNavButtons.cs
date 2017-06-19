using GZFramework.UI.Core.RibbonButton;
using GZFramework.UI.Dev;
using GZFramework.UI.Dev.RibbonButton;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.RibbonButtons
{
    internal class RibbonCommonNavButtons : IRibbonCommonNavButtons, IDisposable
    {
        private RibbonItemNavButton _btnMoveFirst;
        private RibbonItemNavButton _btnMoveLast;
        private RibbonItemNavButton _btnMovePrevious;
        private RibbonItemNavButton _btnMoveNext;


        public RibbonItemButtonBase btnMoveFirst
        {
            get
            {
                if (_btnMoveFirst == null)
                {
                    _btnMoveFirst = new RibbonItemNavButton()
                    {
                        name = "bi_nav_First",
                        Caption = "第一",
                        ImgFileName = "datanav_First_16x16.png",
                        BeginGroup = false
                    };
                }
                return _btnMoveFirst;
            }
        }

        public RibbonItemButtonBase btnMoveLast
        {
            get
            {
                if (_btnMoveLast == null)
                {
                    _btnMoveLast = new RibbonItemNavButton()
                    {
                        name = "bi_nav_Last",
                        Caption = "最后",
                        ImgFileName = "datanav_Last_16x16.png",
                        BeginGroup = false
                    };
                }
                return _btnMoveLast;
            }
        }



        public RibbonItemButtonBase btnMovePrevious
        {
            get
            {
                if (_btnMovePrevious == null)
                {
                    _btnMovePrevious = new RibbonItemNavButton()
                    {
                        name = "bi_nav_Previous",
                        Caption = "上一条",
                        ImgFileName = "datanav_Previous_16x16.png",
                        BeginGroup = true
                    };
                }
                return _btnMovePrevious;
            }
        }
        public RibbonItemButtonBase btnMoveNext
        {
            get
            {
                if (_btnMoveNext == null)
                {
                    _btnMoveNext = new RibbonItemNavButton()
                    {
                        name = "bi_nav_Next",
                        Caption = "下一条",
                        ImgFileName = "datanav_Next_16x16.png",
                        BeginGroup = false
                    };
                }
                return _btnMoveNext;
            }
        }
        public void Dispose()
        {
            if (_btnMoveFirst != null)
            {
                _btnMoveFirst.Dispose();
                _btnMoveFirst = null;
            }
            if (_btnMoveLast != null)
            {
                _btnMoveLast.Dispose();
                _btnMoveLast = null;
            }
            if (_btnMovePrevious != null)
            {
                _btnMovePrevious.Dispose();
                _btnMovePrevious = null;
            }
            if (_btnMoveNext != null)
            {
                _btnMoveNext.Dispose();
                _btnMoveNext = null;
            }
        }
    }
}
