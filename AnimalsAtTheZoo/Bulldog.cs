using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsAtTheZoo
{
    internal class Bulldog : Dog
    {

        public int size = 30;


        public override void makeSound()
        {

            Console.WriteLine("VOFFFFFf!!!!");

        }
        public void Bulldoginfo()
        {

            if (size < 10)
            {
                Console.WriteLine("den är underviktig och behöver ätta mer");

            }
            else if (size == 30)
            {

                Console.WriteLine("hunde har en bra vikt");

            }
            else if (size > 40)
            {

                Console.WriteLine("väliigt överviktig borde bantas");

            }

            else
            {

                Console.WriteLine("troligtvis bra");

            }
        }
    }
}
