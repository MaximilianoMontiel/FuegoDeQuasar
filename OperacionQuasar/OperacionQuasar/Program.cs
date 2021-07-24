using System;

namespace OperacionQuasar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            Console.WriteLine("* Bienvenido General *");
            Console.WriteLine("**********************");
            Console.WriteLine("");

            //Instancio el objeto menu
            Menu menu = new Menu();

            //llamo al metodo seleccionador
            menu.Seleccionador();
        }
    }
}
