// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperScraperLoggingConfigurationFactory(Action<Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration>
{

    internal InnerScraperScraperLoggingDestinationFactory LoggingDestinationFactory { get; set; }

    protected override Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration Create()
    {
        var scraperLoggingConfigurationResult = CreateScraperLoggingConfiguration();
        factoryAction?.Invoke(scraperLoggingConfigurationResult);

        return scraperLoggingConfigurationResult;
    }

    private Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration CreateScraperLoggingConfiguration()
    {
        var scraperLoggingConfigurationResult = new Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration();

        return scraperLoggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.LoggingDestination ??= LoggingDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerScraperScraperLoggingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScraperScraperLoggingConfigurationFactory, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination(this InnerScraperScraperLoggingConfigurationFactory parentFactory, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null)
    {
        parentFactory.LoggingDestinationFactory = new InnerScraperScraperLoggingDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingDestinationFactory);
    }

    public static CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1>(this CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1>(this CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, T2, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2>(this CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, T2, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2>(this CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScraperScraperLoggingConfigurationFactory, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2>(this CombinedResult<T1, T2, InnerScraperScraperLoggingConfigurationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, T2, T3, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3>(this CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, T2, T3, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3>(this CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScraperScraperLoggingConfigurationFactory, T3, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerScraperScraperLoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScraperScraperLoggingConfigurationFactory, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScraperScraperLoggingConfigurationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, T2, T3, T4, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3, T4>(this CombinedResult<InnerScraperScraperLoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, T2, T3, T4, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerScraperScraperLoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScraperScraperLoggingConfigurationFactory, T3, T4, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScraperScraperLoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScraperScraperLoggingConfigurationFactory, T4, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScraperScraperLoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScraperScraperLoggingConfigurationFactory, InnerScraperScraperLoggingDestinationFactory> WithLoggingDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScraperScraperLoggingConfigurationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingDestination(combinedResult.T5, subFactoryAction).T2);
}
