// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQueryErrorReportConfigurationFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration>
{

    internal InnerScheduledQueryS3ConfigurationFactory S3ConfigurationFactory { get; set; }

    protected override Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration Create()
    {
        var errorReportConfigurationResult = CreateErrorReportConfiguration();
        factoryAction?.Invoke(errorReportConfigurationResult);

        return errorReportConfigurationResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration CreateErrorReportConfiguration()
    {
        var errorReportConfigurationResult = new Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration();

        return errorReportConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.ScheduledQueryTypes.ErrorReportConfiguration result)
    {
        base.CreateChildren(result);

        result.S3Configuration ??= S3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledQueryErrorReportConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration(this InnerScheduledQueryErrorReportConfigurationFactory parentFactory, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null)
    {
        parentFactory.S3ConfigurationFactory = new InnerScheduledQueryS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3ConfigurationFactory);
    }

    public static CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1>(this CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, T2, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, T2, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryErrorReportConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerScheduledQueryErrorReportConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, T2, T3, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, T2, T3, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryErrorReportConfigurationFactory, T3, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledQueryErrorReportConfigurationFactory, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryErrorReportConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledQueryErrorReportConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, T2, T3, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerScheduledQueryErrorReportConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, T2, T3, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledQueryErrorReportConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryErrorReportConfigurationFactory, T3, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledQueryErrorReportConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryErrorReportConfigurationFactory, T4, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledQueryErrorReportConfigurationFactory, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledQueryErrorReportConfigurationFactory, InnerScheduledQueryS3ConfigurationFactory> WithS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledQueryErrorReportConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.S3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Configuration(combinedResult.T5, subFactoryAction));
}
