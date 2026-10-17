// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceAudioExtractionConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.AudioExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.AudioExtractionConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.AudioExtractionConfiguration Create()
    {
        var audioExtractionConfigurationResult = CreateAudioExtractionConfiguration();
        factoryAction?.Invoke(audioExtractionConfigurationResult);

        return audioExtractionConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.AudioExtractionConfiguration CreateAudioExtractionConfiguration()
    {
        var audioExtractionConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.AudioExtractionConfiguration();

        return audioExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceAudioExtractionConfigurationFactoryExtensions
{
}
