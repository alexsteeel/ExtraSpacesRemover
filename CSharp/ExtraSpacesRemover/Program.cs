using System;

namespace ExtraSpacesRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите строку для удаления повторяющихся пробелов.");
                var inputString = Console.ReadLine();
                Console.WriteLine(inputString.RemoveExtraSpaces());

                Console.WriteLine("Для обработки еще одной строки нажмите y, для выхода нажмите любую клавишу.");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
    }
}
