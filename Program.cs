// See https://aka.ms/new-console-template for more information

// Задача 47: Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами, 
//округлёнными до одного знака.

/*void Zadacha47()
{
    int rows = 3;
    int colums = 4;
    double[,] array = new double[rows, colums];
    Fillarray(array, rows, colums);
    Printarray(array, rows, colums);


}
void Fillarray(double[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(-10, 11) + random.NextDouble();
                       
        }
    }
}

void Printarray(double[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(Math.Round(array[i, j],1)+ "\t");
        }
        Console.WriteLine();
    }
}
Zadacha47();*/


//Задача 50: Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, 
//что такого элемента нет.


/*void Zadacha50()

{
    int rows = 3;
    int colums = 4;
    int[,] array = new int[rows, colums];
    Fillarray(array, rows, colums);
    Printarray(array, rows, colums);
    Console.WriteLine();
    
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.WriteLine("Введите номер строки");
            i = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("Введите номер столбца");
            j = Convert.ToInt32(Console.ReadLine())-1;
            if (i <= rows && j <= colums)
            Console.WriteLine("По заданным параметрам в массиве находится число: " + array[i,j]);
            else 
            Console.WriteLine("По заданным параметрам элемент в массиве отсутствует");
        }
    }

}
void Fillarray(int[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(0, 10);
             
        }
    }
}

void Printarray(int[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}
Zadacha50();*/


// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.

/*void Zadacha52()
{
    int rows = 3;
    int colums = 4;
    int[,] array = new int[rows, colums];
    Fillarray(array, rows, colums);
    Printarray(array, rows, colums);
       
    
    Console.Write("Среднее арифметическое каждого столбца: ");
    Console.WriteLine();
    for (int j = 0; j < colums; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {           
            sum = array[i,j] + sum;        
        }
        
        Console.Write(Math.Round(sum/rows,2)+"\t");  
    }
    

}
void Fillarray(int[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(0, 10);            
        }
    }
}

void Printarray(int[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}

Zadacha52();*/