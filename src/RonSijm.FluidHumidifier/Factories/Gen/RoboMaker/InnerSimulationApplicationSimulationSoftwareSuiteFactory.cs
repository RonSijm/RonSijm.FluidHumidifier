// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class InnerSimulationApplicationSimulationSoftwareSuiteFactory(Action<Humidifier.RoboMaker.SimulationApplicationTypes.SimulationSoftwareSuite> factoryAction = null) : SubResourceFactory<Humidifier.RoboMaker.SimulationApplicationTypes.SimulationSoftwareSuite>
{

    protected override Humidifier.RoboMaker.SimulationApplicationTypes.SimulationSoftwareSuite Create()
    {
        var simulationSoftwareSuiteResult = CreateSimulationSoftwareSuite();
        factoryAction?.Invoke(simulationSoftwareSuiteResult);

        return simulationSoftwareSuiteResult;
    }

    private Humidifier.RoboMaker.SimulationApplicationTypes.SimulationSoftwareSuite CreateSimulationSoftwareSuite()
    {
        var simulationSoftwareSuiteResult = new Humidifier.RoboMaker.SimulationApplicationTypes.SimulationSoftwareSuite();

        return simulationSoftwareSuiteResult;
    }

} // End Of Class

public static class InnerSimulationApplicationSimulationSoftwareSuiteFactoryExtensions
{
}
