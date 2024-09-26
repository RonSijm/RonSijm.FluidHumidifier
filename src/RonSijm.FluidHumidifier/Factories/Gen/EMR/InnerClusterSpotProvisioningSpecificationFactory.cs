// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterSpotProvisioningSpecificationFactory(Action<Humidifier.EMR.ClusterTypes.SpotProvisioningSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.SpotProvisioningSpecification>
{

    protected override Humidifier.EMR.ClusterTypes.SpotProvisioningSpecification Create()
    {
        var spotProvisioningSpecificationResult = CreateSpotProvisioningSpecification();
        factoryAction?.Invoke(spotProvisioningSpecificationResult);

        return spotProvisioningSpecificationResult;
    }

    private Humidifier.EMR.ClusterTypes.SpotProvisioningSpecification CreateSpotProvisioningSpecification()
    {
        var spotProvisioningSpecificationResult = new Humidifier.EMR.ClusterTypes.SpotProvisioningSpecification();

        return spotProvisioningSpecificationResult;
    }

} // End Of Class

public static class InnerClusterSpotProvisioningSpecificationFactoryExtensions
{
}
