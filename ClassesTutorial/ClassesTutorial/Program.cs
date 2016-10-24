using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mercedes mercedes = new Mercedes();
            //EngineStruct engine = new EngineStruct();
            //ICar car = new Mercedes();
            //AbstractCar car2 = new Mercedes();
            //PrintLogo();
            //PrintLogo(7);
            //Console.WriteLine("This is my first project!");
            //Console.WriteLine("Mercedes is "+ mercedes.Description);
            //Console.WriteLine("Mercedes costs " + mercedes.Price);

            Mercedes m1 = new Mercedes();
            //m.PrintMercedesLogo();
            m1.PrintNewMercedes(Mercedes.staticcounter++);
            Mercedes m2 = new Mercedes();
            Mercedes m3 = new Mercedes();
            Mercedes m4 = new Mercedes();
            m2.PrintNewMercedes(Mercedes.staticcounter++);
            m3.PrintNewMercedes(Mercedes.staticcounter++);
            m4.PrintNewMercedes(Mercedes.staticcounter++);

            Mercedes.StartEngine();
            Console.ReadKey();

            
        }

        static int counter;

        static void PrintLogo() {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C#is great");
            PrintLogo2();
        }
        static void PrintLogo(int i) {
            Console.WriteLine("I am another printlogo");
        }
        static void PrintLogo2() {
            counter++;
            if (counter == 3) return;
            Console.WriteLine("PrintLogo2");
            PrintLogo();
        }
    }
}
