using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class PictureInvert : Picture
    {
        //wszystkie zmienne klasy bazowej są tutaj

        public PictureInvert(Bitmap mypicture) : base(mypicture)
        {
            for (int x = 0; x < mypicture.Width; ++x)
            {
                for (int y = 0; y < mypicture.Height; ++y)
                {
                    Color pixelColor = mypicture.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0xff - pixelColor.R
                   , 0xff - pixelColor.G, 0xff - pixelColor.B);
                    mypicture.SetPixel(x, y, newColor);

                }
            }
        }

    }
}
