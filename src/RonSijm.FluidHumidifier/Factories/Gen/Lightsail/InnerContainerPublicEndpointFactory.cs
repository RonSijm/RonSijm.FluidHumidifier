// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerContainerPublicEndpointFactory(Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.ContainerTypes.PublicEndpoint>
{

    internal InnerContainerHealthCheckConfigFactory HealthCheckConfigFactory { get; set; }

    protected override Humidifier.Lightsail.ContainerTypes.PublicEndpoint Create()
    {
        var publicEndpointResult = CreatePublicEndpoint();
        factoryAction?.Invoke(publicEndpointResult);

        return publicEndpointResult;
    }

    private Humidifier.Lightsail.ContainerTypes.PublicEndpoint CreatePublicEndpoint()
    {
        var publicEndpointResult = new Humidifier.Lightsail.ContainerTypes.PublicEndpoint();

        return publicEndpointResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.ContainerTypes.PublicEndpoint result)
    {
        base.CreateChildren(result);

        result.HealthCheckConfig ??= HealthCheckConfigFactory?.Build();
    }

} // End Of Class

public static class InnerContainerPublicEndpointFactoryExtensions
{
    public static CombinedResult<InnerContainerPublicEndpointFactory, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig(this InnerContainerPublicEndpointFactory parentFactory, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null)
    {
        parentFactory.HealthCheckConfigFactory = new InnerContainerHealthCheckConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckConfigFactory);
    }

    public static CombinedResult<InnerContainerPublicEndpointFactory, T1, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<InnerContainerPublicEndpointFactory, T1> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPublicEndpointFactory, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<T1, InnerContainerPublicEndpointFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContainerPublicEndpointFactory, T1, T2, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<InnerContainerPublicEndpointFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPublicEndpointFactory, T2, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, InnerContainerPublicEndpointFactory, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerPublicEndpointFactory, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, T2, InnerContainerPublicEndpointFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContainerPublicEndpointFactory, T1, T2, T3, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<InnerContainerPublicEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPublicEndpointFactory, T2, T3, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, InnerContainerPublicEndpointFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerPublicEndpointFactory, T3, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerPublicEndpointFactory, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerPublicEndpointFactory, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerPublicEndpointFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContainerPublicEndpointFactory, T1, T2, T3, T4, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<InnerContainerPublicEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPublicEndpointFactory, T2, T3, T4, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerPublicEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerPublicEndpointFactory, T3, T4, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerPublicEndpointFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerPublicEndpointFactory, T4, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerPublicEndpointFactory, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContainerPublicEndpointFactory, InnerContainerHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerPublicEndpointFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T5, subFactoryAction));
}
