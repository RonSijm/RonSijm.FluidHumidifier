// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteHttpGatewayRouteMatchFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch>
{

    internal InnerGatewayRouteHttpPathMatchFactory PathFactory { get; set; }

    internal InnerGatewayRouteGatewayRouteHostnameMatchFactory HostnameFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch Create()
    {
        var httpGatewayRouteMatchResult = CreateHttpGatewayRouteMatch();
        factoryAction?.Invoke(httpGatewayRouteMatchResult);

        return httpGatewayRouteMatchResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch CreateHttpGatewayRouteMatch()
    {
        var httpGatewayRouteMatchResult = new Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch();

        return httpGatewayRouteMatchResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch result)
    {
        base.CreateChildren(result);

        result.Path ??= PathFactory?.Build();
        result.Hostname ??= HostnameFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteHttpGatewayRouteMatchFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteHttpPathMatchFactory> WithPath(this InnerGatewayRouteHttpGatewayRouteMatchFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null)
    {
        parentFactory.PathFactory = new InnerGatewayRouteHttpPathMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PathFactory);
    }

    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname(this InnerGatewayRouteHttpGatewayRouteMatchFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null)
    {
        parentFactory.HostnameFactory = new InnerGatewayRouteGatewayRouteHostnameMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostnameFactory);
    }

    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3, T4, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3, T4, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3, T4, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory, T4, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory, T4, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory, InnerGatewayRouteGatewayRouteHostnameMatchFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T5, subFactoryAction));
}
