// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastoreSseConfigurationFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration>
{

    internal InnerFHIRDatastoreKmsEncryptionConfigFactory KmsEncryptionConfigFactory { get; set; }

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration Create()
    {
        var sseConfigurationResult = CreateSseConfiguration();
        factoryAction?.Invoke(sseConfigurationResult);

        return sseConfigurationResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration CreateSseConfiguration()
    {
        var sseConfigurationResult = new Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration();

        return sseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.HealthLake.FHIRDatastoreTypes.SseConfiguration result)
    {
        base.CreateChildren(result);

        result.KmsEncryptionConfig ??= KmsEncryptionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFHIRDatastoreSseConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig(this InnerFHIRDatastoreSseConfigurationFactory parentFactory, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null)
    {
        parentFactory.KmsEncryptionConfigFactory = new InnerFHIRDatastoreKmsEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KmsEncryptionConfigFactory);
    }

    public static CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1>(this CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1>(this CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, T2, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2>(this CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, T2, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2>(this CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, T2> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFHIRDatastoreSseConfigurationFactory, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2>(this CombinedResult<T1, T2, InnerFHIRDatastoreSseConfigurationFactory> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, T2, T3, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3>(this CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, T2, T3, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFHIRDatastoreSseConfigurationFactory, T3, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFHIRDatastoreSseConfigurationFactory, T3> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFHIRDatastoreSseConfigurationFactory, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFHIRDatastoreSseConfigurationFactory> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, T2, T3, T4, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<InnerFHIRDatastoreSseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, T2, T3, T4, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFHIRDatastoreSseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFHIRDatastoreSseConfigurationFactory, T3, T4, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFHIRDatastoreSseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFHIRDatastoreSseConfigurationFactory, T4, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFHIRDatastoreSseConfigurationFactory, T4> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFHIRDatastoreSseConfigurationFactory, InnerFHIRDatastoreKmsEncryptionConfigFactory> WithKmsEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFHIRDatastoreSseConfigurationFactory> combinedResult, Action<Humidifier.HealthLake.FHIRDatastoreTypes.KmsEncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKmsEncryptionConfig(combinedResult.T5, subFactoryAction));
}
