using static System.Console;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "///Aykhan Dadashov///";
            Algorithm algo = new Algorithm();

            //WriteLine(algo.GetLength(str));
            //WriteLine(algo.Contains("an", str));
            //WriteLine(algo.IndexOf("ov", str));
            //WriteLine(algo.Substring(14, 1, str));
            WriteLine(algo.Replace("Aykhan", "Ayxan", str));
            //WriteLine(algo.Insert(4, "a", str));
            //WriteLine(algo.Remove(4, str));
            //WriteLine(algo.RemoveBetween(0, 4, str));
            //WriteLine(algo.PadLeft(23, 'h', str));
            //WriteLine(algo.PadRight(23, 'h', str));
            //WriteLine(algo.StartsWith("Ay", str));
            //WriteLine(algo.EndsWith("an", str));
            //WriteLine(algo.LastIndexOf("ov", str));
            WriteLine(algo.TrimStart('/', str));
            WriteLine(algo.TrimEnd('/', str));
            WriteLine(algo.Trim('/', str));
            ReadKey();
        }
    }
}