public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        rowData = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public int Rows()
    {
        return rows;
    }

    public int Columns()
    {
        return cols;
    }

    public double GetValue(int i, int j)
    {
        return rowData[i].GetValue(j);
    }

    public void SetValue(int i, int j, double value)
    {
        rowData[i].SetValue(j, value);
    }

    public void Display()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(GetValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    public static Matrix Add(Matrix A, Matrix B)
    {
        if (A.Rows() != B.Rows() || A.Columns() != B.Columns())
        {
            throw new ArgumentException("Matrices have different dimensions, cannot be added.");
        }

        Matrix result = new Matrix(A.Rows(), A.Columns());

        for (int i = 0; i < A.Rows(); i++)
        {
            for (int j = 0; j < A.Columns(); j++)
            {
                result.SetValue(i, j, A.GetValue(i, j) + B.GetValue(i, j));
            }
        }

        return result;
    }

    public void AddRow(Row row)
    {
        if (rowData.Length < rows + 1)
        {
            Row[] temp = new Row[rows + 1];
            Array.Copy(rowData, temp, rows);
            rowData = temp;
        }


        rowData[rows] = row;
        rows++;
    }
}
