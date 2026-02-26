using System;

public class Program
{
    static void Main()
    {
        InputHandler input = new InputHandler();
        
        Console.WriteLine("MATRIX ADDITION");


        Console.WriteLine("Input Matrix A");
        Matrix A = input.InputMatrix();
        
        Console.WriteLine("Input Matrix B");
        Matrix B = input.InputMatrix();
        
        MatrixCalculator matrixCalc = new MatrixCalculator(new DimensionValidator());
        Matrix C = matrixCalc.Add(A, B);
        
        Console.WriteLine("Matrix Addition Result:");
        C.Display();


        Console.WriteLine("Input Vector A");
        Vector vectorA = input.GetVectorInput();

        Console.WriteLine("Input Vector B");
        Vector vectorB = input.GetVectorInput();

        
        VectorCalculator vectorCalc = new VectorCalculator(new DimensionValidator());
        Vector resultVector = vectorCalc.Add(vectorA, vectorB);


        Console.WriteLine("Vector Addition Result:");
        resultVector.Display();
    }

    
}
