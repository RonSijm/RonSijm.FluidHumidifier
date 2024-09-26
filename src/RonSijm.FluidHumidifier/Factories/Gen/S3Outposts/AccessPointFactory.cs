// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Outposts;

public class AccessPointFactory(string resourceName = null, Action<Humidifier.S3Outposts.AccessPoint> factoryAction = null) : ResourceFactory<Humidifier.S3Outposts.AccessPoint>(resourceName)
{

    internal InnerAccessPointVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.S3Outposts.AccessPoint Create()
    {
        var accessPointResult = CreateAccessPoint();
        factoryAction?.Invoke(accessPointResult);

        return accessPointResult;
    }

    private Humidifier.S3Outposts.AccessPoint CreateAccessPoint()
    {
        var accessPointResult = new Humidifier.S3Outposts.AccessPoint
        {
            GivenName = InputResourceName,
        };

        return accessPointResult;
    }
    public override void CreateChildren(Humidifier.S3Outposts.AccessPoint result)
    {
        base.CreateChildren(result);

        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class AccessPointFactoryExtensions
{
    public static CombinedResult<AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration(this AccessPointFactory parentFactory, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerAccessPointVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Outposts.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
}
