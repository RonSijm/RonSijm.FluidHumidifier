// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetTargetConfigurationFactory(Action<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration Create()
    {
        var targetConfigurationResult = CreateTargetConfiguration();
        factoryAction?.Invoke(targetConfigurationResult);

        return targetConfigurationResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration CreateTargetConfiguration()
    {
        var targetConfigurationResult = new Humidifier.GameLift.ContainerFleetTypes.TargetConfiguration();

        return targetConfigurationResult;
    }

} // End Of Class

public static class InnerContainerFleetTargetConfigurationFactoryExtensions
{
}
