// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupTriggerConfigFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig Create()
    {
        var triggerConfigResult = CreateTriggerConfig();
        factoryAction?.Invoke(triggerConfigResult);

        return triggerConfigResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig CreateTriggerConfig()
    {
        var triggerConfigResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.TriggerConfig();

        return triggerConfigResult;
    }

} // End Of Class

public static class InnerDeploymentGroupTriggerConfigFactoryExtensions
{
}
