using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class Histogram
    {

            int[] RHistogram = new int[256];
            int[] GHistogram = new int[256];
            int[] BHistogram = new int[256];
            int[] AHistogram = new int[256];
            int[,] FullHistogram = new int[256, 4];
            Bitmap lol;
            public Histogram(Bitmap lol)
            {
                this.lol = lol;
                for (int x = 0; x < this.lol.Width; ++x)
                {
                    for (int y = 0; y < this.lol.Height; ++y)
                    {
                        Color pixelColor = this.lol.GetPixel(x, y);
                        RHistogram[Convert.ToInt32(pixelColor.R.ToString())] += 1;
                        GHistogram[Convert.ToInt32(pixelColor.G.ToString())] += 1;
                        BHistogram[Convert.ToInt32(pixelColor.B.ToString())] += 1;
                        AHistogram[Convert.ToInt32(pixelColor.A.ToString())] += 1;
                    }
                }

                 for (int w = 0; w < 256; ++w)
                 {
                   FullHistogram[w,0] = RHistogram[w];
                   FullHistogram[w,1] = GHistogram[w];
                   FullHistogram[w,2] = BHistogram[w];
                   FullHistogram[w,3] = AHistogram[w];
                    
                 }

            //to ma być jakby tworzenie histogramu - co zgadza się z ideą konstruktora
            }
        public int MyProperty { get; private set; }


    }
}
