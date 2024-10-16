// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceRedshiftClusterStorageFactory(Action<Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage>
{

    protected override Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage Create()
    {
        var redshiftClusterStorageResult = CreateRedshiftClusterStorage();
        factoryAction?.Invoke(redshiftClusterStorageResult);

        return redshiftClusterStorageResult;
    }

    private Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage CreateRedshiftClusterStorage()
    {
        var redshiftClusterStorageResult = new Humidifier.DataZone.DataSourceTypes.RedshiftClusterStorage();

        return redshiftClusterStorageResult;
    }

} // End Of Class

public static class InnerDataSourceRedshiftClusterStorageFactoryExtensions
{
}
