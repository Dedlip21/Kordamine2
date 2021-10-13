using System;
using System.Linq;
using System.Text;
using System.IO;

namespace Kordamine2
{
    class Program
    {
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            Console.WriteLine("{0} * {1} = {2}", a, b, Korruta(a, b));
            Console.WriteLine(Korruta(3, 6));
            Console.ReadLine();

            /*
            Random rnd = new Random();
            int N = rnd.Next(2, 6);
            int M = rnd.Next(7, 14);
            int[] mass = new int[M - N];
            for (int i = N; i < M + 1; i++)
            {
                Console.WriteLine(i-N);
                Console.ReadLine();
                mass[i - N] = i;
                Console.WriteLine(i * i);
            }
            foreach (var m in mass)
            {
                Console.WriteLine(m);
            }
            */
            //---------------------------------------------------------------------
            //int n;
            using (StreamWriter writer = new StreamWriter("testdata.txt", true))

                for (int i = 1; i <= 10; i++)
                {
                   
                    Console.Write(i + " ");
                }
            Console.WriteLine();
                for (int n = 2; n <= 20; n = n + 2)
                {
                    
                    Console.Write(n + " ");
                }
            Console.WriteLine();
                for (int m = 3; m <= 30; m = m + 3)
                {

                    Console.Write(m + " ");
                }
            Console.WriteLine();
            //---------------------------------------------------------------------
            /*
            string nimi;
            do
            {
                Console.WriteLine("Osta elevant!!!");
                nimi = Console.ReadLine();
            } while (nimi != "elevant");
            */
            //------------------------Ülesanne 4---------------------------------------------
            /*
            Console.WriteLine("Neljas ülesanne");
            Random rnd = new Random();
            int A = rnd.Next(1, 5);
            int AA;
            int K = 1;
            do
            {
                Console.WriteLine("{0}. Katse. Mis arv?", K);
                AA = int.Parse(Console.ReadLine());
                K=K+1;
            } while (AA != A || K != 6);
            if (AA == A)
            {
                Console.WriteLine("Palju õnne!");
            }
            else
            {
                Console.WriteLine("Proovi uuesti!");
            }
            */
            //------------------------Ülesanne 5----------------------------------------------
            /*
            Console.WriteLine();
            int[] arv =new int[4];
            for (int i = 0; i < arv.Length; i++)
            {
                arv[i]=int.Parse(Console.ReadLine());
            }

            Array.Sort(arv);
            Array.Reverse(arv);

            foreach (var item in arv)
            {
                Console.Write(item);
            }
            */

            Random rnd = new Random();



            Console.ReadLine();
        }
    }
}
