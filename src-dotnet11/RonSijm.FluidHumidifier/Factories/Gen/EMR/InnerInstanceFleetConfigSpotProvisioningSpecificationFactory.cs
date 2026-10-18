// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigSpotProvisioningSpecificationFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification>
{

    protected override Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification Create()
    {
        var spotProvisioningSpecificationResult = CreateSpotProvisioningSpecification();
        factoryAction?.Invoke(spotProvisioningSpecificationResult);

        return spotProvisioningSpecificationResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification CreateSpotProvisioningSpecification()
    {
        var spotProvisioningSpecificationResult = new Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification();

        return spotProvisioningSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceFleetConfigSpotProvisioningSpecificationFactoryExtensions
{
}
