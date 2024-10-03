using Tyuiu.GubanovaSO.Sprint1.Task3.V6.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task3.V6
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
           
            Console.WriteLine("Введите раcстояние до дачи: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество бензина, которое потребляет автомобиль на 100 км пробега: ");
            double gasFlow = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену одного литра бензина: ");
            double gasPrice = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Поездка на дачу и обратно обойдется в " + ds.TravelCost(distance, gasFlow, gasPrice));
        }
    }
}
