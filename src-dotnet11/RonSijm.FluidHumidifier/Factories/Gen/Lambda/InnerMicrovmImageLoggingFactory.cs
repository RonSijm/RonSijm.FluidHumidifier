// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageLoggingFactory(Action<Humidifier.Lambda.MicrovmImageTypes.Logging> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.Logging>
{

    internal InnerMicrovmImageCloudWatchLoggingFactory CloudWatchFactory { get; set; }

    protected override Humidifier.Lambda.MicrovmImageTypes.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.Lambda.MicrovmImageTypes.Logging();

        return loggingResult;
    }
    public override void CreateChildren(Humidifier.Lambda.MicrovmImageTypes.Logging result)
    {
        base.CreateChildren(result);

        result.CloudWatch ??= CloudWatchFactory?.Build();
    }

} // End Of Class

public static class InnerMicrovmImageLoggingFactoryExtensions
{
    public static CombinedResult<InnerMicrovmImageLoggingFactory, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch(this InnerMicrovmImageLoggingFactory parentFactory, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null)
    {
        parentFactory.CloudWatchFactory = new InnerMicrovmImageCloudWatchLoggingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchFactory);
    }

    public static CombinedResult<InnerMicrovmImageLoggingFactory, T1, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1>(this CombinedResult<InnerMicrovmImageLoggingFactory, T1> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatch(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageLoggingFactory, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1>(this CombinedResult<T1, InnerMicrovmImageLoggingFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatch(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageLoggingFactory, T1, T2, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2>(this CombinedResult<InnerMicrovmImageLoggingFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageLoggingFactory, T2, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2>(this CombinedResult<T1, InnerMicrovmImageLoggingFactory, T2> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageLoggingFactory, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2>(this CombinedResult<T1, T2, InnerMicrovmImageLoggingFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageLoggingFactory, T1, T2, T3, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3>(this CombinedResult<InnerMicrovmImageLoggingFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageLoggingFactory, T2, T3, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3>(this CombinedResult<T1, InnerMicrovmImageLoggingFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageLoggingFactory, T3, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerMicrovmImageLoggingFactory, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMicrovmImageLoggingFactory, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMicrovmImageLoggingFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageLoggingFactory, T1, T2, T3, T4, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3, T4>(this CombinedResult<InnerMicrovmImageLoggingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageLoggingFactory, T2, T3, T4, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerMicrovmImageLoggingFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageLoggingFactory, T3, T4, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMicrovmImageLoggingFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMicrovmImageLoggingFactory, T4, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMicrovmImageLoggingFactory, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMicrovmImageLoggingFactory, InnerMicrovmImageCloudWatchLoggingFactory> WithCloudWatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMicrovmImageLoggingFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.CloudWatchLogging> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatch(combinedResult.T5, subFactoryAction).T2);
}
