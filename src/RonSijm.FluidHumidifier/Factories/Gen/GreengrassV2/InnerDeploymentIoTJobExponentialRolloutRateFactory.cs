// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerDeploymentIoTJobExponentialRolloutRateFactory(Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate>
{

    internal InnerDeploymentIoTJobRateIncreaseCriteriaFactory RateIncreaseCriteriaFactory { get; set; }

    protected override Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate Create()
    {
        var ioTJobExponentialRolloutRateResult = CreateIoTJobExponentialRolloutRate();
        factoryAction?.Invoke(ioTJobExponentialRolloutRateResult);

        return ioTJobExponentialRolloutRateResult;
    }

    private Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate CreateIoTJobExponentialRolloutRate()
    {
        var ioTJobExponentialRolloutRateResult = new Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate();

        return ioTJobExponentialRolloutRateResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.DeploymentTypes.IoTJobExponentialRolloutRate result)
    {
        base.CreateChildren(result);

        result.RateIncreaseCriteria ??= RateIncreaseCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerDeploymentIoTJobExponentialRolloutRateFactoryExtensions
{
    public static CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria(this InnerDeploymentIoTJobExponentialRolloutRateFactory parentFactory, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null)
    {
        parentFactory.RateIncreaseCriteriaFactory = new InnerDeploymentIoTJobRateIncreaseCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RateIncreaseCriteriaFactory);
    }

    public static CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, T2, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, T2, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, T2, T3, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, T2, T3, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory, T3, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, T2, T3, T4, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentIoTJobExponentialRolloutRateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, T2, T3, T4, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentIoTJobExponentialRolloutRateFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory, T3, T4, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentIoTJobExponentialRolloutRateFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory, T4, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentIoTJobExponentialRolloutRateFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentIoTJobExponentialRolloutRateFactory, InnerDeploymentIoTJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentIoTJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.IoTJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T5, subFactoryAction));
}
