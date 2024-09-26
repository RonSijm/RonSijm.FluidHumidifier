// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteHttpRouteMatchFactory(Action<Humidifier.AppMesh.RouteTypes.HttpRouteMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.HttpRouteMatch>
{

    internal InnerRouteHttpPathMatchFactory PathFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.HttpRouteMatch Create()
    {
        var httpRouteMatchResult = CreateHttpRouteMatch();
        factoryAction?.Invoke(httpRouteMatchResult);

        return httpRouteMatchResult;
    }

    private Humidifier.AppMesh.RouteTypes.HttpRouteMatch CreateHttpRouteMatch()
    {
        var httpRouteMatchResult = new Humidifier.AppMesh.RouteTypes.HttpRouteMatch();

        return httpRouteMatchResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.HttpRouteMatch result)
    {
        base.CreateChildren(result);

        result.Path ??= PathFactory?.Build();
    }

} // End Of Class

public static class InnerRouteHttpRouteMatchFactoryExtensions
{
    public static CombinedResult<InnerRouteHttpRouteMatchFactory, InnerRouteHttpPathMatchFactory> WithPath(this InnerRouteHttpRouteMatchFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null)
    {
        parentFactory.PathFactory = new InnerRouteHttpPathMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PathFactory);
    }

    public static CombinedResult<InnerRouteHttpRouteMatchFactory, T1, InnerRouteHttpPathMatchFactory> WithPath<T1>(this CombinedResult<InnerRouteHttpRouteMatchFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRouteMatchFactory, InnerRouteHttpPathMatchFactory> WithPath<T1>(this CombinedResult<T1, InnerRouteHttpRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteHttpRouteMatchFactory, T1, T2, InnerRouteHttpPathMatchFactory> WithPath<T1, T2>(this CombinedResult<InnerRouteHttpRouteMatchFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRouteMatchFactory, T2, InnerRouteHttpPathMatchFactory> WithPath<T1, T2>(this CombinedResult<T1, InnerRouteHttpRouteMatchFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpRouteMatchFactory, InnerRouteHttpPathMatchFactory> WithPath<T1, T2>(this CombinedResult<T1, T2, InnerRouteHttpRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteHttpRouteMatchFactory, T1, T2, T3, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<InnerRouteHttpRouteMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRouteMatchFactory, T2, T3, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<T1, InnerRouteHttpRouteMatchFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpRouteMatchFactory, T3, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteHttpRouteMatchFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpRouteMatchFactory, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteHttpRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteHttpRouteMatchFactory, T1, T2, T3, T4, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<InnerRouteHttpRouteMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRouteMatchFactory, T2, T3, T4, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteHttpRouteMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpRouteMatchFactory, T3, T4, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteHttpRouteMatchFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpRouteMatchFactory, T4, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteHttpRouteMatchFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteHttpRouteMatchFactory, InnerRouteHttpPathMatchFactory> WithPath<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteHttpRouteMatchFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPath(combinedResult.T5, subFactoryAction));
}
