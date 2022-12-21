using System;
using System.Buffers;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPicEditApp
{
    static internal class PictureCreator
    {

        public static Picture CreatePicture(Bitmap bitmap, string s) 
        {
            switch (s)
            {
                case "new": return new Picture(bitmap);

                case "invert": return new PictureInvert(bitmap);
                
                default: return null;
            }
        }



    }
}
