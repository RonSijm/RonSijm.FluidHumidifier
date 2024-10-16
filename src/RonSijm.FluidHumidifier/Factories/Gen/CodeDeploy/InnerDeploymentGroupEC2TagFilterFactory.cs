// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupEC2TagFilterFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter Create()
    {
        var eC2TagFilterResult = CreateEC2TagFilter();
        factoryAction?.Invoke(eC2TagFilterResult);

        return eC2TagFilterResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter CreateEC2TagFilter()
    {
        var eC2TagFilterResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagFilter();

        return eC2TagFilterResult;
    }

} // End Of Class

public static class InnerDeploymentGroupEC2TagFilterFactoryExtensions
{
}
