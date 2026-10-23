// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class GatewayFactory(string resourceName = null, Action<Humidifier.ECS.Gateway> factoryAction = null) : ResourceFactory<Humidifier.ECS.Gateway>(resourceName)
{

    internal InnerGatewayGatewayConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.ECS.Gateway Create()
    {
        var gatewayResult = CreateGateway();
        factoryAction?.Invoke(gatewayResult);

        return gatewayResult;
    }

    private Humidifier.ECS.Gateway CreateGateway()
    {
        var gatewayResult = new Humidifier.ECS.Gateway
        {
            GivenName = InputResourceName,
        };

        return gatewayResult;
    }
    public override void CreateChildren(Humidifier.ECS.Gateway result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class GatewayFactoryExtensions
{
    public static CombinedResult<GatewayFactory, InnerGatewayGatewayConfigurationFactory> WithConfiguration(this GatewayFactory parentFactory, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerGatewayGatewayConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<GatewayFactory, T1, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1>(this CombinedResult<GatewayFactory, T1> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, GatewayFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GatewayFactory, T1, T2, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<GatewayFactory, T1, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, T2, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, GatewayFactory, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayFactory, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, GatewayFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GatewayFactory, T1, T2, T3, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<GatewayFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, T2, T3, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, GatewayFactory, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayFactory, T3, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, GatewayFactory, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayFactory, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GatewayFactory, T1, T2, T3, T4, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<GatewayFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayFactory, T2, T3, T4, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, GatewayFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayFactory, T3, T4, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayFactory, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayFactory, T4, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayFactory, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GatewayFactory, InnerGatewayGatewayConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
