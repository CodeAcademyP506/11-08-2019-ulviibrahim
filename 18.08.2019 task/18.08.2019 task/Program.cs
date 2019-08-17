using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._08._2019_task
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            Console.WriteLine("--------------------------");
          string name= Console.ReadLine();
            Console.WriteLine("--------------------------");

            Console.WriteLine( "Xos geldin "+ name + " (zehmet olmasa istenilen duymeye basin)");
            Console.WriteLine("--------------------------");
            Console.ReadLine();

            bool student = true;

            Console.WriteLine("Telebesiz? "+ name +" muellim");
            Console.WriteLine("--------------------------");


            string confirm = Console.ReadLine();
           
            Console.WriteLine("--------------------------");


            if (confirm == "he")
            {
                Console.WriteLine("hansi universitetde oxuyursunuz");
                Console.WriteLine("--------------------------");

                string uniname = Console.ReadLine();

                Console.WriteLine("___________________");
                
                Console.WriteLine(" Ixtisasin nedir?");

                  string specialty= Console.ReadLine();
                if (specialty == " ")
                {
                    Console.WriteLine(" ixtisas yazin");

                }

                Console.WriteLine("___________________");


               

                Single();

                Console.WriteLine("___________________");


                Console.WriteLine(" Tesekkur edirik " + name +" muellim. Sen "+ uniname+" de oxuyursan. " +specialty +" tehsili alirsan ve sen 1 den 100-e qeder olan sade ededlerin ceminin " ); Single();
                Console.WriteLine(" oldugunu bilirsen");

                student = true;
            }
           
            else if(confirm == "yox")
            {
                Console.WriteLine(" Isleyirsiniz?");
                Console.WriteLine("--------------------------");

                string works = Console.ReadLine();

                if (works == "he")
                {
                    Console.WriteLine("______________________");

                    Console.WriteLine(" Veziveniz?");
                    Console.WriteLine("______________________");

                    var position = Console.ReadLine();

                    Single101();


                    Console.WriteLine(" Tesekkur edirik " + name + " muellim. Sen " + position + " vezifesinde isleyirsen. Ve sen 1 den 101-e qeder olan sade ededlerin ceminin "); Single101();
                    Console.WriteLine(" oldugunu bilirsen");

                }

                else if (works == "yox")
                {
                   

                    Console.ReadLine();
                    Console.WriteLine( "    Boyuk ehtimal sen sagirdsen, buna baxmayaraq sen 1 den 200-e dek olan 3 e bolunen cut ededlerin  ceminin "  );
                    ucebolunen();
                    Console.WriteLine(" oldugunu bilmelisen");
                }
                    student = false;
            }
        }

           
        static void Single()
        {
            int s = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    s += i;
                   
                }
            }
            Console.WriteLine(s);
        }

        static void Single101()
        {
            int s = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    s += i;

                }
            }
            Console.WriteLine(s);
        }

        static void ucebolunen()
        {
            int s = 0;
            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        s += i;
                    }
                
                }
            }
            Console.WriteLine(s);
        }
    }
}
