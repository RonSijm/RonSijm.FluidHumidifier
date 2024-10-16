// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceSharePointCrawlerConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration>
{

    internal InnerDataSourceCrawlFilterConfigurationFactory FilterConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration Create()
    {
        var sharePointCrawlerConfigurationResult = CreateSharePointCrawlerConfiguration();
        factoryAction?.Invoke(sharePointCrawlerConfigurationResult);

        return sharePointCrawlerConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration CreateSharePointCrawlerConfiguration()
    {
        var sharePointCrawlerConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration();

        return sharePointCrawlerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration result)
    {
        base.CreateChildren(result);

        result.FilterConfiguration ??= FilterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceSharePointCrawlerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration(this InnerDataSourceSharePointCrawlerConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.FilterConfigurationFactory = new InnerDataSourceCrawlFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1>(this CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, T2, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, T2, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceSharePointCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointCrawlerConfigurationFactory, T3, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceSharePointCrawlerConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSharePointCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceSharePointCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceSharePointCrawlerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceSharePointCrawlerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceSharePointCrawlerConfigurationFactory, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceSharePointCrawlerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceSharePointCrawlerConfigurationFactory, T4, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceSharePointCrawlerConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceSharePointCrawlerConfigurationFactory, InnerDataSourceCrawlFilterConfigurationFactory> WithFilterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceSharePointCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterConfiguration(combinedResult.T5, subFactoryAction));
}
