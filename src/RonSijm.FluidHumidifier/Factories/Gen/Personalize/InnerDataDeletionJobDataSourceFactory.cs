// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerDataDeletionJobDataSourceFactory(Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.DataDeletionJobTypes.DataSource>
{

    protected override Humidifier.Personalize.DataDeletionJobTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.Personalize.DataDeletionJobTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.Personalize.DataDeletionJobTypes.DataSource();

        return dataSourceResult;
    }

} // End Of Class

public static class InnerDataDeletionJobDataSourceFactoryExtensions
{
}
