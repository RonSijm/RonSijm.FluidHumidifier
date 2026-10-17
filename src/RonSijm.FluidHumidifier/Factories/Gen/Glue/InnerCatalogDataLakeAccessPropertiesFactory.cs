// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCatalogDataLakeAccessPropertiesFactory(Action<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CatalogTypes.DataLakeAccessProperties>
{

    protected override Humidifier.Glue.CatalogTypes.DataLakeAccessProperties Create()
    {
        var dataLakeAccessPropertiesResult = CreateDataLakeAccessProperties();
        factoryAction?.Invoke(dataLakeAccessPropertiesResult);

        return dataLakeAccessPropertiesResult;
    }

    private Humidifier.Glue.CatalogTypes.DataLakeAccessProperties CreateDataLakeAccessProperties()
    {
        var dataLakeAccessPropertiesResult = new Humidifier.Glue.CatalogTypes.DataLakeAccessProperties();

        return dataLakeAccessPropertiesResult;
    }

} // End Of Class

public static class InnerCatalogDataLakeAccessPropertiesFactoryExtensions
{
}
