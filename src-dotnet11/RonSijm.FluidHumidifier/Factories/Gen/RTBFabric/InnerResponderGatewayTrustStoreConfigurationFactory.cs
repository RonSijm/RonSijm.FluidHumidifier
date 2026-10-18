// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerResponderGatewayTrustStoreConfigurationFactory(Action<Humidifier.RTBFabric.ResponderGatewayTypes.TrustStoreConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.ResponderGatewayTypes.TrustStoreConfiguration>
{

    protected override Humidifier.RTBFabric.ResponderGatewayTypes.TrustStoreConfiguration Create()
    {
        var trustStoreConfigurationResult = CreateTrustStoreConfiguration();
        factoryAction?.Invoke(trustStoreConfigurationResult);

        return trustStoreConfigurationResult;
    }

    private Humidifier.RTBFabric.ResponderGatewayTypes.TrustStoreConfiguration CreateTrustStoreConfiguration()
    {
        var trustStoreConfigurationResult = new Humidifier.RTBFabric.ResponderGatewayTypes.TrustStoreConfiguration();

        return trustStoreConfigurationResult;
    }

} // End Of Class

public static class InnerResponderGatewayTrustStoreConfigurationFactoryExtensions
{
}
