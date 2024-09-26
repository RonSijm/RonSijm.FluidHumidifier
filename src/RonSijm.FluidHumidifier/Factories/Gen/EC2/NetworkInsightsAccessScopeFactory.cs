// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkInsightsAccessScopeFactory(string resourceName = null, Action<Humidifier.EC2.NetworkInsightsAccessScope> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkInsightsAccessScope>(resourceName)
{

    internal List<InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> ExcludePathsFactories { get; set; } = [];

    internal List<InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> MatchPathsFactories { get; set; } = [];

    protected override Humidifier.EC2.NetworkInsightsAccessScope Create()
    {
        var networkInsightsAccessScopeResult = CreateNetworkInsightsAccessScope();
        factoryAction?.Invoke(networkInsightsAccessScopeResult);

        return networkInsightsAccessScopeResult;
    }

    private Humidifier.EC2.NetworkInsightsAccessScope CreateNetworkInsightsAccessScope()
    {
        var networkInsightsAccessScopeResult = new Humidifier.EC2.NetworkInsightsAccessScope
        {
            GivenName = InputResourceName,
        };

        return networkInsightsAccessScopeResult;
    }
    public override void CreateChildren(Humidifier.EC2.NetworkInsightsAccessScope result)
    {
        base.CreateChildren(result);

        result.ExcludePaths = ExcludePathsFactories.Any() ? ExcludePathsFactories.Select(x => x.Build()).ToList() : null;
        result.MatchPaths = MatchPathsFactories.Any() ? MatchPathsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class NetworkInsightsAccessScopeFactoryExtensions
{
    public static CombinedResult<NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths(this NetworkInsightsAccessScopeFactory parentFactory, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null)
    {
        var factory = new InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory(subFactoryAction);
        parentFactory.ExcludePathsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths(this NetworkInsightsAccessScopeFactory parentFactory, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null)
    {
        var factory = new InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory(subFactoryAction);
        parentFactory.MatchPathsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludePaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludePaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2>(this CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3>(this CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3, T4>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3, T4>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithExcludePaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludePaths(combinedResult.T5, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2>(this CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<NetworkInsightsAccessScopeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, NetworkInsightsAccessScopeFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkInsightsAccessScopeFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory, T4, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkInsightsAccessScopeFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkInsightsAccessScopeFactory, InnerNetworkInsightsAccessScopeAccessScopePathRequestFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkInsightsAccessScopeFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsAccessScopeTypes.AccessScopePathRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T5, subFactoryAction));
}
