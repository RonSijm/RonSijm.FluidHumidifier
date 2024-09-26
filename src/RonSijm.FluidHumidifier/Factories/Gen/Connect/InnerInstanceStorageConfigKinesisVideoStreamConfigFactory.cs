// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerInstanceStorageConfigKinesisVideoStreamConfigFactory(Action<Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig>
{

    internal InnerInstanceStorageConfigEncryptionConfigFactory EncryptionConfigFactory { get; set; }

    protected override Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig Create()
    {
        var kinesisVideoStreamConfigResult = CreateKinesisVideoStreamConfig();
        factoryAction?.Invoke(kinesisVideoStreamConfigResult);

        return kinesisVideoStreamConfigResult;
    }

    private Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig CreateKinesisVideoStreamConfig()
    {
        var kinesisVideoStreamConfigResult = new Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig();

        return kinesisVideoStreamConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig result)
    {
        base.CreateChildren(result);

        result.EncryptionConfig ??= EncryptionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceStorageConfigKinesisVideoStreamConfigFactoryExtensions
{
    public static CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig(this InnerInstanceStorageConfigKinesisVideoStreamConfigFactory parentFactory, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigFactory = new InnerInstanceStorageConfigEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigFactory);
    }

    public static CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, T2, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T2, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T2> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, T2, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, T2, T3, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T2, T3, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T3, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T3> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, T2, T3, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T2, T3, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T3, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T4, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, T4> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory, InnerInstanceStorageConfigEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceStorageConfigKinesisVideoStreamConfigFactory> combinedResult, Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T5, subFactoryAction));
}
