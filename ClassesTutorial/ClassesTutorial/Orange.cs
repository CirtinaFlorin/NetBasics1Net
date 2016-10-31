using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Orange:Fruit
    {
        public Orange() {
            Console.WriteLine("Orange was created!");
        }
        public override int GetCalories()
        {
            return 3;
        }
    }
}
