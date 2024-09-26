// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerVirtualClusterContainerInfoFactory(Action<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo>
{

    internal InnerVirtualClusterEksInfoFactory EksInfoFactory { get; set; }

    protected override Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo Create()
    {
        var containerInfoResult = CreateContainerInfo();
        factoryAction?.Invoke(containerInfoResult);

        return containerInfoResult;
    }

    private Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo CreateContainerInfo()
    {
        var containerInfoResult = new Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo();

        return containerInfoResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.VirtualClusterTypes.ContainerInfo result)
    {
        base.CreateChildren(result);

        result.EksInfo ??= EksInfoFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualClusterContainerInfoFactoryExtensions
{
    public static CombinedResult<InnerVirtualClusterContainerInfoFactory, InnerVirtualClusterEksInfoFactory> WithEksInfo(this InnerVirtualClusterContainerInfoFactory parentFactory, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null)
    {
        parentFactory.EksInfoFactory = new InnerVirtualClusterEksInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EksInfoFactory);
    }

    public static CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1>(this CombinedResult<InnerVirtualClusterContainerInfoFactory, T1> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1>(this CombinedResult<T1, InnerVirtualClusterContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, T2, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2>(this CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, T2, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2>(this CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, T2> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualClusterContainerInfoFactory, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2>(this CombinedResult<T1, T2, InnerVirtualClusterContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, T2, T3, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, T2, T3, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualClusterContainerInfoFactory, T3, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualClusterContainerInfoFactory, T3> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualClusterContainerInfoFactory, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualClusterContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, T2, T3, T4, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<InnerVirtualClusterContainerInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, T2, T3, T4, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualClusterContainerInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualClusterContainerInfoFactory, T3, T4, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualClusterContainerInfoFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualClusterContainerInfoFactory, T4, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualClusterContainerInfoFactory, T4> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualClusterContainerInfoFactory, InnerVirtualClusterEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualClusterContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.VirtualClusterTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T5, subFactoryAction));
}
