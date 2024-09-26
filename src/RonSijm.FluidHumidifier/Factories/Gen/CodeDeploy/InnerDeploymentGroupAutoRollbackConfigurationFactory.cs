// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupAutoRollbackConfigurationFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.AutoRollbackConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.AutoRollbackConfiguration>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.AutoRollbackConfiguration Create()
    {
        var autoRollbackConfigurationResult = CreateAutoRollbackConfiguration();
        factoryAction?.Invoke(autoRollbackConfigurationResult);

        return autoRollbackConfigurationResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.AutoRollbackConfiguration CreateAutoRollbackConfiguration()
    {
        var autoRollbackConfigurationResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.AutoRollbackConfiguration();

        return autoRollbackConfigurationResult;
    }

} // End Of Class

public static class InnerDeploymentGroupAutoRollbackConfigurationFactoryExtensions
{
}
