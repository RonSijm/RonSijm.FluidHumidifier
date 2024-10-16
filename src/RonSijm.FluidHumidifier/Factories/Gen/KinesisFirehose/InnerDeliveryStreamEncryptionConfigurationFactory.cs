// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamEncryptionConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration>
{

    internal InnerDeliveryStreamKMSEncryptionConfigFactory KMSEncryptionConfigFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.EncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.KMSEncryptionConfig ??= KMSEncryptionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig(this InnerDeliveryStreamEncryptionConfigurationFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null)
    {
        parentFactory.KMSEncryptionConfigFactory = new InnerDeliveryStreamKMSEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KMSEncryptionConfigFactory);
    }

    public static CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1>(this CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1>(this CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, T2, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2>(this CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, T2, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamEncryptionConfigurationFactory, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamEncryptionConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, T2, T3, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, T2, T3, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamEncryptionConfigurationFactory, T3, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamEncryptionConfigurationFactory, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamEncryptionConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, T2, T3, T4, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, T2, T3, T4, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamEncryptionConfigurationFactory, T3, T4, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamEncryptionConfigurationFactory, T4, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamEncryptionConfigurationFactory, InnerDeliveryStreamKMSEncryptionConfigFactory> WithKMSEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamEncryptionConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.KMSEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKMSEncryptionConfig(combinedResult.T5, subFactoryAction));
}
