// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class AppBlockBuilderFactory(string resourceName = null, Action<Humidifier.AppStream.AppBlockBuilder> factoryAction = null) : ResourceFactory<Humidifier.AppStream.AppBlockBuilder>(resourceName)
{

    internal List<InnerAppBlockBuilderAccessEndpointFactory> AccessEndpointsFactories { get; set; } = [];

    internal InnerAppBlockBuilderVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.AppStream.AppBlockBuilder Create()
    {
        var appBlockBuilderResult = CreateAppBlockBuilder();
        factoryAction?.Invoke(appBlockBuilderResult);

        return appBlockBuilderResult;
    }

    private Humidifier.AppStream.AppBlockBuilder CreateAppBlockBuilder()
    {
        var appBlockBuilderResult = new Humidifier.AppStream.AppBlockBuilder
        {
            GivenName = InputResourceName,
        };

        return appBlockBuilderResult;
    }
    public override void CreateChildren(Humidifier.AppStream.AppBlockBuilder result)
    {
        base.CreateChildren(result);

        result.AccessEndpoints = AccessEndpointsFactories.Any() ? AccessEndpointsFactories.Select(x => x.Build()).ToList() : null;
        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class AppBlockBuilderFactoryExtensions
{
    public static CombinedResult<AppBlockBuilderFactory, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints(this AppBlockBuilderFactory parentFactory, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null)
    {
        var factory = new InnerAppBlockBuilderAccessEndpointFactory(subFactoryAction);
        parentFactory.AccessEndpointsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AppBlockBuilderFactory, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig(this AppBlockBuilderFactory parentFactory, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerAppBlockBuilderVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<AppBlockBuilderFactory, T1, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1>(this CombinedResult<AppBlockBuilderFactory, T1> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1>(this CombinedResult<T1, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, T2, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2>(this CombinedResult<AppBlockBuilderFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, T2, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2>(this CombinedResult<T1, AppBlockBuilderFactory, T2> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockBuilderFactory, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2>(this CombinedResult<T1, T2, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, T2, T3, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<AppBlockBuilderFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, T2, T3, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<T1, AppBlockBuilderFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockBuilderFactory, T3, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, AppBlockBuilderFactory, T3> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockBuilderFactory, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, T2, T3, T4, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<AppBlockBuilderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, T2, T3, T4, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, AppBlockBuilderFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockBuilderFactory, T3, T4, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppBlockBuilderFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockBuilderFactory, T4, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppBlockBuilderFactory, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppBlockBuilderFactory, InnerAppBlockBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<AppBlockBuilderFactory, T1> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, T2, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<AppBlockBuilderFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, T2, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, AppBlockBuilderFactory, T2> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockBuilderFactory, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, T2, T3, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<AppBlockBuilderFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, T2, T3, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, AppBlockBuilderFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockBuilderFactory, T3, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, AppBlockBuilderFactory, T3> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockBuilderFactory, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppBlockBuilderFactory, T1, T2, T3, T4, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<AppBlockBuilderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppBlockBuilderFactory, T2, T3, T4, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, AppBlockBuilderFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppBlockBuilderFactory, T3, T4, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppBlockBuilderFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppBlockBuilderFactory, T4, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppBlockBuilderFactory, T4> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppBlockBuilderFactory, InnerAppBlockBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppBlockBuilderFactory> combinedResult, Action<Humidifier.AppStream.AppBlockBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
