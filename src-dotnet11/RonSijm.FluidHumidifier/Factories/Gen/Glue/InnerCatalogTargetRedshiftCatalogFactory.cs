// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCatalogTargetRedshiftCatalogFactory(Action<Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog>
{

    protected override Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog Create()
    {
        var targetRedshiftCatalogResult = CreateTargetRedshiftCatalog();
        factoryAction?.Invoke(targetRedshiftCatalogResult);

        return targetRedshiftCatalogResult;
    }

    private Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog CreateTargetRedshiftCatalog()
    {
        var targetRedshiftCatalogResult = new Humidifier.Glue.CatalogTypes.TargetRedshiftCatalog();

        return targetRedshiftCatalogResult;
    }

} // End Of Class

public static class InnerCatalogTargetRedshiftCatalogFactoryExtensions
{
}
