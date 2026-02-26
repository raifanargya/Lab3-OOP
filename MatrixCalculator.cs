public class MatrixCalculator
{
    private DimensionValidator Validator;

    public MatrixCalculator(DimensionValidator validator)
    {
        Validator = validator;
    }
    

    public Matrix Add(Matrix A, Matrix B)
    {
        if (!Validator.ValidatorMatrixAddition(A, B))
        {
            throw new ArgumentException("Matrix dimensions do not match.");
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
}
