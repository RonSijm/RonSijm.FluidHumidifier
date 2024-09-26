// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeEnrichmentParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters>
{

    internal InnerPipePipeEnrichmentHttpParametersFactory HttpParametersFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters Create()
    {
        var pipeEnrichmentParametersResult = CreatePipeEnrichmentParameters();
        factoryAction?.Invoke(pipeEnrichmentParametersResult);

        return pipeEnrichmentParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters CreatePipeEnrichmentParameters()
    {
        var pipeEnrichmentParametersResult = new Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters();

        return pipeEnrichmentParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeEnrichmentParameters result)
    {
        base.CreateChildren(result);

        result.HttpParameters ??= HttpParametersFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeEnrichmentParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeEnrichmentParametersFactory, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters(this InnerPipePipeEnrichmentParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null)
    {
        parentFactory.HttpParametersFactory = new InnerPipePipeEnrichmentHttpParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HttpParametersFactory);
    }

    public static CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1>(this CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1>(this CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, T2, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2>(this CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, T2, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2>(this CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeEnrichmentParametersFactory, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeEnrichmentParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, T2, T3, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3>(this CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, T2, T3, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeEnrichmentParametersFactory, T3, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeEnrichmentParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeEnrichmentParametersFactory, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeEnrichmentParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, T2, T3, T4, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeEnrichmentParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, T2, T3, T4, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeEnrichmentParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeEnrichmentParametersFactory, T3, T4, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeEnrichmentParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeEnrichmentParametersFactory, T4, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeEnrichmentParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeEnrichmentParametersFactory, InnerPipePipeEnrichmentHttpParametersFactory> WithHttpParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeEnrichmentParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.PipeEnrichmentHttpParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpParameters(combinedResult.T5, subFactoryAction));
}
