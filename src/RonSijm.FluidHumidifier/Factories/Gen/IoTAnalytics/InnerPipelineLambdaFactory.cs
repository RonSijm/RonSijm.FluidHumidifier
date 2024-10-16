// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineLambdaFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.Lambda> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.Lambda>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.Lambda Create()
    {
        var lambdaResult = CreateLambda();
        factoryAction?.Invoke(lambdaResult);

        return lambdaResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.Lambda CreateLambda()
    {
        var lambdaResult = new Humidifier.IoTAnalytics.PipelineTypes.Lambda();

        return lambdaResult;
    }

} // End Of Class

public static class InnerPipelineLambdaFactoryExtensions
{
}
