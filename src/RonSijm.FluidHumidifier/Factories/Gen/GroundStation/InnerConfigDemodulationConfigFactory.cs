// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigDemodulationConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.DemodulationConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.DemodulationConfig>
{

    protected override Humidifier.GroundStation.ConfigTypes.DemodulationConfig Create()
    {
        var demodulationConfigResult = CreateDemodulationConfig();
        factoryAction?.Invoke(demodulationConfigResult);

        return demodulationConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.DemodulationConfig CreateDemodulationConfig()
    {
        var demodulationConfigResult = new Humidifier.GroundStation.ConfigTypes.DemodulationConfig();

        return demodulationConfigResult;
    }

} // End Of Class

public static class InnerConfigDemodulationConfigFactoryExtensions
{
}
