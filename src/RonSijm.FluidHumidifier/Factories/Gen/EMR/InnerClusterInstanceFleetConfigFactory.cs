// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterInstanceFleetConfigFactory(Action<Humidifier.EMR.ClusterTypes.InstanceFleetConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.InstanceFleetConfig>
{

    internal List<InnerClusterInstanceTypeConfigFactory> InstanceTypeConfigsFactories { get; set; } = [];

    internal InnerClusterInstanceFleetProvisioningSpecificationsFactory LaunchSpecificationsFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.InstanceFleetConfig Create()
    {
        var instanceFleetConfigResult = CreateInstanceFleetConfig();
        factoryAction?.Invoke(instanceFleetConfigResult);

        return instanceFleetConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.InstanceFleetConfig CreateInstanceFleetConfig()
    {
        var instanceFleetConfigResult = new Humidifier.EMR.ClusterTypes.InstanceFleetConfig();

        return instanceFleetConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.InstanceFleetConfig result)
    {
        base.CreateChildren(result);

        result.InstanceTypeConfigs = InstanceTypeConfigsFactories.Any() ? InstanceTypeConfigsFactories.Select(x => x.Build()).ToList() : null;
        result.LaunchSpecifications ??= LaunchSpecificationsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterInstanceFleetConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs(this InnerClusterInstanceFleetConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null)
    {
        var factory = new InnerClusterInstanceTypeConfigFactory(subFactoryAction);
        parentFactory.InstanceTypeConfigsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications(this InnerClusterInstanceFleetConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null)
    {
        parentFactory.LaunchSpecificationsFactory = new InnerClusterInstanceFleetProvisioningSpecificationsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchSpecificationsFactory);
    }

    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2>(this CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3, T4, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3, T4, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3, T4, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory, T4, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2>(this CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3, T4, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<InnerClusterInstanceFleetConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3, T4, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterInstanceFleetConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3, T4, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterInstanceFleetConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory, T4, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterInstanceFleetConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterInstanceFleetConfigFactory, InnerClusterInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterInstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T5, subFactoryAction));
}
