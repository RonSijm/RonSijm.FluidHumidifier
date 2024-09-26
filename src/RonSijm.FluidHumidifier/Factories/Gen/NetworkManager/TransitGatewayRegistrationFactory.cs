// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class TransitGatewayRegistrationFactory(string resourceName = null, Action<Humidifier.NetworkManager.TransitGatewayRegistration> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.TransitGatewayRegistration>(resourceName)
{

    protected override Humidifier.NetworkManager.TransitGatewayRegistration Create()
    {
        var transitGatewayRegistrationResult = CreateTransitGatewayRegistration();
        factoryAction?.Invoke(transitGatewayRegistrationResult);

        return transitGatewayRegistrationResult;
    }

    private Humidifier.NetworkManager.TransitGatewayRegistration CreateTransitGatewayRegistration()
    {
        var transitGatewayRegistrationResult = new Humidifier.NetworkManager.TransitGatewayRegistration
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRegistrationResult;
    }

} // End Of Class

public static class TransitGatewayRegistrationFactoryExtensions
{
}
