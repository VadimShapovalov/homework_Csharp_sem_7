//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

void FillArrayRealNumbers()
{
    Console.WriteLine("Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int col = Convert.ToInt32(Console.ReadLine());
    double [ , ] array = new double [row, col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            Random rand = new Random();
            array[i, j] = rand.Next(-99, 100) + rand.NextDouble();
            double number = array[i,j];
            Console.Write("{0:0.00}", number);
            Console.Write("\t" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
FillArrayRealNumbers();
