// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class AggregationAuthorizationFactory(string resourceName = null, Action<Humidifier.Config.AggregationAuthorization> factoryAction = null) : ResourceFactory<Humidifier.Config.AggregationAuthorization>(resourceName)
{

    protected override Humidifier.Config.AggregationAuthorization Create()
    {
        var aggregationAuthorizationResult = CreateAggregationAuthorization();
        factoryAction?.Invoke(aggregationAuthorizationResult);

        return aggregationAuthorizationResult;
    }

    private Humidifier.Config.AggregationAuthorization CreateAggregationAuthorization()
    {
        var aggregationAuthorizationResult = new Humidifier.Config.AggregationAuthorization
        {
            GivenName = InputResourceName,
        };

        return aggregationAuthorizationResult;
    }

} // End Of Class

public static class AggregationAuthorizationFactoryExtensions
{
}
