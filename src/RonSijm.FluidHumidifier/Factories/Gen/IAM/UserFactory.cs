// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class UserFactory(string resourceName = null, Action<Humidifier.IAM.User> factoryAction = null) : ResourceFactory<Humidifier.IAM.User>(resourceName)
{

    internal List<InnerUserPolicyFactory> PoliciesFactories { get; set; } = [];

    internal InnerUserLoginProfileFactory LoginProfileFactory { get; set; }

    protected override Humidifier.IAM.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.IAM.User CreateUser()
    {
        var userResult = new Humidifier.IAM.User
        {
            GivenName = InputResourceName,
        };

        return userResult;
    }
    public override void CreateChildren(Humidifier.IAM.User result)
    {
        base.CreateChildren(result);

        result.Policies = PoliciesFactories.Any() ? PoliciesFactories.Select(x => x.Build()).ToList() : null;
        result.LoginProfile ??= LoginProfileFactory?.Build();
    }

} // End Of Class

public static class UserFactoryExtensions
{
    public static CombinedResult<UserFactory, InnerUserPolicyFactory> WithPolicies(this UserFactory parentFactory, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null)
    {
        var factory = new InnerUserPolicyFactory(subFactoryAction);
        parentFactory.PoliciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserFactory, InnerUserLoginProfileFactory> WithLoginProfile(this UserFactory parentFactory, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null)
    {
        parentFactory.LoginProfileFactory = new InnerUserLoginProfileFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoginProfileFactory);
    }

    public static CombinedResult<UserFactory, T1, InnerUserPolicyFactory> WithPolicies<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserPolicyFactory> WithPolicies<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserFactory, T1, InnerUserLoginProfileFactory> WithLoginProfile<T1>(this CombinedResult<UserFactory, T1> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoginProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, InnerUserLoginProfileFactory> WithLoginProfile<T1>(this CombinedResult<T1, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoginProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2>(this CombinedResult<UserFactory, T1, T2> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2>(this CombinedResult<T1, UserFactory, T2> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2>(this CombinedResult<T1, T2, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3>(this CombinedResult<UserFactory, T1, T2, T3> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3>(this CombinedResult<T1, UserFactory, T2, T3> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3>(this CombinedResult<T1, T2, UserFactory, T3> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserFactory, T1, T2, T3, T4, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3, T4>(this CombinedResult<UserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserFactory, T2, T3, T4, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3, T4>(this CombinedResult<T1, UserFactory, T2, T3, T4> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserFactory, T3, T4, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserFactory, T3, T4> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserFactory, T4, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserFactory, T4> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserFactory, InnerUserLoginProfileFactory> WithLoginProfile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserFactory> combinedResult, Action<Humidifier.IAM.UserTypes.LoginProfile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoginProfile(combinedResult.T5, subFactoryAction));
}
