using System;

namespace Practica_RPG_1
{
    class Program
    {
        public void llamando(player)
        {
            player.hp = 100;
            player.lvl = 40;
            player.nor_atk = 10;
            player.spe_atk = 20;
            player.def = 1;
            Console WriteLine("Datos personaje: ");
            Console WriteLine("HP: " + player.hp);
            Console WriteLine("Lvl: " + player.lvl);
            Console WriteLine("Ataque: " + player.nor_atk);
            Console WriteLine("Especial " + player.spe_atk);
            Console WriteLine("Defense " + player.def);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("C# Warriors");
            Console.WriteLine("Press enter key to play");
            Console.ReadLine();

            Console.WriteLine("Escriba su nombre:");
            string tunombrees = Console.ReadLine();

            Console.WriteLine("Escoja clase:");
            Console.WriteLine("0) Guerrero");
            Console.WriteLine("1) Caballero");
            Console.WriteLine("2) Asesino");
            Console.WriteLine("3) Mago");
            Console.WriteLine("4) Necromancer");
            Console.WriteLine("5) Druida");
            string clase = Console.ReadLine();


            



        }
    }
}
