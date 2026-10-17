// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class FlowFactory(string resourceName = null, Action<Humidifier.QuickSight.Flow> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Flow>(resourceName)
{

    internal List<InnerFlowPermissionFactory> PermissionsFactories { get; set; } = [];

    protected override Humidifier.QuickSight.Flow Create()
    {
        var flowResult = CreateFlow();
        factoryAction?.Invoke(flowResult);

        return flowResult;
    }

    private Humidifier.QuickSight.Flow CreateFlow()
    {
        var flowResult = new Humidifier.QuickSight.Flow
        {
            GivenName = InputResourceName,
        };

        return flowResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Flow result)
    {
        base.CreateChildren(result);

        result.Permissions = PermissionsFactories.Any() ? PermissionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FlowFactoryExtensions
{
    public static CombinedResult<FlowFactory, InnerFlowPermissionFactory> WithPermissions(this FlowFactory parentFactory, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null)
    {
        var factory = new InnerFlowPermissionFactory(subFactoryAction);
        parentFactory.PermissionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FlowFactory, T1, InnerFlowPermissionFactory> WithPermissions<T1>(this CombinedResult<FlowFactory, T1> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowFactory, InnerFlowPermissionFactory> WithPermissions<T1>(this CombinedResult<T1, FlowFactory> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FlowFactory, T1, T2, InnerFlowPermissionFactory> WithPermissions<T1, T2>(this CombinedResult<FlowFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowFactory, T2, InnerFlowPermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, FlowFactory, T2> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FlowFactory, InnerFlowPermissionFactory> WithPermissions<T1, T2>(this CombinedResult<T1, T2, FlowFactory> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FlowFactory, T1, T2, T3, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<FlowFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowFactory, T2, T3, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, FlowFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FlowFactory, T3, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, FlowFactory, T3> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FlowFactory, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowFactory> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FlowFactory, T1, T2, T3, T4, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<FlowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FlowFactory, T2, T3, T4, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, FlowFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FlowFactory, T3, T4, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FlowFactory, T4, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowFactory, T4> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FlowFactory, InnerFlowPermissionFactory> WithPermissions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowFactory> combinedResult, Action<Humidifier.QuickSight.FlowTypes.Permission> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissions(combinedResult.T5, subFactoryAction).T2);
}
