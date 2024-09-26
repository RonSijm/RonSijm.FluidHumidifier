// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterOnDemandProvisioningSpecificationFactory(Action<Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification>
{

    protected override Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification Create()
    {
        var onDemandProvisioningSpecificationResult = CreateOnDemandProvisioningSpecification();
        factoryAction?.Invoke(onDemandProvisioningSpecificationResult);

        return onDemandProvisioningSpecificationResult;
    }

    private Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification CreateOnDemandProvisioningSpecification()
    {
        var onDemandProvisioningSpecificationResult = new Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification();

        return onDemandProvisioningSpecificationResult;
    }

} // End Of Class

public static class InnerClusterOnDemandProvisioningSpecificationFactoryExtensions
{
}
