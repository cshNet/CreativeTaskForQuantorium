using System;

namespace ForQuantorium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan; //Люблю циановый :D
            Console.WriteLine("Вас приветствует программа решений линейных уравнений!");
            Console.WriteLine("Введите уравнение формата x+2=5 (Вместо плюса любой знак)");
            //Можно было сделать с вводом одной строки, но это надо долго парсить, так что сделаем легче :D
            Console.WriteLine("Первый элемент- X, его не надо вводить ");
            Console.Write("Введите знак: ");
            string symbol = Console.ReadLine();
            //Тут делаем проверку на знак
            if (symbol == "+" || symbol == "-" || symbol == "/" || symbol == ":" || symbol == "*")
            {
                Console.Write("Введите второй элемент: ");
                string bS = Console.ReadLine();
                Console.Write("Введите, чему всё это дело равно: ");
                string cS = Console.ReadLine();

                //Преобразовываем полученные данные в int 
                int a,b,c;
                int.TryParse(bS, out b);
                int.TryParse(cS, out c);

                Console.WriteLine($"Ваше уравнение: x{symbol}{b}={c}");


                if (symbol == "+") Console.WriteLine($"X={c - b}");
                if (symbol == "-") Console.WriteLine($"X={c + b}");
                if (symbol == "/" || symbol == ":") Console.WriteLine($"X={c * b}");
                if (symbol == "*") Console.WriteLine($"X={c / b}");

                

            }

            Console.ReadKey();
        }
    }
}
