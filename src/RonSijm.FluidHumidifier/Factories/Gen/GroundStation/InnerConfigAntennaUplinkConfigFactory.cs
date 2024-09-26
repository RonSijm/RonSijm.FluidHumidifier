// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigAntennaUplinkConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig>
{

    internal InnerConfigUplinkSpectrumConfigFactory SpectrumConfigFactory { get; set; }

    internal InnerConfigEirpFactory TargetEirpFactory { get; set; }

    protected override Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig Create()
    {
        var antennaUplinkConfigResult = CreateAntennaUplinkConfig();
        factoryAction?.Invoke(antennaUplinkConfigResult);

        return antennaUplinkConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig CreateAntennaUplinkConfig()
    {
        var antennaUplinkConfigResult = new Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig();

        return antennaUplinkConfigResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.ConfigTypes.AntennaUplinkConfig result)
    {
        base.CreateChildren(result);

        result.SpectrumConfig ??= SpectrumConfigFactory?.Build();
        result.TargetEirp ??= TargetEirpFactory?.Build();
    }

} // End Of Class

public static class InnerConfigAntennaUplinkConfigFactoryExtensions
{
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig(this InnerConfigAntennaUplinkConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null)
    {
        parentFactory.SpectrumConfigFactory = new InnerConfigUplinkSpectrumConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpectrumConfigFactory);
    }

    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, InnerConfigEirpFactory> WithTargetEirp(this InnerConfigAntennaUplinkConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null)
    {
        parentFactory.TargetEirpFactory = new InnerConfigEirpFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetEirpFactory);
    }

    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2>(this CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3, T4, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3, T4, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3, T4, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory, T4, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigAntennaUplinkConfigFactory, InnerConfigUplinkSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.UplinkSpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, InnerConfigEirpFactory> WithTargetEirp<T1>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetEirp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, InnerConfigEirpFactory> WithTargetEirp<T1>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetEirp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, InnerConfigEirpFactory> WithTargetEirp<T1, T2>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, InnerConfigEirpFactory> WithTargetEirp<T1, T2>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, InnerConfigEirpFactory> WithTargetEirp<T1, T2>(this CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3, T4, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3, T4>(this CombinedResult<InnerConfigAntennaUplinkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3, T4, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigAntennaUplinkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3, T4, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigAntennaUplinkConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory, T4, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigAntennaUplinkConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigAntennaUplinkConfigFactory, InnerConfigEirpFactory> WithTargetEirp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigAntennaUplinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.Eirp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetEirp(combinedResult.T5, subFactoryAction));
}
