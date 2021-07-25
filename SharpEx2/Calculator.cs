using System;

namespace SharpEx2
{ 
    struct Currency
    {
        public const double ConversionRate = 2.589;

        public double BynToUsd(double bynMoney)
        {
            if (bynMoney > 0)
            {
                return bynMoney / ConversionRate;
            }

            return 0;
        }

        public double UsdToByn(double usdMoney)
        {
            if (usdMoney > 0)
            {
                return usdMoney * ConversionRate;
            }

            return 0;
        }
    }

    struct Swapper
    {
        public int First;
        public int Second;
        public int Third;

        public void Swap()
        {
            First += Second;
            Second = First - Second;
            First = First - Second;
        }

        public void SwapThird()
        {
            Third = First;
            First = Second;
            Second = Third;
        }

    }

    public class Parser
    {
        public Parser()
        {

        }

        public int DoubleToInt(double dVal)
        {
            return Convert.ToInt32(dVal);
        }

        public int StringToInt(string sVal)
        {
            return Int32.Parse(sVal);
        }

        public int FloatToInt(float fVal)
        {
            return Convert.ToInt32(fVal);
        }
    }

    public class Calculator
    {
        public Calculator()
        {

        }

        public static int CountIntMean(int first, int second)
        {
            return (first + second) / 2;
        }

        public static double CountDoubleMean(double first, double second)
        {
            return (first + second) / 2;
        }
    }
}
