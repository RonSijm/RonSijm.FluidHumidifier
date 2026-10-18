// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationContainerInfoFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo>
{

    internal InnerSecurityConfigurationEksInfoFactory EksInfoFactory { get; set; }

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo Create()
    {
        var containerInfoResult = CreateContainerInfo();
        factoryAction?.Invoke(containerInfoResult);

        return containerInfoResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo CreateContainerInfo()
    {
        var containerInfoResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo();

        return containerInfoResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo result)
    {
        base.CreateChildren(result);

        result.EksInfo ??= EksInfoFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityConfigurationContainerInfoFactoryExtensions
{
    public static CombinedResult<InnerSecurityConfigurationContainerInfoFactory, InnerSecurityConfigurationEksInfoFactory> WithEksInfo(this InnerSecurityConfigurationContainerInfoFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null)
    {
        parentFactory.EksInfoFactory = new InnerSecurityConfigurationEksInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EksInfoFactory);
    }

    public static CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1>(this CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1>(this CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, T2, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2>(this CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, T2, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2>(this CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationContainerInfoFactory, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2>(this CombinedResult<T1, T2, InnerSecurityConfigurationContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, T2, T3, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, T2, T3, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationContainerInfoFactory, T3, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityConfigurationContainerInfoFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerInfoFactory, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, T2, T3, T4, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<InnerSecurityConfigurationContainerInfoFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, T2, T3, T4, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityConfigurationContainerInfoFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationContainerInfoFactory, T3, T4, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityConfigurationContainerInfoFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerInfoFactory, T4, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerInfoFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationContainerInfoFactory, InnerSecurityConfigurationEksInfoFactory> WithEksInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationContainerInfoFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEksInfo(combinedResult.T5, subFactoryAction).T2);
}
