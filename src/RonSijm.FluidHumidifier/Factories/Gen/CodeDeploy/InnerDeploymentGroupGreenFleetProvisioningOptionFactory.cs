// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupGreenFleetProvisioningOptionFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GreenFleetProvisioningOption> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.GreenFleetProvisioningOption>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.GreenFleetProvisioningOption Create()
    {
        var greenFleetProvisioningOptionResult = CreateGreenFleetProvisioningOption();
        factoryAction?.Invoke(greenFleetProvisioningOptionResult);

        return greenFleetProvisioningOptionResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.GreenFleetProvisioningOption CreateGreenFleetProvisioningOption()
    {
        var greenFleetProvisioningOptionResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.GreenFleetProvisioningOption();

        return greenFleetProvisioningOptionResult;
    }

} // End Of Class

public static class InnerDeploymentGroupGreenFleetProvisioningOptionFactoryExtensions
{
}
