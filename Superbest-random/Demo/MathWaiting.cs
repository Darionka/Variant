using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class MathWaiting : DemoForm
    {
        public static double MX(double[] sequence, double[] b)
        {
            double M = 0;
            for(int i = 0; i < sequence.Length; i++)
            {
                M += sequence[i] * b[i];
            }
            return M;
        }
        public static double DX(double[] a, double[] b)
        {
            double[] aa= new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                aa[i] = Math.Pow(a[i], 2);
            }
            return MX(aa, b)-Math.Pow(MX(a,b), 2);
        }
    }
}
