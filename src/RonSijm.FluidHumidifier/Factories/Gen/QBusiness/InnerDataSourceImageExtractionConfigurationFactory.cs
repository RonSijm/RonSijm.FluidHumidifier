// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceImageExtractionConfigurationFactory(Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration>
{

    protected override Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration Create()
    {
        var imageExtractionConfigurationResult = CreateImageExtractionConfiguration();
        factoryAction?.Invoke(imageExtractionConfigurationResult);

        return imageExtractionConfigurationResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration CreateImageExtractionConfiguration()
    {
        var imageExtractionConfigurationResult = new Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration();

        return imageExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceImageExtractionConfigurationFactoryExtensions
{
}
