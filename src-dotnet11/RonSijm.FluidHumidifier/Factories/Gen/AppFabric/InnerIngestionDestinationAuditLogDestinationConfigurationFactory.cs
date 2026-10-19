// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationAuditLogDestinationConfigurationFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration>
{

    internal InnerIngestionDestinationDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration Create()
    {
        var auditLogDestinationConfigurationResult = CreateAuditLogDestinationConfiguration();
        factoryAction?.Invoke(auditLogDestinationConfigurationResult);

        return auditLogDestinationConfigurationResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration CreateAuditLogDestinationConfiguration()
    {
        var auditLogDestinationConfigurationResult = new Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration();

        return auditLogDestinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerIngestionDestinationAuditLogDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, InnerIngestionDestinationDestinationFactory> WithDestination(this InnerIngestionDestinationAuditLogDestinationConfigurationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerIngestionDestinationDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, InnerIngestionDestinationDestinationFactory> WithDestination<T1>(this CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, InnerIngestionDestinationDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, T2, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T2, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, T2, T3, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T2, T3, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T3, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, T2, T3, T4, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T2, T3, T4, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T3, T4, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T4, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationAuditLogDestinationConfigurationFactory, InnerIngestionDestinationDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction).T2);
}
