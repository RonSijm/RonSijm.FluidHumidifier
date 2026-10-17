// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseAudioExtractionConfigurationFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration>
{

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration Create()
    {
        var audioExtractionConfigurationResult = CreateAudioExtractionConfiguration();
        factoryAction?.Invoke(audioExtractionConfigurationResult);

        return audioExtractionConfigurationResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration CreateAudioExtractionConfiguration()
    {
        var audioExtractionConfigurationResult = new Humidifier.QuickSight.KnowledgeBaseTypes.AudioExtractionConfiguration();

        return audioExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseAudioExtractionConfigurationFactoryExtensions
{
}
