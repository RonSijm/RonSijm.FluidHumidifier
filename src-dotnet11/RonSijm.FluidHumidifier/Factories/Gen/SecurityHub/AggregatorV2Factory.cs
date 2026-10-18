// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class AggregatorV2Factory(string resourceName = null, Action<Humidifier.SecurityHub.AggregatorV2> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.AggregatorV2>(resourceName)
{

    protected override Humidifier.SecurityHub.AggregatorV2 Create()
    {
        var aggregatorV2Result = CreateAggregatorV2();
        factoryAction?.Invoke(aggregatorV2Result);

        return aggregatorV2Result;
    }

    private Humidifier.SecurityHub.AggregatorV2 CreateAggregatorV2()
    {
        var aggregatorV2Result = new Humidifier.SecurityHub.AggregatorV2
        {
            GivenName = InputResourceName,
        };

        return aggregatorV2Result;
    }

} // End Of Class

public static class AggregatorV2FactoryExtensions
{
}
