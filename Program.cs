namespace Final_verification_work;
class Program
{
    static void Main(string[] args)
    {


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

    }
}
