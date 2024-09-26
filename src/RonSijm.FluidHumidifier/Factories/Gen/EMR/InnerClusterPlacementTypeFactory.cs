// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterPlacementTypeFactory(Action<Humidifier.EMR.ClusterTypes.PlacementType> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.PlacementType>
{

    protected override Humidifier.EMR.ClusterTypes.PlacementType Create()
    {
        var placementTypeResult = CreatePlacementType();
        factoryAction?.Invoke(placementTypeResult);

        return placementTypeResult;
    }

    private Humidifier.EMR.ClusterTypes.PlacementType CreatePlacementType()
    {
        var placementTypeResult = new Humidifier.EMR.ClusterTypes.PlacementType();

        return placementTypeResult;
    }

} // End Of Class

public static class InnerClusterPlacementTypeFactoryExtensions
{
}
