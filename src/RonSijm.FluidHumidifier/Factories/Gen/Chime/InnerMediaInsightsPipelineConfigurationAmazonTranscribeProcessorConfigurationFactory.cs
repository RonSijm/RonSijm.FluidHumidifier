// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineConfigurationAmazonTranscribeProcessorConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeProcessorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeProcessorConfiguration>
{

    protected override Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeProcessorConfiguration Create()
    {
        var amazonTranscribeProcessorConfigurationResult = CreateAmazonTranscribeProcessorConfiguration();
        factoryAction?.Invoke(amazonTranscribeProcessorConfigurationResult);

        return amazonTranscribeProcessorConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeProcessorConfiguration CreateAmazonTranscribeProcessorConfiguration()
    {
        var amazonTranscribeProcessorConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeProcessorConfiguration();

        return amazonTranscribeProcessorConfigurationResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineConfigurationAmazonTranscribeProcessorConfigurationFactoryExtensions
{
}
