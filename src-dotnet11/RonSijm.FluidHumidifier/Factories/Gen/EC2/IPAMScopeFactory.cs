// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IPAMScopeFactory(string resourceName = null, Action<Humidifier.EC2.IPAMScope> factoryAction = null) : ResourceFactory<Humidifier.EC2.IPAMScope>(resourceName)
{

    internal InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory ExternalAuthorityConfigurationFactory { get; set; }

    protected override Humidifier.EC2.IPAMScope Create()
    {
        var iPAMScopeResult = CreateIPAMScope();
        factoryAction?.Invoke(iPAMScopeResult);

        return iPAMScopeResult;
    }

    private Humidifier.EC2.IPAMScope CreateIPAMScope()
    {
        var iPAMScopeResult = new Humidifier.EC2.IPAMScope
        {
            GivenName = InputResourceName,
        };

        return iPAMScopeResult;
    }
    public override void CreateChildren(Humidifier.EC2.IPAMScope result)
    {
        base.CreateChildren(result);

        result.ExternalAuthorityConfiguration ??= ExternalAuthorityConfigurationFactory?.Build();
    }

} // End Of Class

public static class IPAMScopeFactoryExtensions
{
    public static CombinedResult<IPAMScopeFactory, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration(this IPAMScopeFactory parentFactory, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null)
    {
        parentFactory.ExternalAuthorityConfigurationFactory = new InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExternalAuthorityConfigurationFactory);
    }

    public static CombinedResult<IPAMScopeFactory, T1, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1>(this CombinedResult<IPAMScopeFactory, T1> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMScopeFactory, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1>(this CombinedResult<T1, IPAMScopeFactory> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IPAMScopeFactory, T1, T2, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2>(this CombinedResult<IPAMScopeFactory, T1, T2> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMScopeFactory, T2, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2>(this CombinedResult<T1, IPAMScopeFactory, T2> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMScopeFactory, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2>(this CombinedResult<T1, T2, IPAMScopeFactory> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IPAMScopeFactory, T1, T2, T3, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3>(this CombinedResult<IPAMScopeFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMScopeFactory, T2, T3, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3>(this CombinedResult<T1, IPAMScopeFactory, T2, T3> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMScopeFactory, T3, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IPAMScopeFactory, T3> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMScopeFactory, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPAMScopeFactory> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IPAMScopeFactory, T1, T2, T3, T4, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3, T4>(this CombinedResult<IPAMScopeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IPAMScopeFactory, T2, T3, T4, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IPAMScopeFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IPAMScopeFactory, T3, T4, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPAMScopeFactory, T3, T4> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IPAMScopeFactory, T4, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPAMScopeFactory, T4> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IPAMScopeFactory, InnerIPAMScopeIpamScopeExternalAuthorityConfigurationFactory> WithExternalAuthorityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPAMScopeFactory> combinedResult, Action<Humidifier.EC2.IPAMScopeTypes.IpamScopeExternalAuthorityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExternalAuthorityConfiguration(combinedResult.T5, subFactoryAction).T2);
}
