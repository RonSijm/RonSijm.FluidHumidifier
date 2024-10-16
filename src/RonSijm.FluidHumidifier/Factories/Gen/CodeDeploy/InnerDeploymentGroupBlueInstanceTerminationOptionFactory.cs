// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupBlueInstanceTerminationOptionFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.BlueInstanceTerminationOption> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.BlueInstanceTerminationOption>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.BlueInstanceTerminationOption Create()
    {
        var blueInstanceTerminationOptionResult = CreateBlueInstanceTerminationOption();
        factoryAction?.Invoke(blueInstanceTerminationOptionResult);

        return blueInstanceTerminationOptionResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.BlueInstanceTerminationOption CreateBlueInstanceTerminationOption()
    {
        var blueInstanceTerminationOptionResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.BlueInstanceTerminationOption();

        return blueInstanceTerminationOptionResult;
    }

} // End Of Class

public static class InnerDeploymentGroupBlueInstanceTerminationOptionFactoryExtensions
{
}
