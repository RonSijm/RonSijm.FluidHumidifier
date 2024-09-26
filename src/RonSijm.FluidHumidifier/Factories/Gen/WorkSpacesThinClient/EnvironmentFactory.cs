// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesThinClient;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.WorkSpacesThinClient.Environment> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesThinClient.Environment>(resourceName)
{

    internal InnerEnvironmentMaintenanceWindowFactory MaintenanceWindowFactory { get; set; }

    protected override Humidifier.WorkSpacesThinClient.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.WorkSpacesThinClient.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.WorkSpacesThinClient.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesThinClient.Environment result)
    {
        base.CreateChildren(result);

        result.MaintenanceWindow ??= MaintenanceWindowFactory?.Build();
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow(this EnvironmentFactory parentFactory, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null)
    {
        parentFactory.MaintenanceWindowFactory = new InnerEnvironmentMaintenanceWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaintenanceWindowFactory);
    }

    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentMaintenanceWindowFactory> WithMaintenanceWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.WorkSpacesThinClient.EnvironmentTypes.MaintenanceWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaintenanceWindow(combinedResult.T5, subFactoryAction));
}
