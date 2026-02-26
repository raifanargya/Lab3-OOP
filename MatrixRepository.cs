using System.Collections.Generic;

public class MatrixRepository
{
    private List<Matrix> matrices;

    public MatrixRepository()
    {
        matrices = new List<Matrix>();
    }

    
    public void AddMatrix(Matrix matrix)
    {
        matrices.Add(matrix);
    }

    public Matrix GetMatrix(int index)
    {
        return matrices[index];
    }
}
