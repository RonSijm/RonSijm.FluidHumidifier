// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineFailureConditionsFactory(Action<Humidifier.CodePipeline.PipelineTypes.FailureConditions> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.FailureConditions>
{

    internal InnerPipelineRetryConfigurationFactory RetryConfigurationFactory { get; set; }

    protected override Humidifier.CodePipeline.PipelineTypes.FailureConditions Create()
    {
        var failureConditionsResult = CreateFailureConditions();
        factoryAction?.Invoke(failureConditionsResult);

        return failureConditionsResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.FailureConditions CreateFailureConditions()
    {
        var failureConditionsResult = new Humidifier.CodePipeline.PipelineTypes.FailureConditions();

        return failureConditionsResult;
    }
    public override void CreateChildren(Humidifier.CodePipeline.PipelineTypes.FailureConditions result)
    {
        base.CreateChildren(result);

        result.RetryConfiguration ??= RetryConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPipelineFailureConditionsFactoryExtensions
{
    public static CombinedResult<InnerPipelineFailureConditionsFactory, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration(this InnerPipelineFailureConditionsFactory parentFactory, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null)
    {
        parentFactory.RetryConfigurationFactory = new InnerPipelineRetryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetryConfigurationFactory);
    }

    public static CombinedResult<InnerPipelineFailureConditionsFactory, T1, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1>(this CombinedResult<InnerPipelineFailureConditionsFactory, T1> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineFailureConditionsFactory, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1>(this CombinedResult<T1, InnerPipelineFailureConditionsFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelineFailureConditionsFactory, T1, T2, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2>(this CombinedResult<InnerPipelineFailureConditionsFactory, T1, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineFailureConditionsFactory, T2, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2>(this CombinedResult<T1, InnerPipelineFailureConditionsFactory, T2> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineFailureConditionsFactory, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPipelineFailureConditionsFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelineFailureConditionsFactory, T1, T2, T3, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3>(this CombinedResult<InnerPipelineFailureConditionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineFailureConditionsFactory, T2, T3, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPipelineFailureConditionsFactory, T2, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineFailureConditionsFactory, T3, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelineFailureConditionsFactory, T3> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineFailureConditionsFactory, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelineFailureConditionsFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelineFailureConditionsFactory, T1, T2, T3, T4, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPipelineFailureConditionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelineFailureConditionsFactory, T2, T3, T4, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelineFailureConditionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelineFailureConditionsFactory, T3, T4, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelineFailureConditionsFactory, T3, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelineFailureConditionsFactory, T4, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelineFailureConditionsFactory, T4> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelineFailureConditionsFactory, InnerPipelineRetryConfigurationFactory> WithRetryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelineFailureConditionsFactory> combinedResult, Action<Humidifier.CodePipeline.PipelineTypes.RetryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfiguration(combinedResult.T5, subFactoryAction));
}
