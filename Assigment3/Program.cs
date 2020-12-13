using System;
using System.Threading;

namespace Assigment3
{


     class bank

    {
        static int netbalance = 1000;

        public static void Deposite(int TransAmount)
        {

            for (int i = 0; i <= 10; i++)
            {
                netbalance += TransAmount;
                Console.WriteLine(" Current Balance After Deposite=" + netbalance);

                 if(i==5)
                {
                    Thread.Sleep(5000);
                }

            }



        }

        public  static void WidthDrawal(int TransAmount)
        {

            for (int i = 0; i <=10; i++)
            {

                netbalance -= TransAmount;
                Console.WriteLine(" Current Balance After Widthrawal=" + netbalance);

            }

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");

            int amt = Convert.ToInt32(Console.ReadLine());

            bank.Deposite(amt);
            bank.WidthDrawal(amt);
           
        }
    }
}
