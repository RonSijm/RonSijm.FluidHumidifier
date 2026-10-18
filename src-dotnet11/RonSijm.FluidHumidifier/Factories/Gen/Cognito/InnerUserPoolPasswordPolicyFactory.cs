// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerUserPoolPasswordPolicyFactory(Action<Humidifier.Cognito.UserPoolTypes.PasswordPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.UserPoolTypes.PasswordPolicy>
{

    protected override Humidifier.Cognito.UserPoolTypes.PasswordPolicy Create()
    {
        var passwordPolicyResult = CreatePasswordPolicy();
        factoryAction?.Invoke(passwordPolicyResult);

        return passwordPolicyResult;
    }

    private Humidifier.Cognito.UserPoolTypes.PasswordPolicy CreatePasswordPolicy()
    {
        var passwordPolicyResult = new Humidifier.Cognito.UserPoolTypes.PasswordPolicy();

        return passwordPolicyResult;
    }

} // End Of Class

public static class InnerUserPoolPasswordPolicyFactoryExtensions
{
}
