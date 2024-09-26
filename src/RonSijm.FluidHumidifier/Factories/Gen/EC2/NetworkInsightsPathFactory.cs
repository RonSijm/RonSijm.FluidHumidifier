// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class NetworkInsightsPathFactory(string resourceName = null, Action<Humidifier.EC2.NetworkInsightsPath> factoryAction = null) : ResourceFactory<Humidifier.EC2.NetworkInsightsPath>(resourceName)
{

    internal InnerNetworkInsightsPathPathFilterFactory FilterAtDestinationFactory { get; set; }

    internal InnerNetworkInsightsPathPathFilterFactory FilterAtSourceFactory { get; set; }

    protected override Humidifier.EC2.NetworkInsightsPath Create()
    {
        var networkInsightsPathResult = CreateNetworkInsightsPath();
        factoryAction?.Invoke(networkInsightsPathResult);

        return networkInsightsPathResult;
    }

    private Humidifier.EC2.NetworkInsightsPath CreateNetworkInsightsPath()
    {
        var networkInsightsPathResult = new Humidifier.EC2.NetworkInsightsPath
        {
            GivenName = InputResourceName,
        };

        return networkInsightsPathResult;
    }
    public override void CreateChildren(Humidifier.EC2.NetworkInsightsPath result)
    {
        base.CreateChildren(result);

        result.FilterAtDestination ??= FilterAtDestinationFactory?.Build();
        result.FilterAtSource ??= FilterAtSourceFactory?.Build();
    }

} // End Of Class

public static class NetworkInsightsPathFactoryExtensions
{
    public static CombinedResult<NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination(this NetworkInsightsPathFactory parentFactory, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null)
    {
        parentFactory.FilterAtDestinationFactory = new InnerNetworkInsightsPathPathFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterAtDestinationFactory);
    }

    public static CombinedResult<NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource(this NetworkInsightsPathFactory parentFactory, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null)
    {
        parentFactory.FilterAtSourceFactory = new InnerNetworkInsightsPathPathFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterAtSourceFactory);
    }

    public static CombinedResult<NetworkInsightsPathFactory, T1, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1>(this CombinedResult<NetworkInsightsPathFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1>(this CombinedResult<T1, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, T2, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2>(this CombinedResult<NetworkInsightsPathFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, T2, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2>(this CombinedResult<T1, NetworkInsightsPathFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2>(this CombinedResult<T1, T2, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3>(this CombinedResult<NetworkInsightsPathFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, T2, T3, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3>(this CombinedResult<T1, NetworkInsightsPathFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsPathFactory, T3, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3>(this CombinedResult<T1, T2, NetworkInsightsPathFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3, T4>(this CombinedResult<NetworkInsightsPathFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3, T4>(this CombinedResult<T1, NetworkInsightsPathFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsPathFactory, T3, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkInsightsPathFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsPathFactory, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkInsightsPathFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtDestination(combinedResult.T5, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1>(this CombinedResult<NetworkInsightsPathFactory, T1> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterAtSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1>(this CombinedResult<T1, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterAtSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, T2, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2>(this CombinedResult<NetworkInsightsPathFactory, T1, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, T2, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2>(this CombinedResult<T1, NetworkInsightsPathFactory, T2> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2>(this CombinedResult<T1, T2, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, T2, T3, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3>(this CombinedResult<NetworkInsightsPathFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, T2, T3, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3>(this CombinedResult<T1, NetworkInsightsPathFactory, T2, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsPathFactory, T3, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3>(this CombinedResult<T1, T2, NetworkInsightsPathFactory, T3> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkInsightsPathFactory, T1, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3, T4>(this CombinedResult<NetworkInsightsPathFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkInsightsPathFactory, T2, T3, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3, T4>(this CombinedResult<T1, NetworkInsightsPathFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkInsightsPathFactory, T3, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkInsightsPathFactory, T3, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkInsightsPathFactory, T4, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkInsightsPathFactory, T4> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkInsightsPathFactory, InnerNetworkInsightsPathPathFilterFactory> WithFilterAtSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkInsightsPathFactory> combinedResult, Action<Humidifier.EC2.NetworkInsightsPathTypes.PathFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterAtSource(combinedResult.T5, subFactoryAction));
}
