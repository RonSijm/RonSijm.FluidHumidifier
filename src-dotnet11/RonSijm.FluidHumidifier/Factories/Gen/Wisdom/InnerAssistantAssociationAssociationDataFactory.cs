// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAssistantAssociationAssociationDataFactory(Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData>
{

    internal InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory ExternalBedrockKnowledgeBaseConfigFactory { get; set; }

    protected override Humidifier.Wisdom.AssistantAssociationTypes.AssociationData Create()
    {
        var associationDataResult = CreateAssociationData();
        factoryAction?.Invoke(associationDataResult);

        return associationDataResult;
    }

    private Humidifier.Wisdom.AssistantAssociationTypes.AssociationData CreateAssociationData()
    {
        var associationDataResult = new Humidifier.Wisdom.AssistantAssociationTypes.AssociationData();

        return associationDataResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.AssistantAssociationTypes.AssociationData result)
    {
        base.CreateChildren(result);

        result.ExternalBedrockKnowledgeBaseConfig ??= ExternalBedrockKnowledgeBaseConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAssistantAssociationAssociationDataFactoryExtensions
{
    public static CombinedResult<InnerAssistantAssociationAssociationDataFactory, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig(this InnerAssistantAssociationAssociationDataFactory parentFactory, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null)
    {
        parentFactory.ExternalBedrockKnowledgeBaseConfigFactory = new InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExternalBedrockKnowledgeBaseConfigFactory);
    }

    public static CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1>(this CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1>(this CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, T2, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2>(this CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, T2, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2>(this CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, T2> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssistantAssociationAssociationDataFactory, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2>(this CombinedResult<T1, T2, InnerAssistantAssociationAssociationDataFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, T2, T3, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3>(this CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, T2, T3, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3>(this CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssistantAssociationAssociationDataFactory, T3, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAssistantAssociationAssociationDataFactory, T3> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAssistantAssociationAssociationDataFactory, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAssistantAssociationAssociationDataFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, T2, T3, T4, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3, T4>(this CombinedResult<InnerAssistantAssociationAssociationDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, T2, T3, T4, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAssistantAssociationAssociationDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAssistantAssociationAssociationDataFactory, T3, T4, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAssistantAssociationAssociationDataFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAssistantAssociationAssociationDataFactory, T4, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAssistantAssociationAssociationDataFactory, T4> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAssistantAssociationAssociationDataFactory, InnerAssistantAssociationExternalBedrockKnowledgeBaseConfigFactory> WithExternalBedrockKnowledgeBaseConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAssistantAssociationAssociationDataFactory> combinedResult, Action<Humidifier.Wisdom.AssistantAssociationTypes.ExternalBedrockKnowledgeBaseConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalBedrockKnowledgeBaseConfig(combinedResult.T5, subFactoryAction).T2);
}
