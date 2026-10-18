// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotInstancesRequestSpotPlacementFactory(Action<Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement>
{

    protected override Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement Create()
    {
        var spotPlacementResult = CreateSpotPlacement();
        factoryAction?.Invoke(spotPlacementResult);

        return spotPlacementResult;
    }

    private Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement CreateSpotPlacement()
    {
        var spotPlacementResult = new Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement();

        return spotPlacementResult;
    }

} // End Of Class

public static class InnerSpotInstancesRequestSpotPlacementFactoryExtensions
{
}
