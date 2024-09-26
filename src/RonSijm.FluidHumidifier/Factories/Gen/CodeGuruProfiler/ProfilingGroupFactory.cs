// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeGuruProfiler;

public class ProfilingGroupFactory(string resourceName = null, Action<Humidifier.CodeGuruProfiler.ProfilingGroup> factoryAction = null) : ResourceFactory<Humidifier.CodeGuruProfiler.ProfilingGroup>(resourceName)
{

    internal List<InnerProfilingGroupChannelFactory> AnomalyDetectionNotificationConfigurationFactories { get; set; } = [];

    internal InnerProfilingGroupAgentPermissionsFactory AgentPermissionsFactory { get; set; }

    protected override Humidifier.CodeGuruProfiler.ProfilingGroup Create()
    {
        var profilingGroupResult = CreateProfilingGroup();
        factoryAction?.Invoke(profilingGroupResult);

        return profilingGroupResult;
    }

    private Humidifier.CodeGuruProfiler.ProfilingGroup CreateProfilingGroup()
    {
        var profilingGroupResult = new Humidifier.CodeGuruProfiler.ProfilingGroup
        {
            GivenName = InputResourceName,
        };

        return profilingGroupResult;
    }
    public override void CreateChildren(Humidifier.CodeGuruProfiler.ProfilingGroup result)
    {
        base.CreateChildren(result);

        result.AnomalyDetectionNotificationConfiguration = AnomalyDetectionNotificationConfigurationFactories.Any() ? AnomalyDetectionNotificationConfigurationFactories.Select(x => x.Build()).ToList() : null;
        result.AgentPermissions ??= AgentPermissionsFactory?.Build();
    }

} // End Of Class

public static class ProfilingGroupFactoryExtensions
{
    public static CombinedResult<ProfilingGroupFactory, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration(this ProfilingGroupFactory parentFactory, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null)
    {
        var factory = new InnerProfilingGroupChannelFactory(subFactoryAction);
        parentFactory.AnomalyDetectionNotificationConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ProfilingGroupFactory, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions(this ProfilingGroupFactory parentFactory, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null)
    {
        parentFactory.AgentPermissionsFactory = new InnerProfilingGroupAgentPermissionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AgentPermissionsFactory);
    }

    public static CombinedResult<ProfilingGroupFactory, T1, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1>(this CombinedResult<ProfilingGroupFactory, T1> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1>(this CombinedResult<T1, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, T2, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2>(this CombinedResult<ProfilingGroupFactory, T1, T2> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, T2, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2>(this CombinedResult<T1, ProfilingGroupFactory, T2> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfilingGroupFactory, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2>(this CombinedResult<T1, T2, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, T2, T3, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3>(this CombinedResult<ProfilingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, T2, T3, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, ProfilingGroupFactory, T2, T3> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfilingGroupFactory, T3, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ProfilingGroupFactory, T3> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProfilingGroupFactory, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, T2, T3, T4, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<ProfilingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, T2, T3, T4, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ProfilingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfilingGroupFactory, T3, T4, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProfilingGroupFactory, T3, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProfilingGroupFactory, T4, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProfilingGroupFactory, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProfilingGroupFactory, InnerProfilingGroupChannelFactory> WithAnomalyDetectionNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.Channel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectionNotificationConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1>(this CombinedResult<ProfilingGroupFactory, T1> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1>(this CombinedResult<T1, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, T2, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2>(this CombinedResult<ProfilingGroupFactory, T1, T2> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, T2, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2>(this CombinedResult<T1, ProfilingGroupFactory, T2> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfilingGroupFactory, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2>(this CombinedResult<T1, T2, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, T2, T3, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3>(this CombinedResult<ProfilingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, T2, T3, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3>(this CombinedResult<T1, ProfilingGroupFactory, T2, T3> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfilingGroupFactory, T3, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3>(this CombinedResult<T1, T2, ProfilingGroupFactory, T3> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProfilingGroupFactory, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProfilingGroupFactory, T1, T2, T3, T4, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3, T4>(this CombinedResult<ProfilingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProfilingGroupFactory, T2, T3, T4, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3, T4>(this CombinedResult<T1, ProfilingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProfilingGroupFactory, T3, T4, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProfilingGroupFactory, T3, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProfilingGroupFactory, T4, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProfilingGroupFactory, T4> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProfilingGroupFactory, InnerProfilingGroupAgentPermissionsFactory> WithAgentPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProfilingGroupFactory> combinedResult, Action<Humidifier.CodeGuruProfiler.ProfilingGroupTypes.AgentPermissions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentPermissions(combinedResult.T5, subFactoryAction));
}
