namespace RonSijm.FluidHumidifier.Factories.Core;

public class CombinedResult<T1In>(T1In t1)
{
    public T1In T1 { get; } = t1;

    public static implicit operator T1In(CombinedResult<T1In> combinedResult)
    {
        return combinedResult.T1;
    }
}

public class CombinedResult<T1In, T2In>(T1In t1, T2In t2) : CombinedResult<T1In>(t1)
{
    public T2In T2 { get; } = t2;

    public static implicit operator T1In(CombinedResult<T1In, T2In> combinedResult)
    {
        return combinedResult.T1;
    }

    public static implicit operator T2In(CombinedResult<T1In, T2In> combinedResult)
    {
        return combinedResult.T2;
    }
}

public class CombinedResult<T1In, T2In, T3In>(T1In t1, T2In t2, T3In t3) : CombinedResult<T1In, T2In>(t1, t2)
{
    public T3In T3 { get; } = t3;

    public static implicit operator T3In(CombinedResult<T1In, T2In, T3In> combinedResult)
    {
        return combinedResult.T3;
    }

    public static implicit operator T2In(CombinedResult<T1In, T2In, T3In> combinedResult)
    {
        return combinedResult.T2;
    }

    public static implicit operator T1In(CombinedResult<T1In, T2In, T3In> combinedResult)
    {
        return combinedResult.T1;
    }
}

public class CombinedResult<T1In, T2In, T3In, T4In>(T1In t1, T2In t2, T3In t3, T4In t4) : CombinedResult<T1In, T2In, T3In>(t1, t2, t3)
{
    public T4In T4 { get; } = t4;

    public static implicit operator T4In(CombinedResult<T1In, T2In, T3In, T4In> combinedResult)
    {
        return combinedResult.T4;
    }

    public static implicit operator T3In(CombinedResult<T1In, T2In, T3In, T4In> combinedResult)
    {
        return combinedResult.T3;
    }

    public static implicit operator T2In(CombinedResult<T1In, T2In, T3In, T4In> combinedResult)
    {
        return combinedResult.T2;
    }

    public static implicit operator T1In(CombinedResult<T1In, T2In, T3In, T4In> combinedResult)
    {
        return combinedResult.T1;
    }
}

public class CombinedResult<T1In, T2In, T3In, T4In, T5In>(T1In t1, T2In t2, T3In t3, T4In t4, T5In t5) : CombinedResult<T1In, T2In, T3In, T4In>(t1, t2, t3, t4)
{
    public T5In T5 { get; } = t5;

    public static implicit operator T5In(CombinedResult<T1In, T2In, T3In, T4In, T5In> combinedResult)
    {
        return combinedResult.T5;
    }

    public static implicit operator T4In(CombinedResult<T1In, T2In, T3In, T4In, T5In> combinedResult)
    {
        return combinedResult.T4;
    }

    public static implicit operator T3In(CombinedResult<T1In, T2In, T3In, T4In, T5In> combinedResult)
    {
        return combinedResult.T3;
    }

    public static implicit operator T2In(CombinedResult<T1In, T2In, T3In, T4In, T5In> combinedResult)
    {
        return combinedResult.T2;
    }

    public static implicit operator T1In(CombinedResult<T1In, T2In, T3In, T4In, T5In> combinedResult)
    {
        return combinedResult.T1;
    }
}

public class CombinedResult<T1In, T2In, T3In, T4In, T5In, T6In>(T1In t1, T2In t2, T3In t3, T4In t4, T5In t5, T6In t6) : CombinedResult<T1In, T2In, T3In, T4In, T5In>(t1, t2, t3, t4, t5)
{
    public T6In T6 { get; } = t6;

    public static implicit operator T5In(CombinedResult<T1In, T2In, T3In, T4In, T5In, T6In> combinedResult)
    {
        return combinedResult.T5;
    }

    public static implicit operator T4In(CombinedResult<T1In, T2In, T3In, T4In, T5In, T6In> combinedResult)
    {
        return combinedResult.T4;
    }

    public static implicit operator T3In(CombinedResult<T1In, T2In, T3In, T4In, T5In, T6In> combinedResult)
    {
        return combinedResult.T3;
    }

    public static implicit operator T2In(CombinedResult<T1In, T2In, T3In, T4In, T5In, T6In> combinedResult)
    {
        return combinedResult.T2;
    }

    public static implicit operator T1In(CombinedResult<T1In, T2In, T3In, T4In, T5In, T6In> combinedResult)
    {
        return combinedResult.T1;
    }
}

public static class CombinedResultFactory
{
    public static CombinedResult<T1In, T2In> Create<T1In, T2In>(T1In parent, T2In child)
    {
        var result = new CombinedResult<T1In, T2In>(parent, child);
        return result;
    }
}