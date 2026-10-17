// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class OriginEndpointPolicyFactory(string resourceName = null, Action<Humidifier.MediaPackageV2.OriginEndpointPolicy> factoryAction = null) : ResourceFactory<Humidifier.MediaPackageV2.OriginEndpointPolicy>(resourceName)
{

    internal InnerOriginEndpointPolicyCdnAuthConfigurationFactory CdnAuthConfigurationFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointPolicy Create()
    {
        var originEndpointPolicyResult = CreateOriginEndpointPolicy();
        factoryAction?.Invoke(originEndpointPolicyResult);

        return originEndpointPolicyResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointPolicy CreateOriginEndpointPolicy()
    {
        var originEndpointPolicyResult = new Humidifier.MediaPackageV2.OriginEndpointPolicy
        {
            GivenName = InputResourceName,
        };

        return originEndpointPolicyResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointPolicy result)
    {
        base.CreateChildren(result);

        result.CdnAuthConfiguration ??= CdnAuthConfigurationFactory?.Build();
    }

} // End Of Class

public static class OriginEndpointPolicyFactoryExtensions
{
    public static CombinedResult<OriginEndpointPolicyFactory, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration(this OriginEndpointPolicyFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null)
    {
        parentFactory.CdnAuthConfigurationFactory = new InnerOriginEndpointPolicyCdnAuthConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CdnAuthConfigurationFactory);
    }

    public static CombinedResult<OriginEndpointPolicyFactory, T1, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1>(this CombinedResult<OriginEndpointPolicyFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OriginEndpointPolicyFactory, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1>(this CombinedResult<T1, OriginEndpointPolicyFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OriginEndpointPolicyFactory, T1, T2, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2>(this CombinedResult<OriginEndpointPolicyFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OriginEndpointPolicyFactory, T2, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2>(this CombinedResult<T1, OriginEndpointPolicyFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OriginEndpointPolicyFactory, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2>(this CombinedResult<T1, T2, OriginEndpointPolicyFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OriginEndpointPolicyFactory, T1, T2, T3, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3>(this CombinedResult<OriginEndpointPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OriginEndpointPolicyFactory, T2, T3, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, OriginEndpointPolicyFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OriginEndpointPolicyFactory, T3, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, OriginEndpointPolicyFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OriginEndpointPolicyFactory, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, OriginEndpointPolicyFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OriginEndpointPolicyFactory, T1, T2, T3, T4, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<OriginEndpointPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OriginEndpointPolicyFactory, T2, T3, T4, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, OriginEndpointPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OriginEndpointPolicyFactory, T3, T4, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, OriginEndpointPolicyFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OriginEndpointPolicyFactory, T4, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OriginEndpointPolicyFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OriginEndpointPolicyFactory, InnerOriginEndpointPolicyCdnAuthConfigurationFactory> WithCdnAuthConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OriginEndpointPolicyFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCdnAuthConfiguration(combinedResult.T5, subFactoryAction).T2);
}
