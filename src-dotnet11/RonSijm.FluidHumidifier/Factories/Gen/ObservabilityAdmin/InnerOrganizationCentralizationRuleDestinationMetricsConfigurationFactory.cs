// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory(Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration>
{

    internal InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory BackupConfigurationFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration Create()
    {
        var destinationMetricsConfigurationResult = CreateDestinationMetricsConfiguration();
        factoryAction?.Invoke(destinationMetricsConfigurationResult);

        return destinationMetricsConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration CreateDestinationMetricsConfiguration()
    {
        var destinationMetricsConfigurationResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration();

        return destinationMetricsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration result)
    {
        base.CreateChildren(result);

        result.BackupConfiguration ??= BackupConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration(this InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory parentFactory, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null)
    {
        parentFactory.BackupConfigurationFactory = new InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BackupConfigurationFactory);
    }

    public static CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1>(this CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1>(this CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, T2, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2>(this CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T2, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2>(this CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, T2, T3, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3>(this CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T2, T3, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T3, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, T2, T3, T4, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T2, T3, T4, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T3, T4, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T4, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory, InnerOrganizationCentralizationRuleMetricsBackupConfigurationFactory> WithBackupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOrganizationCentralizationRuleDestinationMetricsConfigurationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupConfiguration(combinedResult.T5, subFactoryAction).T2);
}
