using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ICCardSystem.Utility;

namespace ICCardSystem.Common
{
    /// <summary>
    /// 生成验证码
    /// </summary>
    public class CheckCode
    {
        #region 字段属性

        private int intLength = 5;       // 长度
        public int IntLength
        {
            get { return intLength; }
            set { intLength = value; }
        }

        private int intHeigth = 30;      // 高度
        public int IntHeigth
        {
            get { return intHeigth; }
            set { intHeigth = value; }
        }

        private float fontSize = 14.0f;	 // 字体大小 
        public float FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }

        // 验证码图
        private MemoryStream imageStream = new MemoryStream();
        public MemoryStream ImageStream
        {
            get { return imageStream; }
            set { imageStream = value; }
        }

        // 验证码
        public string StrCode { get; set; }

        #endregion

        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        public bool ProcessCode()
        {
            StrCode = GenerateCheckCode(intLength);
            if (StrCode == null || StrCode.Trim() == String.Empty)
                return false;
            Bitmap image = new Bitmap((int)Math.Ceiling((intLength * fontSize)), intHeigth);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器
                Random random = new Random();
                //清空图片背景色
                g.Clear(Color.White);
                //画图片的背景噪音线
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }
                Font font = new Font("Times New Roman", fontSize, (FontStyle.Italic | FontStyle.Bold)); // FontStyle.Strikeout
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Black, Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), 1.2f, true);
                g.DrawString(StrCode, font, brush, 2, (float)(intHeigth / 2.0 - fontSize + 4));
                //画图片的前景噪音点
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Gray), 0, 0, image.Width - 1, image.Height - 1);
                ImageStream.Close();
                ImageStream = new MemoryStream();
                image.Save(ImageStream, ImageFormat.Gif);
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
                return false;
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }

        // 生成验证码
        private string GenerateCheckCode(int len)
        {
            char[] code = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            System.Random random = new Random(DateTime.Now.Millisecond);
            string checkCode;
            do
            {
                checkCode = string.Empty;
                for (int i = 0; i < len; ++i)
                {
                    char key = code[random.Next(0, 36)];
                    checkCode += key;
                }
            } while (checkCode.Contains("0") && checkCode.Contains("o"));
            return checkCode;
        }
    }
}