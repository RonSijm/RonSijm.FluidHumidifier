// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class CustomerGatewayFactory(string resourceName = null, Action<Humidifier.EC2.CustomerGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.CustomerGateway>(resourceName)
{

    protected override Humidifier.EC2.CustomerGateway Create()
    {
        var customerGatewayResult = CreateCustomerGateway();
        factoryAction?.Invoke(customerGatewayResult);

        return customerGatewayResult;
    }

    private Humidifier.EC2.CustomerGateway CreateCustomerGateway()
    {
        var customerGatewayResult = new Humidifier.EC2.CustomerGateway
        {
            GivenName = InputResourceName,
        };

        return customerGatewayResult;
    }

} // End Of Class

public static class CustomerGatewayFactoryExtensions
{
}
