// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class SimulationApplicationVersionFactory(string resourceName = null, Action<Humidifier.RoboMaker.SimulationApplicationVersion> factoryAction = null) : ResourceFactory<Humidifier.RoboMaker.SimulationApplicationVersion>(resourceName)
{

    protected override Humidifier.RoboMaker.SimulationApplicationVersion Create()
    {
        var simulationApplicationVersionResult = CreateSimulationApplicationVersion();
        factoryAction?.Invoke(simulationApplicationVersionResult);

        return simulationApplicationVersionResult;
    }

    private Humidifier.RoboMaker.SimulationApplicationVersion CreateSimulationApplicationVersion()
    {
        var simulationApplicationVersionResult = new Humidifier.RoboMaker.SimulationApplicationVersion
        {
            GivenName = InputResourceName,
        };

        return simulationApplicationVersionResult;
    }

} // End Of Class

public static class SimulationApplicationVersionFactoryExtensions
{
}
