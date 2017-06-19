using GZFrameworkDemo.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyClass
{
    public class LoadUIImage
    {
        /// <summary>
        /// 尺寸类型
        /// </summary>
        private enum ImageType
        {
            /// <summary>
            /// 16x16尺寸
            /// </summary>
            Small=16,
            /// <summary>
            /// 32x32尺寸
            /// </summary>
            Normal=32,
            /// <summary>
            /// 64x64尺寸
            /// </summary>
            Large=64
        }


        private static string GetFullFileName(string ImgFileName)
        {
            return Globals.BaseDirectory + "\\" + ImgFileName;
        }

        private static Image LoadImage(string imgFileName, ImageType ImageSize)
        {
            return ImageLibrary.LoadImageByFileEx(GetFullFileName(imgFileName), (int)ImageSize);
        }

        public static Image LoadImage(string imgFileName)
        {
            string ImagePath = Globals.BaseDirectory + "\\images\\" + imgFileName;
            return ImageLibrary.LoadImageByFileEx(ImagePath);
        }


        /// <summary>
        /// 加载NavBarControl Group图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadNavBarImage_Group(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }
        /// <summary>
        /// 加载NavBarControl Item图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadNavBarImage_Item(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }


        /// <summary>
        /// 加载Ribbon BarItem操作组图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadRibbonControlLargeGlyph_BarItem(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Normal);
        }

        /// <summary>
        /// 加载Ribbon BarItem操作组图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadRibbonControlGlyph_BarItem(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }

        /// <summary>
        /// 加载MDI TagPag图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadMDIImg_TabPag(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Small);
        }

        /// <summary>
        /// 加载ChildForm ICO
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Icon LoadFormIcon(string SimpleImgFileName)
        {
            Bitmap bmp = new Bitmap(LoadImage(SimpleImgFileName, ImageType.Small));
            return Icon.FromHandle(bmp.GetHicon());

        }

        /// <summary>
        /// 加载模块功能图标
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Image LoadFunctionButtonImg(string SimpleImgFileName)
        {
            return LoadImage(SimpleImgFileName, ImageType.Large);
        }

    }
}
