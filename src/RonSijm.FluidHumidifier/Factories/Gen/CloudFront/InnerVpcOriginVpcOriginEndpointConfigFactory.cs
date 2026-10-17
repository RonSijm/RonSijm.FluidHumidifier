// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerVpcOriginVpcOriginEndpointConfigFactory(Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig>
{

    protected override Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig Create()
    {
        var vpcOriginEndpointConfigResult = CreateVpcOriginEndpointConfig();
        factoryAction?.Invoke(vpcOriginEndpointConfigResult);

        return vpcOriginEndpointConfigResult;
    }

    private Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig CreateVpcOriginEndpointConfig()
    {
        var vpcOriginEndpointConfigResult = new Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig();

        return vpcOriginEndpointConfigResult;
    }

} // End Of Class

public static class InnerVpcOriginVpcOriginEndpointConfigFactoryExtensions
{
}
