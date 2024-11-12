using System.Collections.Generic;

public abstract class ConjuntoTDA<T>
{
    public abstract bool Add(T element);
    public abstract bool Remove(T element);
    public abstract bool Contains(T element);
    public abstract string Show();
    public abstract int Cardinality();
    public abstract bool IsEmpty();
    public abstract ConjuntoTDA<T> Union(ConjuntoTDA<T> otherSet);
    public abstract ConjuntoTDA<T> Intersect(ConjuntoTDA<T> otherSet);
    public abstract ConjuntoTDA<T> Difference(ConjuntoTDA<T> otherSet);
}