// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class VirtualClusterFactory(string resourceName = null, Action<Humidifier.EMRContainers.VirtualCluster> factoryAction = null) : ResourceFactory<Humidifier.EMRContainers.VirtualCluster>(resourceName)
{

    internal InnerVirtualClusterContainerProviderFactory ContainerProviderFactory { get; set; }

    protected override Humidifier.EMRContainers.VirtualCluster Create()
    {
        var virtualClusterResult = CreateVirtualCluster();
        factoryAction?.Invoke(virtualClusterResult);

        return virtualClusterResult;
    }

    private Humidifier.EMRContainers.VirtualCluster CreateVirtualCluster()
    {
        var virtualClusterResult = new Humidifier.EMRContainers.VirtualCluster
        {
            GivenName = InputResourceName,
        };

        return virtualClusterResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.VirtualCluster result)
    {
        base.CreateChildren(result);

        result.ContainerProvider ??= ContainerProviderFactory?.Build();
    }

} // End Of Class

public static class VirtualClusterFactoryExtensions
{
    public static CombinedResult<VirtualClusterFactory, InnerVirtualClusterContainerProviderFactory> WithContainerProvider(this VirtualClusterFactory parentFactory, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null)
    {
        parentFactory.ContainerProviderFactory = new InnerVirtualClusterContainerProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerProviderFactory);
    }

    public static CombinedResult<VirtualClusterFactory, T1, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1>(this CombinedResult<VirtualClusterFactory, T1> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualClusterFactory, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1>(this CombinedResult<T1, VirtualClusterFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VirtualClusterFactory, T1, T2, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2>(this CombinedResult<VirtualClusterFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualClusterFactory, T2, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2>(this CombinedResult<T1, VirtualClusterFactory, T2> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualClusterFactory, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2>(this CombinedResult<T1, T2, VirtualClusterFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VirtualClusterFactory, T1, T2, T3, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<VirtualClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualClusterFactory, T2, T3, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<T1, VirtualClusterFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualClusterFactory, T3, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<T1, T2, VirtualClusterFactory, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualClusterFactory, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, VirtualClusterFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VirtualClusterFactory, T1, T2, T3, T4, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<VirtualClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VirtualClusterFactory, T2, T3, T4, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, VirtualClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VirtualClusterFactory, T3, T4, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, VirtualClusterFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VirtualClusterFactory, T4, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VirtualClusterFactory, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VirtualClusterFactory, InnerVirtualClusterContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VirtualClusterFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T5, subFactoryAction));
}
