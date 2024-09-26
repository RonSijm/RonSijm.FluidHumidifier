// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerVirtualClusterContainerProviderFactory(Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider>
{

    internal InnerVirtualClusterContainerInfoFactory InfoFactory { get; set; }

    protected override Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider Create()
    {
        var containerProviderResult = CreateContainerProvider();
        factoryAction?.Invoke(containerProviderResult);

        return containerProviderResult;
    }

    private Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider CreateContainerProvider()
    {
        var containerProviderResult = new Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider();

        return containerProviderResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.VirtualClusterTypes.ContainerProvider result)
    {
        base.CreateChildren(result);

        result.Info ??= InfoFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualClusterContainerProviderFactoryExtensions
{
    public static CombinedResult<InnerVirtualClusterContainerProviderFactory, InnerVirtualClusterContainerInfoFactory> WithInfo(this InnerVirtualClusterContainerProviderFactory parentFactory, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null)
    {
        parentFactory.InfoFactory = new InnerVirtualClusterContainerInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InfoFactory);
    }

    public static CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, InnerVirtualClusterContainerInfoFactory> WithInfo<T1>(this CombinedResult<InnerVirtualClusterContainerProviderFactory, T1> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, InnerVirtualClusterContainerInfoFactory> WithInfo<T1>(this CombinedResult<T1, InnerVirtualClusterContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, T2, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2>(this CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, T2, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2>(this CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, T2> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualClusterContainerProviderFactory, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2>(this CombinedResult<T1, T2, InnerVirtualClusterContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, T2, T3, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, T2, T3, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualClusterContainerProviderFactory, T3, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualClusterContainerProviderFactory, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualClusterContainerProviderFactory, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualClusterContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, T2, T3, T4, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<InnerVirtualClusterContainerProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, T2, T3, T4, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualClusterContainerProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualClusterContainerProviderFactory, T3, T4, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualClusterContainerProviderFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualClusterContainerProviderFactory, T4, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualClusterContainerProviderFactory, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualClusterContainerProviderFactory, InnerVirtualClusterContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualClusterContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T5, subFactoryAction));
}
