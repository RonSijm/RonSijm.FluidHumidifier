// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCatalogFederatedCatalogFactory(Action<Humidifier.Glue.CatalogTypes.FederatedCatalog> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CatalogTypes.FederatedCatalog>
{

    protected override Humidifier.Glue.CatalogTypes.FederatedCatalog Create()
    {
        var federatedCatalogResult = CreateFederatedCatalog();
        factoryAction?.Invoke(federatedCatalogResult);

        return federatedCatalogResult;
    }

    private Humidifier.Glue.CatalogTypes.FederatedCatalog CreateFederatedCatalog()
    {
        var federatedCatalogResult = new Humidifier.Glue.CatalogTypes.FederatedCatalog();

        return federatedCatalogResult;
    }

} // End Of Class

public static class InnerCatalogFederatedCatalogFactoryExtensions
{
}
