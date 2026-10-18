// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class EgressOnlyInternetGatewayFactory(string resourceName = null, Action<Humidifier.EC2.EgressOnlyInternetGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.EgressOnlyInternetGateway>(resourceName)
{

    protected override Humidifier.EC2.EgressOnlyInternetGateway Create()
    {
        var egressOnlyInternetGatewayResult = CreateEgressOnlyInternetGateway();
        factoryAction?.Invoke(egressOnlyInternetGatewayResult);

        return egressOnlyInternetGatewayResult;
    }

    private Humidifier.EC2.EgressOnlyInternetGateway CreateEgressOnlyInternetGateway()
    {
        var egressOnlyInternetGatewayResult = new Humidifier.EC2.EgressOnlyInternetGateway
        {
            GivenName = InputResourceName,
        };

        return egressOnlyInternetGatewayResult;
    }

} // End Of Class

public static class EgressOnlyInternetGatewayFactoryExtensions
{
}
