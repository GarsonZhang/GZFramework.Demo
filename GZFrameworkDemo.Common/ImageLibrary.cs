using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class ImageLibrary
    {

        /// <summary>
        /// 图片转换为数组
        /// </summary>
        /// <param name="img">图片实例</param>
        /// <returns></returns>
        public static byte[] ConvertImage2Bytes(Image img)
        {
            if (img == null) return null;
            MemoryStream ms = new MemoryStream();
            try
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(ms, ImageFormat.Bmp);
                byte[] bs = ms.ToArray();
                ms.Close();
                return bs;
            }
            catch { ms.Close(); return null; }
        }
        /// <summary>
        /// 按宽度比例缩小图片
        /// </summary>
        /// <param name="imgSource">原始图片</param>
        /// <param name="MAX_WIDTH">最大宽度</param>
        /// <returns></returns>
        public static Image ResizeImage(Image imgSource, int MAX_WIDTH, int MAX_HEIGHT)
        { 
            Image imgOutput = imgSource;

            Size size = new Size(0, 0); //用于存储按比例计算后的宽和高参数

            if (imgSource.Width <= 3 || imgSource.Height <= 3) return imgSource; //3X3大小的图片不转换

            //按宽度缩放图片
            if (imgSource.Width > MAX_WIDTH) //计算宽度
            {
                double rate = MAX_WIDTH / (double)imgSource.Width; //计算宽度比例因子

                size.Width = Convert.ToInt32(imgSource.Width * rate);
                size.Height = Convert.ToInt32(imgSource.Height * rate);
                imgOutput = imgSource.GetThumbnailImage(size.Width, size.Height, null, IntPtr.Zero);
            }

            //按高度缩放图片
            if (imgOutput.Height > MAX_HEIGHT)//计算高度
            {
                double rate = MAX_HEIGHT / (double)imgOutput.Height; //计算宽度比例因子

                size.Width = Convert.ToInt32(imgOutput.Width * rate);
                size.Height = Convert.ToInt32(imgOutput.Height * rate);
                imgOutput = imgSource.GetThumbnailImage(size.Width, size.Height, null, IntPtr.Zero);
            }

            return imgOutput;
        }


        /// <summary>
        /// 生成空图标
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="Text"></param>
        /// <returns></returns>
        private static Image GenerateNullImage(int Width, int Height, string Text)
        {
            Bitmap bmp = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.PaleVioletRed, new Rectangle() { X = 0, Y = 0, Height = 100, Width = 100 });

            Font font = new Font("宋体", 8);

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(Text, font, Brushes.Black, new Rectangle(0, 0, Width, Height), sf);


            return bmp;
        }

        //public static Image LoadImageByFileEx(string fileName, int ImageSize)
        //{
        //    if (File.Exists(fileName))
        //        return Image.FromFile(fileName);
        //    else
        //    {
        //        string str = String.Format("No {0}", System.IO.Path.GetFileNameWithoutExtension(fileName));
        //        return GenerateNullImage(ImageSize, ImageSize, String.Format("No {0}", str));
        //    }
        //}

        public static Image LoadImageByFileEx(string fileName, int ImageSize)
        {
            if (File.Exists(fileName))
                return Image.FromFile(fileName);
            else
                return GenerateNullImage(ImageSize, ImageSize, "No ImgFile");
        }

        public static Image LoadImageByFileEx(string file)
        {
            if (File.Exists(file))
                return Image.FromFile(file);
            else
                return GenerateNullImage(24, 24, String.Format("No ImgFile"));
        }

        public static Image LoadImageByFile(string file)
        {
            if (File.Exists(file))
                return Image.FromFile(file);
            else
                return null;
        }


        public static Bitmap LoadBitmapByFile(string file)
        {
            if (File.Exists(file))
                return new Bitmap(Bitmap.FromFile(file));
            else
                return null;
        }

        /// <summary>
        /// 加载ChildForm ICO
        /// </summary>
        /// <param name="SimpleImgFileName"></param>
        /// <returns></returns>
        public static Icon LoadFormIcon(string SimpleImgFileName)
        {
            Bitmap bmp = new Bitmap(LoadImageByFileEx(SimpleImgFileName, 16));
            return Icon.FromHandle(bmp.GetHicon());

        }
    }
}
