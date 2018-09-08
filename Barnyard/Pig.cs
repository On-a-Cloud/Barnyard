using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CreateAFarm
{
    class Pig
    {
        public void DisplayPig()
        {
            PigSpeak();
            PigEat();
            PigProduct();
            PigHome();
        }

        public void PigSpeak()
        {
            Console.WriteLine("My name is Porky the Pig. I say Oink." + "\n");
        }

        public void PigEat()
        {
            Console.WriteLine("I will eat Everything! Put it in my mouth and I will eat it." + "\n");
        }

        public void PigProduct()
        {
            Console.WriteLine("I produce Bacon for humans." + "\n");
        }

        public void PigHome()
        {
            Console.WriteLine("I live in the farm.");
        }
    }
}