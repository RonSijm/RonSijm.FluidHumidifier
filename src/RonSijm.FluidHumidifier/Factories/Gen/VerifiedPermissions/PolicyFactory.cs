// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class PolicyFactory(string resourceName = null, Action<Humidifier.VerifiedPermissions.Policy> factoryAction = null) : ResourceFactory<Humidifier.VerifiedPermissions.Policy>(resourceName)
{

    internal InnerPolicyPolicyDefinitionFactory DefinitionFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.VerifiedPermissions.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.VerifiedPermissions.Policy
        {
            GivenName = InputResourceName,
        };

        return policyResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.Policy result)
    {
        base.CreateChildren(result);

        result.Definition ??= DefinitionFactory?.Build();
    }

} // End Of Class

public static class PolicyFactoryExtensions
{
    public static CombinedResult<PolicyFactory, InnerPolicyPolicyDefinitionFactory> WithDefinition(this PolicyFactory parentFactory, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null)
    {
        parentFactory.DefinitionFactory = new InnerPolicyPolicyDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionFactory);
    }

    public static CombinedResult<PolicyFactory, T1, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyPolicyDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.VerifiedPermissions.PolicyTypes.PolicyDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
}
