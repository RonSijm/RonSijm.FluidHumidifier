// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationContainerProviderFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider>
{

    internal InnerSecurityConfigurationContainerInfoFactory InfoFactory { get; set; }

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider Create()
    {
        var containerProviderResult = CreateContainerProvider();
        factoryAction?.Invoke(containerProviderResult);

        return containerProviderResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider CreateContainerProvider()
    {
        var containerProviderResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider();

        return containerProviderResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider result)
    {
        base.CreateChildren(result);

        result.Info ??= InfoFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityConfigurationContainerProviderFactoryExtensions
{
    public static CombinedResult<InnerSecurityConfigurationContainerProviderFactory, InnerSecurityConfigurationContainerInfoFactory> WithInfo(this InnerSecurityConfigurationContainerProviderFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null)
    {
        parentFactory.InfoFactory = new InnerSecurityConfigurationContainerInfoFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InfoFactory);
    }

    public static CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1>(this CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1>(this CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, T2, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2>(this CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, T2, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2>(this CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationContainerProviderFactory, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2>(this CombinedResult<T1, T2, InnerSecurityConfigurationContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, T2, T3, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, T2, T3, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationContainerProviderFactory, T3, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityConfigurationContainerProviderFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerProviderFactory, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, T2, T3, T4, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<InnerSecurityConfigurationContainerProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, T2, T3, T4, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityConfigurationContainerProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationContainerProviderFactory, T3, T4, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityConfigurationContainerProviderFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerProviderFactory, T4, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationContainerProviderFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationContainerProviderFactory, InnerSecurityConfigurationContainerInfoFactory> WithInfo<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationContainerProviderFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerInfo> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfo(combinedResult.T5, subFactoryAction).T2);
}
