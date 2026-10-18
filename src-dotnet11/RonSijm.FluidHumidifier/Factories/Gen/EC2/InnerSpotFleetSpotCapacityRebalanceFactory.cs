// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotFleetSpotCapacityRebalanceFactory(Action<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance>
{

    protected override Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance Create()
    {
        var spotCapacityRebalanceResult = CreateSpotCapacityRebalance();
        factoryAction?.Invoke(spotCapacityRebalanceResult);

        return spotCapacityRebalanceResult;
    }

    private Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance CreateSpotCapacityRebalance()
    {
        var spotCapacityRebalanceResult = new Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance();

        return spotCapacityRebalanceResult;
    }

} // End Of Class

public static class InnerSpotFleetSpotCapacityRebalanceFactoryExtensions
{
}
