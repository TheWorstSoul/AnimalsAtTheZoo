namespace AnimalsAtTheZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulldog Dalton = new Bulldog();

            Console.WriteLine();

            Dalton.Name = "Bulldog";
            Dalton.Legs = "4";
            Dalton.LayEggs = "Nej";
            Dalton.Skin = "Nej";
            Dalton.AnimalsInfo();
            Dalton.SkaGåUt();
            Dalton.Bulldoginfo();
            Dalton.Löss();
            Dalton.makeSound();


            Console.WriteLine();


            PunteFanskHund Punte = new PunteFanskHund();
            Punte.Name = "PunteFanskHund";
            Punte.Legs = "4";
            Punte.LayEggs = "Nej";
            Punte.Skin = "Nej";
            Punte.AnimalsInfo();
            Punte.SkaGåUt();
            Punte.MatIg();
            Punte.Löss();
            Punte.makeSound();


            Console.WriteLine();

            Snake snake = new Snake();
            snake.Name = "Kobra";
            snake.Fur = "Nej";
            snake.FöderLevande = "Nej";
            snake.AnimalsInfo();
            snake.ExtraInfoOrm();
            snake.ömsarShema();
            snake.makeSound();



            Console.WriteLine();

            Moose moose = new Moose();
            moose.Name = "Älg";
            moose.Skin = "nej";
            moose.LayEggs = "nej";
            moose.Horns = "2";
            moose.Legs = "4";
            moose.AnimalsInfo();
            moose.SmellsBad();
            moose.ÄlgHornInfo();
            moose.makeSound();


            Console.WriteLine();

            Dog dog = new Dog();
            dog.Name = "Vanlig hund?";
            dog.Skin = "nej";
            dog.LayEggs = "nej";
            dog.Legs = "4";
            dog.HarLöss = "nej";
            dog.AnimalsInfo();
            dog.SkaGåUt();
            dog.Löss();
            dog.makeSound();

            Console.WriteLine();

            Animal Elefant = new Animal("Elefant");

            Elefant.Fur = "Nej";
            Elefant.Horns = "0 men har 2 betar";
            Elefant.Legs = "4";
            Elefant.LayEggs = "nej";
            Elefant.SkapatLjud = "Eeeeelllleefffffannnt!!!!!";
            Elefant.AnimalsInfo();
            Elefant.makeSound();
        }
    }
}
