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

            //Mercedes m1 = new Mercedes();
            //m.PrintMercedesLogo();
            //m1.PrintNewMercedes(Mercedes.staticcounter++);
            //Mercedes m2 = new Mercedes();
            //Mercedes m3 = new Mercedes();
            //Mercedes m4 = new Mercedes();
            //m2.PrintNewMercedes(Mercedes.staticcounter++);
            //m3.PrintNewMercedes(Mercedes.staticcounter++);
            //m4.PrintNewMercedes(Mercedes.staticcounter++);

            //Mercedes.StartEngine();

            Mercedes remainingNoKm = new Mercedes();
            remainingNoKm.ShowRemainingNoOfKM(10, 7);

            double numberOfKilometerLeft;
            numberOfKilometerLeft= remainingNoKm.ShowRemainingNoOfKM(10, 7);
            Console.WriteLine("Numarul de km ramasi: "+numberOfKilometerLeft);

            Mercedes noMilliseconds = new Mercedes();
            noMilliseconds.StartEngine(12);

            Mercedes printConsum = new Mercedes();
            printConsum.CalculateConsumption(10);

            double calcConsumcar;
            calcConsumcar = printConsum.CalculateConsumption(10);
            Console.WriteLine("The car consumption is " + calcConsumcar);

            Audi a = new ClassesTutorial.Audi();
            a.CarStart();

            a.Vitezometru(1);
            a.Vitezometru(2);
            a.Vitezometru(3);
            a.Vitezometru(0);

            Apple mar = new Apple();
            Orange portocala = new Orange();
            Ionatan tip = new Ionatan();
            Fruit fruct = new Fruit();

            Ionatan i = new Ionatan();
            i.GetCalories();
            Apple ap = new Apple();
            ap.GetCalories();
            Fruit h = new Fruit();
            h.GetCalories();

            FruitBasket cos = new FruitBasket();
            cos.addFruit(fruct);
            cos.addFruit(portocala);
            cos.addFruit(portocala);
            cos.addFruit(portocala);

            cos.displayFruitCalories();



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
