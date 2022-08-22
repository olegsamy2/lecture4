string [,] table = new string[2,5];
// String.Empty - инициализация для строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
// table [1,2]="слово"; // обращение к двумерному элементу массива

// for (int rows = 0; rows < 2; rows++)  // length = 2
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); 
//     }

// }



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  // matrix.GetLength(0) = 3 (rows)
    // for (int i = 0; i < 3; i++)  // i=rows
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // matrix.GetLength(1) = 4 (columns)
        //for (int j = 0; j < 4; j++)   // j-columns
        {
            Console.Write($"{matr[i, j]} "); 
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)  // заполнения массива случайными числами
{
     for (int i = 0; i < matr.GetLength(0); i++)  // 
     {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10)

        }

     }

}
int[,] matrix = new int[3,4];
PrintArray(matrix);

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);