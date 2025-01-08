// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseWebCrawlerConfigurationFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration>
{

    internal InnerKnowledgeBaseUrlConfigurationFactory UrlConfigurationFactory { get; set; }

    internal InnerKnowledgeBaseCrawlerLimitsFactory CrawlerLimitsFactory { get; set; }

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration Create()
    {
        var webCrawlerConfigurationResult = CreateWebCrawlerConfiguration();
        factoryAction?.Invoke(webCrawlerConfigurationResult);

        return webCrawlerConfigurationResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration CreateWebCrawlerConfiguration()
    {
        var webCrawlerConfigurationResult = new Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration();

        return webCrawlerConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration result)
    {
        base.CreateChildren(result);

        result.UrlConfiguration ??= UrlConfigurationFactory?.Build();
        result.CrawlerLimits ??= CrawlerLimitsFactory?.Build();
    }

} // End Of Class

public static class InnerKnowledgeBaseWebCrawlerConfigurationFactoryExtensions
{
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration(this InnerKnowledgeBaseWebCrawlerConfigurationFactory parentFactory, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null)
    {
        parentFactory.UrlConfigurationFactory = new InnerKnowledgeBaseUrlConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UrlConfigurationFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits(this InnerKnowledgeBaseWebCrawlerConfigurationFactory parentFactory, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null)
    {
        parentFactory.CrawlerLimitsFactory = new InnerKnowledgeBaseCrawlerLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrawlerLimitsFactory);
    }

    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3, T4, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T4, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2>(this CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3, T4, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<InnerKnowledgeBaseWebCrawlerConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3, T4, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3, T4, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T4, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerKnowledgeBaseWebCrawlerConfigurationFactory, T4> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory, InnerKnowledgeBaseCrawlerLimitsFactory> WithCrawlerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerKnowledgeBaseWebCrawlerConfigurationFactory> combinedResult, Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrawlerLimits(combinedResult.T5, subFactoryAction));
}
