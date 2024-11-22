using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int result = (number1 / number2);
                Console.WriteLine($"Результат деления {number1} на {number2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Ввод должен быть числом. ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль недопустимо. ");
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: ");
            }
            finally
            {
                Console.WriteLine("Программа завершила работу.");
                Console.ReadLine();
            }
        }
    }
}
