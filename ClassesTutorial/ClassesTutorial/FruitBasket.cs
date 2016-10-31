using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class FruitBasket
    {
        public List<Fruit>  listadefructe;

        public FruitBasket() {
            listadefructe = new List<Fruit>();
        }
        public void addFruit( Fruit fruct) {
            listadefructe.Add(fruct);
        }

        public void displayFruitCalories() {
            foreach (Fruit f in listadefructe) {
                Console.WriteLine(f.GetCalories());
            }
        }
    }
}
