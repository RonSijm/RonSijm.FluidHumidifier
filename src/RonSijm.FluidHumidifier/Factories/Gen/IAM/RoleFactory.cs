// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class RoleFactory(string resourceName = null, Action<Humidifier.IAM.Role> factoryAction = null) : ResourceFactory<Humidifier.IAM.Role>(resourceName)
{

    internal List<InnerRolePolicyFactory> PoliciesFactories { get; set; } = [];

    protected override Humidifier.IAM.Role Create()
    {
        var roleResult = CreateRole();
        factoryAction?.Invoke(roleResult);

        return roleResult;
    }

    private Humidifier.IAM.Role CreateRole()
    {
        var roleResult = new Humidifier.IAM.Role
        {
            GivenName = InputResourceName,
        };

        return roleResult;
    }
    public override void CreateChildren(Humidifier.IAM.Role result)
    {
        base.CreateChildren(result);

        result.Policies = PoliciesFactories.Any() ? PoliciesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RoleFactoryExtensions
{
    public static CombinedResult<RoleFactory, InnerRolePolicyFactory> WithPolicies(this RoleFactory parentFactory, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null)
    {
        var factory = new InnerRolePolicyFactory(subFactoryAction);
        parentFactory.PoliciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RoleFactory, T1, InnerRolePolicyFactory> WithPolicies<T1>(this CombinedResult<RoleFactory, T1> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoleFactory, InnerRolePolicyFactory> WithPolicies<T1>(this CombinedResult<T1, RoleFactory> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RoleFactory, T1, T2, InnerRolePolicyFactory> WithPolicies<T1, T2>(this CombinedResult<RoleFactory, T1, T2> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoleFactory, T2, InnerRolePolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, RoleFactory, T2> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoleFactory, InnerRolePolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, T2, RoleFactory> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RoleFactory, T1, T2, T3, InnerRolePolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<RoleFactory, T1, T2, T3> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoleFactory, T2, T3, InnerRolePolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, RoleFactory, T2, T3> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoleFactory, T3, InnerRolePolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, RoleFactory, T3> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoleFactory, InnerRolePolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, RoleFactory> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RoleFactory, T1, T2, T3, T4, InnerRolePolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<RoleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RoleFactory, T2, T3, T4, InnerRolePolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, RoleFactory, T2, T3, T4> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RoleFactory, T3, T4, InnerRolePolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, RoleFactory, T3, T4> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RoleFactory, T4, InnerRolePolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RoleFactory, T4> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RoleFactory, InnerRolePolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RoleFactory> combinedResult, Action<Humidifier.IAM.RoleTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T5, subFactoryAction));
}
