using System;

public class InputHandler
{
    public Matrix InputMatrix()
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the number of columns:");
        int cols = int.Parse(Console.ReadLine());

        Matrix matrix = new Matrix(rows, cols);


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Enter value for matrix[{i},{j}]:");
                double value = double.Parse(Console.ReadLine());
                matrix.SetValue(i, j, value);
            }
        }

        return matrix;
    }

    
}


