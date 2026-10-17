// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerScheduledQueryDestinationConfigurationFactory(Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration>
{

    internal InnerScheduledQueryS3ConfigurationFactory S3ConfigurationFactory { get; set; }

    protected override Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration Create()
    {
        var destinationConfigurationResult = CreateDestinationConfiguration();
        factoryAction?.Invoke(destinationConfigurationResult);

        return destinationConfigurationResult;
    }

    private Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration CreateDestinationConfiguration()
    {
        var destinationConfigurationResult = new Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration();

        return destinationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration result)
    {
        base.CreateChildren(result);

        result.S3Configuration ??= S3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledQueryDestinationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration(this InnerScheduledQueryDestinationConfigurationFactory parentFactory, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3ConfigurationFactory = new InnerScheduledQueryS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigurationFactory);
    }

    public static CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, T2, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, T2, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, T2> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledQueryDestinationConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerScheduledQueryDestinationConfigurationFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, T2, T3, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, T2, T3, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledQueryDestinationConfigurationFactory, T3, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledQueryDestinationConfigurationFactory, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryDestinationConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledQueryDestinationConfigurationFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, T2, T3, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerScheduledQueryDestinationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, T2, T3, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledQueryDestinationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledQueryDestinationConfigurationFactory, T3, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledQueryDestinationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryDestinationConfigurationFactory, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledQueryDestinationConfigurationFactory, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledQueryDestinationConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledQueryDestinationConfigurationFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T5, subFactoryAction).T2);
}
