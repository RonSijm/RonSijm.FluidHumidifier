// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InstanceFleetConfigFactory(string resourceName = null, Action<Humidifier.EMR.InstanceFleetConfig> factoryAction = null) : ResourceFactory<Humidifier.EMR.InstanceFleetConfig>(resourceName)
{

    internal List<InnerInstanceFleetConfigInstanceTypeConfigFactory> InstanceTypeConfigsFactories { get; set; } = [];

    internal InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory LaunchSpecificationsFactory { get; set; }

    protected override Humidifier.EMR.InstanceFleetConfig Create()
    {
        var instanceFleetConfigResult = CreateInstanceFleetConfig();
        factoryAction?.Invoke(instanceFleetConfigResult);

        return instanceFleetConfigResult;
    }

    private Humidifier.EMR.InstanceFleetConfig CreateInstanceFleetConfig()
    {
        var instanceFleetConfigResult = new Humidifier.EMR.InstanceFleetConfig
        {
            GivenName = InputResourceName,
        };

        return instanceFleetConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.InstanceFleetConfig result)
    {
        base.CreateChildren(result);

        result.InstanceTypeConfigs = InstanceTypeConfigsFactories.Any() ? InstanceTypeConfigsFactories.Select(x => x.Build()).ToList() : null;
        result.LaunchSpecifications ??= LaunchSpecificationsFactory?.Build();
    }

} // End Of Class

public static class InstanceFleetConfigFactoryExtensions
{
    public static CombinedResult<InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs(this InstanceFleetConfigFactory parentFactory, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null)
    {
        var factory = new InnerInstanceFleetConfigInstanceTypeConfigFactory(subFactoryAction);
        parentFactory.InstanceTypeConfigsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications(this InstanceFleetConfigFactory parentFactory, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null)
    {
        parentFactory.LaunchSpecificationsFactory = new InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchSpecificationsFactory);
    }

    public static CombinedResult<InstanceFleetConfigFactory, T1, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1>(this CombinedResult<InstanceFleetConfigFactory, T1> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1>(this CombinedResult<T1, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2>(this CombinedResult<InstanceFleetConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2>(this CombinedResult<T1, InstanceFleetConfigFactory, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2>(this CombinedResult<T1, T2, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, T2, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<InstanceFleetConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, T2, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<T1, InstanceFleetConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFleetConfigFactory, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFleetConfigFactory, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, T2, T3, T4, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<InstanceFleetConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, T2, T3, T4, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFleetConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFleetConfigFactory, T3, T4, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFleetConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFleetConfigFactory, T4, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFleetConfigFactory, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceTypeConfigFactory> WithInstanceTypeConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeConfigs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1>(this CombinedResult<InstanceFleetConfigFactory, T1> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1>(this CombinedResult<T1, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, T2, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2>(this CombinedResult<InstanceFleetConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, T2, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2>(this CombinedResult<T1, InstanceFleetConfigFactory, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2>(this CombinedResult<T1, T2, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, T2, T3, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<InstanceFleetConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, T2, T3, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<T1, InstanceFleetConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFleetConfigFactory, T3, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFleetConfigFactory, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFleetConfigFactory, T1, T2, T3, T4, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<InstanceFleetConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFleetConfigFactory, T2, T3, T4, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFleetConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFleetConfigFactory, T3, T4, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFleetConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFleetConfigFactory, T4, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFleetConfigFactory, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFleetConfigFactory, InnerInstanceFleetConfigInstanceFleetProvisioningSpecificationsFactory> WithLaunchSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFleetConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecifications(combinedResult.T5, subFactoryAction));
}
