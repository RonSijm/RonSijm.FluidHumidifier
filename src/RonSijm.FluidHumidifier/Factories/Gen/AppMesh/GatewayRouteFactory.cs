// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class GatewayRouteFactory(string resourceName = null, Action<Humidifier.AppMesh.GatewayRoute> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.GatewayRoute>(resourceName)
{

    internal InnerGatewayRouteGatewayRouteSpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRoute Create()
    {
        var gatewayRouteResult = CreateGatewayRoute();
        factoryAction?.Invoke(gatewayRouteResult);

        return gatewayRouteResult;
    }

    private Humidifier.AppMesh.GatewayRoute CreateGatewayRoute()
    {
        var gatewayRouteResult = new Humidifier.AppMesh.GatewayRoute
        {
            GivenName = InputResourceName,
        };

        return gatewayRouteResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRoute result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class GatewayRouteFactoryExtensions
{
    public static CombinedResult<GatewayRouteFactory, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec(this GatewayRouteFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerGatewayRouteGatewayRouteSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<GatewayRouteFactory, T1, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1>(this CombinedResult<GatewayRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayRouteFactory, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1>(this CombinedResult<T1, GatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GatewayRouteFactory, T1, T2, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2>(this CombinedResult<GatewayRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayRouteFactory, T2, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, GatewayRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayRouteFactory, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, GatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GatewayRouteFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<GatewayRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayRouteFactory, T2, T3, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, GatewayRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayRouteFactory, T3, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, GatewayRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayRouteFactory, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GatewayRouteFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<GatewayRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GatewayRouteFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, GatewayRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GatewayRouteFactory, T3, T4, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GatewayRouteFactory, T4, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GatewayRouteFactory, InnerGatewayRouteGatewayRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
