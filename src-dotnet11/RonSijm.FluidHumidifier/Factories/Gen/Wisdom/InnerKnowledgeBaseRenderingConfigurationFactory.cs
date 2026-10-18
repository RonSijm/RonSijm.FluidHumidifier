// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseRenderingConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration Create()
    {
        var renderingConfigurationResult = CreateRenderingConfiguration();
        factoryAction?.Invoke(renderingConfigurationResult);

        return renderingConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration CreateRenderingConfiguration()
    {
        var renderingConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration();

        return renderingConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseRenderingConfigurationFactoryExtensions
{
}
