// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class MaintenanceWindowTargetFactory(string resourceName = null, Action<Humidifier.SSM.MaintenanceWindowTarget> factoryAction = null) : ResourceFactory<Humidifier.SSM.MaintenanceWindowTarget>(resourceName)
{

    internal List<InnerMaintenanceWindowTargetTargetsFactory> TargetsFactories { get; set; } = [];

    protected override Humidifier.SSM.MaintenanceWindowTarget Create()
    {
        var maintenanceWindowTargetResult = CreateMaintenanceWindowTarget();
        factoryAction?.Invoke(maintenanceWindowTargetResult);

        return maintenanceWindowTargetResult;
    }

    private Humidifier.SSM.MaintenanceWindowTarget CreateMaintenanceWindowTarget()
    {
        var maintenanceWindowTargetResult = new Humidifier.SSM.MaintenanceWindowTarget
        {
            GivenName = InputResourceName,
        };

        return maintenanceWindowTargetResult;
    }
    public override void CreateChildren(Humidifier.SSM.MaintenanceWindowTarget result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MaintenanceWindowTargetFactoryExtensions
{
    public static CombinedResult<MaintenanceWindowTargetFactory, InnerMaintenanceWindowTargetTargetsFactory> WithTargets(this MaintenanceWindowTargetFactory parentFactory, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null)
    {
        var factory = new InnerMaintenanceWindowTargetTargetsFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MaintenanceWindowTargetFactory, T1, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1>(this CombinedResult<MaintenanceWindowTargetFactory, T1> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MaintenanceWindowTargetFactory, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1>(this CombinedResult<T1, MaintenanceWindowTargetFactory> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MaintenanceWindowTargetFactory, T1, T2, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2>(this CombinedResult<MaintenanceWindowTargetFactory, T1, T2> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MaintenanceWindowTargetFactory, T2, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2>(this CombinedResult<T1, MaintenanceWindowTargetFactory, T2> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MaintenanceWindowTargetFactory, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, MaintenanceWindowTargetFactory> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MaintenanceWindowTargetFactory, T1, T2, T3, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<MaintenanceWindowTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MaintenanceWindowTargetFactory, T2, T3, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, MaintenanceWindowTargetFactory, T2, T3> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MaintenanceWindowTargetFactory, T3, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, MaintenanceWindowTargetFactory, T3> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MaintenanceWindowTargetFactory, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, MaintenanceWindowTargetFactory> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MaintenanceWindowTargetFactory, T1, T2, T3, T4, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<MaintenanceWindowTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MaintenanceWindowTargetFactory, T2, T3, T4, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, MaintenanceWindowTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MaintenanceWindowTargetFactory, T3, T4, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, MaintenanceWindowTargetFactory, T3, T4> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MaintenanceWindowTargetFactory, T4, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MaintenanceWindowTargetFactory, T4> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MaintenanceWindowTargetFactory, InnerMaintenanceWindowTargetTargetsFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MaintenanceWindowTargetFactory> combinedResult, Action<Humidifier.SSM.MaintenanceWindowTargetTypes.Targets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
}
