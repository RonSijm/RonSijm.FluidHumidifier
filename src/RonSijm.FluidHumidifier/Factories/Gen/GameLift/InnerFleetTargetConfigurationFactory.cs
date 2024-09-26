// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetTargetConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.TargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.TargetConfiguration>
{

    protected override Humidifier.GameLift.FleetTypes.TargetConfiguration Create()
    {
        var targetConfigurationResult = CreateTargetConfiguration();
        factoryAction?.Invoke(targetConfigurationResult);

        return targetConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.TargetConfiguration CreateTargetConfiguration()
    {
        var targetConfigurationResult = new Humidifier.GameLift.FleetTypes.TargetConfiguration();

        return targetConfigurationResult;
    }

} // End Of Class

public static class InnerFleetTargetConfigurationFactoryExtensions
{
}
