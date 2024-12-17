using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objectoriented
{
    public class Cat : AAnimal
    {
        public Cat(float weight, string name) : base(weight, name){}
        public Cat() : base(20, "Michi") { }

        public override void Eat()
        {
            Console.WriteLine($"Menjo molt perquè només peso {Weight} kg.");
        }

        public override void Move()
        {
            Console.WriteLine($"Em dic {Name} i estic caminant");
        }
    }
}