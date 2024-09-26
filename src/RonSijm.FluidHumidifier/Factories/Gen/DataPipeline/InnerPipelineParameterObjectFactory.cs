// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataPipeline;

public class InnerPipelineParameterObjectFactory(Action<Humidifier.DataPipeline.PipelineTypes.ParameterObject> factoryAction = null) : SubResourceFactory<Humidifier.DataPipeline.PipelineTypes.ParameterObject>
{

    protected override Humidifier.DataPipeline.PipelineTypes.ParameterObject Create()
    {
        var parameterObjectResult = CreateParameterObject();
        factoryAction?.Invoke(parameterObjectResult);

        return parameterObjectResult;
    }

    private Humidifier.DataPipeline.PipelineTypes.ParameterObject CreateParameterObject()
    {
        var parameterObjectResult = new Humidifier.DataPipeline.PipelineTypes.ParameterObject();

        return parameterObjectResult;
    }

} // End Of Class

public static class InnerPipelineParameterObjectFactoryExtensions
{
}
