// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseAppIntegrationsConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration Create()
    {
        var appIntegrationsConfigurationResult = CreateAppIntegrationsConfiguration();
        factoryAction?.Invoke(appIntegrationsConfigurationResult);

        return appIntegrationsConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration CreateAppIntegrationsConfiguration()
    {
        var appIntegrationsConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration();

        return appIntegrationsConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseAppIntegrationsConfigurationFactoryExtensions
{
}
