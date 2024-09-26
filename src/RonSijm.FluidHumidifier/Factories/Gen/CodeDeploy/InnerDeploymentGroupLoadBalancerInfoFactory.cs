// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupLoadBalancerInfoFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.LoadBalancerInfo> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.LoadBalancerInfo>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.LoadBalancerInfo Create()
    {
        var loadBalancerInfoResult = CreateLoadBalancerInfo();
        factoryAction?.Invoke(loadBalancerInfoResult);

        return loadBalancerInfoResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.LoadBalancerInfo CreateLoadBalancerInfo()
    {
        var loadBalancerInfoResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.LoadBalancerInfo();

        return loadBalancerInfoResult;
    }

} // End Of Class

public static class InnerDeploymentGroupLoadBalancerInfoFactoryExtensions
{
}
