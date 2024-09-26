// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InstanceConnectEndpointFactory(string resourceName = null, Action<Humidifier.EC2.InstanceConnectEndpoint> factoryAction = null) : ResourceFactory<Humidifier.EC2.InstanceConnectEndpoint>(resourceName)
{

    protected override Humidifier.EC2.InstanceConnectEndpoint Create()
    {
        var instanceConnectEndpointResult = CreateInstanceConnectEndpoint();
        factoryAction?.Invoke(instanceConnectEndpointResult);

        return instanceConnectEndpointResult;
    }

    private Humidifier.EC2.InstanceConnectEndpoint CreateInstanceConnectEndpoint()
    {
        var instanceConnectEndpointResult = new Humidifier.EC2.InstanceConnectEndpoint
        {
            GivenName = InputResourceName,
        };

        return instanceConnectEndpointResult;
    }

} // End Of Class

public static class InstanceConnectEndpointFactoryExtensions
{
}
