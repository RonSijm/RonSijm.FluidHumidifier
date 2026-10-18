// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class TrafficDistributionGroupFactory(string resourceName = null, Action<Humidifier.Connect.TrafficDistributionGroup> factoryAction = null) : ResourceFactory<Humidifier.Connect.TrafficDistributionGroup>(resourceName)
{

    protected override Humidifier.Connect.TrafficDistributionGroup Create()
    {
        var trafficDistributionGroupResult = CreateTrafficDistributionGroup();
        factoryAction?.Invoke(trafficDistributionGroupResult);

        return trafficDistributionGroupResult;
    }

    private Humidifier.Connect.TrafficDistributionGroup CreateTrafficDistributionGroup()
    {
        var trafficDistributionGroupResult = new Humidifier.Connect.TrafficDistributionGroup
        {
            GivenName = InputResourceName,
        };

        return trafficDistributionGroupResult;
    }

} // End Of Class

public static class TrafficDistributionGroupFactoryExtensions
{
}
