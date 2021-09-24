using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string Name { get; set; }
        public string View { get; set; }



        public Animal()
        {

        }

        public Animal(string name, string view, string movement)
        {
            Name = name;
            View = view;

        }

        public void Going()
        {
            Console.WriteLine("Умеет ходить");
        }

        public void Voice()
        {
            Console.WriteLine("Издает звуки");
        }

        public void Survival()
        {
            Console.WriteLine("Умеет выживать");
        }

        virtual public void Food()
        {
            Console.WriteLine("Употребляет пищу");
        }

        virtual public void Climb()
        {
            Console.WriteLine("Умеет лазать");
        }

        virtual public void Laziness()
        {
            Console.WriteLine("Оно ленивое");
        }
    }
}
