// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigSpotResizingSpecificationFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification>
{

    protected override Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification Create()
    {
        var spotResizingSpecificationResult = CreateSpotResizingSpecification();
        factoryAction?.Invoke(spotResizingSpecificationResult);

        return spotResizingSpecificationResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification CreateSpotResizingSpecification()
    {
        var spotResizingSpecificationResult = new Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification();

        return spotResizingSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceFleetConfigSpotResizingSpecificationFactoryExtensions
{
}
