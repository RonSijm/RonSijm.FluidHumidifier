// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class AccessPointFactory(string resourceName = null, Action<Humidifier.S3Express.AccessPoint> factoryAction = null) : ResourceFactory<Humidifier.S3Express.AccessPoint>(resourceName)
{

    internal InnerAccessPointPublicAccessBlockConfigurationFactory PublicAccessBlockConfigurationFactory { get; set; }

    internal InnerAccessPointScopeFactory ScopeFactory { get; set; }

    internal InnerAccessPointVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.S3Express.AccessPoint Create()
    {
        var accessPointResult = CreateAccessPoint();
        factoryAction?.Invoke(accessPointResult);

        return accessPointResult;
    }

    private Humidifier.S3Express.AccessPoint CreateAccessPoint()
    {
        var accessPointResult = new Humidifier.S3Express.AccessPoint
        {
            GivenName = InputResourceName,
        };

        return accessPointResult;
    }
    public override void CreateChildren(Humidifier.S3Express.AccessPoint result)
    {
        base.CreateChildren(result);

        result.PublicAccessBlockConfiguration ??= PublicAccessBlockConfigurationFactory?.Build();
        result.Scope ??= ScopeFactory?.Build();
        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class AccessPointFactoryExtensions
{
    public static CombinedResult<AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration(this AccessPointFactory parentFactory, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null)
    {
        parentFactory.PublicAccessBlockConfigurationFactory = new InnerAccessPointPublicAccessBlockConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicAccessBlockConfigurationFactory);
    }

    public static CombinedResult<AccessPointFactory, InnerAccessPointScopeFactory> WithScope(this AccessPointFactory parentFactory, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null)
    {
        parentFactory.ScopeFactory = new InnerAccessPointScopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeFactory);
    }

    public static CombinedResult<AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration(this AccessPointFactory parentFactory, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerAccessPointVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointPublicAccessBlockConfigurationFactory> WithPublicAccessBlockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.PublicAccessBlockConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicAccessBlockConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointScopeFactory> WithScope<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointScopeFactory> WithScope<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointScopeFactory> WithScope<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointScopeFactory> WithScope<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointScopeFactory> WithScope<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointScopeFactory> WithScope<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointScopeFactory> WithScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.Scope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScope(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3Express.AccessPointTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction).T2);
}
