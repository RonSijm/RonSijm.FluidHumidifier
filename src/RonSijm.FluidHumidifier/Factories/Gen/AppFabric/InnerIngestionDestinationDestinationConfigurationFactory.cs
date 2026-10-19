// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationDestinationConfigurationFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration>
{

    internal InnerIngestionDestinationAuditLogDestinationConfigurationFactory AuditLogFactory { get; set; }

    protected override Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration Create()
    {
        var destinationConfigurationResult = CreateDestinationConfiguration();
        factoryAction?.Invoke(destinationConfigurationResult);

        return destinationConfigurationResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration CreateDestinationConfiguration()
    {
        var destinationConfigurationResult = new Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration();

        return destinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.IngestionDestinationTypes.DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.AuditLog ??= AuditLogFactory?.Build();
    }

} // End Of Class

public static class InnerIngestionDestinationDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog(this InnerIngestionDestinationDestinationConfigurationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.AuditLogFactory = new InnerIngestionDestinationAuditLogDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuditLogFactory);
    }

    public static CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1>(this CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1>(this CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2>(this CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, T2, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2>(this CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationConfigurationFactory, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, T2, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, T2, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationConfigurationFactory, T3, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationConfigurationFactory, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, T2, T3, T4, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<InnerIngestionDestinationDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, T2, T3, T4, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, InnerIngestionDestinationDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationDestinationConfigurationFactory, T3, T4, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIngestionDestinationDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationConfigurationFactory, T4, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationDestinationConfigurationFactory, InnerIngestionDestinationAuditLogDestinationConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationDestinationConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T5, subFactoryAction).T2);
}
