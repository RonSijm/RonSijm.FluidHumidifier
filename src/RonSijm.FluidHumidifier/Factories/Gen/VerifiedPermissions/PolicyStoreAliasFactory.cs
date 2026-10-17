// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class PolicyStoreAliasFactory(string resourceName = null, Action<Humidifier.VerifiedPermissions.PolicyStoreAlias> factoryAction = null) : ResourceFactory<Humidifier.VerifiedPermissions.PolicyStoreAlias>(resourceName)
{

    protected override Humidifier.VerifiedPermissions.PolicyStoreAlias Create()
    {
        var policyStoreAliasResult = CreatePolicyStoreAlias();
        factoryAction?.Invoke(policyStoreAliasResult);

        return policyStoreAliasResult;
    }

    private Humidifier.VerifiedPermissions.PolicyStoreAlias CreatePolicyStoreAlias()
    {
        var policyStoreAliasResult = new Humidifier.VerifiedPermissions.PolicyStoreAlias
        {
            GivenName = InputResourceName,
        };

        return policyStoreAliasResult;
    }

} // End Of Class

public static class PolicyStoreAliasFactoryExtensions
{
}
