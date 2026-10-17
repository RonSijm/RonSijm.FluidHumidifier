// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemorySelfManagedConfigurationFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration>
{

    internal InnerMemoryInvocationConfigurationInputFactory InvocationConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration Create()
    {
        var selfManagedConfigurationResult = CreateSelfManagedConfiguration();
        factoryAction?.Invoke(selfManagedConfigurationResult);

        return selfManagedConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration CreateSelfManagedConfiguration()
    {
        var selfManagedConfigurationResult = new Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration();

        return selfManagedConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration result)
    {
        base.CreateChildren(result);

        result.InvocationConfiguration ??= InvocationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMemorySelfManagedConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMemorySelfManagedConfigurationFactory, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration(this InnerMemorySelfManagedConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null)
    {
        parentFactory.InvocationConfigurationFactory = new InnerMemoryInvocationConfigurationInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InvocationConfigurationFactory);
    }

    public static CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1>(this CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1>(this CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, T2, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2>(this CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, T2, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2>(this CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySelfManagedConfigurationFactory, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMemorySelfManagedConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, T2, T3, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3>(this CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, T2, T3, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySelfManagedConfigurationFactory, T3, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemorySelfManagedConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemorySelfManagedConfigurationFactory, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemorySelfManagedConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, T2, T3, T4, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMemorySelfManagedConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, T2, T3, T4, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemorySelfManagedConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMemorySelfManagedConfigurationFactory, T3, T4, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemorySelfManagedConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMemorySelfManagedConfigurationFactory, T4, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemorySelfManagedConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMemorySelfManagedConfigurationFactory, InnerMemoryInvocationConfigurationInputFactory> WithInvocationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemorySelfManagedConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvocationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
