using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    internal class Mercedes: AbstractCar
    {
        internal string Description;
        internal int Price;
        private string _description;
        private int _price;
        public Mercedes() {
            Description = "E Class";
            Price = 67000;
        }

        private int counter;

        public void PrintMercedesLogo() {
            counter++;
            if (counter == 3) return;
            Console.WriteLine("This is from Mercedes");
            PrintMercedesLogo();
        }

        public void PrintNewMercedes(int c) {
            if (c == 3) return;
            Console.WriteLine("Mercedes No = " + c);
        }
        public static int staticcounter;

        public static void StartEngine() {
            Console.WriteLine("Engine Started");
        }
    }
}
