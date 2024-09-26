// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration>
{

    internal InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory StandardKnowledgeArticleTypeConfigurationFactory { get; set; }

    protected override Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration Create()
    {
        var salesforceKnowledgeArticleConfigurationResult = CreateSalesforceKnowledgeArticleConfiguration();
        factoryAction?.Invoke(salesforceKnowledgeArticleConfigurationResult);

        return salesforceKnowledgeArticleConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration CreateSalesforceKnowledgeArticleConfiguration()
    {
        var salesforceKnowledgeArticleConfigurationResult = new Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration();

        return salesforceKnowledgeArticleConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSourceTypes.SalesforceKnowledgeArticleConfiguration result)
    {
        base.CreateChildren(result);

        result.StandardKnowledgeArticleTypeConfiguration ??= StandardKnowledgeArticleTypeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceSalesforceKnowledgeArticleConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration(this InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null)
    {
        parentFactory.StandardKnowledgeArticleTypeConfigurationFactory = new InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StandardKnowledgeArticleTypeConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1>(this CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1>(this CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, T2, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2>(this CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T2, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, T2, T3, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T2, T3, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T3, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, T2, T3, T4, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T2, T3, T4, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T3, T4, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T4, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory, InnerDataSourceSalesforceStandardKnowledgeArticleTypeConfigurationFactory> WithStandardKnowledgeArticleTypeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSalesforceKnowledgeArticleConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.SalesforceStandardKnowledgeArticleTypeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStandardKnowledgeArticleTypeConfiguration(combinedResult.T5, subFactoryAction));
}
