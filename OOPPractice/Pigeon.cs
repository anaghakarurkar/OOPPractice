using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    public class Pigeon: Bird
    {
        public Pigeon(string name, string color) : base(name, color)
        {
            
        }

        public void EatPizza()
        {
            Console.WriteLine("Delicious Pizza!");
        }

        public void Sleep()
        {
            Console.WriteLine("I'm a sleeping pigeon");
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }
    }
}
