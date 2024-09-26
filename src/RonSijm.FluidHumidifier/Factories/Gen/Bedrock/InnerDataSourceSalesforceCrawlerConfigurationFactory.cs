// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceSalesforceCrawlerConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration>
{

    internal InnerDataSourceCrawlFilterConfigurationFactory FilterConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration Create()
    {
        var salesforceCrawlerConfigurationResult = CreateSalesforceCrawlerConfiguration();
        factoryAction?.Invoke(salesforceCrawlerConfigurationResult);

        return salesforceCrawlerConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration CreateSalesforceCrawlerConfiguration()
    {
        var salesforceCrawlerConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration();

        return salesforceCrawlerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration result)
    {
        base.CreateChildren(result);

        result.FilterConfiguration ??= FilterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceSalesforceCrawlerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration(this InnerDataSourceSalesforceCrawlerConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.FilterConfigurationFactory = new InnerDataSourceCrawlFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, T2, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, T2, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSalesforceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSalesforceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSalesforceCrawlerConfigurationFactory, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSalesforceCrawlerConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSalesforceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSalesforceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSalesforceCrawlerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSalesforceCrawlerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSalesforceCrawlerConfigurationFactory, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSalesforceCrawlerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSalesforceCrawlerConfigurationFactory, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSalesforceCrawlerConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSalesforceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSalesforceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T5, subFactoryAction));
}
