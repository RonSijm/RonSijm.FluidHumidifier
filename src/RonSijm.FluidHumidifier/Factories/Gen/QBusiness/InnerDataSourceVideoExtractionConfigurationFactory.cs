// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceVideoExtractionConfigurationFactory(Action<Humidifier.QBusiness.DataSourceTypes.VideoExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.VideoExtractionConfiguration>
{

    protected override Humidifier.QBusiness.DataSourceTypes.VideoExtractionConfiguration Create()
    {
        var videoExtractionConfigurationResult = CreateVideoExtractionConfiguration();
        factoryAction?.Invoke(videoExtractionConfigurationResult);

        return videoExtractionConfigurationResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.VideoExtractionConfiguration CreateVideoExtractionConfiguration()
    {
        var videoExtractionConfigurationResult = new Humidifier.QBusiness.DataSourceTypes.VideoExtractionConfiguration();

        return videoExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceVideoExtractionConfigurationFactoryExtensions
{
}
