// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceRedshiftServerlessStorageFactory(Action<Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage>
{

    protected override Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage Create()
    {
        var redshiftServerlessStorageResult = CreateRedshiftServerlessStorage();
        factoryAction?.Invoke(redshiftServerlessStorageResult);

        return redshiftServerlessStorageResult;
    }

    private Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage CreateRedshiftServerlessStorage()
    {
        var redshiftServerlessStorageResult = new Humidifier.DataZone.DataSourceTypes.RedshiftServerlessStorage();

        return redshiftServerlessStorageResult;
    }

} // End Of Class

public static class InnerDataSourceRedshiftServerlessStorageFactoryExtensions
{
}
