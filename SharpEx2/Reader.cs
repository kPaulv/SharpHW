using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace SharpEx2
{
    class Reader
    {
        public static Task<string> ReadTxtFile(string filename)
        {
            using StreamReader reader = new StreamReader(filename);
            var result = reader.ReadToEndAsync();
            return result;
        }
    }
}
