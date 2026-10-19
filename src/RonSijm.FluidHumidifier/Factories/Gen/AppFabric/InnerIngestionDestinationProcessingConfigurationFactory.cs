// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerIngestionDestinationProcessingConfigurationFactory(Action<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration>
{

    internal InnerIngestionDestinationAuditLogProcessingConfigurationFactory AuditLogFactory { get; set; }

    protected override Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration Create()
    {
        var processingConfigurationResult = CreateProcessingConfiguration();
        factoryAction?.Invoke(processingConfigurationResult);

        return processingConfigurationResult;
    }

    private Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration CreateProcessingConfiguration()
    {
        var processingConfigurationResult = new Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration();

        return processingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppFabric.IngestionDestinationTypes.ProcessingConfiguration result)
    {
        base.CreateChildren(result);

        result.AuditLog ??= AuditLogFactory?.Build();
    }

} // End Of Class

public static class InnerIngestionDestinationProcessingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog(this InnerIngestionDestinationProcessingConfigurationFactory parentFactory, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null)
    {
        parentFactory.AuditLogFactory = new InnerIngestionDestinationAuditLogProcessingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuditLogFactory);
    }

    public static CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1>(this CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1>(this CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, T2, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2>(this CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, T2, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2>(this CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, T2> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationProcessingConfigurationFactory, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2>(this CombinedResult<T1, T2, InnerIngestionDestinationProcessingConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, T2, T3, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, T2, T3, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationProcessingConfigurationFactory, T3, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<T1, T2, InnerIngestionDestinationProcessingConfigurationFactory, T3> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationProcessingConfigurationFactory, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationProcessingConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, T2, T3, T4, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<InnerIngestionDestinationProcessingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, T2, T3, T4, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, InnerIngestionDestinationProcessingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerIngestionDestinationProcessingConfigurationFactory, T3, T4, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIngestionDestinationProcessingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerIngestionDestinationProcessingConfigurationFactory, T4, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIngestionDestinationProcessingConfigurationFactory, T4> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationProcessingConfigurationFactory, InnerIngestionDestinationAuditLogProcessingConfigurationFactory> WithAuditLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIngestionDestinationProcessingConfigurationFactory> combinedResult, Action<Humidifier.AppFabric.IngestionDestinationTypes.AuditLogProcessingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLog(combinedResult.T5, subFactoryAction).T2);
}
