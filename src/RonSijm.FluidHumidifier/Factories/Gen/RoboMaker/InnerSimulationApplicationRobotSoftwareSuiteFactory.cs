// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class InnerSimulationApplicationRobotSoftwareSuiteFactory(Action<Humidifier.RoboMaker.SimulationApplicationTypes.RobotSoftwareSuite> factoryAction = null) : SubResourceFactory<Humidifier.RoboMaker.SimulationApplicationTypes.RobotSoftwareSuite>
{

    protected override Humidifier.RoboMaker.SimulationApplicationTypes.RobotSoftwareSuite Create()
    {
        var robotSoftwareSuiteResult = CreateRobotSoftwareSuite();
        factoryAction?.Invoke(robotSoftwareSuiteResult);

        return robotSoftwareSuiteResult;
    }

    private Humidifier.RoboMaker.SimulationApplicationTypes.RobotSoftwareSuite CreateRobotSoftwareSuite()
    {
        var robotSoftwareSuiteResult = new Humidifier.RoboMaker.SimulationApplicationTypes.RobotSoftwareSuite();

        return robotSoftwareSuiteResult;
    }

} // End Of Class

public static class InnerSimulationApplicationRobotSoftwareSuiteFactoryExtensions
{
}
