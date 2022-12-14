namespace Lib;
using static System.Console;

public class Helper
{
    /// <summary>
    /// Метод возвращает ввод пользователя, преобразованный в строковый массив
    /// </summary>
    /// <param name = "separator">Строковый разделитель; символы между ними в исходной строке будут
    /// преобразованы в элементы результирующего массива</param>
    /// <param name = "prompt">Приглашение для пользователя</param>
    /// <returns>Новый массив, заполненный строковыми значениями</returns>
    public static string[] GetUserInput(string separator = ",", string prompt = "")
    {
        if (prompt != String.Empty) Write($"{prompt}: ");
        return Console.ReadLine()!.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    }
}

public class Arrays
{
    /// <summary>
    /// Метод выводит на экран содержимое переданного одномерного массива
    /// </summary>
    /// <param name = "inArray">Массив, содержимое которого следует вывести на экран</param>
    /// <param name = "prompt">Приглашение для пользователя</param>
    public static void PrintArray(string[] inArray, string prompt = "")
    {
        Write($"{prompt}{(prompt == String.Empty ? "" : ": ")}[");
        for (int i = 0; i < inArray.Length; i++)
        {
            Write($"{inArray[i]}{(i < inArray.Length - 1 ? "," : "")}");
        }
        WriteLine("]");
    }
    
    /// <summary>
    /// Метод возвращает количество элементов массива строкового типа с длиной меньше maxItemLength
    /// </summary>
    /// <param name = "inArray">Входной массив</param>
    /// <param name = "maxItemLength">Максимальная длина элемента</param>
    /// <returns>Количетсво элементов входного массива с длиной меньше maxItemLength</returns>
    public static int CountItemsByLen(string[] inArray, int maxItemLength = 3)
    {
        int result = 0;
        foreach (string item in inArray)
        {
            if (item.Length <= maxItemLength) result++;
        }
        return result;
    }
}
