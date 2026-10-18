// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetLambdaFunctionParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetLambdaFunctionParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetLambdaFunctionParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetLambdaFunctionParameters Create()
    {
        var pipeTargetLambdaFunctionParametersResult = CreatePipeTargetLambdaFunctionParameters();
        factoryAction?.Invoke(pipeTargetLambdaFunctionParametersResult);

        return pipeTargetLambdaFunctionParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetLambdaFunctionParameters CreatePipeTargetLambdaFunctionParameters()
    {
        var pipeTargetLambdaFunctionParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetLambdaFunctionParameters();

        return pipeTargetLambdaFunctionParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetLambdaFunctionParametersFactoryExtensions
{
}
