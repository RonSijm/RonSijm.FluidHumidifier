// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceDataSourceVpcConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration Create()
    {
        var dataSourceVpcConfigurationResult = CreateDataSourceVpcConfiguration();
        factoryAction?.Invoke(dataSourceVpcConfigurationResult);

        return dataSourceVpcConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration CreateDataSourceVpcConfiguration()
    {
        var dataSourceVpcConfigurationResult = new Humidifier.Kendra.DataSourceTypes.DataSourceVpcConfiguration();

        return dataSourceVpcConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceDataSourceVpcConfigurationFactoryExtensions
{
}
