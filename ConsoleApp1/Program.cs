using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<Settlement> Settlements = new List<Settlement>();
        static void Main(string[] args)
        {
            Read("Settlements.txt");
        }

        static void Read(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            string line;
            while((line = sr.ReadLine()) != null)
            {
                Settlements.Add(new Settlement(line));
            }
        }
        static bool LookForWay(float fuel, Settlement[] settlements)
        {
            return false;
        }
    }
}
