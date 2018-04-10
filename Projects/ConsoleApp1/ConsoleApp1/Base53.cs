using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Base53Exercice
    {
        private static void ex1()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Give me your name !");

            string name;
            name = Console.ReadLine();

            Console.WriteLine("Your name is : " + name);
        }
        private static void ex2and3()
        {
            int a, b;
            Console.WriteLine();
            Console.WriteLine("Give me 2 numbers");
            Console.Write("A = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("A + B = {0}", a + b);

            Console.WriteLine("A / B = {0}", (double)a/ (double)b);
        }
        private static void ex4()
        {
            Console.WriteLine();
            Console.WriteLine("{0}", -1 + 4 * 6);
            Console.WriteLine("{0}", (35 + 5) % 7);
            Console.WriteLine("{0}", 14 + (-4) * 6 / 11);
            Console.WriteLine("{0}", 2 + 15 / 6 * 1 - 7 % 2);
        }
        private static void ex5()
        {
            int cinq = 5, dix = 10, temp;

            Console.WriteLine(" cinq = {0}", cinq);
            Console.WriteLine(" dix = {0}", dix);

            //swap
            temp = dix; dix = cinq; cinq = temp;
            Console.WriteLine(" Cinq & Dix Are swapped");

            Console.WriteLine(" cinq = {0}", cinq);
            Console.WriteLine(" dix = {0}", dix);
        }
        private static void ex6()
        {
            Console.WriteLine(); Console.WriteLine();
            //--- EX 6
            int N1, N2, N3;
            Console.WriteLine("Give me 3 numbers to multiply!");

            Console.Write("N1 = ");
            N1 = int.Parse(Console.ReadLine());

            Console.Write("N2 = ");
            N2 = int.Parse(Console.ReadLine());

            Console.Write("N3 = ");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication result = {0}", N1 * N2 * N3);
            Console.WriteLine(); Console.WriteLine();
        }
        private static void ex7()
        {
            Console.WriteLine("Give me 2 numbers !");

            Console.Write("N1 = ");
            int N1 = int.Parse(Console.ReadLine());

            Console.Write("N2 = ");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0} + {1} = {2}", N1, N2, N1 + N2);
            Console.WriteLine(" {0} - {1} = {2}", N1, N2, N1 - N2);
            Console.WriteLine(" {0} * {1} = {2}", N1, N2, N1 * N2);
            Console.WriteLine(" {0} / {1} = {2}", N1, N2, N1 / N2);
            Console.WriteLine(" {0} mod {1} = {2}", N1, N2, N1 % N2);

            Console.WriteLine(); Console.WriteLine();
        }
        private static void ex8()
        {
            int k = 0;

            Console.WriteLine("Give me 1 number !");

            Console.Write("N1 = ");
            int N1 = int.Parse(Console.ReadLine());

            for (; k <= 10; k++)
            {
                Console.WriteLine("{0} * {1} = {2}", N1, k, N1 * k);
            }



            Console.WriteLine(); Console.WriteLine();
        }
        private static void ex9()
        {
            Console.WriteLine("Give me 4 numbers");
            int n1, n2, n3, n4;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("The 4 numbers are : {0}, {1}, {2}, {3}", n1, n2, n3, n4);
            Console.WriteLine("The average is : {0}", (n1 + n2 + n3 + n4) / 4);
            Console.WriteLine(); Console.WriteLine();
        }
        private static void ex10()
        {
            int x, y, z;
            Console.WriteLine("Give 3 numbers");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.WriteLine("output of {0}, {1}, {2} : (x+y).z = {3}, (x.y + y.z) = {4}", x, y, z, (x + y) * z, x * y + y * z);
        }
        private static void ex11()
        {
            Console.WriteLine("Give me your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than " + age);
        }
        private static void ex12()
        {
            Console.WriteLine("Give a number dude");
            int u = int.Parse(Console.ReadLine());
            int  k = 0;
            for (; k < 2; k++) {
                Console.WriteLine("{0}{0}{0}{0}", u);
                Console.WriteLine("{0} {0} {0} {0} ",u);
            } 
        }
        private static void ex13()
        {
            Console.WriteLine("Give Heigh & Length of a rectangle");
            int h, l;
            h = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());

            int num;

            Console.WriteLine("Give number to draw the rectangle");
            
             num = int.Parse(Console.ReadLine());

            int i=0, j=0;
            for (; i < h; i++)
            {
                if (i == 0 || i == h - 1)
                {
                    for (j = 0; j < l; j++)
                    {
                        Console.Write(num);
                        if (j == l - 1)
                            Console.WriteLine();
                    }
                }
                else
                {
                    for (j = 0; j < l; j++)
                    {
                        if (j == 0 || j == l - 1)
                            Console.Write(num);
                        else
                            Console.Write(" ");
                        
                        if (j == l - 1)
                            Console.WriteLine();

                    }
                }
                
            }
        }
        private static void ex14()
        {
            Console.WriteLine("Température ?");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("C° to F° : F = {0}", (double)temp * 1.8 + 38);
            Console.WriteLine("C° to K° : F = {0}", (double)temp + 273.15);

            
        }
        private static void ex15()
        {
            //YES
            string str1 = Console.ReadLine();
            Console.WriteLine("Inversed = {0}", string.Format(
                "{0}{1}{2}"
                    , str1.Substring(str1.Length - 1, 1)
                    , str1.Substring(1, str1.Length - 2)
                    , str1.Substring(0, 1)
                )
          );
        }
        private static void ex16()
        {
            string str1 = Console.ReadLine();
            Console.WriteLine("Inversed = {0}", string.Format(
                "{0}{1}{2}"
                    , str1.Substring(0, 1)
                    , str1
                    , str1.Substring(0, 1)
                )
          );
        }
        private static void ex17()
        {
            Console.WriteLine("Give me 2 numbers");
            int k = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            if((k>0&&j<0) || (k<0 && j > 0)){
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        private static void ex18()
        {
            //a == b ? (a+b)*3 : a +b
            Console.WriteLine("Give me 2 numbers");
            int k = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            if (k == j)
                Console.WriteLine((k + j) * 3);
            else
                Console.WriteLine(k + j);
        }
        private static void ex19()
        {
            Console.WriteLine("Give me 2 numbers");
            int k = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(k > j ? Math.Abs(j - k) * 2 : k - j);
        }
        private static void ex21()
        {
            Console.WriteLine("Give me 2 numbers");
            int k = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(k == 20 || j == 20 || k+j == 20 ? "True" : "False");
        }
        private static void ex22()
        {
            Console.WriteLine("Give me 1 number which is 100+-20 or 200+-20");
            int k = int.Parse(Console.ReadLine());
            List<int> u = new List<int>(new int[] { 4,6,9,11 });
            
            Console.WriteLine( u.Contains(k/20) ? "True" : "False");
        }
        private static void ex23()
        {
            Console.WriteLine("Give me 1 number which is 100+-20 or 200+-20");
            int k = int.Parse(Console.ReadLine());
            List<int> u = new List<int>(new int[] { 4, 6, 9, 11 });

            Console.WriteLine(u.Contains(k / 20) ? "True" : "False");
        }
        private static void ex24()
        {
            Console.WriteLine("Give me 1 string with multiple words");
            string k = Console.ReadLine();

            string[] arr = k.Split(' ');
            int wordSize = 0;
            string word = "" ;
            for(int u =  0; u < arr.Length; u++)
            {
                if (arr[u].Length > wordSize)
                {
                    wordSize = arr[u].Length;
                    word = arr[u];
                }
            }


            Console.WriteLine("Plus grand mot : " + word);
        }
        private static void ex25()
        {
           //w/e
        }
        private static void ex26()
        {
            int result = 0, k = 0, i = 0;
            while (k < 500)
            {
                i++;
               
                if (isPrime(i)) { result += i; k++;  }
            }
            Console.WriteLine("Somme des 500 nombres premiers = " + result);
        }
        private static void ex27()
        {
            Console.WriteLine("Give me a number");
            int k = int.Parse(Console.ReadLine());

            int result = 0 ;
            string str = k.ToString();
            for(int u = 0; u < str.Length; u++)
            {
                result += int.Parse(str[u].ToString());
            }
            Console.WriteLine("result = " + result);
        }
        private static void ex28()
        {
            Console.WriteLine("Give me a complete sentence, which i'll reverse");
            string str = Console.ReadLine();

            string[] arr = str.Split(' ');
            string newString = "";
            for(int k = arr.Length-1; k >= 0 ; k--)
            {
                newString = newString + arr[k] + " ";
            }

            Console.WriteLine(newString.Substring(1,newString.Length-1));
        }

        static void Main(string[] args)
        {

            //int k = int.Parse(Console.ReadLine());
            //int j = int.Parse(Console.ReadLine());

            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex13();
            //ex14();
            //ex15();
            //ex16();
            //ex17();
            //ex18();
            //ex20();
            //ex21();
            //ex22();
            //ex23();
            //ex24();
            //ex25();
            //ex26();
            //ex27();
            
            ex13();
            Console.ReadKey();

        }

        

        private static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

    }
}