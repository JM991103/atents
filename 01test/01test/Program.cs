using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _01test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("출력");
           // string str = Console.ReadLine(); //키보드 입력을 받아서 str이라는 string변수에 저장한다.
           // Console.WriteLine(str); //str출력

            //변수 : 변하는 숫자. 컴퓨터에 사용할 데이터를 저장할 수 있는 곳
            //변수의 종류 : 데이터 타입(Data Type)
            // int : 인티저, 정수, 소수점 없는 숫자 32bit
            // float : 플로트, 실수, 소수점 있는 숫자 32bit
            // string : 스트링, 문자열, 글자들을 저장
            // bool : 불 또는 불리안, true/fales를 저장

            int a = 10; // a라는 인티저 변수에 10이라는 데이터를 넣는다.
            long b = 5000000000; //50억은 int에 넣을 수 없다. => int는 32비트로 표현가능한 숫자의 갯수는 2^32(4,294,967,296)개 이기 때문에

            int c = -100;
            int d = 2000000000;
            int e = 2000000000;
            int f = d + e;
            Console.WriteLine(f); //

            //float의 단점 : 태생적으로 오차가 있을 수 밖에 없다.
            float aa = 0.000123f;
            float ab = 0.999999991f;
            float ac = 0.000000011f;
            float ad = ac + ab; //결과가 1이 아닐 수도 있다.
            Console.WriteLine(ad);

            string str1 = "Hello";
            string str2 = "안녕!";
            string str3 = $"Hello {a}";
            Console.WriteLine(str3); //"Hello 10"이 출력이 됨
            string str4 = str1 + str2; //"Hello안녕!"이 출력 됨

            bool b1 = true;
            bool b2 = false;

            int level = 1;
            int hp = 10;
            float exp = 0.9f;
            string name = "너굴맨";

            //너굴맨의 레벨은 1이고 HP는 10이고 exp는 0.9다.

            Console.WriteLine(name + "의 레벨은 " + level + "이고 HP는 " + hp + "이고 "+ "exp는 " + exp + "다.");

            string str5 = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다";
            Console.WriteLine(str5);
            
            Console.WriteLine($"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다");

            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();
            Console.Write($"{name}의 레벨을 입력하세요 : ");
            string temp = Console.ReadLine();
            //level = int.Parse(temp); //string을 int로 변경해주는 코드(숫자로 바꿀수 있을때만 가능) 간단하지만 위험함
            //level = Convert.ToInt32(temp);  //string을 int로 변경해주는 코드(숫자로 바꿀수 있을때만 가능) 더 세세하게 변경할 수 있다.
            int.TryParse(temp, out level); //string을 int로 변경해주는 코드 (숫자로 바꿀 수 없으면 0으로 만든다.)

            //너굴맨의 레벨은 1이고 HP는 10이고 exp는 90%다.

            exp = 0.959595f;
            Console.WriteLine($"이름 : {name}\n레벨 : {level}\nHP : {hp}\nexp : {exp*100:f3}%"); //exp*100을 소수점 3자리까지 표시함


            










        }
    }
}
