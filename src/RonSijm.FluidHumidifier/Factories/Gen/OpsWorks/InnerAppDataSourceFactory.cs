// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerAppDataSourceFactory(Action<Humidifier.OpsWorks.AppTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.AppTypes.DataSource>
{

    protected override Humidifier.OpsWorks.AppTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.OpsWorks.AppTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.OpsWorks.AppTypes.DataSource();

        return dataSourceResult;
    }

} // End Of Class

public static class InnerAppDataSourceFactoryExtensions
{
}
