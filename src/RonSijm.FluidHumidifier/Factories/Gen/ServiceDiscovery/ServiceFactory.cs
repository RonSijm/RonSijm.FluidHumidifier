// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class ServiceFactory(string resourceName = null, Action<Humidifier.ServiceDiscovery.Service> factoryAction = null) : ResourceFactory<Humidifier.ServiceDiscovery.Service>(resourceName)
{

    internal InnerServiceHealthCheckCustomConfigFactory HealthCheckCustomConfigFactory { get; set; }

    internal InnerServiceDnsConfigFactory DnsConfigFactory { get; set; }

    internal InnerServiceHealthCheckConfigFactory HealthCheckConfigFactory { get; set; }

    protected override Humidifier.ServiceDiscovery.Service Create()
    {
        var serviceResult = CreateService();
        factoryAction?.Invoke(serviceResult);

        return serviceResult;
    }

    private Humidifier.ServiceDiscovery.Service CreateService()
    {
        var serviceResult = new Humidifier.ServiceDiscovery.Service
        {
            GivenName = InputResourceName,
        };

        return serviceResult;
    }
    public override void CreateChildren(Humidifier.ServiceDiscovery.Service result)
    {
        base.CreateChildren(result);

        result.HealthCheckCustomConfig ??= HealthCheckCustomConfigFactory?.Build();
        result.DnsConfig ??= DnsConfigFactory?.Build();
        result.HealthCheckConfig ??= HealthCheckConfigFactory?.Build();
    }

} // End Of Class

public static class ServiceFactoryExtensions
{
    public static CombinedResult<ServiceFactory, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig(this ServiceFactory parentFactory, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null)
    {
        parentFactory.HealthCheckCustomConfigFactory = new InnerServiceHealthCheckCustomConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckCustomConfigFactory);
    }

    public static CombinedResult<ServiceFactory, InnerServiceDnsConfigFactory> WithDnsConfig(this ServiceFactory parentFactory, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null)
    {
        parentFactory.DnsConfigFactory = new InnerServiceDnsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsConfigFactory);
    }

    public static CombinedResult<ServiceFactory, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig(this ServiceFactory parentFactory, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null)
    {
        parentFactory.HealthCheckConfigFactory = new InnerServiceHealthCheckConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckConfigFactory);
    }

    public static CombinedResult<ServiceFactory, T1, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceHealthCheckCustomConfigFactory> WithHealthCheckCustomConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckCustomConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, InnerServiceDnsConfigFactory> WithDnsConfig<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, InnerServiceDnsConfigFactory> WithDnsConfig<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceDnsConfigFactory> WithDnsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T5, subFactoryAction));
}
