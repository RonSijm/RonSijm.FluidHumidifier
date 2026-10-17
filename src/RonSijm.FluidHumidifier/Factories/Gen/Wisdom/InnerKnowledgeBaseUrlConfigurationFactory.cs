// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseUrlConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration Create()
    {
        var urlConfigurationResult = CreateUrlConfiguration();
        factoryAction?.Invoke(urlConfigurationResult);

        return urlConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration CreateUrlConfiguration()
    {
        var urlConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration();

        return urlConfigurationResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseUrlConfigurationFactoryExtensions
{
}
