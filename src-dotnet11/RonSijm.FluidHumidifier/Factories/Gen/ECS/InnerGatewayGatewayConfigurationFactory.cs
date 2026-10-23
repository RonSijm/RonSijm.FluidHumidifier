// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayConfigurationFactory(Action<Humidifier.ECS.GatewayTypes.GatewayConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayConfiguration>
{

    internal InnerGatewayHostSharedAlbConfigurationFactory HostSharedAlbFactory { get; set; }

    protected override Humidifier.ECS.GatewayTypes.GatewayConfiguration Create()
    {
        var gatewayConfigurationResult = CreateGatewayConfiguration();
        factoryAction?.Invoke(gatewayConfigurationResult);

        return gatewayConfigurationResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayConfiguration CreateGatewayConfiguration()
    {
        var gatewayConfigurationResult = new Humidifier.ECS.GatewayTypes.GatewayConfiguration();

        return gatewayConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.GatewayTypes.GatewayConfiguration result)
    {
        base.CreateChildren(result);

        result.HostSharedAlb ??= HostSharedAlbFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayGatewayConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayGatewayConfigurationFactory, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb(this InnerGatewayGatewayConfigurationFactory parentFactory, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null)
    {
        parentFactory.HostSharedAlbFactory = new InnerGatewayHostSharedAlbConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostSharedAlbFactory);
    }

    public static CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1>(this CombinedResult<InnerGatewayGatewayConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1>(this CombinedResult<T1, InnerGatewayGatewayConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, T2, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2>(this CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, T2, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2>(this CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayConfigurationFactory, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2>(this CombinedResult<T1, T2, InnerGatewayGatewayConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, T2, T3, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3>(this CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, T2, T3, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3>(this CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayConfigurationFactory, T3, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayGatewayConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayConfigurationFactory, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, T2, T3, T4, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3, T4>(this CombinedResult<InnerGatewayGatewayConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, T2, T3, T4, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayGatewayConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayConfigurationFactory, T3, T4, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayGatewayConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayConfigurationFactory, T4, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayConfigurationFactory, InnerGatewayHostSharedAlbConfigurationFactory> WithHostSharedAlb<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayConfigurationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostSharedAlb(combinedResult.T5, subFactoryAction).T2);
}
