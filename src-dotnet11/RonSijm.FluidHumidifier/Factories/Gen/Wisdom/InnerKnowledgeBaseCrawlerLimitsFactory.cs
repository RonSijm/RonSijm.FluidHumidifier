// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseCrawlerLimitsFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits Create()
    {
        var crawlerLimitsResult = CreateCrawlerLimits();
        factoryAction?.Invoke(crawlerLimitsResult);

        return crawlerLimitsResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits CreateCrawlerLimits()
    {
        var crawlerLimitsResult = new Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits();

        return crawlerLimitsResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseCrawlerLimitsFactoryExtensions
{
}
