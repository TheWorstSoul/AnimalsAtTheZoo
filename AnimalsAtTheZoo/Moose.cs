using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsAtTheZoo
{
    internal class Moose : Animal
    {
        public string HairyHorns = "Ja";
        public override void makeSound()
        {

            Console.WriteLine("Wohohohohej");

        }

        public void SmellsBad()
        {

            Console.WriteLine("Denna älg dofatar illa");

        }

        public void ÄlgHornInfo()
        {

            Console.WriteLine("Har älgen håriga horn? " + HairyHorns);


        }

    }
}
