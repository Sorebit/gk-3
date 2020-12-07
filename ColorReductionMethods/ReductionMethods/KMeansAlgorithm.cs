using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ColorReductionMethods.ReductionMethods
{
    class KMeansAlgorithm : IReductionMethod
    {
        private readonly Func<int> GetIterations;
        private readonly Func<int> GetClusterNum;
        private readonly Random randomizer = new Random();

        public DirectBitmap Calculate(DirectBitmap source)
        {
            DirectBitmap output = new DirectBitmap(source.Width, source.Height);
            int clustersNum = GetClusterNum();
            int iterationsNum = GetIterations();

            //Inits centroids
            List<Vector3D> centroids = new List<Vector3D>(clustersNum);
            List<List<Vector3D>> clusters = new List<List<Vector3D>>(clustersNum);

            for (int i = 0; i < clustersNum; i++)
            {
                int x = randomizer.Next(source.Width);
                int y = randomizer.Next(source.Height);
                Vector3D centroid = new Vector3D(source.GetPixel(x, y), x, y);

                List<Vector3D> cluster = new List<Vector3D>
                {
                    centroid
                };
                clusters.Add(cluster);

                centroids.Add(centroid);
            }

            for (int it = 0; it < iterationsNum; it++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    for (int y = 0; y < source.Height; y++)
                    {
                        Vector3D currentVector = new Vector3D(source.GetPixel(x, y), x, y);
                        double minDistanceSq = double.PositiveInfinity;
                        Vector3D closestCentroid = centroids[0];

                        // Find closest centroid
                        foreach (Vector3D centroid in centroids)
                        {
                            double distanceSq = currentVector.ColorDistanceSquared(centroid);
                            if (distanceSq < minDistanceSq)
                            {
                                minDistanceSq = distanceSq;
                                closestCentroid = centroid;
                            }
                        }

                        // Find cluster with that centroid in it
                        List<Vector3D> toAssign = clusters[0];
                        foreach (List<Vector3D> clusterList in clusters)
                        {
                            if (clusterList[0].r == closestCentroid.r && clusterList[0].g == closestCentroid.g && clusterList[0].b == closestCentroid.b)
                            {
                                toAssign = clusterList;
                                break;
                            }
                        }

                        toAssign.Add(currentVector);
                        int curLength = toAssign.Count();
                        Vector3D curCentroid = toAssign[0];

                        Vector3D newCentroid = new Vector3D(0, 0, 0);

                        foreach (Vector3D vector in toAssign)
                        {
                            newCentroid = newCentroid.Sum(vector);
                        }

                        newCentroid = new Vector3D(newCentroid.r / curLength, newCentroid.g / curLength, newCentroid.b / curLength);
                        toAssign.RemoveAt(0);
                        toAssign.Insert(0, newCentroid);

                        for (int i = 0; i < centroids.Count(); i++)
                        {
                            if (centroids[i].r == curCentroid.r && centroids[i].g == curCentroid.g && curCentroid.b == centroids[i].b)
                            {
                                centroids[i] = newCentroid;
                                break;
                            }
                        }
                    }
                }
            }

            foreach (List<Vector3D> clusterList in clusters)
            {
                Vector3D curCentroid = clusterList[0];
                for (int i = 1; i < clusterList.Count(); i++)
                {
                    clusterList[i].r = curCentroid.r;
                    clusterList[i].g = curCentroid.g;
                    clusterList[i].b = curCentroid.b;
                }
            }

            foreach (List<Vector3D> clusterList in clusters)
            {
                for (int i = 0; i < clusterList.Count(); i++)
                {
                    Vector3D currentVector = clusterList[i];
                    Color c = Color.FromArgb((int)currentVector.r, (int)currentVector.g, (int)currentVector.b);
                    output.SetPixel(currentVector.x, currentVector.y, c);
                }
            }

            return output;
        }

        public KMeansAlgorithm(Func<int> getClusterNum, Func<int> getIterations)
        {
            GetClusterNum = getClusterNum;
            GetIterations = getIterations;
        }
    }

    class Vector3D
    {
        public double r, g, b;
        public int x, y;
        public Vector3D(Color c, int _x, int _y)
        {
            r = c.R;
            g = c.G;
            b = c.B;
            x = _x;
            y = _y;
        }
        public Vector3D(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public double ColorDistanceSquared(Vector3D v)
        {
            return (r - v.r) * (r - v.r) + (g - v.g) * (g - v.g) + (b - v.b) * (b - v.b);
        }

        public Vector3D Product(int scalar)
        {
            return new Vector3D(r * scalar, g * scalar, b * scalar);
        }

        public double Length()
        {
            return Math.Sqrt((Math.Pow(r, 2) + Math.Pow(g, 2) + Math.Pow(b, 2)));
        }

        public Vector3D Sum(Vector3D v2)
        {
            double new_r = r + v2.r;
            double new_g = g + v2.g;
            double new_b = b + v2.b;

            return new Vector3D(new_r, new_g, new_b);
        }
    }
}
