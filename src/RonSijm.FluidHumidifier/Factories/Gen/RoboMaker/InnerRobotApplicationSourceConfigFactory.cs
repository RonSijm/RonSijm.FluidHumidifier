// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class InnerRobotApplicationSourceConfigFactory(Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig>
{

    protected override Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig Create()
    {
        var sourceConfigResult = CreateSourceConfig();
        factoryAction?.Invoke(sourceConfigResult);

        return sourceConfigResult;
    }

    private Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig CreateSourceConfig()
    {
        var sourceConfigResult = new Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig();

        return sourceConfigResult;
    }

} // End Of Class

public static class InnerRobotApplicationSourceConfigFactoryExtensions
{
}
