// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGatewayRouteTargetFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget>
{

    internal InnerGatewayRouteGatewayRouteVirtualServiceFactory VirtualServiceFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget Create()
    {
        var gatewayRouteTargetResult = CreateGatewayRouteTarget();
        factoryAction?.Invoke(gatewayRouteTargetResult);

        return gatewayRouteTargetResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget CreateGatewayRouteTarget()
    {
        var gatewayRouteTargetResult = new Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget();

        return gatewayRouteTargetResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget result)
    {
        base.CreateChildren(result);

        result.VirtualService ??= VirtualServiceFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteGatewayRouteTargetFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService(this InnerGatewayRouteGatewayRouteTargetFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null)
    {
        parentFactory.VirtualServiceFactory = new InnerGatewayRouteGatewayRouteVirtualServiceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VirtualServiceFactory);
    }

    public static CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1>(this CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, WithVirtualService(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1>(this CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, WithVirtualService(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, T2, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2>(this CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, T2, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGatewayRouteTargetFactory, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGatewayRouteTargetFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, T2, T3, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGatewayRouteTargetFactory, T3, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGatewayRouteTargetFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGatewayRouteTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGatewayRouteTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGatewayRouteTargetFactory, T3, T4, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGatewayRouteTargetFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory, T4, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory, InnerGatewayRouteGatewayRouteVirtualServiceFactory> WithVirtualService<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVirtualService(combinedResult.T5, subFactoryAction));
}
