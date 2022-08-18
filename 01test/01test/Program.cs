using System;

namespace _01test
{
    internal class Program
    {
        //스코프(Scope) : 변수나 함수를 사용할 수 있는 범위, 변수를 선언한 시점에서 해당 변수가 포함된 중괄호가 끝나는 구간까지
        static void Main(string[] args)
        {
            //int sumResult = sum(10, 20); //break porint (단축키 F9)
            //Console.WriteLine($"SumResult : { sumResult}");
            //print();


            // 1. int 타입의 파라메터를 하나 받아서 그 숫자에 해당하는 구구단을 출력해주는 함수 만들기
            // 2. 1번에서 만드는 함수는 2~9까지 입력이 들어오면 해당 구구단 출력. 그 외의 숫자는 "잘못된 입력입니다."라고 출력
            // 3. 메인 함수에서 숫자를 하나 입력받는 코드가 있어야 한다.

            bool b1 = true;
            bool b2 = false;
            //논리 연산자
            //&& (앤드, and)  둘 다 참일 때만 참이다. true && true = true  // false && false = false  //false && true = false
            //|| (오아, or)   둘 중 하나만 참이면 참이다. true || ture = true //true || false = true //false || true = true //flase || false = false
            // ~ (not)        true는 flase, false는 true. ~true = false

            character human1 = new character(); //메모리 할당 완료(Instance화). 객체(Object) 생성 완료 (객체의 인스턴스를 만들었다.)
            character human2 = new character("개굴맨"); //Character 타입으로 하나 더 만든 것. human1과 human2는 서로 다른 객체다

            //human1.name = "너굴맨";

            //human1.TestPrintStatus();
            //human2.Attack();

            
            Random r = new Random();
            r.Next();
            int a = r.Next();
            int b = a % 3;

            Console.WriteLine(b);

            Console.Write("▶ 가위 바위 보");
            Console.WriteLine("0 = 가위 / 1 = 바위 / 2 = 보");
            string n = Console.ReadLine();
            int.TryParse(n, out int m);

            if (m == 0 || m == 1 || m == 2)
            {
                switch (m)
                {
                    case 0:
                        Console.WriteLine("나 : 가위");
                        break;
                    case 1:
                        Console.WriteLine("나 : 바위");
                        break;
                    case 2:
                        Console.WriteLine("나 : 보");
                        break;
                }
            }
            else
            {
                Console.Write("다시 입력해주세요.");
            }
                switch (b)
            {
                case 0:
                    Console.WriteLine("Pc : 가위");
                    break;
                case 1:
                    Console.WriteLine("Pc : 바위");
                    break;
                case 2:
                    Console.WriteLine("Pc : 보");
                    break;
            }
            if (m == b)
            {
                Console.WriteLine("비겼습니다.");
            }
            if (m > b)
            {
                Console.WriteLine("졌습니다.");
            }
            if (m > b)
            {
                Console.WriteLine("이겼습니다.");
            }





        } //main 함수의 끝



        private static void Test_Gugudan()
        {
            //string num1;
            //num1 = Console.ReadLine();
            //int.TryParse(num1, out int num2);

            //Gugudan(num2);



            //static void Gugudan(int num2)
            //{
            //    //<= 나 >= 는 두개의 조건이 결합된 것이므로 피하는 것이 좋다.
            //    //if(2 <= dan && dan <= 9) // 2 <= dan      2 < dan && 2 == dan
            //    if (1 < num2 && num2 < 10)
            //    {
            //        for (int j = 1; j < 10; j++)
            //        {
            //            Console.WriteLine($"{num2} * {j} = {num2 * j}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("잘못된 입력입니다.");
            //    }
            //}
        }


        private static void test_Function()
        {
            string name = "너굴맨";
            int level = 2;
            int hp = 10;
            int maxHP = 20;
            float exp = 0.1f;
            float maxExp = 1.0f;


            printCharacter(name, level, hp, maxHP, exp, maxExp);
        }

        private static void printCharacter(string name, int level, int hp, int maxHP, float exp, float maxExp)
        {
            //실습 : 파라메터로 받은 데이터를 적당한 양식으로 출력해주는 함수 완성하기
            Console.WriteLine($"이름\t : {name}");
            Console.WriteLine($"레벨\t : {level}");
            Console.WriteLine($"HP\t : {hp,3}");
            Console.WriteLine($"MAXHP\t : {maxHP,3}");
            Console.WriteLine($"Exp\t : {exp:f3}");
            Console.WriteLine($"MAXExp\t : {maxExp:f3}");
        }

        //함수의 구성요소
        //이름 : 함수들을 구분하기 위한 이름(예제의 sum)
        //리턴타입 : 함수의 실행 결과로 돌려주는 데이터의 타입(int, 함수의 이름앞에 표시된다.)
        //파라메터(매개변수) : 함수가 실행될 때 외부에서 받는 값(예제의 (int a, int b) 두개의 파라메터가 있다.)
        //함수바디 : 함수가 호출될 때 실행될 코드들(예제의 230 ~ 233라인)

        //함수의 이름, 리턴타입, 파라메터를 합쳐서 함수 프로토타입.이라고 함
        //함수의 주민등록번호, 절대로 하나의 프로그램안에서 겹치지 않는다.

        static int sum(int a, int b)
            {
                int result = a + b;
                return result;
            }

           static void print()    //리턴해주는 값이 없고, 파라메터도 없는 경우
            {
                Console.WriteLine("print");
            }
            void Test()
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

                //bool b1 = true;
                //bool b2 = false;

                //int level = 1;
                //int hp = 10;
                //float exp = 0.9f;
                //string name = "너굴맨";

                ////너굴맨의 레벨은 1이고 HP는 10이고 exp는 0.9다.

                //Console.WriteLine(name + "의 레벨은 " + level + "이고 HP는 " + hp + "이고 "+ "exp는 " + exp + "다.");

                //string str5 = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다";
                //Console.WriteLine(str5);

                //Console.WriteLine($"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다");

                //Console.Write("이름을 입력하세요 : ");
                //name = Console.ReadLine();
                //Console.Write($"{name}의 레벨을 입력하세요 : ");
                //string temp = Console.ReadLine();
                ////level = int.Parse(temp); //string을 int로 변경해주는 코드(숫자로 바꿀수 있을때만 가능) 간단하지만 위험함
                ////level = Convert.ToInt32(temp);  //string을 int로 변경해주는 코드(숫자로 바꿀수 있을때만 가능) 더 세세하게 변경할 수 있다.
                //int.TryParse(temp, out level); //string을 int로 변경해주는 코드 (숫자로 바꿀 수 없으면 0으로 만든다.)

                ////너굴맨의 레벨은 1이고 HP는 10이고 exp는 90%다.

                //exp = 0.959595f;
                //Console.WriteLine($"이름 : {name}\n레벨 : {level}\nHP : {hp}\nexp : {exp*100:f3}%"); //exp*100을 소수점 3자리까지 표시함


                //실습 : 이름, 레벨, hp, 경험치를 각각 입력 받고 출력하는 코드 만들기

                //string temp;
                //string name = "너굴맨";
                //int level = 3;
                //int hp = 2; 
                //float exp = 0.5f;


                //Console.Write("이름을 입력하세요 : ");
                //name = Console.ReadLine();

                //Console.Write($"{name}의 레벨을 입력하세요 : ");
                //temp = Console.ReadLine();
                //int.TryParse(temp, out level);

                //Console.Write($"{name}의 HP를 입력하세요 : ");
                //temp = Console.ReadLine();
                //int.TryParse(temp, out hp);

                //Console.Write($"{name}의 EXP를 입력하세요 : ");
                //temp = Console.ReadLine();
                //float.TryParse(temp, out exp);


                //Console.WriteLine($"이름 : {name}\n레벨 : {level}\nHP : {hp}\nexp : {exp * 100:f3}%");


                //변수 끝 ---------------------------------------------------------------------------

                //제어문(control state), 조건문(if, switch) 반복문 
                //실행되는 코드 라인을 변경할 수 있는 코드

                //if (hp < 3)
                //{
                //    Console.WriteLine("HP가 부족합니다."); //(hp < 3)참일때 실행되는 코드
                //}
                //else if (hp < 10)
                //{
                //    Console.WriteLine("HP가 적당합니다."); //(hp < 3)는 거지싱고 (hp < 10)가 참일때 싱행되는 코드
                //}
                //else
                //{
                //    Console.WriteLine("HP가 충분합니다."); //(hp < 3)와(hp < 10)가 거짓일 때 실행되는 코드
                //}

                //switch (hp)
                //{
                //    case 0: //hp가 0일때
                //        Console.WriteLine("HP가 0입니다.");
                //        break;
                //    case 5: //hp가 5일때
                //        Console.WriteLine("HP가 5입니다.");
                //        break;
                //    default: //위에 설정되지 않은 모든 경우
                //        Console.WriteLine("HP가 0과 5가 아닙니다.");
                //        break;
                //}


                //float _exp;

                //Console.WriteLine("경험치를 추가합니다.");
                //Console.Write("추가한 경험치");
                //temp = Console.ReadLine();
                //float.TryParse(temp, out _exp);

                //if ((_exp + exp) >= 1.0f)
                //{
                //    Console.WriteLine("레벨업!");
                //}
                //else
                //{
                //    Console.WriteLine($"경험치는 {_+exp + exp}입니다.");
                //}

                //level = 1;
                //while (level < 3)   //소괄호 안의 조건이 참이면 중괄호{} 사이의 코드를 실행하는 statement
                //{
                //    Console.WriteLine($"현재 레벨 : {level}");
                //    level++; //level+ level +1; // level +=1;   //셋 다 같은 코드
                //}

                // i는 0에서 시작해서 3보다 작으면 계속 {}사이의 코드를 실행한다. {} 사이의 코드를 실행 할 때마다 1씩 증가한다.
                //hp = 10;
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine($"현재 HP : {hp}");
                //    hp += 10;
                //}
                //Console.WriteLine($"최종 HP : {hp}");

                //do
                //{
                //    Console.WriteLine($"현재 레벨 : {level}");
                //    if (level == 2)
                //    {
                //        break;  
                //    }
                //    level++;
                //} while (level < 3 );
                //Console.WriteLine($"현재 레벨 : {level}");



                string name = "너굴맨";
                int level = 1;
                int hp = 10;
                float exp = 0.0f;
                float exp2 = 0.0f;
                int _str = 0, _dex = 0, _int = 0, _luck = 0;

            Up:
                while (exp < 1.0f) //exp값이 1보다 작으면 계속 반복한다.
                {
                    Console.Write($"경험치를 추가 해야 합니다. 현재 경험치 : {exp:f2}");
                    Console.Write("추가할 경험치 : ");
                    string temp = Console.ReadLine(); // 입력 받기
                    float.TryParse(temp, out exp2); //입력받은 string을 float으로 변경

                    exp += exp2;//입력받은 값을 exp에 추가

                }
                //while이 끝났다라는 이야기는 exp가 1보다 크거나 같아졌다라는 의미
                exp = exp - 1.0f;
                level++;
                hp += 10;
                _str += 2;
                _dex += 2;
                _int += 2;
                _luck += 2;
                Console.WriteLine($"레벨업! 현재 레벨 : {level}");
                Console.WriteLine($"HP가 상승했습니다. {hp}");
                Console.WriteLine($"능력치가 상승했습니다.  힘 : {_str} 민첩 : {_dex} 지능 : {_int} 운 : {_luck}");
                goto Up;

            }

        
    }
}
