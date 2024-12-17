using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectoriented
{
    public class Animal
    {
        public float Weight { get; set; }
        public string? Name { get; set; }
        public Animal(float weight, string name)
        {
            this.Weight = weight;
            this.Name = name;
        }
        public virtual string GetFullInfo()
        {
            return this.Name + " " + this.Weight;
        }
    }
}
