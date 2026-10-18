// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonDaemonDeploymentConfigurationFactory(Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration>
{

    internal InnerDaemonDaemonAlarmConfigurationFactory AlarmsFactory { get; set; }

    protected override Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration Create()
    {
        var daemonDeploymentConfigurationResult = CreateDaemonDeploymentConfiguration();
        factoryAction?.Invoke(daemonDeploymentConfigurationResult);

        return daemonDeploymentConfigurationResult;
    }

    private Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration CreateDaemonDeploymentConfiguration()
    {
        var daemonDeploymentConfigurationResult = new Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration();

        return daemonDeploymentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration result)
    {
        base.CreateChildren(result);

        result.Alarms ??= AlarmsFactory?.Build();
    }

} // End Of Class

public static class InnerDaemonDaemonDeploymentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms(this InnerDaemonDaemonDeploymentConfigurationFactory parentFactory, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null)
    {
        parentFactory.AlarmsFactory = new InnerDaemonDaemonAlarmConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AlarmsFactory);
    }

    public static CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1>(this CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1>(this CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, T2, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2>(this CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, T2, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2>(this CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2>(this CombinedResult<T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, T2, T3, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3>(this CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, T2, T3, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory, T3, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDaemonDaemonDeploymentConfigurationFactory, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDaemonDaemonDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, T2, T3, T4, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<InnerDaemonDaemonDeploymentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, T2, T3, T4, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, InnerDaemonDaemonDeploymentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory, T3, T4, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDaemonDaemonDeploymentConfigurationFactory, T4, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDaemonDaemonDeploymentConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDaemonDaemonDeploymentConfigurationFactory, InnerDaemonDaemonAlarmConfigurationFactory> WithAlarms<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDaemonDaemonDeploymentConfigurationFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAlarms(combinedResult.T5, subFactoryAction).T2);
}
