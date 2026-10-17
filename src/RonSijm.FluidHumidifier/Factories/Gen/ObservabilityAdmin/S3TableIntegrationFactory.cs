// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class S3TableIntegrationFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.S3TableIntegration> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.S3TableIntegration>(resourceName)
{

    internal List<InnerS3TableIntegrationLogSourceFactory> LogSourcesFactories { get; set; } = [];

    internal InnerS3TableIntegrationEncryptionConfigFactory EncryptionFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.S3TableIntegration Create()
    {
        var s3TableIntegrationResult = CreateS3TableIntegration();
        factoryAction?.Invoke(s3TableIntegrationResult);

        return s3TableIntegrationResult;
    }

    private Humidifier.ObservabilityAdmin.S3TableIntegration CreateS3TableIntegration()
    {
        var s3TableIntegrationResult = new Humidifier.ObservabilityAdmin.S3TableIntegration
        {
            GivenName = InputResourceName,
        };

        return s3TableIntegrationResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.S3TableIntegration result)
    {
        base.CreateChildren(result);

        result.LogSources = LogSourcesFactories.Any() ? LogSourcesFactories.Select(x => x.Build()).ToList() : null;
        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class S3TableIntegrationFactoryExtensions
{
    public static CombinedResult<S3TableIntegrationFactory, InnerS3TableIntegrationLogSourceFactory> WithLogSources(this S3TableIntegrationFactory parentFactory, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null)
    {
        var factory = new InnerS3TableIntegrationLogSourceFactory(subFactoryAction);
        parentFactory.LogSourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<S3TableIntegrationFactory, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption(this S3TableIntegrationFactory parentFactory, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerS3TableIntegrationEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<S3TableIntegrationFactory, T1, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1>(this CombinedResult<S3TableIntegrationFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1>(this CombinedResult<T1, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, T2, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2>(this CombinedResult<S3TableIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, T2, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2>(this CombinedResult<T1, S3TableIntegrationFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, S3TableIntegrationFactory, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2>(this CombinedResult<T1, T2, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, T2, T3, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3>(this CombinedResult<S3TableIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, T2, T3, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3>(this CombinedResult<T1, S3TableIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, S3TableIntegrationFactory, T3, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3>(this CombinedResult<T1, T2, S3TableIntegrationFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, S3TableIntegrationFactory, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, T2, T3, T4, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3, T4>(this CombinedResult<S3TableIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, T2, T3, T4, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3, T4>(this CombinedResult<T1, S3TableIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, S3TableIntegrationFactory, T3, T4, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, S3TableIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, S3TableIntegrationFactory, T4, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, S3TableIntegrationFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, S3TableIntegrationFactory, InnerS3TableIntegrationLogSourceFactory> WithLogSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogSources(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1>(this CombinedResult<S3TableIntegrationFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1>(this CombinedResult<T1, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, T2, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2>(this CombinedResult<S3TableIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, T2, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2>(this CombinedResult<T1, S3TableIntegrationFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, S3TableIntegrationFactory, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, T2, T3, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3>(this CombinedResult<S3TableIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, T2, T3, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, S3TableIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, S3TableIntegrationFactory, T3, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, S3TableIntegrationFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, S3TableIntegrationFactory, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<S3TableIntegrationFactory, T1, T2, T3, T4, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<S3TableIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, S3TableIntegrationFactory, T2, T3, T4, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, S3TableIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, S3TableIntegrationFactory, T3, T4, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, S3TableIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, S3TableIntegrationFactory, T4, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, S3TableIntegrationFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, S3TableIntegrationFactory, InnerS3TableIntegrationEncryptionConfigFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, S3TableIntegrationFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction).T2);
}
