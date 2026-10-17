// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerTaskContainerTaskConfigurationFactory(Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration>
{

    internal InnerTaskEphemeralStorageConfigurationFactory EphemeralStorageConfigurationFactory { get; set; }

    protected override Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration Create()
    {
        var containerTaskConfigurationResult = CreateContainerTaskConfiguration();
        factoryAction?.Invoke(containerTaskConfigurationResult);

        return containerTaskConfigurationResult;
    }

    private Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration CreateContainerTaskConfiguration()
    {
        var containerTaskConfigurationResult = new Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration();

        return containerTaskConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration result)
    {
        base.CreateChildren(result);

        result.EphemeralStorageConfiguration ??= EphemeralStorageConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTaskContainerTaskConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTaskContainerTaskConfigurationFactory, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration(this InnerTaskContainerTaskConfigurationFactory parentFactory, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null)
    {
        parentFactory.EphemeralStorageConfigurationFactory = new InnerTaskEphemeralStorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EphemeralStorageConfigurationFactory);
    }

    public static CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1>(this CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1>(this CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, T2, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2>(this CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, T2, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2>(this CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskContainerTaskConfigurationFactory, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTaskContainerTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, T2, T3, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3>(this CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, T2, T3, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskContainerTaskConfigurationFactory, T3, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskContainerTaskConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTaskContainerTaskConfigurationFactory, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskContainerTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, T2, T3, T4, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTaskContainerTaskConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, T2, T3, T4, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskContainerTaskConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskContainerTaskConfigurationFactory, T3, T4, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskContainerTaskConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTaskContainerTaskConfigurationFactory, T4, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskContainerTaskConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTaskContainerTaskConfigurationFactory, InnerTaskEphemeralStorageConfigurationFactory> WithEphemeralStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskContainerTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEphemeralStorageConfiguration(combinedResult.T5, subFactoryAction).T2);
}
