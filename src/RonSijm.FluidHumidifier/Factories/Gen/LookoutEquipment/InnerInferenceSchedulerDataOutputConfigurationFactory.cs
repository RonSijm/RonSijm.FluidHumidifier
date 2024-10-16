// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutEquipment;

public class InnerInferenceSchedulerDataOutputConfigurationFactory(Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration>
{

    internal InnerInferenceSchedulerS3OutputConfigurationFactory S3OutputConfigurationFactory { get; set; }

    protected override Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration Create()
    {
        var dataOutputConfigurationResult = CreateDataOutputConfiguration();
        factoryAction?.Invoke(dataOutputConfigurationResult);

        return dataOutputConfigurationResult;
    }

    private Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration CreateDataOutputConfiguration()
    {
        var dataOutputConfigurationResult = new Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration();

        return dataOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.S3OutputConfiguration ??= S3OutputConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceSchedulerDataOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration(this InnerInferenceSchedulerDataOutputConfigurationFactory parentFactory, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null)
    {
        parentFactory.S3OutputConfigurationFactory = new InnerInferenceSchedulerS3OutputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3OutputConfigurationFactory);
    }

    public static CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1>(this CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1>(this CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, T2, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2>(this CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, T2, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2>(this CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, T2, T3, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3>(this CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, T2, T3, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory, T3, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceSchedulerDataOutputConfigurationFactory, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceSchedulerDataOutputConfigurationFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, T2, T3, T4, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerInferenceSchedulerDataOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, T2, T3, T4, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceSchedulerDataOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory, T3, T4, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceSchedulerDataOutputConfigurationFactory, T4, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceSchedulerDataOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceSchedulerDataOutputConfigurationFactory, InnerInferenceSchedulerS3OutputConfigurationFactory> WithS3OutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceSchedulerDataOutputConfigurationFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3OutputConfiguration(combinedResult.T5, subFactoryAction));
}
