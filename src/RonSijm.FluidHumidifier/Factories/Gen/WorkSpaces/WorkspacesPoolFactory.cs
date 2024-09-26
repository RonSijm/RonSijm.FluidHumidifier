// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class WorkspacesPoolFactory(string resourceName = null, Action<Humidifier.WorkSpaces.WorkspacesPool> factoryAction = null) : ResourceFactory<Humidifier.WorkSpaces.WorkspacesPool>(resourceName)
{

    internal InnerWorkspacesPoolApplicationSettingsFactory ApplicationSettingsFactory { get; set; }

    internal InnerWorkspacesPoolTimeoutSettingsFactory TimeoutSettingsFactory { get; set; }

    internal InnerWorkspacesPoolCapacityFactory CapacityFactory { get; set; }

    protected override Humidifier.WorkSpaces.WorkspacesPool Create()
    {
        var workspacesPoolResult = CreateWorkspacesPool();
        factoryAction?.Invoke(workspacesPoolResult);

        return workspacesPoolResult;
    }

    private Humidifier.WorkSpaces.WorkspacesPool CreateWorkspacesPool()
    {
        var workspacesPoolResult = new Humidifier.WorkSpaces.WorkspacesPool
        {
            GivenName = InputResourceName,
        };

        return workspacesPoolResult;
    }
    public override void CreateChildren(Humidifier.WorkSpaces.WorkspacesPool result)
    {
        base.CreateChildren(result);

        result.ApplicationSettings ??= ApplicationSettingsFactory?.Build();
        result.TimeoutSettings ??= TimeoutSettingsFactory?.Build();
        result.Capacity ??= CapacityFactory?.Build();
    }

} // End Of Class

public static class WorkspacesPoolFactoryExtensions
{
    public static CombinedResult<WorkspacesPoolFactory, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings(this WorkspacesPoolFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null)
    {
        parentFactory.ApplicationSettingsFactory = new InnerWorkspacesPoolApplicationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationSettingsFactory);
    }

    public static CombinedResult<WorkspacesPoolFactory, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings(this WorkspacesPoolFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null)
    {
        parentFactory.TimeoutSettingsFactory = new InnerWorkspacesPoolTimeoutSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeoutSettingsFactory);
    }

    public static CombinedResult<WorkspacesPoolFactory, InnerWorkspacesPoolCapacityFactory> WithCapacity(this WorkspacesPoolFactory parentFactory, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null)
    {
        parentFactory.CapacityFactory = new InnerWorkspacesPoolCapacityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityFactory);
    }

    public static CombinedResult<WorkspacesPoolFactory, T1, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1>(this CombinedResult<WorkspacesPoolFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1>(this CombinedResult<T1, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2>(this CombinedResult<WorkspacesPoolFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2>(this CombinedResult<T1, WorkspacesPoolFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2>(this CombinedResult<T1, T2, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, T3, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3>(this CombinedResult<WorkspacesPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, T3, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3>(this CombinedResult<T1, WorkspacesPoolFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, T3, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3>(this CombinedResult<T1, T2, WorkspacesPoolFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspacesPoolFactory, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, T3, T4, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3, T4>(this CombinedResult<WorkspacesPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, T3, T4, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3, T4>(this CombinedResult<T1, WorkspacesPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, T3, T4, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspacesPoolFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspacesPoolFactory, T4, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspacesPoolFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspacesPoolFactory, InnerWorkspacesPoolApplicationSettingsFactory> WithApplicationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.ApplicationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1>(this CombinedResult<WorkspacesPoolFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1>(this CombinedResult<T1, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2>(this CombinedResult<WorkspacesPoolFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2>(this CombinedResult<T1, WorkspacesPoolFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2>(this CombinedResult<T1, T2, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, T3, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3>(this CombinedResult<WorkspacesPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, T3, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3>(this CombinedResult<T1, WorkspacesPoolFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, T3, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3>(this CombinedResult<T1, T2, WorkspacesPoolFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspacesPoolFactory, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, T3, T4, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3, T4>(this CombinedResult<WorkspacesPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, T3, T4, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3, T4>(this CombinedResult<T1, WorkspacesPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, T3, T4, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspacesPoolFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspacesPoolFactory, T4, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspacesPoolFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspacesPoolFactory, InnerWorkspacesPoolTimeoutSettingsFactory> WithTimeoutSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.TimeoutSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeoutSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1>(this CombinedResult<WorkspacesPoolFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1>(this CombinedResult<T1, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2>(this CombinedResult<WorkspacesPoolFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2>(this CombinedResult<T1, WorkspacesPoolFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2>(this CombinedResult<T1, T2, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, T3, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3>(this CombinedResult<WorkspacesPoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, T3, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3>(this CombinedResult<T1, WorkspacesPoolFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, T3, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3>(this CombinedResult<T1, T2, WorkspacesPoolFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspacesPoolFactory, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspacesPoolFactory, T1, T2, T3, T4, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3, T4>(this CombinedResult<WorkspacesPoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspacesPoolFactory, T2, T3, T4, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3, T4>(this CombinedResult<T1, WorkspacesPoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspacesPoolFactory, T3, T4, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspacesPoolFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspacesPoolFactory, T4, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspacesPoolFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspacesPoolFactory, InnerWorkspacesPoolCapacityFactory> WithCapacity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspacesPoolFactory> combinedResult, Action<Humidifier.WorkSpaces.WorkspacesPoolTypes.Capacity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacity(combinedResult.T5, subFactoryAction));
}
