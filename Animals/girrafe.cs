using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class giraffe : Animal
    {
        public string Postion { get; set; }

        public override void Climb()
        {
            Console.WriteLine("Не умеет лазать");
        }

        public override void Food()
        {
            Console.WriteLine("Ест траву");
        }

        public override void Laziness()
        {
            Console.WriteLine("Ну немного, может быть");
        }
    }
}
