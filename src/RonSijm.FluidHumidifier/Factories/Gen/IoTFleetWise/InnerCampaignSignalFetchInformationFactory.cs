// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignSignalFetchInformationFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation>
{

    internal InnerCampaignSignalFetchConfigFactory SignalFetchConfigFactory { get; set; }

    protected override Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation Create()
    {
        var signalFetchInformationResult = CreateSignalFetchInformation();
        factoryAction?.Invoke(signalFetchInformationResult);

        return signalFetchInformationResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation CreateSignalFetchInformation()
    {
        var signalFetchInformationResult = new Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation();

        return signalFetchInformationResult;
    }
    public override void CreateChildren(Humidifier.IoTFleetWise.CampaignTypes.SignalFetchInformation result)
    {
        base.CreateChildren(result);

        result.SignalFetchConfig ??= SignalFetchConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignSignalFetchInformationFactoryExtensions
{
    public static CombinedResult<InnerCampaignSignalFetchInformationFactory, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig(this InnerCampaignSignalFetchInformationFactory parentFactory, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null)
    {
        parentFactory.SignalFetchConfigFactory = new InnerCampaignSignalFetchConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SignalFetchConfigFactory);
    }

    public static CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1>(this CombinedResult<InnerCampaignSignalFetchInformationFactory, T1> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1>(this CombinedResult<T1, InnerCampaignSignalFetchInformationFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, T2, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2>(this CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, T2, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2>(this CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, T2> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchInformationFactory, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2>(this CombinedResult<T1, T2, InnerCampaignSignalFetchInformationFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, T2, T3, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3>(this CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, T2, T3, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3>(this CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, T2, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchInformationFactory, T3, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignSignalFetchInformationFactory, T3> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSignalFetchInformationFactory, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignSignalFetchInformationFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, T2, T3, T4, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3, T4>(this CombinedResult<InnerCampaignSignalFetchInformationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, T2, T3, T4, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignSignalFetchInformationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignSignalFetchInformationFactory, T3, T4, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignSignalFetchInformationFactory, T3, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignSignalFetchInformationFactory, T4, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignSignalFetchInformationFactory, T4> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignSignalFetchInformationFactory, InnerCampaignSignalFetchConfigFactory> WithSignalFetchConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignSignalFetchInformationFactory> combinedResult, Action<Humidifier.IoTFleetWise.CampaignTypes.SignalFetchConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignalFetchConfig(combinedResult.T5, subFactoryAction));
}
