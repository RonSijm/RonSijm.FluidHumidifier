// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class UserPolicyFactory(string resourceName = null, Action<Humidifier.IAM.UserPolicy> factoryAction = null) : ResourceFactory<Humidifier.IAM.UserPolicy>(resourceName)
{

    protected override Humidifier.IAM.UserPolicy Create()
    {
        var userPolicyResult = CreateUserPolicy();
        factoryAction?.Invoke(userPolicyResult);

        return userPolicyResult;
    }

    private Humidifier.IAM.UserPolicy CreateUserPolicy()
    {
        var userPolicyResult = new Humidifier.IAM.UserPolicy
        {
            GivenName = InputResourceName,
        };

        return userPolicyResult;
    }

} // End Of Class

public static class UserPolicyFactoryExtensions
{
}
