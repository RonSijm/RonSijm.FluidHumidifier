// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetLogConfigurationFactory(Action<Humidifier.GameLift.ContainerFleetTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.LogConfiguration>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.GameLift.ContainerFleetTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerContainerFleetLogConfigurationFactoryExtensions
{
}
