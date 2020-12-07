using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReductionMethods.ReductionMethods
{
    interface IReductionMethod
    {
        DirectBitmap Calculate(DirectBitmap source);
    }

    class Helpers
    {
        /// <summary>
        /// Calculates distance between two colors in euclidian RGB space.
        /// </summary>
        public static int ColorDistanceSquared(Color a, Color b)
        {
            return (a.R - b.R) * (a.R - b.R) + (a.G - b.G) * (a.G - b.G) + (a.G - b.G) * (a.G - b.G);
        }

        // Adapted from: https://stackoverflow.com/questions/1335426/is-there-a-built-in-c-net-system-api-for-hsv-to-rgb
        public static Color HsvToRgb(double h, double S, double V)
        {
            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            if (V <= 0)
            {
                return ClampColor(0, 0, 0);
            }
            else if (S <= 0)
            {
                return ClampColor(V, V, V);
            }

            double hf = H / 60.0;
            int i = (int)Math.Floor(hf);
            double f = hf - i;
            double pv = V * (1 - S);
            double qv = V * (1 - S * f);
            double tv = V * (1 - S * (1 - f));
            switch (i)
            {

                // Red is the dominant color
                case 0: return ClampColor(V, tv, pv);

                // Green is the dominant color
                case 1: return ClampColor(qv, V, pv);
                case 2: return ClampColor(pv, V, tv);

                // Blue is the dominant color
                case 3: return ClampColor(pv, qv, V);
                case 4: return ClampColor(tv, pv, V);

                // Red is the dominant color
                case 5: return ClampColor(V, pv, qv);

                // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.
                case 6: return ClampColor(V, tv, pv);
                case -1: return ClampColor(V, pv, qv);

                // The color is not defined, we should throw an error.
                default:
                    //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                    return ClampColor(V, V, V); // Just pretend its black/white
            }
            
        }

        public static Color ClampColor(double r, double g, double b)
        {
            return Color.FromArgb(
                Clamp((int)(r * 255.0)),
                Clamp((int)(g * 255.0)),
                Clamp((int)(b * 255.0))
                );
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        public static int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        public static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
    }
}
