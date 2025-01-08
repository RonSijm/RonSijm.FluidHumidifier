// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class TypeFactory(string resourceName = null, Action<Humidifier.Cassandra.Type> factoryAction = null) : ResourceFactory<Humidifier.Cassandra.Type>(resourceName)
{

    internal List<InnerTypeFieldFactory> FieldsFactories { get; set; } = [];

    protected override Humidifier.Cassandra.Type Create()
    {
        var typeResult = CreateType();
        factoryAction?.Invoke(typeResult);

        return typeResult;
    }

    private Humidifier.Cassandra.Type CreateType()
    {
        var typeResult = new Humidifier.Cassandra.Type
        {
            GivenName = InputResourceName,
        };

        return typeResult;
    }
    public override void CreateChildren(Humidifier.Cassandra.Type result)
    {
        base.CreateChildren(result);

        result.Fields = FieldsFactories.Any() ? FieldsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TypeFactoryExtensions
{
    public static CombinedResult<TypeFactory, InnerTypeFieldFactory> WithFields(this TypeFactory parentFactory, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null)
    {
        var factory = new InnerTypeFieldFactory(subFactoryAction);
        parentFactory.FieldsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TypeFactory, T1, InnerTypeFieldFactory> WithFields<T1>(this CombinedResult<TypeFactory, T1> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeFactory, InnerTypeFieldFactory> WithFields<T1>(this CombinedResult<T1, TypeFactory> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TypeFactory, T1, T2, InnerTypeFieldFactory> WithFields<T1, T2>(this CombinedResult<TypeFactory, T1, T2> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeFactory, T2, InnerTypeFieldFactory> WithFields<T1, T2>(this CombinedResult<T1, TypeFactory, T2> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TypeFactory, InnerTypeFieldFactory> WithFields<T1, T2>(this CombinedResult<T1, T2, TypeFactory> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TypeFactory, T1, T2, T3, InnerTypeFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<TypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeFactory, T2, T3, InnerTypeFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, TypeFactory, T2, T3> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TypeFactory, T3, InnerTypeFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, T2, TypeFactory, T3> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TypeFactory, InnerTypeFieldFactory> WithFields<T1, T2, T3>(this CombinedResult<T1, T2, T3, TypeFactory> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TypeFactory, T1, T2, T3, T4, InnerTypeFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<TypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TypeFactory, T2, T3, T4, InnerTypeFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, TypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TypeFactory, T3, T4, InnerTypeFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, TypeFactory, T3, T4> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TypeFactory, T4, InnerTypeFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TypeFactory, T4> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TypeFactory, InnerTypeFieldFactory> WithFields<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TypeFactory> combinedResult, Action<Humidifier.Cassandra.TypeTypes.Field> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFields(combinedResult.T5, subFactoryAction));
}
