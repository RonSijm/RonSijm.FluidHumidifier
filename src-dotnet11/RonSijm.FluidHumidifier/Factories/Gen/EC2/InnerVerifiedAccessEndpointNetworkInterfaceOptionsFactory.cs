// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessEndpointNetworkInterfaceOptionsFactory(Action<Humidifier.EC2.VerifiedAccessEndpointTypes.NetworkInterfaceOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessEndpointTypes.NetworkInterfaceOptions>
{

    protected override Humidifier.EC2.VerifiedAccessEndpointTypes.NetworkInterfaceOptions Create()
    {
        var networkInterfaceOptionsResult = CreateNetworkInterfaceOptions();
        factoryAction?.Invoke(networkInterfaceOptionsResult);

        return networkInterfaceOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessEndpointTypes.NetworkInterfaceOptions CreateNetworkInterfaceOptions()
    {
        var networkInterfaceOptionsResult = new Humidifier.EC2.VerifiedAccessEndpointTypes.NetworkInterfaceOptions();

        return networkInterfaceOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessEndpointNetworkInterfaceOptionsFactoryExtensions
{
}
