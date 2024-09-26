// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyCustomHeadersConfigFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig Create()
    {
        var customHeadersConfigResult = CreateCustomHeadersConfig();
        factoryAction?.Invoke(customHeadersConfigResult);

        return customHeadersConfigResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig CreateCustomHeadersConfig()
    {
        var customHeadersConfigResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.CustomHeadersConfig();

        return customHeadersConfigResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyCustomHeadersConfigFactoryExtensions
{
}
