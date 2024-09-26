// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class InnerSimulationApplicationSourceConfigFactory(Action<Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig>
{

    protected override Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig Create()
    {
        var sourceConfigResult = CreateSourceConfig();
        factoryAction?.Invoke(sourceConfigResult);

        return sourceConfigResult;
    }

    private Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig CreateSourceConfig()
    {
        var sourceConfigResult = new Humidifier.RoboMaker.SimulationApplicationTypes.SourceConfig();

        return sourceConfigResult;
    }

} // End Of Class

public static class InnerSimulationApplicationSourceConfigFactoryExtensions
{
}
