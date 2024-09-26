// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceCrawlFilterConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration>
{

    internal InnerDataSourcePatternObjectFilterConfigurationFactory PatternObjectFilterFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration Create()
    {
        var crawlFilterConfigurationResult = CreateCrawlFilterConfiguration();
        factoryAction?.Invoke(crawlFilterConfigurationResult);

        return crawlFilterConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration CreateCrawlFilterConfiguration()
    {
        var crawlFilterConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration();

        return crawlFilterConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration result)
    {
        base.CreateChildren(result);

        result.PatternObjectFilter ??= PatternObjectFilterFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceCrawlFilterConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter(this InnerDataSourceCrawlFilterConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null)
    {
        parentFactory.PatternObjectFilterFactory = new InnerDataSourcePatternObjectFilterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PatternObjectFilterFactory);
    }

    public static CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1>(this CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1>(this CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, T2, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2>(this CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, T2, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2>(this CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceCrawlFilterConfigurationFactory, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceCrawlFilterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, T2, T3, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3>(this CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, T2, T3, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceCrawlFilterConfigurationFactory, T3, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceCrawlFilterConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, T2, T3, T4, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceCrawlFilterConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, T2, T3, T4, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceCrawlFilterConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceCrawlFilterConfigurationFactory, T3, T4, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceCrawlFilterConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory, T4, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceCrawlFilterConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory, InnerDataSourcePatternObjectFilterConfigurationFactory> WithPatternObjectFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceCrawlFilterConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPatternObjectFilter(combinedResult.T5, subFactoryAction));
}
