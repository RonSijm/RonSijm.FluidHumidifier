// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentIoTJobExecutionsRolloutConfigFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig>
{

    internal InnerDeploymentIoTJobExponentialRolloutRateFactory ExponentialRateFactory { get; set; }

    protected override Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig Create()
    {
        var ioTJobExecutionsRolloutConfigResult = CreateIoTJobExecutionsRolloutConfig();
        factoryAction?.Invoke(ioTJobExecutionsRolloutConfigResult);

        return ioTJobExecutionsRolloutConfigResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig CreateIoTJobExecutionsRolloutConfig()
    {
        var ioTJobExecutionsRolloutConfigResult = new Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig();

        return ioTJobExecutionsRolloutConfigResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.DeploymentTypes.IoTJobExecutionsRolloutConfig result)
    {
        base.CreateChildren(result);

        result.ExponentialRate ??= ExponentialRateFactory?.Build();
    }

} // End Of Class

public static class InnerDeploymentIoTJobExecutionsRolloutConfigFactoryExtensions
{
    public static CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate(this InnerDeploymentIoTJobExecutionsRolloutConfigFactory parentFactory, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null)
    {
        parentFactory.ExponentialRateFactory = new InnerDeploymentIoTJobExponentialRolloutRateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExponentialRateFactory);
    }

    public static CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1>(this CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1>(this CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentIoTJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, T2, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T2, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, T2, T3, T4, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T2, T3, T4, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T3, T4, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T4, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentIoTJobExecutionsRolloutConfigFactory, InnerDeploymentIoTJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentIoTJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T5, subFactoryAction));
}
