// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeSourceDynamoDBStreamParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters>
{

    internal InnerPipeDeadLetterConfigFactory DeadLetterConfigFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters Create()
    {
        var pipeSourceDynamoDBStreamParametersResult = CreatePipeSourceDynamoDBStreamParameters();
        factoryAction?.Invoke(pipeSourceDynamoDBStreamParametersResult);

        return pipeSourceDynamoDBStreamParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters CreatePipeSourceDynamoDBStreamParameters()
    {
        var pipeSourceDynamoDBStreamParametersResult = new Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters();

        return pipeSourceDynamoDBStreamParametersResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.PipeSourceDynamoDBStreamParameters result)
    {
        base.CreateChildren(result);

        result.DeadLetterConfig ??= DeadLetterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerPipePipeSourceDynamoDBStreamParametersFactoryExtensions
{
    public static CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig(this InnerPipePipeSourceDynamoDBStreamParametersFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null)
    {
        parentFactory.DeadLetterConfigFactory = new InnerPipeDeadLetterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeadLetterConfigFactory);
    }

    public static CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, T2, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, T2, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceDynamoDBStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, T2, InnerPipePipeSourceDynamoDBStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, T2, T3, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, T2, T3, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceDynamoDBStreamParametersFactory, T3, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipePipeSourceDynamoDBStreamParametersFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceDynamoDBStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceDynamoDBStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, T2, T3, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<InnerPipePipeSourceDynamoDBStreamParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, T2, T3, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipePipeSourceDynamoDBStreamParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipePipeSourceDynamoDBStreamParametersFactory, T3, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipePipeSourceDynamoDBStreamParametersFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipePipeSourceDynamoDBStreamParametersFactory, T4, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipePipeSourceDynamoDBStreamParametersFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceDynamoDBStreamParametersFactory, InnerPipeDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipePipeSourceDynamoDBStreamParametersFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T5, subFactoryAction));
}
