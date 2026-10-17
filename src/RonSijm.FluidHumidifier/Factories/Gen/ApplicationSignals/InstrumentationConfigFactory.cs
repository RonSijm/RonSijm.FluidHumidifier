// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InstrumentationConfigFactory(string resourceName = null, Action<Humidifier.ApplicationSignals.InstrumentationConfig> factoryAction = null) : ResourceFactory<Humidifier.ApplicationSignals.InstrumentationConfig>(resourceName)
{

    internal InnerInstrumentationConfigCaptureConfigurationFactory CaptureConfigurationFactory { get; set; }

    internal InnerInstrumentationConfigLocationFactory LocationFactory { get; set; }

    protected override Humidifier.ApplicationSignals.InstrumentationConfig Create()
    {
        var instrumentationConfigResult = CreateInstrumentationConfig();
        factoryAction?.Invoke(instrumentationConfigResult);

        return instrumentationConfigResult;
    }

    private Humidifier.ApplicationSignals.InstrumentationConfig CreateInstrumentationConfig()
    {
        var instrumentationConfigResult = new Humidifier.ApplicationSignals.InstrumentationConfig
        {
            GivenName = InputResourceName,
        };

        return instrumentationConfigResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.InstrumentationConfig result)
    {
        base.CreateChildren(result);

        result.CaptureConfiguration ??= CaptureConfigurationFactory?.Build();
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InstrumentationConfigFactoryExtensions
{
    public static CombinedResult<InstrumentationConfigFactory, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration(this InstrumentationConfigFactory parentFactory, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null)
    {
        parentFactory.CaptureConfigurationFactory = new InnerInstrumentationConfigCaptureConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CaptureConfigurationFactory);
    }

    public static CombinedResult<InstrumentationConfigFactory, InnerInstrumentationConfigLocationFactory> WithLocation(this InstrumentationConfigFactory parentFactory, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerInstrumentationConfigLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InstrumentationConfigFactory, T1, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1>(this CombinedResult<InstrumentationConfigFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1>(this CombinedResult<T1, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2>(this CombinedResult<InstrumentationConfigFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, T2, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2>(this CombinedResult<T1, InstrumentationConfigFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstrumentationConfigFactory, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2>(this CombinedResult<T1, T2, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, T2, T3, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3>(this CombinedResult<InstrumentationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, T2, T3, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3>(this CombinedResult<T1, InstrumentationConfigFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstrumentationConfigFactory, T3, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InstrumentationConfigFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InstrumentationConfigFactory, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, T2, T3, T4, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3, T4>(this CombinedResult<InstrumentationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, T2, T3, T4, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InstrumentationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstrumentationConfigFactory, T3, T4, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstrumentationConfigFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InstrumentationConfigFactory, T4, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstrumentationConfigFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InstrumentationConfigFactory, InnerInstrumentationConfigCaptureConfigurationFactory> WithCaptureConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, InnerInstrumentationConfigLocationFactory> WithLocation<T1>(this CombinedResult<InstrumentationConfigFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, InnerInstrumentationConfigLocationFactory> WithLocation<T1>(this CombinedResult<T1, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, T2, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2>(this CombinedResult<InstrumentationConfigFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, T2, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InstrumentationConfigFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstrumentationConfigFactory, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, T2, T3, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InstrumentationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, T2, T3, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InstrumentationConfigFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstrumentationConfigFactory, T3, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InstrumentationConfigFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InstrumentationConfigFactory, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InstrumentationConfigFactory, T1, T2, T3, T4, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InstrumentationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InstrumentationConfigFactory, T2, T3, T4, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InstrumentationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InstrumentationConfigFactory, T3, T4, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstrumentationConfigFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InstrumentationConfigFactory, T4, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstrumentationConfigFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InstrumentationConfigFactory, InnerInstrumentationConfigLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstrumentationConfigFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction).T2);
}
