// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerResponseHeadersPolicyServerTimingHeadersConfigFactory(Action<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig>
{

    protected override Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig Create()
    {
        var serverTimingHeadersConfigResult = CreateServerTimingHeadersConfig();
        factoryAction?.Invoke(serverTimingHeadersConfigResult);

        return serverTimingHeadersConfigResult;
    }

    private Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig CreateServerTimingHeadersConfig()
    {
        var serverTimingHeadersConfigResult = new Humidifier.CloudFront.ResponseHeadersPolicyTypes.ServerTimingHeadersConfig();

        return serverTimingHeadersConfigResult;
    }

} // End Of Class

public static class InnerResponseHeadersPolicyServerTimingHeadersConfigFactoryExtensions
{
}
