using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objectoriented
{
    public class Dog : Animal
    {
        public Dog(float weight, string name) : base(weight, name){}
        public Dog() : base(20, "Rex") { }

        public override string GetFullInfo()
        {
            return "Dog: " + base.GetFullInfo();
        }
    }
}