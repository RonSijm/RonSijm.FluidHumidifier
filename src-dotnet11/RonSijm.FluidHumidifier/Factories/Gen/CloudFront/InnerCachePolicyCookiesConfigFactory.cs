// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerCachePolicyCookiesConfigFactory(Action<Humidifier.CloudFront.CachePolicyTypes.CookiesConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.CachePolicyTypes.CookiesConfig>
{

    protected override Humidifier.CloudFront.CachePolicyTypes.CookiesConfig Create()
    {
        var cookiesConfigResult = CreateCookiesConfig();
        factoryAction?.Invoke(cookiesConfigResult);

        return cookiesConfigResult;
    }

    private Humidifier.CloudFront.CachePolicyTypes.CookiesConfig CreateCookiesConfig()
    {
        var cookiesConfigResult = new Humidifier.CloudFront.CachePolicyTypes.CookiesConfig();

        return cookiesConfigResult;
    }

} // End Of Class

public static class InnerCachePolicyCookiesConfigFactoryExtensions
{
}
