// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGrpcGatewayRouteMatchFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch>
{

    internal InnerGatewayRouteGatewayRouteHostnameMatchFactory HostnameFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch Create()
    {
        var grpcGatewayRouteMatchResult = CreateGrpcGatewayRouteMatch();
        factoryAction?.Invoke(grpcGatewayRouteMatchResult);

        return grpcGatewayRouteMatchResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch CreateGrpcGatewayRouteMatch()
    {
        var grpcGatewayRouteMatchResult = new Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch();

        return grpcGatewayRouteMatchResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch result)
    {
        base.CreateChildren(result);

        result.Hostname ??= HostnameFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteGrpcGatewayRouteMatchFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname(this InnerGatewayRouteGrpcGatewayRouteMatchFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null)
    {
        parentFactory.HostnameFactory = new InnerGatewayRouteGatewayRouteHostnameMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostnameFactory);
    }

    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, T2, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T2, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T2, T3, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T3, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T3, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T5, subFactoryAction));
}
