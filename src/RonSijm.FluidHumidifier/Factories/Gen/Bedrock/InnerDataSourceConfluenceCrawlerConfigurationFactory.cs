// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceConfluenceCrawlerConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration>
{

    internal InnerDataSourceCrawlFilterConfigurationFactory FilterConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration Create()
    {
        var confluenceCrawlerConfigurationResult = CreateConfluenceCrawlerConfiguration();
        factoryAction?.Invoke(confluenceCrawlerConfigurationResult);

        return confluenceCrawlerConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration CreateConfluenceCrawlerConfiguration()
    {
        var confluenceCrawlerConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration();

        return confluenceCrawlerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration result)
    {
        base.CreateChildren(result);

        result.FilterConfiguration ??= FilterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceConfluenceCrawlerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration(this InnerDataSourceConfluenceCrawlerConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.FilterConfigurationFactory = new InnerDataSourceCrawlFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, T2, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, T2, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceConfluenceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceConfluenceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceConfluenceCrawlerConfigurationFactory, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceConfluenceCrawlerConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceConfluenceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceConfluenceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceConfluenceCrawlerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceConfluenceCrawlerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceConfluenceCrawlerConfigurationFactory, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceConfluenceCrawlerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceConfluenceCrawlerConfigurationFactory, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceConfluenceCrawlerConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceConfluenceCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceConfluenceCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T5, subFactoryAction));
}
