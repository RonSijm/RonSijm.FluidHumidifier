// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseVideoExtractionConfigurationFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration>
{

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration Create()
    {
        var videoExtractionConfigurationResult = CreateVideoExtractionConfiguration();
        factoryAction?.Invoke(videoExtractionConfigurationResult);

        return videoExtractionConfigurationResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration CreateVideoExtractionConfiguration()
    {
        var videoExtractionConfigurationResult = new Humidifier.QuickSight.KnowledgeBaseTypes.VideoExtractionConfiguration();

        return videoExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseVideoExtractionConfigurationFactoryExtensions
{
}
