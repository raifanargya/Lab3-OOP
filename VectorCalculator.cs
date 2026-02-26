public class VectorCalculator
{
    private DimensionValidator Validator;

    public VectorCalculator(DimensionValidator validator)
    {
        Validator = validator;
    }

    public Vector Add(Vector A, Vector B)
    {

        if (!Validator.ValidatorVectorAddition(A, B))
        {
            throw new ArgumentException("Vector dimensions do not match");
        }

        Vector result = new Vector(A.Size);

        for (int i = 0; i < A.Size; i++)
        {
            result.SetValue(i, A.GetValue(i) + B.GetValue(i));
        }



        return result;
    }

    
}
