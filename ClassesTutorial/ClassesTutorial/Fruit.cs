using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Fruit
    {
        int fibres;

        public Fruit() {
            Console.WriteLine("Fruit was created!");
        }
        public virtual int GetCalories() {
            return 3;
        }
    }
}
