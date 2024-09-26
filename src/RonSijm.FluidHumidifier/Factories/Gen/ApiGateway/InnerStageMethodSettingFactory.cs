// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerStageMethodSettingFactory(Action<Humidifier.ApiGateway.StageTypes.MethodSetting> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.StageTypes.MethodSetting>
{

    protected override Humidifier.ApiGateway.StageTypes.MethodSetting Create()
    {
        var methodSettingResult = CreateMethodSetting();
        factoryAction?.Invoke(methodSettingResult);

        return methodSettingResult;
    }

    private Humidifier.ApiGateway.StageTypes.MethodSetting CreateMethodSetting()
    {
        var methodSettingResult = new Humidifier.ApiGateway.StageTypes.MethodSetting();

        return methodSettingResult;
    }

} // End Of Class

public static class InnerStageMethodSettingFactoryExtensions
{
}
