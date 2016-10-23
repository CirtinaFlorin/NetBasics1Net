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
    }
}
