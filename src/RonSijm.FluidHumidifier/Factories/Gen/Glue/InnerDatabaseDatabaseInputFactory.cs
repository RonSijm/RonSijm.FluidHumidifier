// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerDatabaseDatabaseInputFactory(Action<Humidifier.Glue.DatabaseTypes.DatabaseInput> factoryAction = null) : SubResourceFactory<Humidifier.Glue.DatabaseTypes.DatabaseInput>
{

    internal InnerDatabaseDatabaseIdentifierFactory TargetDatabaseFactory { get; set; }

    internal InnerDatabaseFederatedDatabaseFactory FederatedDatabaseFactory { get; set; }

    protected override Humidifier.Glue.DatabaseTypes.DatabaseInput Create()
    {
        var databaseInputResult = CreateDatabaseInput();
        factoryAction?.Invoke(databaseInputResult);

        return databaseInputResult;
    }

    private Humidifier.Glue.DatabaseTypes.DatabaseInput CreateDatabaseInput()
    {
        var databaseInputResult = new Humidifier.Glue.DatabaseTypes.DatabaseInput();

        return databaseInputResult;
    }
    public override void CreateChildren(Humidifier.Glue.DatabaseTypes.DatabaseInput result)
    {
        base.CreateChildren(result);

        result.TargetDatabase ??= TargetDatabaseFactory?.Build();
        result.FederatedDatabase ??= FederatedDatabaseFactory?.Build();
    }

} // End Of Class

public static class InnerDatabaseDatabaseInputFactoryExtensions
{
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase(this InnerDatabaseDatabaseInputFactory parentFactory, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null)
    {
        parentFactory.TargetDatabaseFactory = new InnerDatabaseDatabaseIdentifierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetDatabaseFactory);
    }

    public static CombinedResult<InnerDatabaseDatabaseInputFactory, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase(this InnerDatabaseDatabaseInputFactory parentFactory, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null)
    {
        parentFactory.FederatedDatabaseFactory = new InnerDatabaseFederatedDatabaseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FederatedDatabaseFactory);
    }

    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2>(this CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3, T4, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3, T4>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3, T4, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3, T4, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory, T4, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatabaseDatabaseInputFactory, InnerDatabaseDatabaseIdentifierFactory> WithTargetDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.DatabaseIdentifier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDatabase(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2>(this CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3, T4, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3, T4>(this CombinedResult<InnerDatabaseDatabaseInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3, T4, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatabaseDatabaseInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3, T4, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatabaseDatabaseInputFactory, T3, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory, T4, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatabaseDatabaseInputFactory, T4> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatabaseDatabaseInputFactory, InnerDatabaseFederatedDatabaseFactory> WithFederatedDatabase<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatabaseDatabaseInputFactory> combinedResult, Action<Humidifier.Glue.DatabaseTypes.FederatedDatabase> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFederatedDatabase(combinedResult.T5, subFactoryAction));
}
