using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsAtTheZoo
{
    internal class Dog : Animal
    {

        public string HarLöss = "Yes";

        public override void makeSound()
        {

            Console.WriteLine("VOFF! (dregel)");

        }


        public void SkaGåUt()
        {


            Console.WriteLine("En gång var tredje timme");

        }

        public void Löss()
        {

            if (HarLöss == "Yes")
            {

                Console.WriteLine("hunden bör behandlas måt löss dirkt och separeas från de andra hundarna så länge den behandlas");

            }
            else
            {

                Console.WriteLine("Huden har inga löss och kan var med de andra");

            }

        }

    }
}
