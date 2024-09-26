// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class PolicyTemplateFactory(string resourceName = null, Action<Humidifier.VerifiedPermissions.PolicyTemplate> factoryAction = null) : ResourceFactory<Humidifier.VerifiedPermissions.PolicyTemplate>(resourceName)
{

    protected override Humidifier.VerifiedPermissions.PolicyTemplate Create()
    {
        var policyTemplateResult = CreatePolicyTemplate();
        factoryAction?.Invoke(policyTemplateResult);

        return policyTemplateResult;
    }

    private Humidifier.VerifiedPermissions.PolicyTemplate CreatePolicyTemplate()
    {
        var policyTemplateResult = new Humidifier.VerifiedPermissions.PolicyTemplate
        {
            GivenName = InputResourceName,
        };

        return policyTemplateResult;
    }

} // End Of Class

public static class PolicyTemplateFactoryExtensions
{
}
