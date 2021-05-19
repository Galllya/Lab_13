using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class GeometricDistribution
    {
        int m = 5;
        Random random = new Random();
        public double[] P = new double[5];
      

        public int[] Statistical(double p, int N)
        {
            
            int[] statistical = new int[5+2];

            double sum = 0;

            for (int j = 0; j < m-1; j++)
            {
                
                    P[j] = p * Math.Pow((1 - p), j);
                sum += P[j];
            }
            P[m - 1] = 1-sum;



            int[] Statistic = new int[m];
            for (int i = 0; i < N; i++)
            {

                double a = random.NextDouble();
                int X = (int)Math.Truncate(Math.Log10(a) / Math.Log10(1 - p));
                if (X < 4)
                {
                    Statistic[X]++;
                }
                else
                {
                    Statistic[4]++;
                }
            }
            return Statistic;

        }


       

    }
}



