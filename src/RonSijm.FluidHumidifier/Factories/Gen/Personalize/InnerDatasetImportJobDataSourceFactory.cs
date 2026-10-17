// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerDatasetImportJobDataSourceFactory(Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.DatasetImportJobTypes.DataSource>
{

    protected override Humidifier.Personalize.DatasetImportJobTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.Personalize.DatasetImportJobTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.Personalize.DatasetImportJobTypes.DataSource();

        return dataSourceResult;
    }

} // End Of Class

public static class InnerDatasetImportJobDataSourceFactoryExtensions
{
}
