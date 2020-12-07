using System;
using System.Drawing;

namespace ColorReductionMethods.ReductionMethods
{
    // Potetntial optimizations:
    // - When changing K and not source Image, recalculate palette only.
    // - Use RST instead of sorting.
    class PopularityMethod : IReductionMethod
    {
        private int PaletteSize;
        private readonly int[] Buckets = new int[1 << 24];
        private readonly int[] Indices = new int[1 << 24];
        private Color[] Palette;
        private static readonly int RGBMask = (1 << 24) - 1;
        private readonly Func<int> GetK;

        public PopularityMethod(Func<int> getK)
        {
            GetK = getK;
        }
        
        public DirectBitmap Calculate(DirectBitmap source)
        {
            DirectBitmap output = new DirectBitmap(source.Width, source.Height);

            Analyze(source);

            for (int y = 0; y < output.Height; y++)
            {
                for (int x = 0; x < output.Width; x++)
                {
                    output.SetPixel(x, y, Palette[FindClosest(source.GetPixel(x, y))]);
                }
            }

            return output;
        }

        /// <summary>
        /// Analyze source image.
        /// </summary>
        private void Analyze(DirectBitmap source)
        {
            // Clear arrays
            for (int i = 0; i < Indices.Length; i++)
            {
                Indices[i] = i;
                Buckets[i] = 0;
            }

            // Count colors
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    // Use bitmask to get only RGB values (ignore A)
                    int c = source.GetPixelRaw(x, y) & RGBMask;
                    Buckets[c]++;
                }
            }

            // Find k most popular colors and store them in Palette
            Array.Sort(Indices, CompareBuckets);

            // Get palette size
            PaletteSize = GetK();

            Palette = new Color[PaletteSize];
            for (int i = 0; i < PaletteSize; i++)
            {
                byte r = (byte)((Indices[i] >> 16) & 0xff);
                byte g = (byte)((Indices[i] >> 8) & 0xff);
                byte b = (byte)(Indices[i] & 0xff);
                Palette[i] = Color.FromArgb(r, g, b);
            }
        }

        /// <summary>
        /// Finds closest color in set palette.
        /// </summary>
        private int FindClosest(Color color)
        {
            // Highest possible distance: 255*255 + 255*255 + 255*255 = 195075
            int bestDistance = 200000;
            int bestIndex = -1;
            for (int i = 0; i < PaletteSize; i++)
            {
                int distance = ColorDistanceSquared(color, Palette[i]);
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                    bestIndex = i;
                }
            }
            return bestIndex;
        }

        /// <summary>
        /// Calculates distance between two colors in euclidian RGB space.
        /// </summary>
        private static int ColorDistanceSquared(Color a, Color b)
        {
            return (a.R - b.R) * (a.R - b.R) + (a.G - b.G) * (a.G - b.G) + (a.G - b.G) * (a.G - b.G);
        }

        /// <summary>
        /// Reverse sort by value in bucket.
        /// </summary>
        /// <param name="left">Bucket index</param>
        /// <param name="right">Bucket index</param>
        public int CompareBuckets(int left, int right)
        {
            if (Buckets[left] < Buckets[right])
                return 1;
            else if (Buckets[left] > Buckets[right])
                return -1;
            else
                return 0;
        }
    }
}
