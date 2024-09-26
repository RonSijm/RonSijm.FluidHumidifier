// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class ImageBuilderFactory(string resourceName = null, Action<Humidifier.AppStream.ImageBuilder> factoryAction = null) : ResourceFactory<Humidifier.AppStream.ImageBuilder>(resourceName)
{

    internal List<InnerImageBuilderAccessEndpointFactory> AccessEndpointsFactories { get; set; } = [];

    internal InnerImageBuilderVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerImageBuilderDomainJoinInfoFactory DomainJoinInfoFactory { get; set; }

    protected override Humidifier.AppStream.ImageBuilder Create()
    {
        var imageBuilderResult = CreateImageBuilder();
        factoryAction?.Invoke(imageBuilderResult);

        return imageBuilderResult;
    }

    private Humidifier.AppStream.ImageBuilder CreateImageBuilder()
    {
        var imageBuilderResult = new Humidifier.AppStream.ImageBuilder
        {
            GivenName = InputResourceName,
        };

        return imageBuilderResult;
    }
    public override void CreateChildren(Humidifier.AppStream.ImageBuilder result)
    {
        base.CreateChildren(result);

        result.AccessEndpoints = AccessEndpointsFactories.Any() ? AccessEndpointsFactories.Select(x => x.Build()).ToList() : null;
        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.DomainJoinInfo ??= DomainJoinInfoFactory?.Build();
    }

} // End Of Class

public static class ImageBuilderFactoryExtensions
{
    public static CombinedResult<ImageBuilderFactory, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints(this ImageBuilderFactory parentFactory, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null)
    {
        var factory = new InnerImageBuilderAccessEndpointFactory(subFactoryAction);
        parentFactory.AccessEndpointsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ImageBuilderFactory, InnerImageBuilderVpcConfigFactory> WithVpcConfig(this ImageBuilderFactory parentFactory, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerImageBuilderVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<ImageBuilderFactory, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo(this ImageBuilderFactory parentFactory, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null)
    {
        parentFactory.DomainJoinInfoFactory = new InnerImageBuilderDomainJoinInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DomainJoinInfoFactory);
    }

    public static CombinedResult<ImageBuilderFactory, T1, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1>(this CombinedResult<ImageBuilderFactory, T1> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1>(this CombinedResult<T1, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2>(this CombinedResult<ImageBuilderFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2>(this CombinedResult<T1, ImageBuilderFactory, T2> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2>(this CombinedResult<T1, T2, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, T3, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<ImageBuilderFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, T3, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<T1, ImageBuilderFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, T3, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, ImageBuilderFactory, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageBuilderFactory, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, T3, T4, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<ImageBuilderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, T3, T4, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, ImageBuilderFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, T3, T4, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageBuilderFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageBuilderFactory, T4, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageBuilderFactory, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ImageBuilderFactory, InnerImageBuilderAccessEndpointFactory> WithAccessEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessEndpoints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<ImageBuilderFactory, T1> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<ImageBuilderFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, ImageBuilderFactory, T2> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, T3, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<ImageBuilderFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, T3, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, ImageBuilderFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, T3, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, ImageBuilderFactory, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageBuilderFactory, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, T3, T4, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<ImageBuilderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, T3, T4, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, ImageBuilderFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, T3, T4, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageBuilderFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageBuilderFactory, T4, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageBuilderFactory, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ImageBuilderFactory, InnerImageBuilderVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1>(this CombinedResult<ImageBuilderFactory, T1> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1>(this CombinedResult<T1, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2>(this CombinedResult<ImageBuilderFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2>(this CombinedResult<T1, ImageBuilderFactory, T2> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2>(this CombinedResult<T1, T2, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, T3, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<ImageBuilderFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, T3, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<T1, ImageBuilderFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, T3, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<T1, T2, ImageBuilderFactory, T3> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageBuilderFactory, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ImageBuilderFactory, T1, T2, T3, T4, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<ImageBuilderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ImageBuilderFactory, T2, T3, T4, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, ImageBuilderFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ImageBuilderFactory, T3, T4, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImageBuilderFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ImageBuilderFactory, T4, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImageBuilderFactory, T4> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ImageBuilderFactory, InnerImageBuilderDomainJoinInfoFactory> WithDomainJoinInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImageBuilderFactory> combinedResult, Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainJoinInfo(combinedResult.T5, subFactoryAction));
}
