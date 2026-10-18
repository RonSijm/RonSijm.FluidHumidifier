// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceSqlServerParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.SqlServerParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.SqlServerParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.SqlServerParameters Create()
    {
        var sqlServerParametersResult = CreateSqlServerParameters();
        factoryAction?.Invoke(sqlServerParametersResult);

        return sqlServerParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.SqlServerParameters CreateSqlServerParameters()
    {
        var sqlServerParametersResult = new Humidifier.QuickSight.DataSourceTypes.SqlServerParameters();

        return sqlServerParametersResult;
    }

} // End Of Class

public static class InnerDataSourceSqlServerParametersFactoryExtensions
{
}
