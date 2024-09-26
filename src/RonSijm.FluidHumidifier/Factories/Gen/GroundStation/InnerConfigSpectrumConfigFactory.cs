// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigSpectrumConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.SpectrumConfig>
{

    internal InnerConfigFrequencyBandwidthFactory BandwidthFactory { get; set; }

    internal InnerConfigFrequencyFactory CenterFrequencyFactory { get; set; }

    protected override Humidifier.GroundStation.ConfigTypes.SpectrumConfig Create()
    {
        var spectrumConfigResult = CreateSpectrumConfig();
        factoryAction?.Invoke(spectrumConfigResult);

        return spectrumConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.SpectrumConfig CreateSpectrumConfig()
    {
        var spectrumConfigResult = new Humidifier.GroundStation.ConfigTypes.SpectrumConfig();

        return spectrumConfigResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.ConfigTypes.SpectrumConfig result)
    {
        base.CreateChildren(result);

        result.Bandwidth ??= BandwidthFactory?.Build();
        result.CenterFrequency ??= CenterFrequencyFactory?.Build();
    }

} // End Of Class

public static class InnerConfigSpectrumConfigFactoryExtensions
{
    public static CombinedResult<InnerConfigSpectrumConfigFactory, InnerConfigFrequencyBandwidthFactory> WithBandwidth(this InnerConfigSpectrumConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null)
    {
        parentFactory.BandwidthFactory = new InnerConfigFrequencyBandwidthFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BandwidthFactory);
    }

    public static CombinedResult<InnerConfigSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency(this InnerConfigSpectrumConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null)
    {
        parentFactory.CenterFrequencyFactory = new InnerConfigFrequencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CenterFrequencyFactory);
    }

    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2>(this CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3, T4, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3, T4, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3, T4, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory, T4, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyBandwidthFactory> WithBandwidth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.FrequencyBandwidth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBandwidth(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, InnerConfigFrequencyFactory> WithCenterFrequency<T1>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2>(this CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<InnerConfigSpectrumConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigSpectrumConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigSpectrumConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigSpectrumConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T5, subFactoryAction));
}
