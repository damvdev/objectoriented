using System;

namespace objectoriented
{
    public class Program
    {
        public static void Main()
        {
            /* Test de les classes ActorV1, ActorV2 i ActorV3
            ActorV1 firstActor = new ActorV1("Keanu", "Reeves");
            ActorV2 secondActor = new ActorV2("Pratt");
            ActorV3 thirdActor = new ActorV3("Chris", "Hemsworth");
            Console.WriteLine($"El nom del primer actor és: {firstActor.GetFullName()}");
            Console.WriteLine($"El nom del segon actor és: {secondActor.GetFullName()}");
            Console.WriteLine($"El nom del tercer actor és: {thirdActor.GetFullName()}");
            
            */
            // Test de les classes Cat, Dog i Animal
            Animal animal = new Animal(10, "Animal");
            //AAnimal animal = new AAnimal(10, "Firulais"); //dona error perquè no es pot instanciar un objecte d'una classe abstracta
            Console.WriteLine(animal.GetFullInfo());
            Console.WriteLine("----------------------------------------");

            Cat cat = new Cat(5, "Cat");
            cat.Eat();
            cat.Move();

            Console.WriteLine("----------------------------------------");

            Dog dog = new Dog(20.5f, "Dog");
            Console.WriteLine(dog.GetFullInfo());
        }
    }
}