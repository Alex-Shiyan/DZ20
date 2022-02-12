//
// Домашнее задание к занятию 20. Делегаты, события, лямбды
//
// Задача 1. В приложении объявить тип делегата, который ссылается на метод.
// Требования к сигнатуре метода следующие:
// -метод получает входным параметром переменную типа double;
// -метод возвращает значение типа double, которое является результатом вычисления.

// Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
// -длину окружности по формуле D = 2 * π* R;
// -площадь круга по формуле S = π* R²;
// -объем шара.Формула V = 4 / 3 * π * R³.

//Методы должны быть объявлены как статические.


namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        delegate double MyDelegate(double r);
        public static void Main(string[] args)
        {
            double r = 0;
            Console.Write("Введите радиус r: ");
            while(!double.TryParse(Console.ReadLine(), out r))
            { Console.WriteLine("Ошибка ввода"); }

            MyDelegate myDelegate = D;
            double d = myDelegate(r);
            Console.WriteLine($"Длина окружности равна \t {d:0.000}");

            myDelegate += S;
            d = myDelegate(r);
            Console.WriteLine($"Площадь круга равна \t {d:0.000}");

            myDelegate += V;
            d = myDelegate(r);
            Console.WriteLine($"Объем шара равн \t {d:0.000}");

            Console.ReadKey();
        }
        static double D(double r) => (double)(2 * Math.PI * r);
        static double S(double r) => (double)(Math.PI * Math.Pow(r, 2));
        static double V(double r) => (double)(4 * Math.PI * Math.Pow(r, 3) / 3);

    }
}
