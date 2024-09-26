// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class InnerDetectorCFNKubernetesConfigurationFactory(Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration>
{

    internal InnerDetectorCFNKubernetesAuditLogsConfigurationFactory AuditLogsFactory { get; set; }

    protected override Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration Create()
    {
        var cFNKubernetesConfigurationResult = CreateCFNKubernetesConfiguration();
        factoryAction?.Invoke(cFNKubernetesConfigurationResult);

        return cFNKubernetesConfigurationResult;
    }

    private Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration CreateCFNKubernetesConfiguration()
    {
        var cFNKubernetesConfigurationResult = new Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration();

        return cFNKubernetesConfigurationResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.DetectorTypes.CFNKubernetesConfiguration result)
    {
        base.CreateChildren(result);

        result.AuditLogs ??= AuditLogsFactory?.Build();
    }

} // End Of Class

public static class InnerDetectorCFNKubernetesConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs(this InnerDetectorCFNKubernetesConfigurationFactory parentFactory, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null)
    {
        parentFactory.AuditLogsFactory = new InnerDetectorCFNKubernetesAuditLogsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuditLogsFactory);
    }

    public static CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1>(this CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuditLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1>(this CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuditLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, T2, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2>(this CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, T2, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2>(this CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, T2> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDetectorCFNKubernetesConfigurationFactory, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2>(this CombinedResult<T1, T2, InnerDetectorCFNKubernetesConfigurationFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, T2, T3, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3>(this CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, T2, T3, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3>(this CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDetectorCFNKubernetesConfigurationFactory, T3, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerDetectorCFNKubernetesConfigurationFactory, T3> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDetectorCFNKubernetesConfigurationFactory, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDetectorCFNKubernetesConfigurationFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, T2, T3, T4, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3, T4>(this CombinedResult<InnerDetectorCFNKubernetesConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, T2, T3, T4, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerDetectorCFNKubernetesConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDetectorCFNKubernetesConfigurationFactory, T3, T4, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDetectorCFNKubernetesConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDetectorCFNKubernetesConfigurationFactory, T4, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDetectorCFNKubernetesConfigurationFactory, T4> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDetectorCFNKubernetesConfigurationFactory, InnerDetectorCFNKubernetesAuditLogsConfigurationFactory> WithAuditLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDetectorCFNKubernetesConfigurationFactory> combinedResult, Action<Humidifier.GuardDuty.DetectorTypes.CFNKubernetesAuditLogsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuditLogs(combinedResult.T5, subFactoryAction));
}
