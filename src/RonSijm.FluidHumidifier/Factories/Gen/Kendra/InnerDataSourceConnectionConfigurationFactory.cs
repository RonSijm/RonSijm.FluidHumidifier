// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceConnectionConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ConnectionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ConnectionConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ConnectionConfiguration Create()
    {
        var connectionConfigurationResult = CreateConnectionConfiguration();
        factoryAction?.Invoke(connectionConfigurationResult);

        return connectionConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ConnectionConfiguration CreateConnectionConfiguration()
    {
        var connectionConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ConnectionConfiguration();

        return connectionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceConnectionConfigurationFactoryExtensions
{
}
