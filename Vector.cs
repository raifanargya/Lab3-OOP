using System;

public class Vector
{
    private int size;
    private double[] data;
     public int Size => size;

    public Vector(int size)
    {
        this.size = size;
        data = new double[size];
    }


    public double GetValue(int i)
    {
        return data[i];
    }

    public void SetValue(int i, double value)
    {
        data[i] = value;
    }


    public void Display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }

    
}
