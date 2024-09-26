// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class CarrierGatewayFactory(string resourceName = null, Action<Humidifier.EC2.CarrierGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.CarrierGateway>(resourceName)
{

    protected override Humidifier.EC2.CarrierGateway Create()
    {
        var carrierGatewayResult = CreateCarrierGateway();
        factoryAction?.Invoke(carrierGatewayResult);

        return carrierGatewayResult;
    }

    private Humidifier.EC2.CarrierGateway CreateCarrierGateway()
    {
        var carrierGatewayResult = new Humidifier.EC2.CarrierGateway
        {
            GivenName = InputResourceName,
        };

        return carrierGatewayResult;
    }

} // End Of Class

public static class CarrierGatewayFactoryExtensions
{
}
