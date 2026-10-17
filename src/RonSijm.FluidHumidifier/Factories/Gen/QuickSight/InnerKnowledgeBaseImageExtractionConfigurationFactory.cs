// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseImageExtractionConfigurationFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration>
{

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration Create()
    {
        var imageExtractionConfigurationResult = CreateImageExtractionConfiguration();
        factoryAction?.Invoke(imageExtractionConfigurationResult);

        return imageExtractionConfigurationResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration CreateImageExtractionConfiguration()
    {
        var imageExtractionConfigurationResult = new Humidifier.QuickSight.KnowledgeBaseTypes.ImageExtractionConfiguration();

        return imageExtractionConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseImageExtractionConfigurationFactoryExtensions
{
}
