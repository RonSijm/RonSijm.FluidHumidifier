// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InternetGatewayFactory(string resourceName = null, Action<Humidifier.EC2.InternetGateway> factoryAction = null) : ResourceFactory<Humidifier.EC2.InternetGateway>(resourceName)
{

    protected override Humidifier.EC2.InternetGateway Create()
    {
        var internetGatewayResult = CreateInternetGateway();
        factoryAction?.Invoke(internetGatewayResult);

        return internetGatewayResult;
    }

    private Humidifier.EC2.InternetGateway CreateInternetGateway()
    {
        var internetGatewayResult = new Humidifier.EC2.InternetGateway
        {
            GivenName = InputResourceName,
        };

        return internetGatewayResult;
    }

} // End Of Class

public static class InternetGatewayFactoryExtensions
{
}
