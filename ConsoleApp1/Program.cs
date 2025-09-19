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
            //O(n^2) megoldas nem a leghatekonyabb
            ref Settlement startSettlement = ref settlements[0];

            for (int  i = 0; i < settlements.Length; ++i)
            {
                for(int j = i + 1; j < settlements.Length; ++j)
                {
                    Vector2 currentSett = new Vector2(settlements[i].XCoordinate, settlements[i].YCoordinate);
                    Vector2 nextSett = new Vector2(settlements[j].XCoordinate, settlements[j].YCoordinate);

                    if(Vector2.Distance(currentSett, nextSett) <= fuel && settlements[j].HasCharger == 1)
                    {
                        if (j == settlements.Length - 1)
                            return true;
                        else
                            i = j - 1;
                        break;
                    }
                }
                
            }
            return false;
        }
        static bool LookForOtherWay(float fuel, Settlement[] settlements)
        {
            //O(n) megoldas

            ref Settlement startSettlement = ref settlements[0];
            int L = 0;
            int R = settlements.Length - 1;
            while (L < R)
            {
                Vector2 currentSett = new Vector2(settlements[L].XCoordinate, settlements[L].YCoordinate);
                Vector2 nextSett = new Vector2(settlements[R].XCoordinate, settlements[R].YCoordinate);

                if (Vector2.Distance(currentSett, nextSett) <= fuel && settlements[R].HasCharger == 1)
                {
                    if (R == settlements.Length - 1)
                        return true;
                    else
                        L++;
                }
                else
                    R--;

            }
            return false;
        }
    }
}
