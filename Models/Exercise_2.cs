using System;
using System.Collections.Generic;
using System.Linq;
using testing_dotnet.Interfaces;

namespace testing_dotnet.Models
{
    public class Exercise_2: IExercise_2
    {
        private int quantity = 0;
        public Exercise_2(int quantitySteps)
        {
            quantity = quantitySteps;
        }

        public IEnumerable<string> BuildLadderMarioBros()
        {
            string step = InicializeBaseLadder(quantity);
            for(int i = 0; i < quantity; i++)
            {
                yield return step.Substring(0, i);
            }
        }

        private string InicializeBaseLadder(int quantity)
        {
            string baseLadder = "";
            for(int i = 0; i < quantity; i++)
            {
                baseLadder = baseLadder + "#";
            }
            return baseLadder;
        }
    }
}