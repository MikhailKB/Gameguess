using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameguess

{
    class Program
    {
        static void Main(string[] args)
        {
              
            WriteLine("Добро пожаловать в игру \"Угадайка\"");
            
            Random rand = new Random();

            int iNumber = rand.Next(1, 101);
            int count = 0;
            int userNumber;

            while (true)
            {
                Write("\nВведите число от 1 до 100 и нажмите клавишу Enter: ");
                count++;
                userNumber = Convert.ToInt32(ReadLine());
                if (userNumber<iNumber)
                {
                    WriteLine("\nВведённое число меньше загаданного. Попробуйте ещё раз");
                }
                else if (userNumber>iNumber)
                {
                    WriteLine("\nВведённое число больше загаданного. Попробуйте ещё раз");
                }
                else
                {
                    WriteLine($"Поздравляю, число угадано! Число попыток: {count}.");
                    ReadKey();
                    break;
                }
            }
        }
    }
}


