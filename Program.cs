namespace Final_verification_work;
class Program
{
    static void Main(string[] args)
    {
        
        void PrintArrayStr(string[] pArray) // печать массива тип string
        {
            Console.Write("[ ");
            for (int i = 0; i < pArray.Length; i++) Console.Write($"{pArray[i]} ");
            Console.Write("]");
        }

    }
}
