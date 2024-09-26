// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerOriginRequestPolicyHeadersConfigFactory(Action<Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig>
{

    protected override Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig Create()
    {
        var headersConfigResult = CreateHeadersConfig();
        factoryAction?.Invoke(headersConfigResult);

        return headersConfigResult;
    }

    private Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig CreateHeadersConfig()
    {
        var headersConfigResult = new Humidifier.CloudFront.OriginRequestPolicyTypes.HeadersConfig();

        return headersConfigResult;
    }

} // End Of Class

public static class InnerOriginRequestPolicyHeadersConfigFactoryExtensions
{
}
