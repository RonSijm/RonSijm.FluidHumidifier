// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterSpotResizingSpecificationFactory(Action<Humidifier.EMR.ClusterTypes.SpotResizingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.SpotResizingSpecification>
{

    protected override Humidifier.EMR.ClusterTypes.SpotResizingSpecification Create()
    {
        var spotResizingSpecificationResult = CreateSpotResizingSpecification();
        factoryAction?.Invoke(spotResizingSpecificationResult);

        return spotResizingSpecificationResult;
    }

    private Humidifier.EMR.ClusterTypes.SpotResizingSpecification CreateSpotResizingSpecification()
    {
        var spotResizingSpecificationResult = new Humidifier.EMR.ClusterTypes.SpotResizingSpecification();

        return spotResizingSpecificationResult;
    }

} // End Of Class

public static class InnerClusterSpotResizingSpecificationFactoryExtensions
{
}
