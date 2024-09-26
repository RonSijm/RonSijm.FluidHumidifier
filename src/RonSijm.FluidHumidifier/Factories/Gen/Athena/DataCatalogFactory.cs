// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class DataCatalogFactory(string resourceName = null, Action<Humidifier.Athena.DataCatalog> factoryAction = null) : ResourceFactory<Humidifier.Athena.DataCatalog>(resourceName)
{

    protected override Humidifier.Athena.DataCatalog Create()
    {
        var dataCatalogResult = CreateDataCatalog();
        factoryAction?.Invoke(dataCatalogResult);

        return dataCatalogResult;
    }

    private Humidifier.Athena.DataCatalog CreateDataCatalog()
    {
        var dataCatalogResult = new Humidifier.Athena.DataCatalog
        {
            GivenName = InputResourceName,
        };

        return dataCatalogResult;
    }

} // End Of Class

public static class DataCatalogFactoryExtensions
{
}
