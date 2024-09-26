// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class PlacementGroupFactory(string resourceName = null, Action<Humidifier.EC2.PlacementGroup> factoryAction = null) : ResourceFactory<Humidifier.EC2.PlacementGroup>(resourceName)
{

    protected override Humidifier.EC2.PlacementGroup Create()
    {
        var placementGroupResult = CreatePlacementGroup();
        factoryAction?.Invoke(placementGroupResult);

        return placementGroupResult;
    }

    private Humidifier.EC2.PlacementGroup CreatePlacementGroup()
    {
        var placementGroupResult = new Humidifier.EC2.PlacementGroup
        {
            GivenName = InputResourceName,
        };

        return placementGroupResult;
    }

} // End Of Class

public static class PlacementGroupFactoryExtensions
{
}
