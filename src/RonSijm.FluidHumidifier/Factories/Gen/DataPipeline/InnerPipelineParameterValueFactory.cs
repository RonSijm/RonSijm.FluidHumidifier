// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataPipeline;

public class InnerPipelineParameterValueFactory(Action<Humidifier.DataPipeline.PipelineTypes.ParameterValue> factoryAction = null) : SubResourceFactory<Humidifier.DataPipeline.PipelineTypes.ParameterValue>
{

    protected override Humidifier.DataPipeline.PipelineTypes.ParameterValue Create()
    {
        var parameterValueResult = CreateParameterValue();
        factoryAction?.Invoke(parameterValueResult);

        return parameterValueResult;
    }

    private Humidifier.DataPipeline.PipelineTypes.ParameterValue CreateParameterValue()
    {
        var parameterValueResult = new Humidifier.DataPipeline.PipelineTypes.ParameterValue();

        return parameterValueResult;
    }

} // End Of Class

public static class InnerPipelineParameterValueFactoryExtensions
{
}
