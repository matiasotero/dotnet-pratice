using System;
using System.Collections.Generic;
using System.Linq;

namespace testing_dotnet
{
    public class Excerise_1
    {

        public static List<int> FilterList(List<int> list)
        {
            return list.Distinct().ToList();
        }

        public static IEnumerable<int> FilterListWithYield(List<int> listInt)
        {
            int aux = 0;
            foreach(int item in listInt.OrderBy(x => x).ToList())
            {
                if(item != aux)
                {
                    yield return item;
                }                
                aux = item;
            }
        }

        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}