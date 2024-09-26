// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class InnerStateMachineAliasDeploymentPreferenceFactory(Action<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference> factoryAction = null) : SubResourceFactory<Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference>
{

    protected override Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference Create()
    {
        var deploymentPreferenceResult = CreateDeploymentPreference();
        factoryAction?.Invoke(deploymentPreferenceResult);

        return deploymentPreferenceResult;
    }

    private Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference CreateDeploymentPreference()
    {
        var deploymentPreferenceResult = new Humidifier.StepFunctions.StateMachineAliasTypes.DeploymentPreference();

        return deploymentPreferenceResult;
    }

} // End Of Class

public static class InnerStateMachineAliasDeploymentPreferenceFactoryExtensions
{
}
