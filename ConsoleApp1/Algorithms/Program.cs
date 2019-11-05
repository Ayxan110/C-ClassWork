using static System.Console;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Aykhan Dadashov";
            Algorithm algo = new Algorithm();

            WriteLine(algo.GetLength(str));
            WriteLine(algo.Contains("hgjan", str));
            WriteLine(algo.IndexOf("D", str));
            ReadKey();
        }
    }
}