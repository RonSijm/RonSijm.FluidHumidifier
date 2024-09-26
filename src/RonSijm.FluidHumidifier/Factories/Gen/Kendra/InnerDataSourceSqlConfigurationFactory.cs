// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceSqlConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.SqlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.SqlConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.SqlConfiguration Create()
    {
        var sqlConfigurationResult = CreateSqlConfiguration();
        factoryAction?.Invoke(sqlConfigurationResult);

        return sqlConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.SqlConfiguration CreateSqlConfiguration()
    {
        var sqlConfigurationResult = new Humidifier.Kendra.DataSourceTypes.SqlConfiguration();

        return sqlConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSqlConfigurationFactoryExtensions
{
}
