// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerInstanceStorageConfigS3ConfigFactory(Action<Humidifier.Connect.InstanceStorageConfigTypes.S3Config> factoryAction = null) : SubResourceFactory<Humidifier.Connect.InstanceStorageConfigTypes.S3Config>
{

    internal InnerInstanceStorageConfigEncryptionConfigFactory EncryptionConfigFactory { get; set; }

    protected override Humidifier.Connect.InstanceStorageConfigTypes.S3Config Create()
    {
        var s3ConfigResult = CreateS3Config();
        factoryAction?.Invoke(s3ConfigResult);

        return s3ConfigResult;
    }

    private Humidifier.Connect.InstanceStorageConfigTypes.S3Config CreateS3Config()
    {
        var s3ConfigResult = new Humidifier.Connect.InstanceStorageConfigTypes.S3Config();

        return s3ConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.InstanceStorageConfigTypes.S3Config result)
    {
        base.CreateChildren(result);

        result.EncryptionConfig ??= EncryptionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceStorageConfigS3ConfigFactoryExtensions
{
    public static CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig(this InnerInstanceStorageConfigS3ConfigFactory parentFactory, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigFactory = new InnerInstanceStorageConfigEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigFactory);
    }

    public static CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, T2, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, T2, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, T2> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceStorageConfigS3ConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, T2, InnerInstanceStorageConfigS3ConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, T2, T3, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, T2, T3, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceStorageConfigS3ConfigFactory, T3, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceStorageConfigS3ConfigFactory, T3> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceStorageConfigS3ConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceStorageConfigS3ConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, T2, T3, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<InnerInstanceStorageConfigS3ConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, T2, T3, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceStorageConfigS3ConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceStorageConfigS3ConfigFactory, T3, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceStorageConfigS3ConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceStorageConfigS3ConfigFactory, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceStorageConfigS3ConfigFactory, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceStorageConfigS3ConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceStorageConfigS3ConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T5, subFactoryAction));
}
