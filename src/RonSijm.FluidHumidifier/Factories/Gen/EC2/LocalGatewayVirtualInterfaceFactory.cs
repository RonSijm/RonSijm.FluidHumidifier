// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayVirtualInterfaceFactory(string resourceName = null, Action<Humidifier.EC2.LocalGatewayVirtualInterface> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGatewayVirtualInterface>(resourceName)
{

    protected override Humidifier.EC2.LocalGatewayVirtualInterface Create()
    {
        var localGatewayVirtualInterfaceResult = CreateLocalGatewayVirtualInterface();
        factoryAction?.Invoke(localGatewayVirtualInterfaceResult);

        return localGatewayVirtualInterfaceResult;
    }

    private Humidifier.EC2.LocalGatewayVirtualInterface CreateLocalGatewayVirtualInterface()
    {
        var localGatewayVirtualInterfaceResult = new Humidifier.EC2.LocalGatewayVirtualInterface
        {
            GivenName = InputResourceName,
        };

        return localGatewayVirtualInterfaceResult;
    }

} // End Of Class

public static class LocalGatewayVirtualInterfaceFactoryExtensions
{
}
