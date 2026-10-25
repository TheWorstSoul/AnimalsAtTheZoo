using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsAtTheZoo
{
    internal class Snake : Animal
    {
        public int Fangs = 2;
        public override void makeSound()
        {

            Console.WriteLine("Sish");

        }

        public void ömsarShema()
        {


            Console.WriteLine("En gång i månade, den ömsade senast 23 ocktober");


        }
        public void ExtraInfoOrm()
        {

            if (Fangs > 0)
            {

                Console.WriteLine("orm har " + Fangs + " hugtänder, och därför är den giftig");
            }
            else
            {

                Console.WriteLine("ormen har inga hug tänder och är därför inte giftig");

            }

        }
    }
}
