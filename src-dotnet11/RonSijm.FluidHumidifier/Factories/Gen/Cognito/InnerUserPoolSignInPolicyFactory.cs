// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolSignInPolicyFactory(Action<Humidifier.Cognito.UserPoolTypes.SignInPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.SignInPolicy>
{

    protected override Humidifier.Cognito.UserPoolTypes.SignInPolicy Create()
    {
        var signInPolicyResult = CreateSignInPolicy();
        factoryAction?.Invoke(signInPolicyResult);

        return signInPolicyResult;
    }

    private Humidifier.Cognito.UserPoolTypes.SignInPolicy CreateSignInPolicy()
    {
        var signInPolicyResult = new Humidifier.Cognito.UserPoolTypes.SignInPolicy();

        return signInPolicyResult;
    }

} // End Of Class

public static class InnerUserPoolSignInPolicyFactoryExtensions
{
}
