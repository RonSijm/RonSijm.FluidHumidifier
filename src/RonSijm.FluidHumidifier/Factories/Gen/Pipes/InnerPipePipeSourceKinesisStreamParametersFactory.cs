// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeSourceKinesisStreamParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters>
{

    internal InnerPipeDeadLetterConfigFactory DeadLetterConfigFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters Create()
    {
        var pipeSourceKinesisStreamParametersResult = CreatePipeSourceKinesisStreamParameters();
        factoryAction?.Invoke(pipeSourceKinesisStreamParametersResult);

        return pipeSourceKinesisStreamParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters CreatePipeSourceKinesisStreamParameters()
    {
        var pipeSourceKinesisStreamParametersResult = new Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters();

        return pipeSourceKinesisStreamParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeSourceKinesisStreamParameters result)
    {
        base.CreateChildren(result);

        result.DeadLetterConfig ??= DeadLetterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeSourceKinesisStreamParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig(this InnerPipePipeSourceKinesisStreamParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null)
    {
        parentFactory.DeadLetterConfigFactory = new InnerPipeDeadLetterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeadLetterConfigFactory);
    }

    public static CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, T2, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, T2, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceKinesisStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeSourceKinesisStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, T2, T3, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, T2, T3, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceKinesisStreamParametersFactory, T3, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeSourceKinesisStreamParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceKinesisStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceKinesisStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, T2, T3, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeSourceKinesisStreamParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, T2, T3, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeSourceKinesisStreamParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceKinesisStreamParametersFactory, T3, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeSourceKinesisStreamParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceKinesisStreamParametersFactory, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceKinesisStreamParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceKinesisStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceKinesisStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T5, subFactoryAction));
}
