// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerLayerLifecycleEventConfigurationFactory(Action<Humidifier.OpsWorks.LayerTypes.LifecycleEventConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.LayerTypes.LifecycleEventConfiguration>
{

    internal InnerLayerShutdownEventConfigurationFactory ShutdownEventConfigurationFactory { get; set; }

    protected override Humidifier.OpsWorks.LayerTypes.LifecycleEventConfiguration Create()
    {
        var lifecycleEventConfigurationResult = CreateLifecycleEventConfiguration();
        factoryAction?.Invoke(lifecycleEventConfigurationResult);

        return lifecycleEventConfigurationResult;
    }

    private Humidifier.OpsWorks.LayerTypes.LifecycleEventConfiguration CreateLifecycleEventConfiguration()
    {
        var lifecycleEventConfigurationResult = new Humidifier.OpsWorks.LayerTypes.LifecycleEventConfiguration();

        return lifecycleEventConfigurationResult;
    }
    public override void CreateChildren(Humidifier.OpsWorks.LayerTypes.LifecycleEventConfiguration result)
    {
        base.CreateChildren(result);

        result.ShutdownEventConfiguration ??= ShutdownEventConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerLayerLifecycleEventConfigurationFactoryExtensions
{
    public static CombinedResult<InnerLayerLifecycleEventConfigurationFactory, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration(this InnerLayerLifecycleEventConfigurationFactory parentFactory, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null)
    {
        parentFactory.ShutdownEventConfigurationFactory = new InnerLayerShutdownEventConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ShutdownEventConfigurationFactory);
    }

    public static CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1>(this CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1>(this CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, T2, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2>(this CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, T2, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2>(this CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, T2> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLifecycleEventConfigurationFactory, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerLayerLifecycleEventConfigurationFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, T2, T3, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3>(this CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, T2, T3, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLifecycleEventConfigurationFactory, T3, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerLayerLifecycleEventConfigurationFactory, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLayerLifecycleEventConfigurationFactory, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLayerLifecycleEventConfigurationFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, T2, T3, T4, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerLayerLifecycleEventConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, T2, T3, T4, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerLayerLifecycleEventConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLifecycleEventConfigurationFactory, T3, T4, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLayerLifecycleEventConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLayerLifecycleEventConfigurationFactory, T4, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLayerLifecycleEventConfigurationFactory, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLayerLifecycleEventConfigurationFactory, InnerLayerShutdownEventConfigurationFactory> WithShutdownEventConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLayerLifecycleEventConfigurationFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.ShutdownEventConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShutdownEventConfiguration(combinedResult.T5, subFactoryAction));
}
