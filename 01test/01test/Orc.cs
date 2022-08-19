using _01_Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01test
{
    public class Orc : Character
    {
        int Defensive;

        public override void GenerateStatus()
        {
            base.GenerateStatus();
            int Defensive = rand.Next(10, 30);

        }
        public override void TestPrintStatus()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ 이름\t:\t 오크              ┃ ");
            Console.WriteLine($"┃ HP\t:{hp,4} / {maxHP,4}               ┃ ");
            Console.WriteLine($"┃ 방어력:{Defensive,3}%                      ┃ ");
            Console.WriteLine($"┃ 힘\t:{strenth,3}                       ┃ ");
            Console.WriteLine($"┃ 민첩\t:{dexterity,3}                       ┃ ");
            Console.WriteLine($"┃ 지능\t:{intellegence,3}                       ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }



    }
}
