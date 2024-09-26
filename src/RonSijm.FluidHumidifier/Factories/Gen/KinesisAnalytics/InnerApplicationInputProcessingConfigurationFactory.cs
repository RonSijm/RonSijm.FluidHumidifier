// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationInputProcessingConfigurationFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputProcessingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.InputProcessingConfiguration>
{

    internal InnerApplicationInputLambdaProcessorFactory InputLambdaProcessorFactory { get; set; }

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.InputProcessingConfiguration Create()
    {
        var inputProcessingConfigurationResult = CreateInputProcessingConfiguration();
        factoryAction?.Invoke(inputProcessingConfigurationResult);

        return inputProcessingConfigurationResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.InputProcessingConfiguration CreateInputProcessingConfiguration()
    {
        var inputProcessingConfigurationResult = new Humidifier.KinesisAnalytics.ApplicationTypes.InputProcessingConfiguration();

        return inputProcessingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalytics.ApplicationTypes.InputProcessingConfiguration result)
    {
        base.CreateChildren(result);

        result.InputLambdaProcessor ??= InputLambdaProcessorFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationInputProcessingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationInputProcessingConfigurationFactory, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor(this InnerApplicationInputProcessingConfigurationFactory parentFactory, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null)
    {
        parentFactory.InputLambdaProcessorFactory = new InnerApplicationInputLambdaProcessorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputLambdaProcessorFactory);
    }

    public static CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1>(this CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1>(this CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, T2, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2>(this CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, T2, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2>(this CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInputProcessingConfigurationFactory, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2>(this CombinedResult<T1, T2, InnerApplicationInputProcessingConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, T2, T3, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3>(this CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, T2, T3, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3>(this CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInputProcessingConfigurationFactory, T3, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationInputProcessingConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInputProcessingConfigurationFactory, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationInputProcessingConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, T2, T3, T4, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3, T4>(this CombinedResult<InnerApplicationInputProcessingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, T2, T3, T4, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationInputProcessingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInputProcessingConfigurationFactory, T3, T4, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationInputProcessingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInputProcessingConfigurationFactory, T4, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationInputProcessingConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationInputProcessingConfigurationFactory, InnerApplicationInputLambdaProcessorFactory> WithInputLambdaProcessor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationInputProcessingConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputLambdaProcessor(combinedResult.T5, subFactoryAction));
}
