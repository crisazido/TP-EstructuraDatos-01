using System.Collections.Generic;
public class ConjuntoEstatico<T> : ConjuntoTDA<T>
{
    private T[] elementos;
    private int count;

    public ConjuntoEstatico(int capacity)
    {
        elementos = new T[capacity];
        count = 0;
    }

    public override bool Add(T element)
    {
        if (count >= elementos.Length || Contains(element))
            return false;

        elementos[count++] = element;
        return true;
    }

    public override bool Remove(T element)
    {
        for (int i = 0; i < count; i++)
        {
            if (elementos[i].Equals(element))
            {
                elementos[i] = elementos[count - 1];
                count--;
                return true;
            }
        }
        return false;
    }

    public override bool Contains(T element)
    {
        for (int i = 0; i < count; i++)
        {
            if (elementos[i].Equals(element))
                return true;
        }
        return false;
    }

    public override string Show()
    {
        var list = new List<T>();
        for (int i = 0; i < count; i++)
        {
            list.Add(elementos[i]);
        }
        return string.Join(", ", list);
    }

    public override int Cardinality()
    {
        return count;
    }

    public override bool IsEmpty()
    {
        return count == 0;
    }

    public override ConjuntoTDA<T> Union(ConjuntoTDA<T> otherSet)
    {
        ConjuntoEstatico<T> unionSet = new ConjuntoEstatico<T>(elementos.Length + (otherSet as ConjuntoEstatico<T>).elementos.Length);
        foreach (var elem in elementos)
        {
            unionSet.Add(elem);
        }
        foreach (var elem in (otherSet as ConjuntoEstatico<T>).elementos)
        {
            unionSet.Add(elem);
        }
        return unionSet;
    }

    public override ConjuntoTDA<T> Intersect(ConjuntoTDA<T> otherSet)
    {
        ConjuntoEstatico<T> intersectSet = new ConjuntoEstatico<T>(count);
        for (int i = 0; i < count; i++)
        {
            if (otherSet.Contains(elementos[i]))
            {
                intersectSet.Add(elementos[i]);
            }
        }
        return intersectSet;
    }

    public override ConjuntoTDA<T> Difference(ConjuntoTDA<T> otherSet)
    {
        ConjuntoEstatico<T> differenceSet = new ConjuntoEstatico<T>(count);
        for (int i = 0; i < count; i++)
        {
            if (!otherSet.Contains(elementos[i]))
            {
                differenceSet.Add(elementos[i]);
            }
        }
        return differenceSet;
    }
}

