// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDeploymentCanarySettingFactory(Action<Humidifier.ApiGateway.DeploymentTypes.CanarySetting> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DeploymentTypes.CanarySetting>
{

    protected override Humidifier.ApiGateway.DeploymentTypes.CanarySetting Create()
    {
        var canarySettingResult = CreateCanarySetting();
        factoryAction?.Invoke(canarySettingResult);

        return canarySettingResult;
    }

    private Humidifier.ApiGateway.DeploymentTypes.CanarySetting CreateCanarySetting()
    {
        var canarySettingResult = new Humidifier.ApiGateway.DeploymentTypes.CanarySetting();

        return canarySettingResult;
    }

} // End Of Class

public static class InnerDeploymentCanarySettingFactoryExtensions
{
}
