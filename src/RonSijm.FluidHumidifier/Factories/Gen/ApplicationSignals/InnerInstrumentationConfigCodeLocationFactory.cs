// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerInstrumentationConfigCodeLocationFactory(Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation>
{

    protected override Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation Create()
    {
        var codeLocationResult = CreateCodeLocation();
        factoryAction?.Invoke(codeLocationResult);

        return codeLocationResult;
    }

    private Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation CreateCodeLocation()
    {
        var codeLocationResult = new Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation();

        return codeLocationResult;
    }

} // End Of Class

public static class InnerInstrumentationConfigCodeLocationFactoryExtensions
{
}
