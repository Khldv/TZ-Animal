using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Panda : Animal
    {
        public string Postion { get; set; }


        public override void Climb()
        {
            Console.WriteLine("Умеет лазать на деревья");
        }

        public override void Food()
        {
            Console.WriteLine("Ест в основном бамбук");
        }

        public override void Laziness()
        {
            Console.WriteLine("Лентяй");
        }
    }
}
