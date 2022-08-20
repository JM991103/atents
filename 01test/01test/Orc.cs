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
        int defense;
        public Orc(string newName) : base(newName)  //생성자
        {
            //Orc의 이름 출력
        }

        public override void GenerateStatus()
        {
            base.GenerateStatus();
            

        }

    
        public override void TestPrintStatus()
        {
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ 이름\t:\t {name,3}             ┃ ");
            Console.WriteLine($"┃ HP\t:{hp,4} / {maxHP,4}               ┃ ");
            Console.WriteLine($"┃ 힘\t:{strenth,3}                       ┃ ");
            Console.WriteLine($"┃ 민첩\t:{dexterity,3}                       ┃ ");
            Console.WriteLine($"┃ 지능\t:{intellegence,3}                       ┃ ");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        public override void Attack(Character target)
        {
            base.Attack(target);
            int damage = strenth;
            if (rand.NextDouble() < 0.3)
            {
                damage *= 2;
                Console.WriteLine("크리티컬 히트!");
            }
            Console.WriteLine($"{name}이(가) {target.Name}에게 공격을 합니다.(공격력 : {damage})");
            target.TakeDamage(damage);
        }



        public void OrcSkill()
        {

        }

    }
}
