using static System.Console;

class Program
{
    static void Main(string[] args)
    {

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
    public static void PrintArray(string[] inArray)
    {
        Write("[");
        for (int i = 0; i < inArray.Length; i++)
        {
            Write($"{inArray[i]}{(i < inArray.Length - 1 ? "," : "")}");
        }
        Write("]");
    }
}