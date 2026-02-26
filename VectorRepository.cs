using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors;


    public VectorRepository()
    {
        vectors = new List<Vector>();
    }

    public void AddVector(Vector vector)
    {
        vectors.Add(vector);
    }


    public Vector GetVector(int index)
    {
        return vectors[index];
    }


}
