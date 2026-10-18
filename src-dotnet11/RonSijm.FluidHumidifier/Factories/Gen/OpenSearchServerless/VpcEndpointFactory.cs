// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class VpcEndpointFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.VpcEndpoint> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.VpcEndpoint>(resourceName)
{

    protected override Humidifier.OpenSearchServerless.VpcEndpoint Create()
    {
        var vpcEndpointResult = CreateVpcEndpoint();
        factoryAction?.Invoke(vpcEndpointResult);

        return vpcEndpointResult;
    }

    private Humidifier.OpenSearchServerless.VpcEndpoint CreateVpcEndpoint()
    {
        var vpcEndpointResult = new Humidifier.OpenSearchServerless.VpcEndpoint
        {
            GivenName = InputResourceName,
        };

        return vpcEndpointResult;
    }

} // End Of Class

public static class VpcEndpointFactoryExtensions
{
}
