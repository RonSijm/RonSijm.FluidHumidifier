// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerContainerContainerServiceDeploymentFactory(Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment>
{

    internal InnerContainerPublicEndpointFactory PublicEndpointFactory { get; set; }

    protected override Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment Create()
    {
        var containerServiceDeploymentResult = CreateContainerServiceDeployment();
        factoryAction?.Invoke(containerServiceDeploymentResult);

        return containerServiceDeploymentResult;
    }

    private Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment CreateContainerServiceDeployment()
    {
        var containerServiceDeploymentResult = new Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment();

        return containerServiceDeploymentResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment result)
    {
        base.CreateChildren(result);

        result.PublicEndpoint ??= PublicEndpointFactory?.Build();
    }

} // End Of Class

public static class InnerContainerContainerServiceDeploymentFactoryExtensions
{
    public static CombinedResult<InnerContainerContainerServiceDeploymentFactory, InnerContainerPublicEndpointFactory> WithPublicEndpoint(this InnerContainerContainerServiceDeploymentFactory parentFactory, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null)
    {
        parentFactory.PublicEndpointFactory = new InnerContainerPublicEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublicEndpointFactory);
    }

    public static CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1>(this CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1>(this CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, T2, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2>(this CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, T2, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2>(this CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerContainerServiceDeploymentFactory, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2>(this CombinedResult<T1, T2, InnerContainerContainerServiceDeploymentFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, T2, T3, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3>(this CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, T2, T3, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3>(this CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerContainerServiceDeploymentFactory, T3, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerContainerServiceDeploymentFactory, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerContainerServiceDeploymentFactory, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerContainerServiceDeploymentFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, T2, T3, T4, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3, T4>(this CombinedResult<InnerContainerContainerServiceDeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, T2, T3, T4, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerContainerServiceDeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerContainerServiceDeploymentFactory, T3, T4, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerContainerServiceDeploymentFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerContainerServiceDeploymentFactory, T4, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerContainerServiceDeploymentFactory, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContainerContainerServiceDeploymentFactory, InnerContainerPublicEndpointFactory> WithPublicEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerContainerServiceDeploymentFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicEndpoint(combinedResult.T5, subFactoryAction));
}
