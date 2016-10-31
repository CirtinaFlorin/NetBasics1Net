using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Audi : Car
    {

        public void Vitezometru(int acceleratie) {
            switch (acceleratie) {

                case 1:
                    Console.WriteLine(50);
                    break;
                case 2:
                    Console.WriteLine(100);
                    break;
                case 3:
                    Console.WriteLine(150);
                    break;
                default:
                    Console.WriteLine(0);
                    break;
            }


        
        }
    }
}
