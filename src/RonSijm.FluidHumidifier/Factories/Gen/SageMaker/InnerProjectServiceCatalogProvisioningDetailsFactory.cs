// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProjectServiceCatalogProvisioningDetailsFactory(Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails>
{

    protected override Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails Create()
    {
        var serviceCatalogProvisioningDetailsResult = CreateServiceCatalogProvisioningDetails();
        factoryAction?.Invoke(serviceCatalogProvisioningDetailsResult);

        return serviceCatalogProvisioningDetailsResult;
    }

    private Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails CreateServiceCatalogProvisioningDetails()
    {
        var serviceCatalogProvisioningDetailsResult = new Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails();

        return serviceCatalogProvisioningDetailsResult;
    }

} // End Of Class

public static class InnerProjectServiceCatalogProvisioningDetailsFactoryExtensions
{
}
