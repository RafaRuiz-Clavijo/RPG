﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_RPG_1
{
    class Druida
    {
        public string name;
        public double lvl;
        public double nor_atk;
        public double spe_atk;
        public double hp;
        public double def;

        public void Normal_attack()
        {
            Console.WriteLine(name + "ataca");
            Console.WriteLine(name + "realiza" + nor_atk + "de damage");
        }

        public void Special_attack()
        {
            Console.WriteLine("El guerrero usa su ataque especial: Curacion");
            Console.WriteLine(name + "realiza" + spe_atk + "de curacion");
        }

        public void Defense()
        {
            Console.WriteLine(name + "se defiende");
            Console.WriteLine("Defensa x" + def);
        }
    }
}
