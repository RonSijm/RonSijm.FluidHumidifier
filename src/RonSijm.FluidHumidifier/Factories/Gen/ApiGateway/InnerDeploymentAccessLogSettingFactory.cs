// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDeploymentAccessLogSettingFactory(Action<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting>
{

    protected override Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting Create()
    {
        var accessLogSettingResult = CreateAccessLogSetting();
        factoryAction?.Invoke(accessLogSettingResult);

        return accessLogSettingResult;
    }

    private Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting CreateAccessLogSetting()
    {
        var accessLogSettingResult = new Humidifier.ApiGateway.DeploymentTypes.AccessLogSetting();

        return accessLogSettingResult;
    }

} // End Of Class

public static class InnerDeploymentAccessLogSettingFactoryExtensions
{
}
