// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerResponderGatewayEksEndpointsConfigurationFactory(Action<Humidifier.RTBFabric.ResponderGatewayTypes.EksEndpointsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.ResponderGatewayTypes.EksEndpointsConfiguration>
{

    protected override Humidifier.RTBFabric.ResponderGatewayTypes.EksEndpointsConfiguration Create()
    {
        var eksEndpointsConfigurationResult = CreateEksEndpointsConfiguration();
        factoryAction?.Invoke(eksEndpointsConfigurationResult);

        return eksEndpointsConfigurationResult;
    }

    private Humidifier.RTBFabric.ResponderGatewayTypes.EksEndpointsConfiguration CreateEksEndpointsConfiguration()
    {
        var eksEndpointsConfigurationResult = new Humidifier.RTBFabric.ResponderGatewayTypes.EksEndpointsConfiguration();

        return eksEndpointsConfigurationResult;
    }

} // End Of Class

public static class InnerResponderGatewayEksEndpointsConfigurationFactoryExtensions
{
}
