using System;

namespace SharpEx2
{
    public class TaylorSum
    {
        private long Fact(uint x)
        {
            long factorial = 1;
            for (int i = 2; i <= x; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private bool IsEven(uint k)
        {
            return k % 2 == 0;
        }

        public double RowSum(double x, double eps)
        {
            double rowSum = 0;
            double prevSum = 0;
            uint k = 0;
            do
            {
                prevSum = rowSum;
                if (IsEven(k))
                {
                    rowSum += Math.Pow(x, 2 * k + 1) / Fact(2 * k + 1);
                }
                else
                {
                    rowSum -= Math.Pow(x, 2 * k + 1) / Fact(2 * k + 1);
                }
                k++;
            } while (Math.Abs(rowSum - prevSum) > eps);
            return rowSum;
        }
    }
}
