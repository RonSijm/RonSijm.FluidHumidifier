// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCrawlerRecrawlPolicyFactory(Action<Humidifier.Glue.CrawlerTypes.RecrawlPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CrawlerTypes.RecrawlPolicy>
{

    protected override Humidifier.Glue.CrawlerTypes.RecrawlPolicy Create()
    {
        var recrawlPolicyResult = CreateRecrawlPolicy();
        factoryAction?.Invoke(recrawlPolicyResult);

        return recrawlPolicyResult;
    }

    private Humidifier.Glue.CrawlerTypes.RecrawlPolicy CreateRecrawlPolicy()
    {
        var recrawlPolicyResult = new Humidifier.Glue.CrawlerTypes.RecrawlPolicy();

        return recrawlPolicyResult;
    }

} // End Of Class

public static class InnerCrawlerRecrawlPolicyFactoryExtensions
{
}
