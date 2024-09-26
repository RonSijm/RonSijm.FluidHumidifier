// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NatGatewayFactory(string resourceName = null, Action<Humidifier.EC2.NatGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.NatGateway>(resourceName)
{

    protected override Humidifier.EC2.NatGateway Create()
    {
        var natGatewayResult = CreateNatGateway();
        factoryAction?.Invoke(natGatewayResult);

        return natGatewayResult;
    }

    private Humidifier.EC2.NatGateway CreateNatGateway()
    {
        var natGatewayResult = new Humidifier.EC2.NatGateway
        {
            GivenName = InputResourceName,
        };

        return natGatewayResult;
    }

} // End Of Class

public static class NatGatewayFactoryExtensions
{
}
