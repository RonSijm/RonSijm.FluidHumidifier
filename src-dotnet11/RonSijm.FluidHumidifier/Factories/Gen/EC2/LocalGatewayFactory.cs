// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayFactory(string resourceName = null, Action<Humidifier.EC2.LocalGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGateway>(resourceName)
{

    protected override Humidifier.EC2.LocalGateway Create()
    {
        var localGatewayResult = CreateLocalGateway();
        factoryAction?.Invoke(localGatewayResult);

        return localGatewayResult;
    }

    private Humidifier.EC2.LocalGateway CreateLocalGateway()
    {
        var localGatewayResult = new Humidifier.EC2.LocalGateway
        {
            GivenName = InputResourceName,
        };

        return localGatewayResult;
    }

} // End Of Class

public static class LocalGatewayFactoryExtensions
{
}
