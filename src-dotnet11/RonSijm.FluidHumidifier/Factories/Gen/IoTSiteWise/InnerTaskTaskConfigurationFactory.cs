// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerTaskTaskConfigurationFactory(Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration>
{

    internal InnerTaskContainerTaskConfigurationFactory ContainerTaskConfigurationFactory { get; set; }

    protected override Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration Create()
    {
        var taskConfigurationResult = CreateTaskConfiguration();
        factoryAction?.Invoke(taskConfigurationResult);

        return taskConfigurationResult;
    }

    private Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration CreateTaskConfiguration()
    {
        var taskConfigurationResult = new Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration();

        return taskConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration result)
    {
        base.CreateChildren(result);

        result.ContainerTaskConfiguration ??= ContainerTaskConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTaskTaskConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTaskTaskConfigurationFactory, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration(this InnerTaskTaskConfigurationFactory parentFactory, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null)
    {
        parentFactory.ContainerTaskConfigurationFactory = new InnerTaskContainerTaskConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerTaskConfigurationFactory);
    }

    public static CombinedResult<InnerTaskTaskConfigurationFactory, T1, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1>(this CombinedResult<InnerTaskTaskConfigurationFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskTaskConfigurationFactory, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1>(this CombinedResult<T1, InnerTaskTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTaskTaskConfigurationFactory, T1, T2, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2>(this CombinedResult<InnerTaskTaskConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskTaskConfigurationFactory, T2, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2>(this CombinedResult<T1, InnerTaskTaskConfigurationFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskTaskConfigurationFactory, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTaskTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTaskTaskConfigurationFactory, T1, T2, T3, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3>(this CombinedResult<InnerTaskTaskConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskTaskConfigurationFactory, T2, T3, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTaskTaskConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskTaskConfigurationFactory, T3, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskTaskConfigurationFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTaskTaskConfigurationFactory, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTaskTaskConfigurationFactory, T1, T2, T3, T4, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTaskTaskConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTaskTaskConfigurationFactory, T2, T3, T4, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskTaskConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTaskTaskConfigurationFactory, T3, T4, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskTaskConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTaskTaskConfigurationFactory, T4, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskTaskConfigurationFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTaskTaskConfigurationFactory, InnerTaskContainerTaskConfigurationFactory> WithContainerTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskTaskConfigurationFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerTaskConfiguration(combinedResult.T5, subFactoryAction).T2);
}
