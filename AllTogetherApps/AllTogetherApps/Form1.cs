using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace AllTogetherApps
{
    public partial class Form1 : Form
    {
        private String FileLocation = "";
        private String FileName = @"\Lawl.txt";
        private String Path;

        public Form1()
        {
            InitializeComponent();
            Path = Environment.CurrentDirectory + FileName;
            FileLocation = Environment.CurrentDirectory;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void TakeScreenShot()
        {
                Bitmap b = BitMapGenerate();

                StringBuilder builder = new StringBuilder();
                byte[] imgBytes = getBytesFromBitmap(b);

                for (int i = 0; i < imgBytes.Length; i++)
                {
                    builder.Append(imgBytes[i]+"");
                }
                WriteFile(builder.ToString());

                String cDateTime = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToShortTimeString();
                this.BackgroundImage = b;
                b.Save(FileLocation + @"\"+"sd"+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void WriteFile(String text)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
                TextWriter tw = new StreamWriter(Path);
                tw.Write(text);
            }
        }

        public byte[] getBytesFromBitmap(Bitmap bitmap)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + ""); }
            return ms.ToArray();
        }

        private static Bitmap BitMapGenerate()
        {
            Bitmap bmpScreen = null;
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            int color = Screen.PrimaryScreen.BitsPerPixel;
            PixelFormat pxFormat;

            switch (color)
            {
                case 8:
                case 16:
                    pxFormat = PixelFormat.Format16bppRgb565;
                    break;

                case 24:
                    pxFormat = PixelFormat.Format24bppRgb;
                    break;

                case 32:
                    pxFormat = PixelFormat.Format32bppArgb;
                    break;

                default:
                    pxFormat = PixelFormat.Format32bppArgb;
                    break;
            }

            try
            {
                bmpScreen = new Bitmap(rect.Width, rect.Height, pxFormat);
                Graphics g = Graphics.FromImage(bmpScreen);
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }
            catch (Exception) { }
            return bmpScreen;
        }

        private void btn_take_screen_Click(object sender, EventArgs e)
        {
            TakeScreenShot();
        }

        private void hotkeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPSCal f = new FPSCal();
            f.ShowDialog();

        }
    }
}
