using System.Collections;
using System.Collections.Generic;

namespace LogViewer
{
    class DataInMemory : Database
    {
        static private readonly ArrayList texts;
        static DataInMemory()
        {
            texts = new ArrayList();
        }
        public override void AddText(string text)
        {
            texts.Add(text);
        }

        public override string[] Read()
        {
            return (string[])texts.ToArray(typeof(string));
        }
    }
}
