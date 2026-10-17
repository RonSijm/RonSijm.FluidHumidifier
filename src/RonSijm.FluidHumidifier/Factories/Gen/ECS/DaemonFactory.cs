// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class DaemonFactory(string resourceName = null, Action<Humidifier.ECS.Daemon> factoryAction = null) : ResourceFactory<Humidifier.ECS.Daemon>(resourceName)
{

    internal InnerDaemonDaemonDeploymentConfigurationFactory DeploymentConfigurationFactory { get; set; }

    protected override Humidifier.ECS.Daemon Create()
    {
        var daemonResult = CreateDaemon();
        factoryAction?.Invoke(daemonResult);

        return daemonResult;
    }

    private Humidifier.ECS.Daemon CreateDaemon()
    {
        var daemonResult = new Humidifier.ECS.Daemon
        {
            GivenName = InputResourceName,
        };

        return daemonResult;
    }
    public override void CreateChildren(Humidifier.ECS.Daemon result)
    {
        base.CreateChildren(result);

        result.DeploymentConfiguration ??= DeploymentConfigurationFactory?.Build();
    }

} // End Of Class

public static class DaemonFactoryExtensions
{
    public static CombinedResult<DaemonFactory, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration(this DaemonFactory parentFactory, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null)
    {
        parentFactory.DeploymentConfigurationFactory = new InnerDaemonDaemonDeploymentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentConfigurationFactory);
    }

    public static CombinedResult<DaemonFactory, T1, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1>(this CombinedResult<DaemonFactory, T1> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonFactory, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1>(this CombinedResult<T1, DaemonFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DaemonFactory, T1, T2, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2>(this CombinedResult<DaemonFactory, T1, T2> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonFactory, T2, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2>(this CombinedResult<T1, DaemonFactory, T2> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonFactory, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2>(this CombinedResult<T1, T2, DaemonFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DaemonFactory, T1, T2, T3, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3>(this CombinedResult<DaemonFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonFactory, T2, T3, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3>(this CombinedResult<T1, DaemonFactory, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonFactory, T3, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DaemonFactory, T3> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DaemonFactory, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DaemonFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DaemonFactory, T1, T2, T3, T4, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3, T4>(this CombinedResult<DaemonFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonFactory, T2, T3, T4, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DaemonFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonFactory, T3, T4, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DaemonFactory, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DaemonFactory, T4, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DaemonFactory, T4> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DaemonFactory, InnerDaemonDaemonDeploymentConfigurationFactory> WithDeploymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DaemonFactory> combinedResult, Action<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfiguration(combinedResult.T5, subFactoryAction).T2);
}
