// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerDeploymentAssociatedScopeFactory(Action<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope>
{

    protected override Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope Create()
    {
        var associatedScopeResult = CreateAssociatedScope();
        factoryAction?.Invoke(associatedScopeResult);

        return associatedScopeResult;
    }

    private Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope CreateAssociatedScope()
    {
        var associatedScopeResult = new Humidifier.NetworkSecurityManager.DeploymentTypes.AssociatedScope();

        return associatedScopeResult;
    }

} // End Of Class

public static class InnerDeploymentAssociatedScopeFactoryExtensions
{
}
