// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class AccessPointFactory(string resourceName = null, Action<Humidifier.S3.AccessPoint> factoryAction = null) : ResourceFactory<Humidifier.S3.AccessPoint>(resourceName)
{

    internal InnerAccessPointPublicAccessBlockConfigurationFactory PublicAccessBlockConfigurationFactory { get; set; }

    internal InnerAccessPointVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.S3.AccessPoint Create()
    {
        var accessPointResult = CreateAccessPoint();
        factoryAction?.Invoke(accessPointResult);

        return accessPointResult;
    }

    private Humidifier.S3.AccessPoint CreateAccessPoint()
    {
        var accessPointResult = new Humidifier.S3.AccessPoint
        {
            GivenName = InputResourceName,
        };

        return accessPointResult;
    }
    public override void CreateChildren(Humidifier.S3.AccessPoint result)
    {
        base.CreateChildren(result);

        result.PublicAccessBlockConfiguration ??= PublicAccessBlockConfigurationFactory?.Build();
        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class AccessPointFactoryExtensions
{
    public static CombinedResult<AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration(this AccessPointFactory parentFactory, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null)
    {
        parentFactory.PublicAccessBlockConfigurationFactory = new InnerAccessPointPublicAccessBlockConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicAccessBlockConfigurationFactory);
    }

    public static CombinedResult<AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration(this AccessPointFactory parentFactory, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerAccessPointVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
}
