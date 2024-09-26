// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigUplinkSpectrumConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig>
{

    internal InnerConfigFrequencyFactory CenterFrequencyFactory { get; set; }

    protected override Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig Create()
    {
        var uplinkSpectrumConfigResult = CreateUplinkSpectrumConfig();
        factoryAction?.Invoke(uplinkSpectrumConfigResult);

        return uplinkSpectrumConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig CreateUplinkSpectrumConfig()
    {
        var uplinkSpectrumConfigResult = new Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig();

        return uplinkSpectrumConfigResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig result)
    {
        base.CreateChildren(result);

        result.CenterFrequency ??= CenterFrequencyFactory?.Build();
    }

} // End Of Class

public static class InnerConfigUplinkSpectrumConfigFactoryExtensions
{
    public static CombinedResult<InnerConfigUplinkSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency(this InnerConfigUplinkSpectrumConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null)
    {
        parentFactory.CenterFrequencyFactory = new InnerConfigFrequencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CenterFrequencyFactory);
    }

    public static CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, InnerConfigFrequencyFactory> WithCenterFrequency<T1>(this CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1>(this CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, T2, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2>(this CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, T2, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2>(this CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigUplinkSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2>(this CombinedResult<T1, T2, InnerConfigUplinkSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, T2, T3, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, T2, T3, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigUplinkSpectrumConfigFactory, T3, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigUplinkSpectrumConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigUplinkSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigUplinkSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, T2, T3, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<InnerConfigUplinkSpectrumConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, T2, T3, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigUplinkSpectrumConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigUplinkSpectrumConfigFactory, T3, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigUplinkSpectrumConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigUplinkSpectrumConfigFactory, T4, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigUplinkSpectrumConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigUplinkSpectrumConfigFactory, InnerConfigFrequencyFactory> WithCenterFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigUplinkSpectrumConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Frequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCenterFrequency(combinedResult.T5, subFactoryAction));
}
