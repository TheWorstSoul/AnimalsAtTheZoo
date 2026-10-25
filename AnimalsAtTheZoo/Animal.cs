using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsAtTheZoo
{
    internal class Animal
    {


        public string Name { get; set; }

        public string Legs = "0";
        public string Fur = "Ja";
        public string Skin = "Ja";
        public string LayEggs = "Ja";
        public string FöderLevande = "Ja";
        public string Horns = "0";
        public string SkapatLjud = "0";


        public Animal()
        {


        }

        public Animal(string namn)
        {

            Name = namn;

        }


        public void AnimalsInfo()
        {
            Console.WriteLine("Djur: " + Name);
            Console.WriteLine("Antal Ben: " + Legs);
            Console.WriteLine("Har päls: " + Fur);
            Console.WriteLine("Har skin: " + Skin);
            Console.WriteLine("Lägger ägg: " + LayEggs);
            Console.WriteLine("Föderlevand: " + FöderLevande);
            Console.WriteLine("Antal horn: " + Horns);

        }

        public void CleanTimes()
        {



        }

        public void SpeedContest()
        {



        }

        public virtual void makeSound()
        {

            Console.WriteLine(SkapatLjud);

        }


    }
}
