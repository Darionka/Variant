using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public sealed class Gaussian_distribution : DemoForm
    {
        static Random _rand = new Random();

        public static double Draw()
        {
            while (true)
            {
                var x = _rand.NextDouble();
                var y = _rand.NextDouble();

                if (y < f(x))
                    return x;
            }
        }
        public static double Draw2()
        {
            while (true)
            {
                var x = _rand.NextDouble();
                var y = _rand.NextDouble();

                if (y < f2(x))
                    return x;
            }
        }

        public static double f(double x)
        {
            double μ = mu;
            double σ = ssigma;
            return 1d / Math.Sqrt(2 * σ * σ * Math.PI) * Math.Exp(-((x - μ) * (x - μ)) / (2 * σ * σ));
        }
        public static double f2(double x)
        {
            double μ = mu2;
            double σ = ssigma2;
            return 1d / Math.Sqrt(2 * σ * σ * Math.PI) * Math.Exp(-((x - μ) * (x - μ)) / (2 * σ * σ));
        }
    }
}
