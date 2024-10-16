// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class DatabaseFactory(string resourceName = null, Action<Humidifier.Glue.Database> factoryAction = null) : ResourceFactory<Humidifier.Glue.Database>(resourceName)
{

    internal InnerDatabaseDatabaseInputFactory DatabaseInputFactory { get; set; }

    protected override Humidifier.Glue.Database Create()
    {
        var databaseResult = CreateDatabase();
        factoryAction?.Invoke(databaseResult);

        return databaseResult;
    }

    private Humidifier.Glue.Database CreateDatabase()
    {
        var databaseResult = new Humidifier.Glue.Database
        {
            GivenName = InputResourceName,
        };

        return databaseResult;
    }
    public override void CreateChildren(Humidifier.Glue.Database result)
    {
        base.CreateChildren(result);

        result.DatabaseInput ??= DatabaseInputFactory?.Build();
    }

} // End Of Class

public static class DatabaseFactoryExtensions
{
    public static CombinedResult<DatabaseFactory, InnerDatabaseDatabaseInputFactory> WithDatabaseInput(this DatabaseFactory parentFactory, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null)
    {
        parentFactory.DatabaseInputFactory = new InnerDatabaseDatabaseInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatabaseInputFactory);
    }

    public static CombinedResult<DatabaseFactory, T1, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1>(this CombinedResult<DatabaseFactory, T1> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1>(this CombinedResult<T1, DatabaseFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatabaseFactory, T1, T2, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2>(this CombinedResult<DatabaseFactory, T1, T2> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, T2, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2>(this CombinedResult<T1, DatabaseFactory, T2> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatabaseFactory, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2>(this CombinedResult<T1, T2, DatabaseFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatabaseFactory, T1, T2, T3, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3>(this CombinedResult<DatabaseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, T2, T3, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3>(this CombinedResult<T1, DatabaseFactory, T2, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatabaseFactory, T3, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3>(this CombinedResult<T1, T2, DatabaseFactory, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatabaseFactory, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatabaseFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatabaseFactory, T1, T2, T3, T4, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3, T4>(this CombinedResult<DatabaseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatabaseFactory, T2, T3, T4, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3, T4>(this CombinedResult<T1, DatabaseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatabaseFactory, T3, T4, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatabaseFactory, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatabaseFactory, T4, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatabaseFactory, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatabaseFactory, InnerDatabaseDatabaseInputFactory> WithDatabaseInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatabaseFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseInput(combinedResult.T5, subFactoryAction));
}
