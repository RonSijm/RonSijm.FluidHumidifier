// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationMonitoringConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration>
{

    internal InnerApplicationS3MonitoringConfigurationFactory S3MonitoringConfigurationFactory { get; set; }

    internal InnerApplicationManagedPersistenceMonitoringConfigurationFactory ManagedPersistenceMonitoringConfigurationFactory { get; set; }

    internal InnerApplicationCloudWatchLoggingConfigurationFactory CloudWatchLoggingConfigurationFactory { get; set; }

    protected override Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration Create()
    {
        var monitoringConfigurationResult = CreateMonitoringConfiguration();
        factoryAction?.Invoke(monitoringConfigurationResult);

        return monitoringConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration CreateMonitoringConfiguration()
    {
        var monitoringConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration();

        return monitoringConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EMRServerless.ApplicationTypes.MonitoringConfiguration result)
    {
        base.CreateChildren(result);

        result.S3MonitoringConfiguration ??= S3MonitoringConfigurationFactory?.Build();
        result.ManagedPersistenceMonitoringConfiguration ??= ManagedPersistenceMonitoringConfigurationFactory?.Build();
        result.CloudWatchLoggingConfiguration ??= CloudWatchLoggingConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationMonitoringConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration(this InnerApplicationMonitoringConfigurationFactory parentFactory, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null)
    {
        parentFactory.S3MonitoringConfigurationFactory = new InnerApplicationS3MonitoringConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3MonitoringConfigurationFactory);
    }

    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration(this InnerApplicationMonitoringConfigurationFactory parentFactory, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null)
    {
        parentFactory.ManagedPersistenceMonitoringConfigurationFactory = new InnerApplicationManagedPersistenceMonitoringConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManagedPersistenceMonitoringConfigurationFactory);
    }

    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration(this InnerApplicationMonitoringConfigurationFactory parentFactory, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null)
    {
        parentFactory.CloudWatchLoggingConfigurationFactory = new InnerApplicationCloudWatchLoggingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLoggingConfigurationFactory);
    }

    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, T4, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, T4, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, T4, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, T4, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationMonitoringConfigurationFactory, InnerApplicationS3MonitoringConfigurationFactory> WithS3MonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.S3MonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3MonitoringConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, T4, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, T4, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, T4, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, T4, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationMonitoringConfigurationFactory, InnerApplicationManagedPersistenceMonitoringConfigurationFactory> WithManagedPersistenceMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedPersistenceMonitoringConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, T4, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerApplicationMonitoringConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, T4, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationMonitoringConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, T4, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationMonitoringConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, T4, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationMonitoringConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationMonitoringConfigurationFactory, InnerApplicationCloudWatchLoggingConfigurationFactory> WithCloudWatchLoggingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationMonitoringConfigurationFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.CloudWatchLoggingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingConfiguration(combinedResult.T5, subFactoryAction));
}
