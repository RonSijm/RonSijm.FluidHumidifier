// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceForceNewDeploymentFactory(Action<Humidifier.ECS.ServiceTypes.ForceNewDeployment> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ForceNewDeployment>
{

    protected override Humidifier.ECS.ServiceTypes.ForceNewDeployment Create()
    {
        var forceNewDeploymentResult = CreateForceNewDeployment();
        factoryAction?.Invoke(forceNewDeploymentResult);

        return forceNewDeploymentResult;
    }

    private Humidifier.ECS.ServiceTypes.ForceNewDeployment CreateForceNewDeployment()
    {
        var forceNewDeploymentResult = new Humidifier.ECS.ServiceTypes.ForceNewDeployment();

        return forceNewDeploymentResult;
    }

} // End Of Class

public static class InnerServiceForceNewDeploymentFactoryExtensions
{
}
