public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }


    public double GetValue(int j)
    {
        return values[j];
    }

    public void SetValue(int j, double value)
    {
        values[j] = value;
    }


    public int Length()
    {
        return values.Length;
    }


    
}
