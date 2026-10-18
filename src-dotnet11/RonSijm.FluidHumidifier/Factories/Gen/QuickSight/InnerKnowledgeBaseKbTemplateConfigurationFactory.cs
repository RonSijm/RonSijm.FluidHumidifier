// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseKbTemplateConfigurationFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration>
{

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration Create()
    {
        var kbTemplateConfigurationResult = CreateKbTemplateConfiguration();
        factoryAction?.Invoke(kbTemplateConfigurationResult);

        return kbTemplateConfigurationResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration CreateKbTemplateConfiguration()
    {
        var kbTemplateConfigurationResult = new Humidifier.QuickSight.KnowledgeBaseTypes.KbTemplateConfiguration();

        return kbTemplateConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseKbTemplateConfigurationFactoryExtensions
{
}
