// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerCrawlerTargetsFactory(Action<Humidifier.Glue.CrawlerTypes.Targets> factoryAction = null) : SubResourceFactory<Humidifier.Glue.CrawlerTypes.Targets>
{

    protected override Humidifier.Glue.CrawlerTypes.Targets Create()
    {
        var targetsResult = CreateTargets();
        factoryAction?.Invoke(targetsResult);

        return targetsResult;
    }

    private Humidifier.Glue.CrawlerTypes.Targets CreateTargets()
    {
        var targetsResult = new Humidifier.Glue.CrawlerTypes.Targets();

        return targetsResult;
    }

} // End Of Class

public static class InnerCrawlerTargetsFactoryExtensions
{
}
