// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceNetworkConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.NetworkConfiguration>
{

    internal InnerServiceAwsVpcConfigurationFactory AwsvpcConfigurationFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.ECS.ServiceTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.AwsvpcConfiguration ??= AwsvpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration(this InnerServiceNetworkConfigurationFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.AwsvpcConfigurationFactory = new InnerServiceAwsVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsvpcConfigurationFactory);
    }

    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, T4, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, T4, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, T4, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, T4, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceNetworkConfigurationFactory, InnerServiceAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T5, subFactoryAction));
}
