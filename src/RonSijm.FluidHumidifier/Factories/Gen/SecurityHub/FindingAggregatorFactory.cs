// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class FindingAggregatorFactory(string resourceName = null, Action<Humidifier.SecurityHub.FindingAggregator> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.FindingAggregator>(resourceName)
{

    protected override Humidifier.SecurityHub.FindingAggregator Create()
    {
        var findingAggregatorResult = CreateFindingAggregator();
        factoryAction?.Invoke(findingAggregatorResult);

        return findingAggregatorResult;
    }

    private Humidifier.SecurityHub.FindingAggregator CreateFindingAggregator()
    {
        var findingAggregatorResult = new Humidifier.SecurityHub.FindingAggregator
        {
            GivenName = InputResourceName,
        };

        return findingAggregatorResult;
    }

} // End Of Class

public static class FindingAggregatorFactoryExtensions
{
}
