// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class RequesterGatewayFactory(string resourceName = null, Action<Humidifier.RTBFabric.RequesterGateway> factoryAction = null) : ResourceFactory<Humidifier.RTBFabric.RequesterGateway>(resourceName)
{

    protected override Humidifier.RTBFabric.RequesterGateway Create()
    {
        var requesterGatewayResult = CreateRequesterGateway();
        factoryAction?.Invoke(requesterGatewayResult);

        return requesterGatewayResult;
    }

    private Humidifier.RTBFabric.RequesterGateway CreateRequesterGateway()
    {
        var requesterGatewayResult = new Humidifier.RTBFabric.RequesterGateway
        {
            GivenName = InputResourceName,
        };

        return requesterGatewayResult;
    }

} // End Of Class

public static class RequesterGatewayFactoryExtensions
{
}
