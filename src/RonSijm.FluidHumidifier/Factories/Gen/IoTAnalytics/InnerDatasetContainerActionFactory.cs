// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetContainerActionFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.ContainerAction>
{

    internal InnerDatasetResourceConfigurationFactory ResourceConfigurationFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.ContainerAction Create()
    {
        var containerActionResult = CreateContainerAction();
        factoryAction?.Invoke(containerActionResult);

        return containerActionResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.ContainerAction CreateContainerAction()
    {
        var containerActionResult = new Humidifier.IoTAnalytics.DatasetTypes.ContainerAction();

        return containerActionResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.ContainerAction result)
    {
        base.CreateChildren(result);

        result.ResourceConfiguration ??= ResourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetContainerActionFactoryExtensions
{
    public static CombinedResult<InnerDatasetContainerActionFactory, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration(this InnerDatasetContainerActionFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null)
    {
        parentFactory.ResourceConfigurationFactory = new InnerDatasetResourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceConfigurationFactory);
    }

    public static CombinedResult<InnerDatasetContainerActionFactory, T1, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1>(this CombinedResult<InnerDatasetContainerActionFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetContainerActionFactory, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1>(this CombinedResult<T1, InnerDatasetContainerActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetContainerActionFactory, T1, T2, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2>(this CombinedResult<InnerDatasetContainerActionFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetContainerActionFactory, T2, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2>(this CombinedResult<T1, InnerDatasetContainerActionFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetContainerActionFactory, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDatasetContainerActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetContainerActionFactory, T1, T2, T3, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<InnerDatasetContainerActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetContainerActionFactory, T2, T3, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDatasetContainerActionFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetContainerActionFactory, T3, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetContainerActionFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetContainerActionFactory, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetContainerActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetContainerActionFactory, T1, T2, T3, T4, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDatasetContainerActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetContainerActionFactory, T2, T3, T4, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetContainerActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetContainerActionFactory, T3, T4, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetContainerActionFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetContainerActionFactory, T4, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetContainerActionFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetContainerActionFactory, InnerDatasetResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetContainerActionFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T5, subFactoryAction));
}
