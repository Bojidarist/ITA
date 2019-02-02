using System.IO;

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
