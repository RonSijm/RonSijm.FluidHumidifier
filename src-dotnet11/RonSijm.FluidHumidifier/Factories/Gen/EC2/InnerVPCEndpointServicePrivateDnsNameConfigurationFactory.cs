// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPCEndpointServicePrivateDnsNameConfigurationFactory(Action<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration>
{

    protected override Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration Create()
    {
        var privateDnsNameConfigurationResult = CreatePrivateDnsNameConfiguration();
        factoryAction?.Invoke(privateDnsNameConfigurationResult);

        return privateDnsNameConfigurationResult;
    }

    private Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration CreatePrivateDnsNameConfiguration()
    {
        var privateDnsNameConfigurationResult = new Humidifier.EC2.VPCEndpointServiceTypes.PrivateDnsNameConfiguration();

        return privateDnsNameConfigurationResult;
    }

} // End Of Class

public static class InnerVPCEndpointServicePrivateDnsNameConfigurationFactoryExtensions
{
}
