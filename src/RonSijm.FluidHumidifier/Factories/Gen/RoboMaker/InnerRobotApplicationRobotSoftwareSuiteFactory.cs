// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class InnerRobotApplicationRobotSoftwareSuiteFactory(Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> factoryAction = null) : SubResourceFactory<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite>
{

    protected override Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite Create()
    {
        var robotSoftwareSuiteResult = CreateRobotSoftwareSuite();
        factoryAction?.Invoke(robotSoftwareSuiteResult);

        return robotSoftwareSuiteResult;
    }

    private Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite CreateRobotSoftwareSuite()
    {
        var robotSoftwareSuiteResult = new Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite();

        return robotSoftwareSuiteResult;
    }

} // End Of Class

public static class InnerRobotApplicationRobotSoftwareSuiteFactoryExtensions
{
}
