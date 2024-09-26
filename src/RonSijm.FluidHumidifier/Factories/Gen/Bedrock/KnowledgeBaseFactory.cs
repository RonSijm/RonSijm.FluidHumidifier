// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class KnowledgeBaseFactory(string resourceName = null, Action<Humidifier.Bedrock.KnowledgeBase> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.KnowledgeBase>(resourceName)
{

    internal InnerKnowledgeBaseKnowledgeBaseConfigurationFactory KnowledgeBaseConfigurationFactory { get; set; }

    internal InnerKnowledgeBaseStorageConfigurationFactory StorageConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.KnowledgeBase Create()
    {
        var knowledgeBaseResult = CreateKnowledgeBase();
        factoryAction?.Invoke(knowledgeBaseResult);

        return knowledgeBaseResult;
    }

    private Humidifier.Bedrock.KnowledgeBase CreateKnowledgeBase()
    {
        var knowledgeBaseResult = new Humidifier.Bedrock.KnowledgeBase
        {
            GivenName = InputResourceName,
        };

        return knowledgeBaseResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.KnowledgeBase result)
    {
        base.CreateChildren(result);

        result.KnowledgeBaseConfiguration ??= KnowledgeBaseConfigurationFactory?.Build();
        result.StorageConfiguration ??= StorageConfigurationFactory?.Build();
    }

} // End Of Class

public static class KnowledgeBaseFactoryExtensions
{
    public static CombinedResult<KnowledgeBaseFactory, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration(this KnowledgeBaseFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null)
    {
        parentFactory.KnowledgeBaseConfigurationFactory = new InnerKnowledgeBaseKnowledgeBaseConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KnowledgeBaseConfigurationFactory);
    }

    public static CombinedResult<KnowledgeBaseFactory, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration(this KnowledgeBaseFactory parentFactory, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null)
    {
        parentFactory.StorageConfigurationFactory = new InnerKnowledgeBaseStorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageConfigurationFactory);
    }

    public static CombinedResult<KnowledgeBaseFactory, T1, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1>(this CombinedResult<KnowledgeBaseFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1>(this CombinedResult<T1, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2>(this CombinedResult<KnowledgeBaseFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, T2, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2>(this CombinedResult<T1, KnowledgeBaseFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KnowledgeBaseFactory, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2>(this CombinedResult<T1, T2, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<KnowledgeBaseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, T2, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<T1, KnowledgeBaseFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KnowledgeBaseFactory, T3, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, KnowledgeBaseFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KnowledgeBaseFactory, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, T2, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<KnowledgeBaseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, T2, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, KnowledgeBaseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KnowledgeBaseFactory, T3, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, KnowledgeBaseFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KnowledgeBaseFactory, T4, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, KnowledgeBaseFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, KnowledgeBaseFactory, InnerKnowledgeBaseKnowledgeBaseConfigurationFactory> WithKnowledgeBaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKnowledgeBaseConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1>(this CombinedResult<KnowledgeBaseFactory, T1> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1>(this CombinedResult<T1, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, T2, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2>(this CombinedResult<KnowledgeBaseFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, T2, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2>(this CombinedResult<T1, KnowledgeBaseFactory, T2> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KnowledgeBaseFactory, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2>(this CombinedResult<T1, T2, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, T2, T3, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<KnowledgeBaseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, T2, T3, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, KnowledgeBaseFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KnowledgeBaseFactory, T3, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, KnowledgeBaseFactory, T3> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KnowledgeBaseFactory, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<KnowledgeBaseFactory, T1, T2, T3, T4, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<KnowledgeBaseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, KnowledgeBaseFactory, T2, T3, T4, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, KnowledgeBaseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, KnowledgeBaseFactory, T3, T4, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, KnowledgeBaseFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, KnowledgeBaseFactory, T4, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, KnowledgeBaseFactory, T4> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, KnowledgeBaseFactory, InnerKnowledgeBaseStorageConfigurationFactory> WithStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, KnowledgeBaseFactory> combinedResult, Action<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageConfiguration(combinedResult.T5, subFactoryAction));
}
