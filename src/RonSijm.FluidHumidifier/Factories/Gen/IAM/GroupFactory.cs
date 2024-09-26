// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class GroupFactory(string resourceName = null, Action<Humidifier.IAM.Group> factoryAction = null) : ResourceFactory<Humidifier.IAM.Group>(resourceName)
{

    internal List<InnerGroupPolicyFactory> PoliciesFactories { get; set; } = [];

    protected override Humidifier.IAM.Group Create()
    {
        var groupResult = CreateGroup();
        factoryAction?.Invoke(groupResult);

        return groupResult;
    }

    private Humidifier.IAM.Group CreateGroup()
    {
        var groupResult = new Humidifier.IAM.Group
        {
            GivenName = InputResourceName,
        };

        return groupResult;
    }
    public override void CreateChildren(Humidifier.IAM.Group result)
    {
        base.CreateChildren(result);

        result.Policies = PoliciesFactories.Any() ? PoliciesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GroupFactoryExtensions
{
    public static CombinedResult<GroupFactory, InnerGroupPolicyFactory> WithPolicies(this GroupFactory parentFactory, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null)
    {
        var factory = new InnerGroupPolicyFactory(subFactoryAction);
        parentFactory.PoliciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GroupFactory, T1, InnerGroupPolicyFactory> WithPolicies<T1>(this CombinedResult<GroupFactory, T1> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, InnerGroupPolicyFactory> WithPolicies<T1>(this CombinedResult<T1, GroupFactory> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, InnerGroupPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<GroupFactory, T1, T2> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, InnerGroupPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, GroupFactory, T2> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, InnerGroupPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, T2, GroupFactory> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<GroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, GroupFactory, T2, T3> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, GroupFactory, T3> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupFactory> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GroupFactory, T1, T2, T3, T4, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<GroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupFactory, T2, T3, T4, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, GroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupFactory, T3, T4, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupFactory, T3, T4> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupFactory, T4, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupFactory, T4> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GroupFactory, InnerGroupPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupFactory> combinedResult, Action<Humidifier.IAM.GroupTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T5, subFactoryAction));
}
