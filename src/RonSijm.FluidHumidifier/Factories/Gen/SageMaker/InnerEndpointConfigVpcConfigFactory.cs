// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigVpcConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigVpcConfigFactoryExtensions
{
}
