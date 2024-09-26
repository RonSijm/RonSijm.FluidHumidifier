// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerDatasetDataSourceFactory(Action<Humidifier.Personalize.DatasetTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.DatasetTypes.DataSource>
{

    protected override Humidifier.Personalize.DatasetTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.Personalize.DatasetTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.Personalize.DatasetTypes.DataSource();

        return dataSourceResult;
    }

} // End Of Class

public static class InnerDatasetDataSourceFactoryExtensions
{
}
