// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerInfrastructureConfigurationLoggingFactory(Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging>
{

    internal InnerInfrastructureConfigurationS3LogsFactory S3LogsFactory { get; set; }

    protected override Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging();

        return loggingResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.InfrastructureConfigurationTypes.Logging result)
    {
        base.CreateChildren(result);

        result.S3Logs ??= S3LogsFactory?.Build();
    }

} // End Of Class

public static class InnerInfrastructureConfigurationLoggingFactoryExtensions
{
    public static CombinedResult<InnerInfrastructureConfigurationLoggingFactory, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs(this InnerInfrastructureConfigurationLoggingFactory parentFactory, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null)
    {
        parentFactory.S3LogsFactory = new InnerInfrastructureConfigurationS3LogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LogsFactory);
    }

    public static CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1>(this CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1>(this CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, T2, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2>(this CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, T2, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2>(this CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInfrastructureConfigurationLoggingFactory, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2>(this CombinedResult<T1, T2, InnerInfrastructureConfigurationLoggingFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, T2, T3, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, T2, T3, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInfrastructureConfigurationLoggingFactory, T3, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<T1, T2, InnerInfrastructureConfigurationLoggingFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationLoggingFactory, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationLoggingFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, T2, T3, T4, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<InnerInfrastructureConfigurationLoggingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, T2, T3, T4, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, InnerInfrastructureConfigurationLoggingFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInfrastructureConfigurationLoggingFactory, T3, T4, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInfrastructureConfigurationLoggingFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationLoggingFactory, T4, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInfrastructureConfigurationLoggingFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInfrastructureConfigurationLoggingFactory, InnerInfrastructureConfigurationS3LogsFactory> WithS3Logs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInfrastructureConfigurationLoggingFactory> combinedResult, Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Logs(combinedResult.T5, subFactoryAction));
}
