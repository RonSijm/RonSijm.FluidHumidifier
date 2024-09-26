// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceWebCrawlerConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration>
{

    internal InnerDataSourceWebCrawlerLimitsFactory CrawlerLimitsFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration Create()
    {
        var webCrawlerConfigurationResult = CreateWebCrawlerConfiguration();
        factoryAction?.Invoke(webCrawlerConfigurationResult);

        return webCrawlerConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration CreateWebCrawlerConfiguration()
    {
        var webCrawlerConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration();

        return webCrawlerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration result)
    {
        base.CreateChildren(result);

        result.CrawlerLimits ??= CrawlerLimitsFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceWebCrawlerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits(this InnerDataSourceWebCrawlerConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null)
    {
        parentFactory.CrawlerLimitsFactory = new InnerDataSourceWebCrawlerLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrawlerLimitsFactory);
    }

    public static CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1>(this CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1>(this CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, T2, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2>(this CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, T2, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2>(this CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceWebCrawlerConfigurationFactory, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, T2, T3, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, T2, T3, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceWebCrawlerConfigurationFactory, T3, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceWebCrawlerConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceWebCrawlerConfigurationFactory, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, T2, T3, T4, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceWebCrawlerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, T2, T3, T4, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceWebCrawlerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceWebCrawlerConfigurationFactory, T3, T4, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceWebCrawlerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceWebCrawlerConfigurationFactory, T4, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceWebCrawlerConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceWebCrawlerConfigurationFactory, InnerDataSourceWebCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T5, subFactoryAction));
}
