// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetRedshiftDataParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetRedshiftDataParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetRedshiftDataParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetRedshiftDataParameters Create()
    {
        var pipeTargetRedshiftDataParametersResult = CreatePipeTargetRedshiftDataParameters();
        factoryAction?.Invoke(pipeTargetRedshiftDataParametersResult);

        return pipeTargetRedshiftDataParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetRedshiftDataParameters CreatePipeTargetRedshiftDataParameters()
    {
        var pipeTargetRedshiftDataParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetRedshiftDataParameters();

        return pipeTargetRedshiftDataParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetRedshiftDataParametersFactoryExtensions
{
}
