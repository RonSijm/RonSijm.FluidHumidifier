// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigAntennaDownlinkConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig>
{

    internal InnerConfigSpectrumConfigFactory SpectrumConfigFactory { get; set; }

    protected override Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig Create()
    {
        var antennaDownlinkConfigResult = CreateAntennaDownlinkConfig();
        factoryAction?.Invoke(antennaDownlinkConfigResult);

        return antennaDownlinkConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig CreateAntennaDownlinkConfig()
    {
        var antennaDownlinkConfigResult = new Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig();

        return antennaDownlinkConfigResult;
    }
    public override void CreateChildren(Humidifier.GroundStation.ConfigTypes.AntennaDownlinkConfig result)
    {
        base.CreateChildren(result);

        result.SpectrumConfig ??= SpectrumConfigFactory?.Build();
    }

} // End Of Class

public static class InnerConfigAntennaDownlinkConfigFactoryExtensions
{
    public static CombinedResult<InnerConfigAntennaDownlinkConfigFactory, InnerConfigSpectrumConfigFactory> WithSpectrumConfig(this InnerConfigAntennaDownlinkConfigFactory parentFactory, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null)
    {
        parentFactory.SpectrumConfigFactory = new InnerConfigSpectrumConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpectrumConfigFactory);
    }

    public static CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1>(this CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1>(this CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, T2, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2>(this CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, T2, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2>(this CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, T2> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaDownlinkConfigFactory, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2>(this CombinedResult<T1, T2, InnerConfigAntennaDownlinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, T2, T3, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, T2, T3, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, T2, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaDownlinkConfigFactory, T3, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigAntennaDownlinkConfigFactory, T3> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigAntennaDownlinkConfigFactory, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigAntennaDownlinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, T2, T3, T4, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<InnerConfigAntennaDownlinkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, T2, T3, T4, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigAntennaDownlinkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigAntennaDownlinkConfigFactory, T3, T4, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigAntennaDownlinkConfigFactory, T3, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigAntennaDownlinkConfigFactory, T4, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigAntennaDownlinkConfigFactory, T4> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigAntennaDownlinkConfigFactory, InnerConfigSpectrumConfigFactory> WithSpectrumConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigAntennaDownlinkConfigFactory> combinedResult, Action<Humidifier.GroundStation.ConfigTypes.SpectrumConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpectrumConfig(combinedResult.T5, subFactoryAction));
}
