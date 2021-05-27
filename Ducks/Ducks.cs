using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Ducks
    {
        public string name;
        public int lake;
        public bool swim { get; set; } = false;
        public bool hide { get; set; } = false;
        public bool play { get; set; } = false;
        public bool home { get; set; } = false;

        public int homeId;
        public int caught;
        public string characht;
        public int num;

        public void GetInfo()
        {
            Console.WriteLine($"Порода: {name}");
            Console.WriteLine($"Номер: {num}");

            if (swim == true)
            {
                Console.WriteLine("Умеет плавать");
            }

            if (hide == true)
            {
                Console.WriteLine("Умеет прятаться");
            }

            if (play == true)
            {
                Console.WriteLine("Умеет играть");
            }

            if (home == true)
            {
                Console.WriteLine("Знает, где живет");
            }
            else
            {
                Console.WriteLine("Не знает, где живет");
            }
            Console.WriteLine($"Характеристики: {characht}");
            Console.WriteLine($"Поймали: {caught} раз");
        }
    }
}
