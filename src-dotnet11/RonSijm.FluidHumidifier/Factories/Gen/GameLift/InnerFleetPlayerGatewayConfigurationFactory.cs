// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetPlayerGatewayConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.PlayerGatewayConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.PlayerGatewayConfiguration>
{

    protected override Humidifier.GameLift.FleetTypes.PlayerGatewayConfiguration Create()
    {
        var playerGatewayConfigurationResult = CreatePlayerGatewayConfiguration();
        factoryAction?.Invoke(playerGatewayConfigurationResult);

        return playerGatewayConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.PlayerGatewayConfiguration CreatePlayerGatewayConfiguration()
    {
        var playerGatewayConfigurationResult = new Humidifier.GameLift.FleetTypes.PlayerGatewayConfiguration();

        return playerGatewayConfigurationResult;
    }

} // End Of Class

public static class InnerFleetPlayerGatewayConfigurationFactoryExtensions
{
}
