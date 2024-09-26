// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceColumnConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ColumnConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ColumnConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ColumnConfiguration Create()
    {
        var columnConfigurationResult = CreateColumnConfiguration();
        factoryAction?.Invoke(columnConfigurationResult);

        return columnConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ColumnConfiguration CreateColumnConfiguration()
    {
        var columnConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ColumnConfiguration();

        return columnConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceColumnConfigurationFactoryExtensions
{
}
