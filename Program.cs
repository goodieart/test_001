using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string[] inArray = GetUserInput();
        PrintArray(inArray);
        WriteLine($"Количество элементов длиной < 3: {CountItemsByLen(inArray)}"); 
    }
    /// <summary>
    /// Метод возвращает ввод пользователя, преобразованный в строковый массив
    /// </summary>
    /// <param name = "separator">Строковый разделитель; символы между ними в исходной строке будут
    /// преобразованы в элементы результирующего массива</param>
    /// <returns>Новый массив, заполненный преобразованными строковыми значениями в целочисленный тип</returns>
    static string[] GetUserInput(string separator = ",")
    {
        return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    }
    /// <summary>
    /// Метод выводит на экран содержимое переданного одномерного массива с вещественными числами
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    static void PrintArray(string[] inArray)
    {
        Write("[");
        for (int i = 0; i < inArray.Length; i++)
        {
            Write($"{inArray[i]}{(i < inArray.Length - 1 ? "," : "")}");
        }
        Write("]");
    }
    /// <summary>
    /// Метод возвращает количество элементов массива строкового типа с длиной меньше maxItemLength
    /// </summary>
    /// <param name = "inArray">Входной массив</param>
    /// <param name = "maxItemLength">Максимальная длина элемента</param>
    /// <returns>Количетсво элементов входного массива с длиной меньше maxItemLength</returns>
    static int CountItemsByLen(string[] inArray, int maxItemLength = 3)
    {
        int result = 0;
        foreach (string item in inArray)
        {
            if (item.Length <= maxItemLength)
            {
                result++;
            }
        }
        return result;
    }
}