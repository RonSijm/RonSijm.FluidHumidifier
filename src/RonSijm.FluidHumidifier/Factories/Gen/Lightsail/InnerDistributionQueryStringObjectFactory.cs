// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerDistributionQueryStringObjectFactory(Action<Humidifier.Lightsail.DistributionTypes.QueryStringObject> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.DistributionTypes.QueryStringObject>
{

    protected override Humidifier.Lightsail.DistributionTypes.QueryStringObject Create()
    {
        var queryStringObjectResult = CreateQueryStringObject();
        factoryAction?.Invoke(queryStringObjectResult);

        return queryStringObjectResult;
    }

    private Humidifier.Lightsail.DistributionTypes.QueryStringObject CreateQueryStringObject()
    {
        var queryStringObjectResult = new Humidifier.Lightsail.DistributionTypes.QueryStringObject();

        return queryStringObjectResult;
    }

} // End Of Class

public static class InnerDistributionQueryStringObjectFactoryExtensions
{
}
