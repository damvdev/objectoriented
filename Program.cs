using System;

namespace objectoriented
{
    public class Program
    {
        public static void Main()
        {
            ActorV1 firstActor = new ActorV1("Keanu", "Reeves");
            ActorV2 secondActor = new ActorV2("Pratt");
            ActorV3 thirdActor = new ActorV3("Chris", "Hemsworth");
            Console.WriteLine($"El nom del primer actor és: {firstActor.GetFullName()}");
            Console.WriteLine($"El nom del segon actor és: {secondActor.GetFullName()}");
            Console.WriteLine($"El nom del tercer actor és: {thirdActor.GetFullName()}");
        }
    }
}