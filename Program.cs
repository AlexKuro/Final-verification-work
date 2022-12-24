namespace Final_verification_work;
class Program
{
    static void Main(string[] args)
    {
        /* Студент geekbrains: Курочкин Алексей Иванович */

        void Task()  // Решение задачи контрольной работы.
        {
            Console.WriteLine("- - - - - - - - Студент geekbrains: Курочкин Алексей Иванович - - - - - - - -\n");
            Console.WriteLine("\tЗадача: Написать программу, которая из имеющегося массива строк ");
            Console.WriteLine("формирует новый массив из строк, длина которых меньше, либо равна 3 символам.\n");
            Console.WriteLine("\tВы хотите ввести слова/числа/символы через клавиатуру?");
            Console.Write("\tНажмите 'Y' - это ДА, 'N' - это нет -> ");
            string? enteringText = Console.ReadLine();
            if (enteringText?.ToLower() == "y") Task2();
            else if (enteringText?.ToLower() == "n") Task1();
            else Console.WriteLine("\tВвод неверный! ");
        }

        void Task1() // Вводит тект компьютер
        {
            Console.WriteLine("\tВводит тект компьютер.\n");
            string[] container = { "Hello", "-2", "world", "МИР", "Hi", "GeekBrains", "Student", ";-)", ":-)", ":0", "99",
                                   "1", "CVC", "NO", "YES", "True", "False", "Go", "Russia", "Kazan", "Search", "Ru", "$",
                                   "En", "-6", "0", "Z", "One", "Mail", "Pro", "Program", "7", "77", ".cs", ".txt", "BMW",
                                   "VW", "Audi", "bin", "odj", "Труд", "МАЙ", "Пн", "Вт", "Cp", "Чт", "Пт", "СБ", "BC", "3",
                                   "One", "Two", "Three", "Four", "Five",   "Six",  "Seven", "Eight", "Nine", "Ten"};
            Random rand = new Random();
            int size = 6;
            string[] text = new string[size];
            for (int i = 0; i < size; i++) text[i] = container[rand.Next(0, container.Length)];
            Console.Write("\t");
            PrintArrayStr(text);
            Console.Write(" --> ");
            PrintArrayStr(SearchByLines(text));
            Console.WriteLine();
        }

        void Task2() // Ввод текста через клавиатуру
        {
            Console.WriteLine("\tВыбран ввод через клавиатуру.");
            Console.WriteLine();
            Console.WriteLine("Введите текты разной длины. Длина которых меньше, либо равна 3 или больше.");
            Console.Write("Вводите через пробел!: ");
            string? container = Console.ReadLine();
            string[] text = container!.Split();
            Console.WriteLine();
            Console.Write("\t");
            PrintArrayStr(text);
            Console.Write(" --> ");
            PrintArrayStr(SearchByLines(text));
            Console.WriteLine();
        }

        string[] SearchByLines(string[] text, int lenNum = 3) // поиск нужных элементов по длине строки 
        {
            int size = text.Length;
            int length = 0;
            for (int i = 0; i < size; i++)
            {
                if (text[i].Length <= lenNum) text[length++] = text[i];
            }
            string[] newText = new string[length];
            for (int i = 0; i < length; i++) newText[i] = text[i];
            return newText;
        }

        void PrintArrayStr(string[] pArray) // печать массива тип string
        {
            Console.Write("[ ");
            for (int i = 0; i < pArray.Length; i++) Console.Write($"{pArray[i]} ");
            Console.Write("]");
        }

        Task();

    }
}
