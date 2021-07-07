using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAgain = "yes";
            string smass1;
            string smass2;
            string sDistance;
            double mass1;
            double mass2;
            double Distance;
            double Gforces;
            
            do
            {

                Gforce force = new Gforce();

                Console.Out.WriteLine("Please enter in the Mass of object 1 in kg");
                smass1 = Console.ReadLine();
                mass1 = double.Parse(smass1);
                force.SetMass1(mass1);

                Console.Out.WriteLine("Please enter in the Mass of object 2 in kg");
                smass2 = Console.ReadLine();
                mass2 = double.Parse(smass2);
                force.SetMass2(mass2);

    
                force.SetMass2(mass2);
                Console.Out.WriteLine("Please enter in the Distance between the 2 Objects in meters;");
                sDistance = Console.ReadLine();
                Distance = double.Parse(sDistance);
                force.SetDistance(Distance);

                Gforces = force.GetGraviForce();
                Console.Out.WriteLine("The Gravitational force between these 2 ojects is: " + Gforces);

                Console.Out.WriteLine("Would you like to do another? yes/no: ");
                doAgain = Console.ReadLine().ToLower();



            } while (doAgain == "yes");

            Console.Out.WriteLine("GoodBye!");
        }
    }
}
