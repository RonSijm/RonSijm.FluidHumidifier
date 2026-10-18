// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionCookiesFactory(Action<Humidifier.CloudFront.DistributionTypes.Cookies> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.Cookies>
{

    protected override Humidifier.CloudFront.DistributionTypes.Cookies Create()
    {
        var cookiesResult = CreateCookies();
        factoryAction?.Invoke(cookiesResult);

        return cookiesResult;
    }

    private Humidifier.CloudFront.DistributionTypes.Cookies CreateCookies()
    {
        var cookiesResult = new Humidifier.CloudFront.DistributionTypes.Cookies();

        return cookiesResult;
    }

} // End Of Class

public static class InnerDistributionCookiesFactoryExtensions
{
}
