using Lib;

class Program
{
    const int MAX_LENGTH = 3;
    static void Main(string[] args)
    {
        string[] inArray = Helper.GetUserInput(prompt: "Введите строки через запятую для отбора по длине");
        Arrays.PrintArray(inArray, "Входной массив");

        int outLength = Arrays.CountItemsByLen(inArray, MAX_LENGTH);
        string[] outArray = new string[outLength];

        int i = 0;
        foreach (string item in inArray)
        {
            if (item.Length <= MAX_LENGTH)
            {
                outArray[i] = item;
                i++;
            }
        }
        Arrays.PrintArray(outArray, "Выходной массив");
    }
}