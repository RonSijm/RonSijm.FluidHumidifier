// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class ServerlessClusterFactory(string resourceName = null, Action<Humidifier.MSK.ServerlessCluster> factoryAction = null) : ResourceFactory<Humidifier.MSK.ServerlessCluster>(resourceName)
{

    internal List<InnerServerlessClusterVpcConfigFactory> VpcConfigsFactories { get; set; } = [];

    internal InnerServerlessClusterClientAuthenticationFactory ClientAuthenticationFactory { get; set; }

    protected override Humidifier.MSK.ServerlessCluster Create()
    {
        var serverlessClusterResult = CreateServerlessCluster();
        factoryAction?.Invoke(serverlessClusterResult);

        return serverlessClusterResult;
    }

    private Humidifier.MSK.ServerlessCluster CreateServerlessCluster()
    {
        var serverlessClusterResult = new Humidifier.MSK.ServerlessCluster
        {
            GivenName = InputResourceName,
        };

        return serverlessClusterResult;
    }
    public override void CreateChildren(Humidifier.MSK.ServerlessCluster result)
    {
        base.CreateChildren(result);

        result.VpcConfigs = VpcConfigsFactories.Any() ? VpcConfigsFactories.Select(x => x.Build()).ToList() : null;
        result.ClientAuthentication ??= ClientAuthenticationFactory?.Build();
    }

} // End Of Class

public static class ServerlessClusterFactoryExtensions
{
    public static CombinedResult<ServerlessClusterFactory, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs(this ServerlessClusterFactory parentFactory, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null)
    {
        var factory = new InnerServerlessClusterVpcConfigFactory(subFactoryAction);
        parentFactory.VpcConfigsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ServerlessClusterFactory, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication(this ServerlessClusterFactory parentFactory, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null)
    {
        parentFactory.ClientAuthenticationFactory = new InnerServerlessClusterClientAuthenticationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClientAuthenticationFactory);
    }

    public static CombinedResult<ServerlessClusterFactory, T1, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1>(this CombinedResult<ServerlessClusterFactory, T1> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1>(this CombinedResult<T1, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, T2, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2>(this CombinedResult<ServerlessClusterFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, T2, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2>(this CombinedResult<T1, ServerlessClusterFactory, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessClusterFactory, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2>(this CombinedResult<T1, T2, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, T2, T3, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3>(this CombinedResult<ServerlessClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, T2, T3, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3>(this CombinedResult<T1, ServerlessClusterFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessClusterFactory, T3, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3>(this CombinedResult<T1, T2, ServerlessClusterFactory, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessClusterFactory, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, T2, T3, T4, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3, T4>(this CombinedResult<ServerlessClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, T2, T3, T4, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3, T4>(this CombinedResult<T1, ServerlessClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessClusterFactory, T3, T4, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServerlessClusterFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessClusterFactory, T4, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServerlessClusterFactory, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServerlessClusterFactory, InnerServerlessClusterVpcConfigFactory> WithVpcConfigs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfigs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1>(this CombinedResult<ServerlessClusterFactory, T1> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1>(this CombinedResult<T1, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, T2, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2>(this CombinedResult<ServerlessClusterFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, T2, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2>(this CombinedResult<T1, ServerlessClusterFactory, T2> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessClusterFactory, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2>(this CombinedResult<T1, T2, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, T2, T3, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<ServerlessClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, T2, T3, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<T1, ServerlessClusterFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessClusterFactory, T3, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, ServerlessClusterFactory, T3> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessClusterFactory, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServerlessClusterFactory, T1, T2, T3, T4, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<ServerlessClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServerlessClusterFactory, T2, T3, T4, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, ServerlessClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServerlessClusterFactory, T3, T4, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServerlessClusterFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServerlessClusterFactory, T4, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServerlessClusterFactory, T4> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServerlessClusterFactory, InnerServerlessClusterClientAuthenticationFactory> WithClientAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServerlessClusterFactory> combinedResult, Action<Humidifier.MSK.ServerlessClusterTypes.ClientAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClientAuthentication(combinedResult.T5, subFactoryAction));
}
