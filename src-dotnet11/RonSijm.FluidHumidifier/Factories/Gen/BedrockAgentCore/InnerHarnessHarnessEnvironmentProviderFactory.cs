// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessEnvironmentProviderFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider>
{

    internal InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory AgentCoreRuntimeEnvironmentFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider Create()
    {
        var harnessEnvironmentProviderResult = CreateHarnessEnvironmentProvider();
        factoryAction?.Invoke(harnessEnvironmentProviderResult);

        return harnessEnvironmentProviderResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider CreateHarnessEnvironmentProvider()
    {
        var harnessEnvironmentProviderResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider();

        return harnessEnvironmentProviderResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessEnvironmentProvider result)
    {
        base.CreateChildren(result);

        result.AgentCoreRuntimeEnvironment ??= AgentCoreRuntimeEnvironmentFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessEnvironmentProviderFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment(this InnerHarnessHarnessEnvironmentProviderFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null)
    {
        parentFactory.AgentCoreRuntimeEnvironmentFactory = new InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AgentCoreRuntimeEnvironmentFactory);
    }

    public static CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1>(this CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, T2, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2>(this CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, T2, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentProviderFactory, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, T2, T3, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, T2, T3, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentProviderFactory, T3, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentProviderFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentProviderFactory, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, T2, T3, T4, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessEnvironmentProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, T2, T3, T4, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessEnvironmentProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentProviderFactory, T3, T4, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessEnvironmentProviderFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentProviderFactory, T4, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessEnvironmentProviderFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessEnvironmentProviderFactory, InnerHarnessHarnessAgentCoreRuntimeEnvironmentFactory> WithAgentCoreRuntimeEnvironment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessEnvironmentProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreRuntimeEnvironment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgentCoreRuntimeEnvironment(combinedResult.T5, subFactoryAction).T2);
}
