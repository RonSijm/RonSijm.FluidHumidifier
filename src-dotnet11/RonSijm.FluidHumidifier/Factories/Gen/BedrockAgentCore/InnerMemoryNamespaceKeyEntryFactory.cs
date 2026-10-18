// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryNamespaceKeyEntryFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry>
{

    internal InnerMemoryNamespaceKeyValidationFactory ValidationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry Create()
    {
        var namespaceKeyEntryResult = CreateNamespaceKeyEntry();
        factoryAction?.Invoke(namespaceKeyEntryResult);

        return namespaceKeyEntryResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry CreateNamespaceKeyEntry()
    {
        var namespaceKeyEntryResult = new Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry();

        return namespaceKeyEntryResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry result)
    {
        base.CreateChildren(result);

        result.Validation ??= ValidationFactory?.Build();
    }

} // End Of Class

public static class InnerMemoryNamespaceKeyEntryFactoryExtensions
{
    public static CombinedResult<InnerMemoryNamespaceKeyEntryFactory, InnerMemoryNamespaceKeyValidationFactory> WithValidation(this InnerMemoryNamespaceKeyEntryFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null)
    {
        parentFactory.ValidationFactory = new InnerMemoryNamespaceKeyValidationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidationFactory);
    }

    public static CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1>(this CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1>(this CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, T2, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2>(this CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, T2, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2>(this CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryNamespaceKeyEntryFactory, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2>(this CombinedResult<T1, T2, InnerMemoryNamespaceKeyEntryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, T2, T3, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, T2, T3, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryNamespaceKeyEntryFactory, T3, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemoryNamespaceKeyEntryFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryNamespaceKeyEntryFactory, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemoryNamespaceKeyEntryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, T2, T3, T4, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<InnerMemoryNamespaceKeyEntryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, T2, T3, T4, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemoryNamespaceKeyEntryFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemoryNamespaceKeyEntryFactory, T3, T4, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemoryNamespaceKeyEntryFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemoryNamespaceKeyEntryFactory, T4, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemoryNamespaceKeyEntryFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemoryNamespaceKeyEntryFactory, InnerMemoryNamespaceKeyValidationFactory> WithValidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemoryNamespaceKeyEntryFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidation(combinedResult.T5, subFactoryAction).T2);
}
