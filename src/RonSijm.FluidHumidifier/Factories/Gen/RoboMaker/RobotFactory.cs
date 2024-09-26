// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class RobotFactory(string resourceName = null, Action<Humidifier.RoboMaker.Robot> factoryAction = null) : ResourceFactory<Humidifier.RoboMaker.Robot>(resourceName)
{

    protected override Humidifier.RoboMaker.Robot Create()
    {
        var robotResult = CreateRobot();
        factoryAction?.Invoke(robotResult);

        return robotResult;
    }

    private Humidifier.RoboMaker.Robot CreateRobot()
    {
        var robotResult = new Humidifier.RoboMaker.Robot
        {
            GivenName = InputResourceName,
        };

        return robotResult;
    }

} // End Of Class

public static class RobotFactoryExtensions
{
}
