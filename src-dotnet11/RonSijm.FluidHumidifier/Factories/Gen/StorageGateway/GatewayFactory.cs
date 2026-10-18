// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StorageGateway;

public class GatewayFactory(string resourceName = null, Action<Humidifier.StorageGateway.Gateway> factoryAction = null) : ResourceFactory<Humidifier.StorageGateway.Gateway>(resourceName)
{

    protected override Humidifier.StorageGateway.Gateway Create()
    {
        var gatewayResult = CreateGateway();
        factoryAction?.Invoke(gatewayResult);

        return gatewayResult;
    }

    private Humidifier.StorageGateway.Gateway CreateGateway()
    {
        var gatewayResult = new Humidifier.StorageGateway.Gateway
        {
            GivenName = InputResourceName,
        };

        return gatewayResult;
    }

} // End Of Class

public static class GatewayFactoryExtensions
{
}
