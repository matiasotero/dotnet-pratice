using System;
using System.Collections.Generic;

namespace testing_dotnet.Interfaces
{
    interface IExercise_1
    {
        List<int> FilterList();
        IEnumerable<int> FilterListWithYield();
        void PrintList(List<int> list);
    }
}