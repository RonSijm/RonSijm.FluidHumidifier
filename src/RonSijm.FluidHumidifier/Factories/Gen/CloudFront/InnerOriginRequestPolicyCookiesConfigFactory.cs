// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerOriginRequestPolicyCookiesConfigFactory(Action<Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig>
{

    protected override Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig Create()
    {
        var cookiesConfigResult = CreateCookiesConfig();
        factoryAction?.Invoke(cookiesConfigResult);

        return cookiesConfigResult;
    }

    private Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig CreateCookiesConfig()
    {
        var cookiesConfigResult = new Humidifier.CloudFront.OriginRequestPolicyTypes.CookiesConfig();

        return cookiesConfigResult;
    }

} // End Of Class

public static class InnerOriginRequestPolicyCookiesConfigFactoryExtensions
{
}
