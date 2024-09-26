// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignSignalFetchConfigFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig>
{

    internal InnerCampaignConditionBasedSignalFetchConfigFactory ConditionBasedFactory { get; set; }

    internal InnerCampaignTimeBasedSignalFetchConfigFactory TimeBasedFactory { get; set; }

    protected override Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig Create()
    {
        var signalFetchConfigResult = CreateSignalFetchConfig();
        factoryAction?.Invoke(signalFetchConfigResult);

        return signalFetchConfigResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig CreateSignalFetchConfig()
    {
        var signalFetchConfigResult = new Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig();

        return signalFetchConfigResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig result)
    {
        base.CreateChildren(result);

        result.ConditionBased ??= ConditionBasedFactory?.Build();
        result.TimeBased ??= TimeBasedFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignSignalFetchConfigFactoryExtensions
{
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased(this InnerCampaignSignalFetchConfigFactory parentFactory, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null)
    {
        parentFactory.ConditionBasedFactory = new InnerCampaignConditionBasedSignalFetchConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionBasedFactory);
    }

    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased(this InnerCampaignSignalFetchConfigFactory parentFactory, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null)
    {
        parentFactory.TimeBasedFactory = new InnerCampaignTimeBasedSignalFetchConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeBasedFactory);
    }

    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2>(this CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3, T4, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3, T4>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3, T4, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3, T4, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory, T4, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignSignalFetchConfigFactory, InnerCampaignConditionBasedSignalFetchConfigFactory> WithConditionBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditionBased(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2>(this CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3, T4, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3, T4>(this CombinedResult<InnerCampaignSignalFetchConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3, T4, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignSignalFetchConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3, T4, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignSignalFetchConfigFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory, T4, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignSignalFetchConfigFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignSignalFetchConfigFactory, InnerCampaignTimeBasedSignalFetchConfigFactory> WithTimeBased<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignSignalFetchConfigFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedSignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBased(combinedResult.T5, subFactoryAction));
}
