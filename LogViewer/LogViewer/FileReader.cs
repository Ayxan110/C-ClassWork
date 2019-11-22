using System.Collections.Generic;
using System.IO;

namespace LogViewer
{
     class FileReader : Database
    {
        public override void AddText(string text)
        {
            File.AppendAllLines("Log.txt", new List<string> { text });
        }

        public override string[] Read()
        {
            return File.ReadAllLines("Log.txt");
        }
    }
}
