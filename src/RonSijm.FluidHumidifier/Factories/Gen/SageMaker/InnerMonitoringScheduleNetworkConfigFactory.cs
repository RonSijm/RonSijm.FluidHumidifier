// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleNetworkConfigFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig>
{

    internal InnerMonitoringScheduleVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig Create()
    {
        var networkConfigResult = CreateNetworkConfig();
        factoryAction?.Invoke(networkConfigResult);

        return networkConfigResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig CreateNetworkConfig()
    {
        var networkConfigResult = new Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig();

        return networkConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerMonitoringScheduleNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig(this InnerMonitoringScheduleNetworkConfigFactory parentFactory, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerMonitoringScheduleVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, T2, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, T2, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringScheduleNetworkConfigFactory, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerMonitoringScheduleNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, T2, T3, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, T2, T3, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringScheduleNetworkConfigFactory, T3, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerMonitoringScheduleNetworkConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitoringScheduleNetworkConfigFactory, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMonitoringScheduleNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, T2, T3, T4, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerMonitoringScheduleNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, T2, T3, T4, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerMonitoringScheduleNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringScheduleNetworkConfigFactory, T3, T4, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMonitoringScheduleNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitoringScheduleNetworkConfigFactory, T4, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMonitoringScheduleNetworkConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMonitoringScheduleNetworkConfigFactory, InnerMonitoringScheduleVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMonitoringScheduleNetworkConfigFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
