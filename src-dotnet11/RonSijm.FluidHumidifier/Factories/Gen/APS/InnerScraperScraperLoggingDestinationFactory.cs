// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class InnerScraperScraperLoggingDestinationFactory(Action<Humidifier.APS.ScraperTypes.ScraperLoggingDestination> factoryAction = null) : SubResourceFactory<Humidifier.APS.ScraperTypes.ScraperLoggingDestination>
{

    internal InnerScraperCloudWatchLogDestinationFactory CloudWatchLogsFactory { get; set; }

    protected override Humidifier.APS.ScraperTypes.ScraperLoggingDestination Create()
    {
        var scraperLoggingDestinationResult = CreateScraperLoggingDestination();
        factoryAction?.Invoke(scraperLoggingDestinationResult);

        return scraperLoggingDestinationResult;
    }

    private Humidifier.APS.ScraperTypes.ScraperLoggingDestination CreateScraperLoggingDestination()
    {
        var scraperLoggingDestinationResult = new Humidifier.APS.ScraperTypes.ScraperLoggingDestination();

        return scraperLoggingDestinationResult;
    }
    public override void CreateChildren(Humidifier.APS.ScraperTypes.ScraperLoggingDestination result)
    {
        base.CreateChildren(result);

        result.CloudWatchLogs ??= CloudWatchLogsFactory?.Build();
    }

} // End Of Class

public static class InnerScraperScraperLoggingDestinationFactoryExtensions
{
    public static CombinedResult<InnerScraperScraperLoggingDestinationFactory, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs(this InnerScraperScraperLoggingDestinationFactory parentFactory, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsFactory = new InnerScraperCloudWatchLogDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsFactory);
    }

    public static CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1>(this CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1>(this CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, T2, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, T2, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, T2> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScraperScraperLoggingDestinationFactory, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, T2, InnerScraperScraperLoggingDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, T2, T3, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, T2, T3, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, T2, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScraperScraperLoggingDestinationFactory, T3, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerScraperScraperLoggingDestinationFactory, T3> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScraperScraperLoggingDestinationFactory, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScraperScraperLoggingDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, T2, T3, T4, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<InnerScraperScraperLoggingDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, T2, T3, T4, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerScraperScraperLoggingDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScraperScraperLoggingDestinationFactory, T3, T4, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScraperScraperLoggingDestinationFactory, T3, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScraperScraperLoggingDestinationFactory, T4, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScraperScraperLoggingDestinationFactory, T4> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScraperScraperLoggingDestinationFactory, InnerScraperCloudWatchLogDestinationFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScraperScraperLoggingDestinationFactory> combinedResult, Action<Humidifier.APS.ScraperTypes.CloudWatchLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T5, subFactoryAction).T2);
}
