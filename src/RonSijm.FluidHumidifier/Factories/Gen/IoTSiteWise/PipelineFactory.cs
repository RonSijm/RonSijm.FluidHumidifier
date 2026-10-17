// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class PipelineFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Pipeline> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Pipeline>(resourceName)
{

    internal List<InnerPipelineComputeNodeFactory> ComputationsFactories { get; set; } = [];

    protected override Humidifier.IoTSiteWise.Pipeline Create()
    {
        var pipelineResult = CreatePipeline();
        factoryAction?.Invoke(pipelineResult);

        return pipelineResult;
    }

    private Humidifier.IoTSiteWise.Pipeline CreatePipeline()
    {
        var pipelineResult = new Humidifier.IoTSiteWise.Pipeline
        {
            GivenName = InputResourceName,
        };

        return pipelineResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Pipeline result)
    {
        base.CreateChildren(result);

        result.Computations = ComputationsFactories.Any() ? ComputationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PipelineFactoryExtensions
{
    public static CombinedResult<PipelineFactory, InnerPipelineComputeNodeFactory> WithComputations(this PipelineFactory parentFactory, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null)
    {
        var factory = new InnerPipelineComputeNodeFactory(subFactoryAction);
        parentFactory.ComputationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PipelineFactory, T1, InnerPipelineComputeNodeFactory> WithComputations<T1>(this CombinedResult<PipelineFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PipelineFactory, InnerPipelineComputeNodeFactory> WithComputations<T1>(this CombinedResult<T1, PipelineFactory> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PipelineFactory, T1, T2, InnerPipelineComputeNodeFactory> WithComputations<T1, T2>(this CombinedResult<PipelineFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PipelineFactory, T2, InnerPipelineComputeNodeFactory> WithComputations<T1, T2>(this CombinedResult<T1, PipelineFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PipelineFactory, InnerPipelineComputeNodeFactory> WithComputations<T1, T2>(this CombinedResult<T1, T2, PipelineFactory> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PipelineFactory, T1, T2, T3, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3>(this CombinedResult<PipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PipelineFactory, T2, T3, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3>(this CombinedResult<T1, PipelineFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PipelineFactory, T3, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3>(this CombinedResult<T1, T2, PipelineFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PipelineFactory, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3>(this CombinedResult<T1, T2, T3, PipelineFactory> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PipelineFactory, T1, T2, T3, T4, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3, T4>(this CombinedResult<PipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PipelineFactory, T2, T3, T4, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3, T4>(this CombinedResult<T1, PipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PipelineFactory, T3, T4, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3, T4>(this CombinedResult<T1, T2, PipelineFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PipelineFactory, T4, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PipelineFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PipelineFactory, InnerPipelineComputeNodeFactory> WithComputations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PipelineFactory> combinedResult, Action<Humidifier.IoTSiteWise.PipelineTypes.ComputeNode> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputations(combinedResult.T5, subFactoryAction).T2);
}
