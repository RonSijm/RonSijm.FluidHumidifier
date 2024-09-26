// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerCachePolicyHeadersConfigFactory(Action<Humidifier.CloudFront.CachePolicyTypes.HeadersConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.CachePolicyTypes.HeadersConfig>
{

    protected override Humidifier.CloudFront.CachePolicyTypes.HeadersConfig Create()
    {
        var headersConfigResult = CreateHeadersConfig();
        factoryAction?.Invoke(headersConfigResult);

        return headersConfigResult;
    }

    private Humidifier.CloudFront.CachePolicyTypes.HeadersConfig CreateHeadersConfig()
    {
        var headersConfigResult = new Humidifier.CloudFront.CachePolicyTypes.HeadersConfig();

        return headersConfigResult;
    }

} // End Of Class

public static class InnerCachePolicyHeadersConfigFactoryExtensions
{
}
