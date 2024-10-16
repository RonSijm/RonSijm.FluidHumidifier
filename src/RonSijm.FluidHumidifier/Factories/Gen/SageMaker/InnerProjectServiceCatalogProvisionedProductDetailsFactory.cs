// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProjectServiceCatalogProvisionedProductDetailsFactory(Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails>
{

    protected override Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails Create()
    {
        var serviceCatalogProvisionedProductDetailsResult = CreateServiceCatalogProvisionedProductDetails();
        factoryAction?.Invoke(serviceCatalogProvisionedProductDetailsResult);

        return serviceCatalogProvisionedProductDetailsResult;
    }

    private Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails CreateServiceCatalogProvisionedProductDetails()
    {
        var serviceCatalogProvisionedProductDetailsResult = new Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails();

        return serviceCatalogProvisionedProductDetailsResult;
    }

} // End Of Class

public static class InnerProjectServiceCatalogProvisionedProductDetailsFactoryExtensions
{
}
