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
            string str = Console.ReadLine(); //키보드 입력을 받아서 str이라는 string변수에 저장한다.
            Console.WriteLine(str); //str출력

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

        }
    }
}
