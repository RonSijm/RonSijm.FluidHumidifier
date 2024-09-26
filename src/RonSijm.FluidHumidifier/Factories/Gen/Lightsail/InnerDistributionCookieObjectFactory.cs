// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDistributionCookieObjectFactory(Action<Humidifier.Lightsail.DistributionTypes.CookieObject> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DistributionTypes.CookieObject>
{

    protected override Humidifier.Lightsail.DistributionTypes.CookieObject Create()
    {
        var cookieObjectResult = CreateCookieObject();
        factoryAction?.Invoke(cookieObjectResult);

        return cookieObjectResult;
    }

    private Humidifier.Lightsail.DistributionTypes.CookieObject CreateCookieObject()
    {
        var cookieObjectResult = new Humidifier.Lightsail.DistributionTypes.CookieObject();

        return cookieObjectResult;
    }

} // End Of Class

public static class InnerDistributionCookieObjectFactoryExtensions
{
}
