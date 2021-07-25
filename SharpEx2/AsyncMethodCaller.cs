using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEx2
{
    public class AsyncMethodCaller
    {
        public static async void CallRowSumAsync()
        {
            TaylorSum tSum = new TaylorSum();
            var taskRes = Task.Run(() => tSum.RowSum(1.5, 0.001));
            await taskRes;
        }
    }
}
