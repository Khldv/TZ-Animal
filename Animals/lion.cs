using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class lion : Animal
    {
        public string Postion { get; set; }

        public override void Climb()
        {
            Console.WriteLine("Умеет лазать");
        }

        public override void Food()
        {
            Console.WriteLine("Ест мясо");

        }

        public override void Laziness()
        {
            Console.WriteLine("Оно не ленивое");
        }



    }
}
