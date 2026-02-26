public class DimensionValidator
{
    public bool ValidatorMatrixAddition(Matrix A, Matrix B)
    {
        return A.Rows() == B.Rows() && A.Columns() == B.Columns();
    }


    public bool ValidatorVectorAddition(Vector A, Vector B){
        return A.Size == B.Size;
    }



}
