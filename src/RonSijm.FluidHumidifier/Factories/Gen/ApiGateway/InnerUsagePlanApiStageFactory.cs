// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerUsagePlanApiStageFactory(Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.UsagePlanTypes.ApiStage>
{

    protected override Humidifier.ApiGateway.UsagePlanTypes.ApiStage Create()
    {
        var apiStageResult = CreateApiStage();
        factoryAction?.Invoke(apiStageResult);

        return apiStageResult;
    }

    private Humidifier.ApiGateway.UsagePlanTypes.ApiStage CreateApiStage()
    {
        var apiStageResult = new Humidifier.ApiGateway.UsagePlanTypes.ApiStage();

        return apiStageResult;
    }

} // End Of Class

public static class InnerUsagePlanApiStageFactoryExtensions
{
}
