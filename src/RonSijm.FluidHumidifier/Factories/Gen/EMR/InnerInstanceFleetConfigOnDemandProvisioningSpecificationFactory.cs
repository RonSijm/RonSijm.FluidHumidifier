// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification>
{

    protected override Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification Create()
    {
        var onDemandProvisioningSpecificationResult = CreateOnDemandProvisioningSpecification();
        factoryAction?.Invoke(onDemandProvisioningSpecificationResult);

        return onDemandProvisioningSpecificationResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification CreateOnDemandProvisioningSpecification()
    {
        var onDemandProvisioningSpecificationResult = new Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification();

        return onDemandProvisioningSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactoryExtensions
{
}
