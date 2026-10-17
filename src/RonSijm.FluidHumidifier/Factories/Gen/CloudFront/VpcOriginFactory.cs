// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class VpcOriginFactory(string resourceName = null, Action<Humidifier.CloudFront.VpcOrigin> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.VpcOrigin>(resourceName)
{

    internal InnerVpcOriginVpcOriginEndpointConfigFactory VpcOriginEndpointConfigFactory { get; set; }

    protected override Humidifier.CloudFront.VpcOrigin Create()
    {
        var vpcOriginResult = CreateVpcOrigin();
        factoryAction?.Invoke(vpcOriginResult);

        return vpcOriginResult;
    }

    private Humidifier.CloudFront.VpcOrigin CreateVpcOrigin()
    {
        var vpcOriginResult = new Humidifier.CloudFront.VpcOrigin
        {
            GivenName = InputResourceName,
        };

        return vpcOriginResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.VpcOrigin result)
    {
        base.CreateChildren(result);

        result.VpcOriginEndpointConfig ??= VpcOriginEndpointConfigFactory?.Build();
    }

} // End Of Class

public static class VpcOriginFactoryExtensions
{
    public static CombinedResult<VpcOriginFactory, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig(this VpcOriginFactory parentFactory, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null)
    {
        parentFactory.VpcOriginEndpointConfigFactory = new InnerVpcOriginVpcOriginEndpointConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcOriginEndpointConfigFactory);
    }

    public static CombinedResult<VpcOriginFactory, T1, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1>(this CombinedResult<VpcOriginFactory, T1> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcOriginFactory, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1>(this CombinedResult<T1, VpcOriginFactory> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VpcOriginFactory, T1, T2, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2>(this CombinedResult<VpcOriginFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcOriginFactory, T2, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2>(this CombinedResult<T1, VpcOriginFactory, T2> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcOriginFactory, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2>(this CombinedResult<T1, T2, VpcOriginFactory> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VpcOriginFactory, T1, T2, T3, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3>(this CombinedResult<VpcOriginFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcOriginFactory, T2, T3, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3>(this CombinedResult<T1, VpcOriginFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcOriginFactory, T3, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3>(this CombinedResult<T1, T2, VpcOriginFactory, T3> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VpcOriginFactory, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, VpcOriginFactory> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VpcOriginFactory, T1, T2, T3, T4, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3, T4>(this CombinedResult<VpcOriginFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VpcOriginFactory, T2, T3, T4, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, VpcOriginFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VpcOriginFactory, T3, T4, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, VpcOriginFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VpcOriginFactory, T4, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VpcOriginFactory, T4> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VpcOriginFactory, InnerVpcOriginVpcOriginEndpointConfigFactory> WithVpcOriginEndpointConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VpcOriginFactory> combinedResult, Action<Humidifier.CloudFront.VpcOriginTypes.VpcOriginEndpointConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcOriginEndpointConfig(combinedResult.T5, subFactoryAction).T2);
}
