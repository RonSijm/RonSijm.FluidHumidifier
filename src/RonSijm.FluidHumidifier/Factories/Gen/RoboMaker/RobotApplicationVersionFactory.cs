// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class RobotApplicationVersionFactory(string resourceName = null, Action<Humidifier.RoboMaker.RobotApplicationVersion> factoryAction = null) : ResourceFactory<Humidifier.RoboMaker.RobotApplicationVersion>(resourceName)
{

    protected override Humidifier.RoboMaker.RobotApplicationVersion Create()
    {
        var robotApplicationVersionResult = CreateRobotApplicationVersion();
        factoryAction?.Invoke(robotApplicationVersionResult);

        return robotApplicationVersionResult;
    }

    private Humidifier.RoboMaker.RobotApplicationVersion CreateRobotApplicationVersion()
    {
        var robotApplicationVersionResult = new Humidifier.RoboMaker.RobotApplicationVersion
        {
            GivenName = InputResourceName,
        };

        return robotApplicationVersionResult;
    }

} // End Of Class

public static class RobotApplicationVersionFactoryExtensions
{
}
