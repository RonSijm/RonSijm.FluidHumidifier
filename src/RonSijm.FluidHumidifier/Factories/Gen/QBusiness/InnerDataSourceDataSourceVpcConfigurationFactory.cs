// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceDataSourceVpcConfigurationFactory(Action<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration>
{

    protected override Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration Create()
    {
        var dataSourceVpcConfigurationResult = CreateDataSourceVpcConfiguration();
        factoryAction?.Invoke(dataSourceVpcConfigurationResult);

        return dataSourceVpcConfigurationResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration CreateDataSourceVpcConfiguration()
    {
        var dataSourceVpcConfigurationResult = new Humidifier.QBusiness.DataSourceTypes.DataSourceVpcConfiguration();

        return dataSourceVpcConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceDataSourceVpcConfigurationFactoryExtensions
{
}
