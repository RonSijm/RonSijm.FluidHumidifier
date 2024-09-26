// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationInitialCapacityConfigFactory(Action<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig>
{

    internal InnerApplicationWorkerConfigurationFactory WorkerConfigurationFactory { get; set; }

    protected override Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig Create()
    {
        var initialCapacityConfigResult = CreateInitialCapacityConfig();
        factoryAction?.Invoke(initialCapacityConfigResult);

        return initialCapacityConfigResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig CreateInitialCapacityConfig()
    {
        var initialCapacityConfigResult = new Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig();

        return initialCapacityConfigResult;
    }
    public override void CreateChildren(Humidifier.EMRServerless.ApplicationTypes.InitialCapacityConfig result)
    {
        base.CreateChildren(result);

        result.WorkerConfiguration ??= WorkerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationInitialCapacityConfigFactoryExtensions
{
    public static CombinedResult<InnerApplicationInitialCapacityConfigFactory, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration(this InnerApplicationInitialCapacityConfigFactory parentFactory, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null)
    {
        parentFactory.WorkerConfigurationFactory = new InnerApplicationWorkerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WorkerConfigurationFactory);
    }

    public static CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1>(this CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, T2, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2>(this CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, T2, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, T2> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigFactory, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, T2, T3, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3>(this CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, T2, T3, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigFactory, T3, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigFactory, T3> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigFactory, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, T2, T3, T4, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerApplicationInitialCapacityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, T2, T3, T4, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationInitialCapacityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigFactory, T3, T4, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationInitialCapacityConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigFactory, T4, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationInitialCapacityConfigFactory, T4> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationInitialCapacityConfigFactory, InnerApplicationWorkerConfigurationFactory> WithWorkerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationInitialCapacityConfigFactory> combinedResult, Action<Humidifier.EMRServerless.ApplicationTypes.WorkerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWorkerConfiguration(combinedResult.T5, subFactoryAction));
}
