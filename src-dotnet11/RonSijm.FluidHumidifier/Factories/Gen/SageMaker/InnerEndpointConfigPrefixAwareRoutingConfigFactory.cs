// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigPrefixAwareRoutingConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig Create()
    {
        var prefixAwareRoutingConfigResult = CreatePrefixAwareRoutingConfig();
        factoryAction?.Invoke(prefixAwareRoutingConfigResult);

        return prefixAwareRoutingConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig CreatePrefixAwareRoutingConfig()
    {
        var prefixAwareRoutingConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig();

        return prefixAwareRoutingConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigPrefixAwareRoutingConfigFactoryExtensions
{
}
