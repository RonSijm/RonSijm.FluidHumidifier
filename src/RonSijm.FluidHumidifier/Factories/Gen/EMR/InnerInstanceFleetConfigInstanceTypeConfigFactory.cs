// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigInstanceTypeConfigFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig>
{

    internal InnerInstanceFleetConfigEbsConfigurationFactory EbsConfigurationFactory { get; set; }

    protected override Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig Create()
    {
        var instanceTypeConfigResult = CreateInstanceTypeConfig();
        factoryAction?.Invoke(instanceTypeConfigResult);

        return instanceTypeConfigResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig CreateInstanceTypeConfig()
    {
        var instanceTypeConfigResult = new Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig();

        return instanceTypeConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig result)
    {
        base.CreateChildren(result);

        result.EbsConfiguration ??= EbsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceFleetConfigInstanceTypeConfigFactoryExtensions
{
    public static CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration(this InnerInstanceFleetConfigInstanceTypeConfigFactory parentFactory, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null)
    {
        parentFactory.EbsConfigurationFactory = new InnerInstanceFleetConfigEbsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsConfigurationFactory);
    }

    public static CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1>(this CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1>(this CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, T2, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, T2, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, T2, T3, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, T2, T3, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory, T3, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, T2, T3, T4, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerInstanceFleetConfigInstanceTypeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, T2, T3, T4, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceFleetConfigInstanceTypeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory, T3, T4, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceFleetConfigInstanceTypeConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory, T4, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceFleetConfigInstanceTypeConfigFactory, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceFleetConfigInstanceTypeConfigFactory, InnerInstanceFleetConfigEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceFleetConfigInstanceTypeConfigFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T5, subFactoryAction));
}
