// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceNetworkConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.NetworkConfiguration>
{

    internal InnerServiceEgressConfigurationFactory EgressConfigurationFactory { get; set; }

    internal InnerServiceIngressConfigurationFactory IngressConfigurationFactory { get; set; }

    protected override Humidifier.AppRunner.ServiceTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.AppRunner.ServiceTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AppRunner.ServiceTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.EgressConfiguration ??= EgressConfigurationFactory?.Build();
        result.IngressConfiguration ??= IngressConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, InnerServiceEgressConfigurationFactory> WithEgressConfiguration(this InnerServiceNetworkConfigurationFactory parentFactory, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null)
    {
        parentFactory.EgressConfigurationFactory = new InnerServiceEgressConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EgressConfigurationFactory);
    }

    public static CombinedResult<InnerServiceNetworkConfigurationFactory, InnerServiceIngressConfigurationFactory> WithIngressConfiguration(this InnerServiceNetworkConfigurationFactory parentFactory, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null)
    {
        parentFactory.IngressConfigurationFactory = new InnerServiceIngressConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IngressConfigurationFactory);
    }

    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, T4, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, T4, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, T4, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, T4, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceNetworkConfigurationFactory, InnerServiceEgressConfigurationFactory> WithEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, T4, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, T4, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, T4, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, T4, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceNetworkConfigurationFactory, InnerServiceIngressConfigurationFactory> WithIngressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.IngressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressConfiguration(combinedResult.T5, subFactoryAction));
}
