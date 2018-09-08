using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CreateAFarm
{
    class Horse
    {
        public void DisplayHorse()
        {
            HorseSpeak();
            HorseEat();
            HorseProduct();
            HorseHome();
        }

        public void HorseSpeak()
        {
            Console.WriteLine("My name is Bullseye the Horse! I say neigh." + "\n");
        }

        public void HorseEat()
        {
            Console.WriteLine("I love to eat hay. It's my favorite." + "\n");
        }

        public void HorseProduct()
        {
            Console.WriteLine("I provide transportation for humans. They can ride on my back or I can pull their wagons."
                               + "\n" + "I love to race." + "\n");
        }

        public void HorseHome()
        {
            Console.WriteLine("I live in the farm.");
        }
    }
}