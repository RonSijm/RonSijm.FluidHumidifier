// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceVideoExtractionConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.VideoExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.VideoExtractionConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.VideoExtractionConfiguration Create()
    {
        var videoExtractionConfigurationResult = CreateVideoExtractionConfiguration();
        factoryAction?.Invoke(videoExtractionConfigurationResult);

        return videoExtractionConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.VideoExtractionConfiguration CreateVideoExtractionConfiguration()
    {
        var videoExtractionConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.VideoExtractionConfiguration();

        return videoExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceVideoExtractionConfigurationFactoryExtensions
{
}
