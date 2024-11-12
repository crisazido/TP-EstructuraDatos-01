using System.Collections.Generic;

public class ConjuntoDinamico<T> : ConjuntoTDA<T>
{
    private HashSet<T> elementos = new HashSet<T>();

    public override bool Add(T element)
    {
        return elementos.Add(element);
    }

    public override bool Remove(T element)
    {
        return elementos.Remove(element);
    }

    public override bool Contains(T element)
    {
        return elementos.Contains(element);
    }

    public override string Show()
    {
        return string.Join(", ", elementos);
    }

    public override int Cardinality()
    {
        return elementos.Count;
    }

    public override bool IsEmpty()
    {
        return elementos.Count == 0;
    }

    public override ConjuntoTDA<T> Union(ConjuntoTDA<T> otherSet)
    {
        ConjuntoDinamico<T> unionSet = new ConjuntoDinamico<T>();
        foreach (var elem in elementos)
        {
            unionSet.Add(elem);
        }
        foreach (var elem in (otherSet as ConjuntoDinamico<T>).elementos)
        {
            unionSet.Add(elem);
        }
        return unionSet;
    }

    public override ConjuntoTDA<T> Intersect(ConjuntoTDA<T> otherSet)
    {
        ConjuntoDinamico<T> intersectSet = new ConjuntoDinamico<T>();
        foreach (var elem in elementos)
        {
            if (otherSet.Contains(elem))
            {
                intersectSet.Add(elem);
            }
        }
        return intersectSet;
    }

    public override ConjuntoTDA<T> Difference(ConjuntoTDA<T> otherSet)
    {
        ConjuntoDinamico<T> differenceSet = new ConjuntoDinamico<T>();
        foreach (var elem in elementos)
        {
            if (!otherSet.Contains(elem))
            {
                differenceSet.Add(elem);
            }
        }
        return differenceSet;
    }
}

