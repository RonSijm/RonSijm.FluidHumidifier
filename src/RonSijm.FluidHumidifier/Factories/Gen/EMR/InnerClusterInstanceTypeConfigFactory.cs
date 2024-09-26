// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterInstanceTypeConfigFactory(Action<Humidifier.EMR.ClusterTypes.InstanceTypeConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.InstanceTypeConfig>
{

    internal InnerClusterEbsConfigurationFactory EbsConfigurationFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.InstanceTypeConfig Create()
    {
        var instanceTypeConfigResult = CreateInstanceTypeConfig();
        factoryAction?.Invoke(instanceTypeConfigResult);

        return instanceTypeConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.InstanceTypeConfig CreateInstanceTypeConfig()
    {
        var instanceTypeConfigResult = new Humidifier.EMR.ClusterTypes.InstanceTypeConfig();

        return instanceTypeConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.InstanceTypeConfig result)
    {
        base.CreateChildren(result);

        result.EbsConfiguration ??= EbsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerClusterInstanceTypeConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterInstanceTypeConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration(this InnerClusterInstanceTypeConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null)
    {
        parentFactory.EbsConfigurationFactory = new InnerClusterEbsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsConfigurationFactory);
    }

    public static CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1>(this CombinedResult<InnerClusterInstanceTypeConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1>(this CombinedResult<T1, InnerClusterInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, T2, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, T2, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceTypeConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerClusterInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, T2, T3, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, T2, T3, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceTypeConfigFactory, T3, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterInstanceTypeConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceTypeConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, T2, T3, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerClusterInstanceTypeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, T2, T3, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterInstanceTypeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterInstanceTypeConfigFactory, T3, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterInstanceTypeConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceTypeConfigFactory, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterInstanceTypeConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterInstanceTypeConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T5, subFactoryAction));
}
