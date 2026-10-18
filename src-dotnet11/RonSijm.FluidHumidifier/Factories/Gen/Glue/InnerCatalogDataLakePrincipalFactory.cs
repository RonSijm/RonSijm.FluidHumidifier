// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCatalogDataLakePrincipalFactory(Action<Humidifier.Glue.CatalogTypes.DataLakePrincipal> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CatalogTypes.DataLakePrincipal>
{

    protected override Humidifier.Glue.CatalogTypes.DataLakePrincipal Create()
    {
        var dataLakePrincipalResult = CreateDataLakePrincipal();
        factoryAction?.Invoke(dataLakePrincipalResult);

        return dataLakePrincipalResult;
    }

    private Humidifier.Glue.CatalogTypes.DataLakePrincipal CreateDataLakePrincipal()
    {
        var dataLakePrincipalResult = new Humidifier.Glue.CatalogTypes.DataLakePrincipal();

        return dataLakePrincipalResult;
    }

} // End Of Class

public static class InnerCatalogDataLakePrincipalFactoryExtensions
{
}
