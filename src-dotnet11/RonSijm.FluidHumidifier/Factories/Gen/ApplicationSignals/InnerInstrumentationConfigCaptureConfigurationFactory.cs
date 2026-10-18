// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerInstrumentationConfigCaptureConfigurationFactory(Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration>
{

    internal InnerInstrumentationConfigCodeCaptureConfigurationFactory CodeCaptureFactory { get; set; }

    protected override Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration Create()
    {
        var captureConfigurationResult = CreateCaptureConfiguration();
        factoryAction?.Invoke(captureConfigurationResult);

        return captureConfigurationResult;
    }

    private Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration CreateCaptureConfiguration()
    {
        var captureConfigurationResult = new Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration();

        return captureConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureConfiguration result)
    {
        base.CreateChildren(result);

        result.CodeCapture ??= CodeCaptureFactory?.Build();
    }

} // End Of Class

public static class InnerInstrumentationConfigCaptureConfigurationFactoryExtensions
{
    public static CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture(this InnerInstrumentationConfigCaptureConfigurationFactory parentFactory, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null)
    {
        parentFactory.CodeCaptureFactory = new InnerInstrumentationConfigCodeCaptureConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeCaptureFactory);
    }

    public static CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1>(this CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeCapture(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1>(this CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeCapture(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2>(this CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, T2, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2>(this CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2>(this CombinedResult<T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, T2, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3>(this CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, T2, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3>(this CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory, T3, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstrumentationConfigCaptureConfigurationFactory, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstrumentationConfigCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, T2, T3, T4, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3, T4>(this CombinedResult<InnerInstrumentationConfigCaptureConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, T2, T3, T4, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstrumentationConfigCaptureConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory, T3, T4, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstrumentationConfigCaptureConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstrumentationConfigCaptureConfigurationFactory, T4, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstrumentationConfigCaptureConfigurationFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInstrumentationConfigCaptureConfigurationFactory, InnerInstrumentationConfigCodeCaptureConfigurationFactory> WithCodeCapture<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstrumentationConfigCaptureConfigurationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeCaptureConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeCapture(combinedResult.T5, subFactoryAction).T2);
}
