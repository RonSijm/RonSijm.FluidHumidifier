// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class PolicyGenerationFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.PolicyGeneration> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.PolicyGeneration>(resourceName)
{

    internal InnerPolicyGenerationResourceFactory ResourceFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.PolicyGeneration Create()
    {
        var policyGenerationResult = CreatePolicyGeneration();
        factoryAction?.Invoke(policyGenerationResult);

        return policyGenerationResult;
    }

    private Humidifier.BedrockAgentCore.PolicyGeneration CreatePolicyGeneration()
    {
        var policyGenerationResult = new Humidifier.BedrockAgentCore.PolicyGeneration
        {
            GivenName = InputResourceName,
        };

        return policyGenerationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.PolicyGeneration result)
    {
        base.CreateChildren(result);

        result.Resource ??= ResourceFactory?.Build();
    }

} // End Of Class

public static class PolicyGenerationFactoryExtensions
{
    public static CombinedResult<PolicyGenerationFactory, InnerPolicyGenerationResourceFactory> WithResource(this PolicyGenerationFactory parentFactory, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null)
    {
        parentFactory.ResourceFactory = new InnerPolicyGenerationResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceFactory);
    }

    public static CombinedResult<PolicyGenerationFactory, T1, InnerPolicyGenerationResourceFactory> WithResource<T1>(this CombinedResult<PolicyGenerationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGenerationFactory, InnerPolicyGenerationResourceFactory> WithResource<T1>(this CombinedResult<T1, PolicyGenerationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PolicyGenerationFactory, T1, T2, InnerPolicyGenerationResourceFactory> WithResource<T1, T2>(this CombinedResult<PolicyGenerationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGenerationFactory, T2, InnerPolicyGenerationResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, PolicyGenerationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGenerationFactory, InnerPolicyGenerationResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, T2, PolicyGenerationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PolicyGenerationFactory, T1, T2, T3, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<PolicyGenerationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGenerationFactory, T2, T3, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, PolicyGenerationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGenerationFactory, T3, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, PolicyGenerationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyGenerationFactory, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyGenerationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PolicyGenerationFactory, T1, T2, T3, T4, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<PolicyGenerationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGenerationFactory, T2, T3, T4, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, PolicyGenerationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGenerationFactory, T3, T4, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyGenerationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyGenerationFactory, T4, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyGenerationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PolicyGenerationFactory, InnerPolicyGenerationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyGenerationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T5, subFactoryAction).T2);
}
