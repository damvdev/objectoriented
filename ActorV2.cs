using System;

namespace objectoriented
{
    public class ActorV2
    {
        private string name;
        private string surname;
        //propietat: mètode per realitzar operacions sobre els atributs
        //abans de c# 3 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        //sobrecàrrega del constructor
        public ActorV2(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public ActorV2(string surname)
        {
            Name = "M.";
            Surname = surname;
        }
        public string GetFullName()
        {
            return Surname + ", " + Name;
        }
    }
}
