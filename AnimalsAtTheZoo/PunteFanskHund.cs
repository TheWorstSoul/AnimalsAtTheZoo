using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsAtTheZoo
{
    internal class PunteFanskHund : Dog
    {

        public int MatMängd = 100;

        public override void makeSound()
        {

            Console.WriteLine("bloff");

        }

        public void MatIg()
        {

            Console.WriteLine("Så många gram mat ska du ge hunden?");
            //int mat = int.Parse(Console.ReadLine());

            Console.WriteLine(MatMängd + " g");


        }


    }
}
