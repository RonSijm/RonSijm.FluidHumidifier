// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class PolicyAssociationFactory(string resourceName = null, Action<Humidifier.SecurityHub.PolicyAssociation> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.PolicyAssociation>(resourceName)
{

    protected override Humidifier.SecurityHub.PolicyAssociation Create()
    {
        var policyAssociationResult = CreatePolicyAssociation();
        factoryAction?.Invoke(policyAssociationResult);

        return policyAssociationResult;
    }

    private Humidifier.SecurityHub.PolicyAssociation CreatePolicyAssociation()
    {
        var policyAssociationResult = new Humidifier.SecurityHub.PolicyAssociation
        {
            GivenName = InputResourceName,
        };

        return policyAssociationResult;
    }

} // End Of Class

public static class PolicyAssociationFactoryExtensions
{
}
