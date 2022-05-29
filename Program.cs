using GameRPG_DIO.src.Entities;

namespace GameRPG_DIO
{
    class Program
    {
        static void Main()
        {
            Knigth knigth = new Knigth("Arus", 50, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 81, "Ninja");

            Console.WriteLine(knigth.ToString());
            Console.WriteLine(knigth.Attack());

            Console.WriteLine(wizard.ToString());
            Console.WriteLine(wizard.Attack(8));

            Console.WriteLine(ninja.ToString());
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ninja.Attack(8));
        }
    }
}



