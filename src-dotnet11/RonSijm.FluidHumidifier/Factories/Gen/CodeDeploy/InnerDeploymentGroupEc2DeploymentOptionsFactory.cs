// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupEc2DeploymentOptionsFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.Ec2DeploymentOptions> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.Ec2DeploymentOptions>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.Ec2DeploymentOptions Create()
    {
        var ec2DeploymentOptionsResult = CreateEc2DeploymentOptions();
        factoryAction?.Invoke(ec2DeploymentOptionsResult);

        return ec2DeploymentOptionsResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.Ec2DeploymentOptions CreateEc2DeploymentOptions()
    {
        var ec2DeploymentOptionsResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.Ec2DeploymentOptions();

        return ec2DeploymentOptionsResult;
    }

} // End Of Class

public static class InnerDeploymentGroupEc2DeploymentOptionsFactoryExtensions
{
}
