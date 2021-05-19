using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Mathematics
    {
        public double Average(double[] pop)
        {
            double average = 0;
            for (int i = 1; i < 5; i++)
            {
                average += (i) * pop[i];
            }

            return average;
        }

        public int Prosent(double E, double M)
        {
            double prosent = (Math.Abs(E - M)) / E;
            int prosenttt = (int)(prosent * 100);
            return prosenttt;
        }

        public double Variance(double[] pop)
        {
            double varoance = 0;
            for (int i = 1; i < 5; i++)
            {
                varoance += (i) * (i) * pop[i];
            }

            varoance -= Average(pop) * Average(pop); ;

            return varoance;
        }

        public double Xi(int[] first, int max, double[] P)
        {
            double xi = 0;

            double r;
            for (int i = 0; i < 5; i++)
            {
                xi += (first[i] * first[i]) / (double)(max * P[i]);
            }
            xi -= max;

            return xi;
        }
    }
}
