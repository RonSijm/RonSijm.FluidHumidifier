// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeEnrichmentHttpParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters Create()
    {
        var pipeEnrichmentHttpParametersResult = CreatePipeEnrichmentHttpParameters();
        factoryAction?.Invoke(pipeEnrichmentHttpParametersResult);

        return pipeEnrichmentHttpParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters CreatePipeEnrichmentHttpParameters()
    {
        var pipeEnrichmentHttpParametersResult = new Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters();

        return pipeEnrichmentHttpParametersResult;
    }

} // End Of Class

public static class InnerPipePipeEnrichmentHttpParametersFactoryExtensions
{
}
