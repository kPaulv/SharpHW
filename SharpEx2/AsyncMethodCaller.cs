using System;
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

        public static async void InputOutputAsync()
        {
            string strToWrite = "Try writing some text.";
            
            var text = await Reader.ReadTxtFile("input.txt");
            Console.WriteLine(text);
            await Writer.WriteToTxtFile("output.txt", strToWrite);
        }
    }
}
