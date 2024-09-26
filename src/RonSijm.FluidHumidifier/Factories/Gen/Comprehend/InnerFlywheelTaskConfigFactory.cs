// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerFlywheelTaskConfigFactory(Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.FlywheelTypes.TaskConfig>
{

    internal InnerFlywheelDocumentClassificationConfigFactory DocumentClassificationConfigFactory { get; set; }

    internal InnerFlywheelEntityRecognitionConfigFactory EntityRecognitionConfigFactory { get; set; }

    protected override Humidifier.Comprehend.FlywheelTypes.TaskConfig Create()
    {
        var taskConfigResult = CreateTaskConfig();
        factoryAction?.Invoke(taskConfigResult);

        return taskConfigResult;
    }

    private Humidifier.Comprehend.FlywheelTypes.TaskConfig CreateTaskConfig()
    {
        var taskConfigResult = new Humidifier.Comprehend.FlywheelTypes.TaskConfig();

        return taskConfigResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.FlywheelTypes.TaskConfig result)
    {
        base.CreateChildren(result);

        result.DocumentClassificationConfig ??= DocumentClassificationConfigFactory?.Build();
        result.EntityRecognitionConfig ??= EntityRecognitionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlywheelTaskConfigFactoryExtensions
{
    public static CombinedResult<InnerFlywheelTaskConfigFactory, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig(this InnerFlywheelTaskConfigFactory parentFactory, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null)
    {
        parentFactory.DocumentClassificationConfigFactory = new InnerFlywheelDocumentClassificationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DocumentClassificationConfigFactory);
    }

    public static CombinedResult<InnerFlywheelTaskConfigFactory, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig(this InnerFlywheelTaskConfigFactory parentFactory, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null)
    {
        parentFactory.EntityRecognitionConfigFactory = new InnerFlywheelEntityRecognitionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EntityRecognitionConfigFactory);
    }

    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3, T4, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3, T4, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3, T4, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory, T4, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlywheelTaskConfigFactory, InnerFlywheelDocumentClassificationConfigFactory> WithDocumentClassificationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DocumentClassificationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentClassificationConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3, T4, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlywheelTaskConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3, T4, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlywheelTaskConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3, T4, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlywheelTaskConfigFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory, T4, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlywheelTaskConfigFactory, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlywheelTaskConfigFactory, InnerFlywheelEntityRecognitionConfigFactory> WithEntityRecognitionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlywheelTaskConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.EntityRecognitionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntityRecognitionConfig(combinedResult.T5, subFactoryAction));
}
