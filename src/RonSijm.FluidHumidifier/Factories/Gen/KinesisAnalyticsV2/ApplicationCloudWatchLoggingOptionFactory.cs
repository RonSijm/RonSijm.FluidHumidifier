// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class ApplicationCloudWatchLoggingOptionFactory(string resourceName = null, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption> factoryAction = null) : ResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption>(resourceName)
{

    internal InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory CloudWatchLoggingOptionFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption Create()
    {
        var applicationCloudWatchLoggingOptionResult = CreateApplicationCloudWatchLoggingOption();
        factoryAction?.Invoke(applicationCloudWatchLoggingOptionResult);

        return applicationCloudWatchLoggingOptionResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption CreateApplicationCloudWatchLoggingOption()
    {
        var applicationCloudWatchLoggingOptionResult = new Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption
        {
            GivenName = InputResourceName,
        };

        return applicationCloudWatchLoggingOptionResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOption result)
    {
        base.CreateChildren(result);

        result.CloudWatchLoggingOption ??= CloudWatchLoggingOptionFactory?.Build();
    }

} // End Of Class

public static class ApplicationCloudWatchLoggingOptionFactoryExtensions
{
    public static CombinedResult<ApplicationCloudWatchLoggingOptionFactory, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption(this ApplicationCloudWatchLoggingOptionFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null)
    {
        parentFactory.CloudWatchLoggingOptionFactory = new InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLoggingOptionFactory);
    }

    public static CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1>(this CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1>(this CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, T2, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2>(this CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, T2, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2>(this CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationCloudWatchLoggingOptionFactory, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2>(this CombinedResult<T1, T2, ApplicationCloudWatchLoggingOptionFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, T2, T3, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3>(this CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, T2, T3, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3>(this CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationCloudWatchLoggingOptionFactory, T3, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationCloudWatchLoggingOptionFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationCloudWatchLoggingOptionFactory, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationCloudWatchLoggingOptionFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, T2, T3, T4, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3, T4>(this CombinedResult<ApplicationCloudWatchLoggingOptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, T2, T3, T4, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationCloudWatchLoggingOptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationCloudWatchLoggingOptionFactory, T3, T4, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationCloudWatchLoggingOptionFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationCloudWatchLoggingOptionFactory, T4, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationCloudWatchLoggingOptionFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationCloudWatchLoggingOptionFactory, InnerApplicationCloudWatchLoggingOptionCloudWatchLoggingOptionFactory> WithCloudWatchLoggingOption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationCloudWatchLoggingOptionFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationCloudWatchLoggingOptionTypes.CloudWatchLoggingOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLoggingOption(combinedResult.T5, subFactoryAction));
}
