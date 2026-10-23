// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayElbAccessLogConfigurationFactory(Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration>
{

    internal InnerGatewayGatewayElbAccessLogDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration Create()
    {
        var gatewayElbAccessLogConfigurationResult = CreateGatewayElbAccessLogConfiguration();
        factoryAction?.Invoke(gatewayElbAccessLogConfigurationResult);

        return gatewayElbAccessLogConfigurationResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration CreateGatewayElbAccessLogConfiguration()
    {
        var gatewayElbAccessLogConfigurationResult = new Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration();

        return gatewayElbAccessLogConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayGatewayElbAccessLogConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination(this InnerGatewayGatewayElbAccessLogConfigurationFactory parentFactory, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerGatewayGatewayElbAccessLogDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1>(this CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, T2, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogConfigurationFactory, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, T2, T3, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, T2, T3, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogConfigurationFactory, T3, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogConfigurationFactory, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, T2, T3, T4, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerGatewayGatewayElbAccessLogConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, T2, T3, T4, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogConfigurationFactory, T3, T4, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogConfigurationFactory, T4, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayElbAccessLogConfigurationFactory, InnerGatewayGatewayElbAccessLogDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayElbAccessLogConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction).T2);
}
