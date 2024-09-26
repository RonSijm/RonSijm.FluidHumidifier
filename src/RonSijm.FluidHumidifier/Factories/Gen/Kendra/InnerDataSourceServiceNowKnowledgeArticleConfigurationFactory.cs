// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceServiceNowKnowledgeArticleConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.ServiceNowKnowledgeArticleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.ServiceNowKnowledgeArticleConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.ServiceNowKnowledgeArticleConfiguration Create()
    {
        var serviceNowKnowledgeArticleConfigurationResult = CreateServiceNowKnowledgeArticleConfiguration();
        factoryAction?.Invoke(serviceNowKnowledgeArticleConfigurationResult);

        return serviceNowKnowledgeArticleConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.ServiceNowKnowledgeArticleConfiguration CreateServiceNowKnowledgeArticleConfiguration()
    {
        var serviceNowKnowledgeArticleConfigurationResult = new Humidifier.Kendra.DataSourceTypes.ServiceNowKnowledgeArticleConfiguration();

        return serviceNowKnowledgeArticleConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceServiceNowKnowledgeArticleConfigurationFactoryExtensions
{
}
