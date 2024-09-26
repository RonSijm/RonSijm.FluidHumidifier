// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentConfigZonalConfigFactory(Action<Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig>
{

    internal InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory MinimumHealthyHostsPerZoneFactory { get; set; }

    protected override Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig Create()
    {
        var zonalConfigResult = CreateZonalConfig();
        factoryAction?.Invoke(zonalConfigResult);

        return zonalConfigResult;
    }

    private Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig CreateZonalConfig()
    {
        var zonalConfigResult = new Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig();

        return zonalConfigResult;
    }
    public override void CreateChildren(Humidifier.CodeDeploy.DeploymentConfigTypes.ZonalConfig result)
    {
        base.CreateChildren(result);

        result.MinimumHealthyHostsPerZone ??= MinimumHealthyHostsPerZoneFactory?.Build();
    }

} // End Of Class

public static class InnerDeploymentConfigZonalConfigFactoryExtensions
{
    public static CombinedResult<InnerDeploymentConfigZonalConfigFactory, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone(this InnerDeploymentConfigZonalConfigFactory parentFactory, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null)
    {
        parentFactory.MinimumHealthyHostsPerZoneFactory = new InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MinimumHealthyHostsPerZoneFactory);
    }

    public static CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1>(this CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1>(this CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, T2, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2>(this CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, T2, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2>(this CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentConfigZonalConfigFactory, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentConfigZonalConfigFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, T2, T3, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3>(this CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, T2, T3, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentConfigZonalConfigFactory, T3, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentConfigZonalConfigFactory, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentConfigZonalConfigFactory, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentConfigZonalConfigFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, T2, T3, T4, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentConfigZonalConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, T2, T3, T4, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentConfigZonalConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentConfigZonalConfigFactory, T3, T4, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentConfigZonalConfigFactory, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentConfigZonalConfigFactory, T4, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentConfigZonalConfigFactory, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentConfigZonalConfigFactory, InnerDeploymentConfigMinimumHealthyHostsPerZoneFactory> WithMinimumHealthyHostsPerZone<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentConfigZonalConfigFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentConfigTypes.MinimumHealthyHostsPerZone> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMinimumHealthyHostsPerZone(combinedResult.T5, subFactoryAction));
}
