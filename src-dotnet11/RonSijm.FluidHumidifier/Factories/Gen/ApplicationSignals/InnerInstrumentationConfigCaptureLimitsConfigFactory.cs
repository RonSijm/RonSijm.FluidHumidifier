// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerInstrumentationConfigCaptureLimitsConfigFactory(Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig>
{

    protected override Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig Create()
    {
        var captureLimitsConfigResult = CreateCaptureLimitsConfig();
        factoryAction?.Invoke(captureLimitsConfigResult);

        return captureLimitsConfigResult;
    }

    private Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig CreateCaptureLimitsConfig()
    {
        var captureLimitsConfigResult = new Humidifier.ApplicationSignals.InstrumentationConfigTypes.CaptureLimitsConfig();

        return captureLimitsConfigResult;
    }

} // End Of Class

public static class InnerInstrumentationConfigCaptureLimitsConfigFactoryExtensions
{
}
