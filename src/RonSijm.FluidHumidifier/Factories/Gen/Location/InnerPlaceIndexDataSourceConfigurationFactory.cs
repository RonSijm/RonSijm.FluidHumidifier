// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerPlaceIndexDataSourceConfigurationFactory(Action<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration>
{

    protected override Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration Create()
    {
        var dataSourceConfigurationResult = CreateDataSourceConfiguration();
        factoryAction?.Invoke(dataSourceConfigurationResult);

        return dataSourceConfigurationResult;
    }

    private Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration CreateDataSourceConfiguration()
    {
        var dataSourceConfigurationResult = new Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration();

        return dataSourceConfigurationResult;
    }

} // End Of Class

public static class InnerPlaceIndexDataSourceConfigurationFactoryExtensions
{
}
