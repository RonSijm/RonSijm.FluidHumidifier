// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerStageCanarySettingFactory(Action<Humidifier.ApiGateway.StageTypes.CanarySetting> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.StageTypes.CanarySetting>
{

    protected override Humidifier.ApiGateway.StageTypes.CanarySetting Create()
    {
        var canarySettingResult = CreateCanarySetting();
        factoryAction?.Invoke(canarySettingResult);

        return canarySettingResult;
    }

    private Humidifier.ApiGateway.StageTypes.CanarySetting CreateCanarySetting()
    {
        var canarySettingResult = new Humidifier.ApiGateway.StageTypes.CanarySetting();

        return canarySettingResult;
    }

} // End Of Class

public static class InnerStageCanarySettingFactoryExtensions
{
}
