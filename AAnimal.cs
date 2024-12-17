using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objectoriented
{
    public abstract class AAnimal
    {
        protected float Weight { get; set; }
        protected string? Name { get; set; }
        public AAnimal(float weight, string name)
        {
            Weight = weight;
            Name = name;
        }
        public abstract void Eat();
        public abstract void Move();
    }
}