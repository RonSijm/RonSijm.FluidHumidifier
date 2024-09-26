// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class OriginAccessControlFactory(string resourceName = null, Action<Humidifier.CloudFront.OriginAccessControl> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.OriginAccessControl>(resourceName)
{

    internal InnerOriginAccessControlOriginAccessControlConfigFactory OriginAccessControlConfigFactory { get; set; }

    protected override Humidifier.CloudFront.OriginAccessControl Create()
    {
        var originAccessControlResult = CreateOriginAccessControl();
        factoryAction?.Invoke(originAccessControlResult);

        return originAccessControlResult;
    }

    private Humidifier.CloudFront.OriginAccessControl CreateOriginAccessControl()
    {
        var originAccessControlResult = new Humidifier.CloudFront.OriginAccessControl
        {
            GivenName = InputResourceName,
        };

        return originAccessControlResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.OriginAccessControl result)
    {
        base.CreateChildren(result);

        result.OriginAccessControlConfig ??= OriginAccessControlConfigFactory?.Build();
    }

} // End Of Class

public static class OriginAccessControlFactoryExtensions
{
    public static CombinedResult<OriginAccessControlFactory, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig(this OriginAccessControlFactory parentFactory, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null)
    {
        parentFactory.OriginAccessControlConfigFactory = new InnerOriginAccessControlOriginAccessControlConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OriginAccessControlConfigFactory);
    }

    public static CombinedResult<OriginAccessControlFactory, T1, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1>(this CombinedResult<OriginAccessControlFactory, T1> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginAccessControlFactory, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1>(this CombinedResult<T1, OriginAccessControlFactory> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<OriginAccessControlFactory, T1, T2, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2>(this CombinedResult<OriginAccessControlFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginAccessControlFactory, T2, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2>(this CombinedResult<T1, OriginAccessControlFactory, T2> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OriginAccessControlFactory, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2>(this CombinedResult<T1, T2, OriginAccessControlFactory> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<OriginAccessControlFactory, T1, T2, T3, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3>(this CombinedResult<OriginAccessControlFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginAccessControlFactory, T2, T3, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3>(this CombinedResult<T1, OriginAccessControlFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OriginAccessControlFactory, T3, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3>(this CombinedResult<T1, T2, OriginAccessControlFactory, T3> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OriginAccessControlFactory, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, OriginAccessControlFactory> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<OriginAccessControlFactory, T1, T2, T3, T4, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3, T4>(this CombinedResult<OriginAccessControlFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OriginAccessControlFactory, T2, T3, T4, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3, T4>(this CombinedResult<T1, OriginAccessControlFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OriginAccessControlFactory, T3, T4, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, OriginAccessControlFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OriginAccessControlFactory, T4, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OriginAccessControlFactory, T4> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, OriginAccessControlFactory, InnerOriginAccessControlOriginAccessControlConfigFactory> WithOriginAccessControlConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OriginAccessControlFactory> combinedResult, Action<Humidifier.CloudFront.OriginAccessControlTypes.OriginAccessControlConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOriginAccessControlConfig(combinedResult.T5, subFactoryAction));
}
