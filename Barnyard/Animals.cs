using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CreateAFarm
{

    class Animals
    {
        Horse bullseyes = new Horse();
        Cow otis = new Cow();
        Pig porky = new Pig();
        Chicken Foghorn = new Chicken();

        public void FarmAnimal()
        {
            Console.WriteLine("Which animal do you want to see?");
            Console.WriteLine("Type horse, cow, pig, chicken or exit");
        }

        public void AnimalSelect()
        {
            do
            {
                FarmAnimal();
                string userSelection = Console.ReadLine();
                Console.WriteLine("\n");
                switch (userSelection)
                {
                    case "horse":
                        bullseyes.DisplayHorse();
                        break;
                    case "cow":
                        otis.DisplayCow();
                        break;
                    case "pig":
                        porky.DisplayPig();
                        break;
                    case "chicken":
                        Foghorn.DisplayChicken();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please make a selection.");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
            while (true);
        }
    }
}