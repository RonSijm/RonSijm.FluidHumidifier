// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class DatabaseFactory(string resourceName = null, Action<Humidifier.Lightsail.Database> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Database>(resourceName)
{

    internal List<InnerDatabaseRelationalDatabaseParameterFactory> RelationalDatabaseParametersFactories { get; set; } = [];

    protected override Humidifier.Lightsail.Database Create()
    {
        var databaseResult = CreateDatabase();
        factoryAction?.Invoke(databaseResult);

        return databaseResult;
    }

    private Humidifier.Lightsail.Database CreateDatabase()
    {
        var databaseResult = new Humidifier.Lightsail.Database
        {
            GivenName = InputResourceName,
        };

        return databaseResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.Database result)
    {
        base.CreateChildren(result);

        result.RelationalDatabaseParameters = RelationalDatabaseParametersFactories.Any() ? RelationalDatabaseParametersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DatabaseFactoryExtensions
{
    public static CombinedResult<DatabaseFactory, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters(this DatabaseFactory parentFactory, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null)
    {
        var factory = new InnerDatabaseRelationalDatabaseParameterFactory(subFactoryAction);
        parentFactory.RelationalDatabaseParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DatabaseFactory, T1, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1>(this CombinedResult<DatabaseFactory, T1> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1>(this CombinedResult<T1, DatabaseFactory> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatabaseFactory, T1, T2, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2>(this CombinedResult<DatabaseFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, T2, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2>(this CombinedResult<T1, DatabaseFactory, T2> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatabaseFactory, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2>(this CombinedResult<T1, T2, DatabaseFactory> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatabaseFactory, T1, T2, T3, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3>(this CombinedResult<DatabaseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, T2, T3, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3>(this CombinedResult<T1, DatabaseFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatabaseFactory, T3, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3>(this CombinedResult<T1, T2, DatabaseFactory, T3> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatabaseFactory, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatabaseFactory> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatabaseFactory, T1, T2, T3, T4, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3, T4>(this CombinedResult<DatabaseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, T2, T3, T4, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3, T4>(this CombinedResult<T1, DatabaseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatabaseFactory, T3, T4, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatabaseFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatabaseFactory, T4, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatabaseFactory, T4> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatabaseFactory, InnerDatabaseRelationalDatabaseParameterFactory> WithRelationalDatabaseParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatabaseFactory> combinedResult, Action<Humidifier.Lightsail.DatabaseTypes.RelationalDatabaseParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRelationalDatabaseParameters(combinedResult.T5, subFactoryAction));
}
