using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEx2
{

    struct Currency
    {
        public double Byn;
        public double Usd;
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

    //struct CastSet
    //{
    //    public double DVal;
    //    public string SVal;
    //    public float FVal;
    //}

    class Calculator
    {
        private Currency _currencyPair;
        //private CastSet _castData;

        public Calculator(Currency oCurrencyPair/*, CastSet oCastData*/)
        {
            _currencyPair = oCurrencyPair;
            //_castData = oCastData;
        }

        public Currency CurrencyPair
        {
            get;
            set;
        }

        //public CastSet CastData
        //{
        //    get;
        //    set;
        //}

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

        public int CountIntMean(int first, int second)
        {
            return (first + second) / 2;
        }
    }
}
