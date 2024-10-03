using Tyuiu.GubanovaSO.Sprint1.Task4.V21.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Губанова С. О. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Губанова Софья Олеговна | ИБКСб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|(1 + x ,2)^2 - y| / (x + y) = " +ds.Calculate(x, y));
        }
    }
}
