using System;
using System.Collections.Generic;
using System.Linq;
using testing_dotnet.Interfaces;

namespace testing_dotnet.Models
{
    public class Exercise_1: IExercise_1
    {
        private List<int> list = null;
        public Exercise_1(List<int> listInt)
        {
            list = listInt;
        }

        public List<int> FilterList()
        {
            return list.Distinct().ToList();
        }

        public IEnumerable<int> FilterListWithYield()
        {
            int aux = 0;
            foreach(int item in list.OrderBy(x => x).ToList())
            {
                if(item != aux)
                {
                    yield return item;
                }                
                aux = item;
            }
        }

        public void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}