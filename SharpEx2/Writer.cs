using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEx2
{
    class Writer
    {
        public static Task WriteToTxtFile(string filename, string text)
        {
            using StreamWriter writer = new StreamWriter(filename, false);
            var result = writer.WriteLineAsync(text);  // асинхронная запись в файл
            return result;
        }
    }
}
