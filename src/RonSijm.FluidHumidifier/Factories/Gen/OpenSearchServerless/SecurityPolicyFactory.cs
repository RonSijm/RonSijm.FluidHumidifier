// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class SecurityPolicyFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.SecurityPolicy> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.SecurityPolicy>(resourceName)
{

    protected override Humidifier.OpenSearchServerless.SecurityPolicy Create()
    {
        var securityPolicyResult = CreateSecurityPolicy();
        factoryAction?.Invoke(securityPolicyResult);

        return securityPolicyResult;
    }

    private Humidifier.OpenSearchServerless.SecurityPolicy CreateSecurityPolicy()
    {
        var securityPolicyResult = new Humidifier.OpenSearchServerless.SecurityPolicy
        {
            GivenName = InputResourceName,
        };

        return securityPolicyResult;
    }

} // End Of Class

public static class SecurityPolicyFactoryExtensions
{
}
