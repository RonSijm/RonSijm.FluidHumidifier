// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerGameServerGroupTargetTrackingConfigurationFactory(Action<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration>
{

    protected override Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration Create()
    {
        var targetTrackingConfigurationResult = CreateTargetTrackingConfiguration();
        factoryAction?.Invoke(targetTrackingConfigurationResult);

        return targetTrackingConfigurationResult;
    }

    private Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration CreateTargetTrackingConfiguration()
    {
        var targetTrackingConfigurationResult = new Humidifier.GameLift.GameServerGroupTypes.TargetTrackingConfiguration();

        return targetTrackingConfigurationResult;
    }

} // End Of Class

public static class InnerGameServerGroupTargetTrackingConfigurationFactoryExtensions
{
}
