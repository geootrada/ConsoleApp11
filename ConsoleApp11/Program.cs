using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int numberOfTimes;

            Console.Write(" Здравствуйте, это программа-напоминатель!\n " +
               "Введите сообщение, которое вам нужно сегодня напомнить: ");
            //Позвонить в поликлинику
            message = Console.ReadLine();

            Console.Write("Сколько раз вам напомнить: ");
            numberOfTimes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine(message);
            }
        }   
    }
}
