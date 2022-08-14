/*Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве,
 и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
*/
int[,] CreateAndPrintArray(int row, int col)
{
    int [ , ] array = new int [row, col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
void FindNumbersOrIndex(int [,]array)
{
    try
    {        
        Console.WriteLine("Введите искомое число, либо индексы нужного числа через запятую: ");
        string numbers = Console.ReadLine();
        int[] array2 = numbers.Split(',').Select(int.Parse).ToArray();
        if(array2.Length == 1)
        {
            int check = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] == array2[0])
                    {
                    Console.WriteLine($"Введенное Вами число {array2[0]} расположенно по индексам i = {i} j = {j}" + "\t");
                    check = check + 1;                    
                    }
                }
             
            }
            Console.WriteLine();
            if(check < 1) Console.WriteLine("В массиву нет введенного Вами числа");
        }
        if(array2.Length == 2)
        {
            Console.WriteLine($"По введенным Вами координатам расположено число: {array[array2[0], array2[1]]}");
        }
    }
    catch
    {
        Console.WriteLine("Вы ввели некорректные данные");
    }
}
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

FindNumbersOrIndex(CreateAndPrintArray(row, col));