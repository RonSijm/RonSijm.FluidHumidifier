// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerStageAccessLogSettingFactory(Action<Humidifier.ApiGateway.StageTypes.AccessLogSetting> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.StageTypes.AccessLogSetting>
{

    protected override Humidifier.ApiGateway.StageTypes.AccessLogSetting Create()
    {
        var accessLogSettingResult = CreateAccessLogSetting();
        factoryAction?.Invoke(accessLogSettingResult);

        return accessLogSettingResult;
    }

    private Humidifier.ApiGateway.StageTypes.AccessLogSetting CreateAccessLogSetting()
    {
        var accessLogSettingResult = new Humidifier.ApiGateway.StageTypes.AccessLogSetting();

        return accessLogSettingResult;
    }

} // End Of Class

public static class InnerStageAccessLogSettingFactoryExtensions
{
}
