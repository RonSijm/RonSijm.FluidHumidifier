// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class ScraperFactory(string resourceName = null, Action<Humidifier.APS.Scraper> factoryAction = null) : ResourceFactory<Humidifier.APS.Scraper>(resourceName)
{

    internal InnerScraperScrapeConfigurationFactory ScrapeConfigurationFactory { get; set; }

    internal InnerScraperDestinationFactory DestinationFactory { get; set; }

    internal InnerScraperSourceFactory SourceFactory { get; set; }

    protected override Humidifier.APS.Scraper Create()
    {
        var scraperResult = CreateScraper();
        factoryAction?.Invoke(scraperResult);

        return scraperResult;
    }

    private Humidifier.APS.Scraper CreateScraper()
    {
        var scraperResult = new Humidifier.APS.Scraper
        {
            GivenName = InputResourceName,
        };

        return scraperResult;
    }
    public override void CreateChildren(Humidifier.APS.Scraper result)
    {
        base.CreateChildren(result);

        result.ScrapeConfiguration ??= ScrapeConfigurationFactory?.Build();
        result.Destination ??= DestinationFactory?.Build();
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class ScraperFactoryExtensions
{
    public static CombinedResult<ScraperFactory, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration(this ScraperFactory parentFactory, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null)
    {
        parentFactory.ScrapeConfigurationFactory = new InnerScraperScrapeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScrapeConfigurationFactory);
    }

    public static CombinedResult<ScraperFactory, InnerScraperDestinationFactory> WithDestination(this ScraperFactory parentFactory, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerScraperDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<ScraperFactory, InnerScraperSourceFactory> WithSource(this ScraperFactory parentFactory, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerScraperSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<ScraperFactory, T1, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1>(this CombinedResult<ScraperFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1>(this CombinedResult<T1, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2>(this CombinedResult<ScraperFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2>(this CombinedResult<T1, ScraperFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2>(this CombinedResult<T1, T2, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, T3, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3>(this CombinedResult<ScraperFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, T3, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3>(this CombinedResult<T1, ScraperFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, T3, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ScraperFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScraperFactory, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, T3, T4, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3, T4>(this CombinedResult<ScraperFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, T3, T4, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ScraperFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, T3, T4, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScraperFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScraperFactory, T4, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScraperFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScraperFactory, InnerScraperScrapeConfigurationFactory> WithScrapeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScrapeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScrapeConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, InnerScraperDestinationFactory> WithDestination<T1>(this CombinedResult<ScraperFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, InnerScraperDestinationFactory> WithDestination<T1>(this CombinedResult<T1, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, InnerScraperDestinationFactory> WithDestination<T1, T2>(this CombinedResult<ScraperFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, InnerScraperDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, ScraperFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, InnerScraperDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, T3, InnerScraperDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<ScraperFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, T3, InnerScraperDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, ScraperFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, T3, InnerScraperDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, ScraperFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScraperFactory, InnerScraperDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, T3, T4, InnerScraperDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<ScraperFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, T3, T4, InnerScraperDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, ScraperFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, T3, T4, InnerScraperDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScraperFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScraperFactory, T4, InnerScraperDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScraperFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScraperFactory, InnerScraperDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, InnerScraperSourceFactory> WithSource<T1>(this CombinedResult<ScraperFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, InnerScraperSourceFactory> WithSource<T1>(this CombinedResult<T1, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, InnerScraperSourceFactory> WithSource<T1, T2>(this CombinedResult<ScraperFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, InnerScraperSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, ScraperFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, InnerScraperSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, T3, InnerScraperSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<ScraperFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, T3, InnerScraperSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, ScraperFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, T3, InnerScraperSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, ScraperFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScraperFactory, InnerScraperSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScraperFactory, T1, T2, T3, T4, InnerScraperSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<ScraperFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScraperFactory, T2, T3, T4, InnerScraperSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, ScraperFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScraperFactory, T3, T4, InnerScraperSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScraperFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScraperFactory, T4, InnerScraperSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScraperFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScraperFactory, InnerScraperSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScraperFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction));
}
