// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerNetworkConnectorConfigFactory(Action<Humidifier.Lambda.NetworkConnectorTypes.Config> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.NetworkConnectorTypes.Config>
{

    internal InnerNetworkConnectorVpcEgressConfigurationFactory VpcEgressConfigurationFactory { get; set; }

    protected override Humidifier.Lambda.NetworkConnectorTypes.Config Create()
    {
        var configResult = CreateConfig();
        factoryAction?.Invoke(configResult);

        return configResult;
    }

    private Humidifier.Lambda.NetworkConnectorTypes.Config CreateConfig()
    {
        var configResult = new Humidifier.Lambda.NetworkConnectorTypes.Config();

        return configResult;
    }
    public override void CreateChildren(Humidifier.Lambda.NetworkConnectorTypes.Config result)
    {
        base.CreateChildren(result);

        result.VpcEgressConfiguration ??= VpcEgressConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerNetworkConnectorConfigFactoryExtensions
{
    public static CombinedResult<InnerNetworkConnectorConfigFactory, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration(this InnerNetworkConnectorConfigFactory parentFactory, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcEgressConfigurationFactory = new InnerNetworkConnectorVpcEgressConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcEgressConfigurationFactory);
    }

    public static CombinedResult<InnerNetworkConnectorConfigFactory, T1, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1>(this CombinedResult<InnerNetworkConnectorConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkConnectorConfigFactory, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1>(this CombinedResult<T1, InnerNetworkConnectorConfigFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerNetworkConnectorConfigFactory, T1, T2, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2>(this CombinedResult<InnerNetworkConnectorConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkConnectorConfigFactory, T2, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2>(this CombinedResult<T1, InnerNetworkConnectorConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerNetworkConnectorConfigFactory, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerNetworkConnectorConfigFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerNetworkConnectorConfigFactory, T1, T2, T3, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3>(this CombinedResult<InnerNetworkConnectorConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkConnectorConfigFactory, T2, T3, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerNetworkConnectorConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerNetworkConnectorConfigFactory, T3, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerNetworkConnectorConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerNetworkConnectorConfigFactory, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerNetworkConnectorConfigFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerNetworkConnectorConfigFactory, T1, T2, T3, T4, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerNetworkConnectorConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkConnectorConfigFactory, T2, T3, T4, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerNetworkConnectorConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerNetworkConnectorConfigFactory, T3, T4, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerNetworkConnectorConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerNetworkConnectorConfigFactory, T4, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerNetworkConnectorConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerNetworkConnectorConfigFactory, InnerNetworkConnectorVpcEgressConfigurationFactory> WithVpcEgressConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerNetworkConnectorConfigFactory> combinedResult, Action<Humidifier.Lambda.NetworkConnectorTypes.VpcEgressConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEgressConfiguration(combinedResult.T5, subFactoryAction).T2);
}
