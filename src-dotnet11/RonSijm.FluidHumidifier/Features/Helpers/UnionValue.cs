using System.Runtime.CompilerServices;

namespace RonSijm.FluidHumidifier.Features.Helpers;

/// <summary>Accesses literal values while keeping CloudFormation expressions deferred.</summary>
public static class UnionValue
{
    public static object Unwrap(object value)
    {
        while (value is IUnion union)
        {
            value = union.Value;
        }

        return value;
    }

    public static T GetLiteral<T>(this Union<T, BaseFunction>? value)
    {
        var literal = Unwrap(value);
        if (literal is T result && literal is not BaseFunction)
        {
            return result;
        }

        throw new InvalidOperationException($"Expected a literal {typeof(T).Name}; the property is unset or contains a CloudFormation expression.");
    }

    public static IReadOnlyList<Union<T, BaseFunction>> GetItems<T>(
        this Union<IReadOnlyList<T>, IReadOnlyList<Union<T, BaseFunction>>, BaseFunction>? value)
    {
        return Unwrap(value) switch
        {
            null => [],
            IReadOnlyList<Union<T, BaseFunction>> mixed => mixed,
            IReadOnlyList<T> literals => literals.Select(item => (Union<T, BaseFunction>)item).ToArray(),
            _ => throw new InvalidOperationException("The collection is a CloudFormation expression and cannot be enumerated locally.")
        };
    }
}
