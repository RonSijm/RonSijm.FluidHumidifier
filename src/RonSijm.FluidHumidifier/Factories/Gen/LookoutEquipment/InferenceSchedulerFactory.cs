// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutEquipment;

public class InferenceSchedulerFactory(string resourceName = null, Action<Humidifier.LookoutEquipment.InferenceScheduler> factoryAction = null) : ResourceFactory<Humidifier.LookoutEquipment.InferenceScheduler>(resourceName)
{

    internal InnerInferenceSchedulerDataInputConfigurationFactory DataInputConfigurationFactory { get; set; }

    internal InnerInferenceSchedulerDataOutputConfigurationFactory DataOutputConfigurationFactory { get; set; }

    protected override Humidifier.LookoutEquipment.InferenceScheduler Create()
    {
        var inferenceSchedulerResult = CreateInferenceScheduler();
        factoryAction?.Invoke(inferenceSchedulerResult);

        return inferenceSchedulerResult;
    }

    private Humidifier.LookoutEquipment.InferenceScheduler CreateInferenceScheduler()
    {
        var inferenceSchedulerResult = new Humidifier.LookoutEquipment.InferenceScheduler
        {
            GivenName = InputResourceName,
        };

        return inferenceSchedulerResult;
    }
    public override void CreateChildren(Humidifier.LookoutEquipment.InferenceScheduler result)
    {
        base.CreateChildren(result);

        result.DataInputConfiguration ??= DataInputConfigurationFactory?.Build();
        result.DataOutputConfiguration ??= DataOutputConfigurationFactory?.Build();
    }

} // End Of Class

public static class InferenceSchedulerFactoryExtensions
{
    public static CombinedResult<InferenceSchedulerFactory, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration(this InferenceSchedulerFactory parentFactory, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null)
    {
        parentFactory.DataInputConfigurationFactory = new InnerInferenceSchedulerDataInputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataInputConfigurationFactory);
    }

    public static CombinedResult<InferenceSchedulerFactory, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration(this InferenceSchedulerFactory parentFactory, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null)
    {
        parentFactory.DataOutputConfigurationFactory = new InnerInferenceSchedulerDataOutputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataOutputConfigurationFactory);
    }

    public static CombinedResult<InferenceSchedulerFactory, T1, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1>(this CombinedResult<InferenceSchedulerFactory, T1> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1>(this CombinedResult<T1, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, T2, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2>(this CombinedResult<InferenceSchedulerFactory, T1, T2> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, T2, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2>(this CombinedResult<T1, InferenceSchedulerFactory, T2> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceSchedulerFactory, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2>(this CombinedResult<T1, T2, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, T2, T3, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3>(this CombinedResult<InferenceSchedulerFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, T2, T3, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3>(this CombinedResult<T1, InferenceSchedulerFactory, T2, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceSchedulerFactory, T3, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InferenceSchedulerFactory, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceSchedulerFactory, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, T2, T3, T4, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3, T4>(this CombinedResult<InferenceSchedulerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, T2, T3, T4, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InferenceSchedulerFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceSchedulerFactory, T3, T4, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceSchedulerFactory, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceSchedulerFactory, T4, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceSchedulerFactory, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceSchedulerFactory, InnerInferenceSchedulerDataInputConfigurationFactory> WithDataInputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataInputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataInputConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1>(this CombinedResult<InferenceSchedulerFactory, T1> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1>(this CombinedResult<T1, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, T2, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2>(this CombinedResult<InferenceSchedulerFactory, T1, T2> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, T2, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2>(this CombinedResult<T1, InferenceSchedulerFactory, T2> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceSchedulerFactory, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2>(this CombinedResult<T1, T2, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, T2, T3, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3>(this CombinedResult<InferenceSchedulerFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, T2, T3, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, InferenceSchedulerFactory, T2, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceSchedulerFactory, T3, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InferenceSchedulerFactory, T3> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceSchedulerFactory, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceSchedulerFactory, T1, T2, T3, T4, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<InferenceSchedulerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceSchedulerFactory, T2, T3, T4, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InferenceSchedulerFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceSchedulerFactory, T3, T4, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceSchedulerFactory, T3, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceSchedulerFactory, T4, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceSchedulerFactory, T4> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceSchedulerFactory, InnerInferenceSchedulerDataOutputConfigurationFactory> WithDataOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceSchedulerFactory> combinedResult, Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.DataOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataOutputConfiguration(combinedResult.T5, subFactoryAction));
}
