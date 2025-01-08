// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolPoliciesFactory(Action<Humidifier.Cognito.UserPoolTypes.Policies> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.Policies>
{

    internal InnerUserPoolPasswordPolicyFactory PasswordPolicyFactory { get; set; }

    internal InnerUserPoolSignInPolicyFactory SignInPolicyFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolTypes.Policies Create()
    {
        var policiesResult = CreatePolicies();
        factoryAction?.Invoke(policiesResult);

        return policiesResult;
    }

    private Humidifier.Cognito.UserPoolTypes.Policies CreatePolicies()
    {
        var policiesResult = new Humidifier.Cognito.UserPoolTypes.Policies();

        return policiesResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolTypes.Policies result)
    {
        base.CreateChildren(result);

        result.PasswordPolicy ??= PasswordPolicyFactory?.Build();
        result.SignInPolicy ??= SignInPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerUserPoolPoliciesFactoryExtensions
{
    public static CombinedResult<InnerUserPoolPoliciesFactory, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy(this InnerUserPoolPoliciesFactory parentFactory, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null)
    {
        parentFactory.PasswordPolicyFactory = new InnerUserPoolPasswordPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PasswordPolicyFactory);
    }

    public static CombinedResult<InnerUserPoolPoliciesFactory, InnerUserPoolSignInPolicyFactory> WithSignInPolicy(this InnerUserPoolPoliciesFactory parentFactory, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null)
    {
        parentFactory.SignInPolicyFactory = new InnerUserPoolSignInPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SignInPolicyFactory);
    }

    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1>(this CombinedResult<InnerUserPoolPoliciesFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1>(this CombinedResult<T1, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2>(this CombinedResult<InnerUserPoolPoliciesFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2>(this CombinedResult<T1, InnerUserPoolPoliciesFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3>(this CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3, T4, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3, T4, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3, T4, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory, T4, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolPoliciesFactory, InnerUserPoolPasswordPolicyFactory> WithPasswordPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPasswordPolicy(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1>(this CombinedResult<InnerUserPoolPoliciesFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1>(this CombinedResult<T1, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithSignInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2>(this CombinedResult<InnerUserPoolPoliciesFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2>(this CombinedResult<T1, InnerUserPoolPoliciesFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2>(this CombinedResult<T1, T2, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3>(this CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3>(this CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3, T4, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3, T4>(this CombinedResult<InnerUserPoolPoliciesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3, T4, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerUserPoolPoliciesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3, T4, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerUserPoolPoliciesFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory, T4, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerUserPoolPoliciesFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerUserPoolPoliciesFactory, InnerUserPoolSignInPolicyFactory> WithSignInPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerUserPoolPoliciesFactory> combinedResult, Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSignInPolicy(combinedResult.T5, subFactoryAction));
}
