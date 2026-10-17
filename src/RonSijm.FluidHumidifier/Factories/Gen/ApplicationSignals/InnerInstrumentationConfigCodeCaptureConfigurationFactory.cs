// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerInstrumentationConfigCodeCaptureConfigurationFactory(Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration>
{

    internal InnerInstrumentationConfigCaptureLimitsConfigFactory CaptureLimitsFactory { get; set; }

    protected override Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration Create()
    {
        var codeCaptureConfigurationResult = CreateCodeCaptureConfiguration();
        factoryAction?.Invoke(codeCaptureConfigurationResult);

        return codeCaptureConfigurationResult;
    }

    private Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration CreateCodeCaptureConfiguration()
    {
        var codeCaptureConfigurationResult = new Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration();

        return codeCaptureConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration result)
    {
        base.CreateChildren(result);

        result.CaptureLimits ??= CaptureLimitsFactory?.Build();
    }

} // End Of Class

public static class InnerInstrumentationConfigCodeCaptureConfigurationFactoryExtensions
{
    public static CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits(this InnerInstrumentationConfigCodeCaptureConfigurationFactory parentFactory, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null)
    {
        parentFactory.CaptureLimitsFactory = new InnerInstrumentationConfigCaptureLimitsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CaptureLimitsFactory);
    }

    public static CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1>(this CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptureLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1>(this CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptureLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, T2, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2>(this CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T2, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2>(this CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2>(this CombinedResult<T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, T2, T3, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3>(this CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T2, T3, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3>(this CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T3, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, T2, T3, T4, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3, T4>(this CombinedResult<InnerInstrumentationConfigCodeCaptureConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T2, T3, T4, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T3, T4, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T4, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInstrumentationConfigCodeCaptureConfigurationFactory, InnerInstrumentationConfigCaptureLimitsConfigFactory> WithCaptureLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstrumentationConfigCodeCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptureLimits(combinedResult.T5, subFactoryAction).T2);
}
