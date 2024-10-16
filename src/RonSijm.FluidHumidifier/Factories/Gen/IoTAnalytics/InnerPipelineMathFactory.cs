// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineMathFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.Math> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.Math>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.Math Create()
    {
        var mathResult = CreateMath();
        factoryAction?.Invoke(mathResult);

        return mathResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.Math CreateMath()
    {
        var mathResult = new Humidifier.IoTAnalytics.PipelineTypes.Math();

        return mathResult;
    }

} // End Of Class

public static class InnerPipelineMathFactoryExtensions
{
}
