using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITALibrary
{
    class SaveASCII
    {
        public static void SaveFile(string fileName, string imageString)
        {
            File.WriteAllText(fileName, imageString);
        }
    }
}
