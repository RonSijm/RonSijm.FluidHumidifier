// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerApplicationDataSourceFactory(Action<Humidifier.OpenSearchService.ApplicationTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.ApplicationTypes.DataSource>
{

    protected override Humidifier.OpenSearchService.ApplicationTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.OpenSearchService.ApplicationTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.OpenSearchService.ApplicationTypes.DataSource();

        return dataSourceResult;
    }

} // End Of Class

public static class InnerApplicationDataSourceFactoryExtensions
{
}
