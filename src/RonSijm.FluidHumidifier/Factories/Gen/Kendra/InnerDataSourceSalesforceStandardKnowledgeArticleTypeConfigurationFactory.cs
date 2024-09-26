// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration Create()
    {
        var salesforceStandardKnowledgeArticleTypeConfigurationResult = CreateSalesforceStandardKnowledgeArticleTypeConfiguration();
        factoryAction?.Invoke(salesforceStandardKnowledgeArticleTypeConfigurationResult);

        return salesforceStandardKnowledgeArticleTypeConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration CreateSalesforceStandardKnowledgeArticleTypeConfiguration()
    {
        var salesforceStandardKnowledgeArticleTypeConfigurationResult = new Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration();

        return salesforceStandardKnowledgeArticleTypeConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactoryExtensions
{
}
