using System;
using System.Drawing;

namespace ColorReductionMethods.ReductionMethods
{
    public class ErrorDiffusionDithering
    {
        private static readonly double[,] FloydSteinbergArray = { { 0, 0, 0 }, { 0, 0, 7 }, { 3, 5, 1 } };
        private static readonly double[,] BurkesArray = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 8, 4 }, { 2, 4, 8, 4, 2 } };
        private static readonly double[,] StuckyArray = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 8, 4 }, { 2, 4, 8, 4, 2 }, { 1, 2, 4, 2, 1 } };

        public static readonly Filter FloydSteinbergFilter = new Filter(3, 3, FloydSteinbergArray, 16);
        public static readonly Filter BurkesFilter = new Filter(5, 3, BurkesArray, 32);
        public static readonly Filter StuckyFilter = new Filter(5, 5, StuckyArray, 42);

        // Number of colors per channel
        private int kr;
        private int kb;
        private int kg;
        public int Kr
        { 
            get => kr;
            set { kr = value; CalculateLUT(LUTR, Kr); }
        }
        public int Kg
        {
            get => kg;
            set { kg = value; CalculateLUT(LUTG, Kg); }
        }
        public int Kb
        {
            get => kb;
            set { kb = value; CalculateLUT(LUTB, Kb); }
        }

        // Look-up tables per channel
        private readonly int[] LUTR = new int[256];
        private readonly int[] LUTG = new int[256];
        private readonly int[] LUTB = new int[256];

        public ErrorDiffusionDithering(int _kr, int _kg, int _kb)
        {
            Kr = _kr;
            Kg = _kg;
            Kb = _kb;
        }

        public DirectBitmap Calculate(DirectBitmap _source, Filter filter)
        {
            // Copy source for error diffusing
            DirectBitmap src = new DirectBitmap(_source);

            DirectBitmap output = new DirectBitmap(src.Width, src.Height);

            for (int y = 0; y < output.Height; y++)
            {
                for (int x = 0; x < output.Width; x++)
                {
                    Color s = src.GetPixel(x, y);

                    // Approximate source pixel to nearest displayable intensity
                    int r = LUTR[s.R];
                    int g = LUTG[s.G];
                    int b = LUTB[s.B];

                    // Calculate errors
                    float er = s.R - r;
                    float eg = s.G - g;
                    float eb = s.B - b;

                    // Draw pixel at (x, y)
                    Color c = Color.FromArgb(s.A, r, g, b);
                    output.SetPixel(x, y, c);

                    // Diffuse error
                    for (int i = -filter.RadiusY; i <= filter.RadiusY; i++)
                    {
                        int fy = y + i;
                        // Omit out-of-bound
                        if (fy < 0 || fy >= output.Height)
                            continue;
                        for (int j = -filter.RadiusX; j <= filter.RadiusX; j++)
                        {
                            int fx = x + j;
                            // Omit out-of-bound
                            if (fx < 0 || fx >= output.Width)
                                continue;
                            // Omit 0 cells
                            if (filter.values[i + filter.RadiusY, j + filter.RadiusX] == 0)
                                continue;

                            Color oc = src.GetPixel(fx, fy);
                            byte nr = PlusTruncate(oc.R, er * filter.values[i + filter.RadiusY, j + filter.RadiusX]);
                            byte ng = PlusTruncate(oc.G, eg * filter.values[i + filter.RadiusY, j + filter.RadiusX]);
                            byte nb = PlusTruncate(oc.B, eb * filter.values[i + filter.RadiusY, j + filter.RadiusX]);
                            Color nc = Color.FromArgb(oc.A, nr, ng, nb);
                            src.SetPixel(fx, fy, nc);
                        }
                    }
                }
            }

            return output;
        }

        /// <summary>
        /// Calculates channel look-up table by dividing [0, 255] into <paramref name="k"/>-1 segments.
        /// </summary>
        /// <param name="LUT">Look-up table.</param>
        /// <param name="k">Min. 2, Max. 255</param>
        private static void CalculateLUT(int[] LUT, int k)
        {
            // Divide [0, 255] range into k-1 segments
            double step = 255 / (k - 1);
            double currentIntensity = 0;
            double nextIntensity = step;
            double threshold = (currentIntensity + nextIntensity) / 2;

            for (int i = 0; i < 256; i++)
            {
                if (i > nextIntensity)
                {
                    currentIntensity = nextIntensity;
                    nextIntensity += step;
                    threshold = (currentIntensity + nextIntensity) / 2;
                }

                if (i < threshold)
                    LUT[i] = (int)Math.Round(currentIntensity);
                else
                    LUT[i] = (int)Math.Round(nextIntensity);
            }
        }

        /// <summary>
        /// Adds <paramref name="b"/> to <paramref name="a"/>, then clamps the result into single byte range.
        /// </summary>
        private static byte PlusTruncate(byte a, double b)
        {
            double c = a + b;
            if (c < 0) return 0;
            if (c > 255) return 255;
            return (byte)c;
        }
    }

    /// <summary>
    /// Helper filter wrapper
    /// </summary>
    public class Filter
    {
        readonly int Width;
        readonly int Height;
        public readonly double[,] values;
        public readonly int RadiusX;
        public readonly int RadiusY;

        public Filter(int width, int height, double[,] numerators, int denominator)
        {
            Width = width;
            Height = height;
            RadiusX = (width - 1) / 2;
            RadiusY = (height - 1) / 2;

            values = numerators;
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    values[i, j] /= denominator;
        }
    }
}
