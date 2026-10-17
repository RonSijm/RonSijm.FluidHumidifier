// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerDeploymentAssociatedPolicyFactory(Action<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy>
{

    protected override Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy Create()
    {
        var associatedPolicyResult = CreateAssociatedPolicy();
        factoryAction?.Invoke(associatedPolicyResult);

        return associatedPolicyResult;
    }

    private Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy CreateAssociatedPolicy()
    {
        var associatedPolicyResult = new Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedPolicy();

        return associatedPolicyResult;
    }

} // End Of Class

public static class InnerDeploymentAssociatedPolicyFactoryExtensions
{
}
