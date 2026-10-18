// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class SecurityConfigurationFactory(string resourceName = null, Action<Humidifier.EMRContainers.SecurityConfiguration> factoryAction = null) : ResourceFactory<Humidifier.EMRContainers.SecurityConfiguration>(resourceName)
{

    internal InnerSecurityConfigurationContainerProviderFactory ContainerProviderFactory { get; set; }

    internal InnerSecurityConfigurationSecurityConfigurationDataFactory SecurityConfigurationDataFactory { get; set; }

    protected override Humidifier.EMRContainers.SecurityConfiguration Create()
    {
        var securityConfigurationResult = CreateSecurityConfiguration();
        factoryAction?.Invoke(securityConfigurationResult);

        return securityConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfiguration CreateSecurityConfiguration()
    {
        var securityConfigurationResult = new Humidifier.EMRContainers.SecurityConfiguration
        {
            GivenName = InputResourceName,
        };

        return securityConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.SecurityConfiguration result)
    {
        base.CreateChildren(result);

        result.ContainerProvider ??= ContainerProviderFactory?.Build();
        result.SecurityConfigurationData ??= SecurityConfigurationDataFactory?.Build();
    }

} // End Of Class

public static class SecurityConfigurationFactoryExtensions
{
    public static CombinedResult<SecurityConfigurationFactory, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider(this SecurityConfigurationFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null)
    {
        parentFactory.ContainerProviderFactory = new InnerSecurityConfigurationContainerProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerProviderFactory);
    }

    public static CombinedResult<SecurityConfigurationFactory, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData(this SecurityConfigurationFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null)
    {
        parentFactory.SecurityConfigurationDataFactory = new InnerSecurityConfigurationSecurityConfigurationDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecurityConfigurationDataFactory);
    }

    public static CombinedResult<SecurityConfigurationFactory, T1, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1>(this CombinedResult<SecurityConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1>(this CombinedResult<T1, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2>(this CombinedResult<SecurityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2>(this CombinedResult<T1, SecurityConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2>(this CombinedResult<T1, T2, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, T3, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<SecurityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, T3, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<T1, SecurityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, T3, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<T1, T2, SecurityConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SecurityConfigurationFactory, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, T3, T4, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<SecurityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, T3, T4, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, SecurityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, T3, T4, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SecurityConfigurationFactory, T4, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SecurityConfigurationFactory, InnerSecurityConfigurationContainerProviderFactory> WithContainerProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.ContainerProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerProvider(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1>(this CombinedResult<SecurityConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1>(this CombinedResult<T1, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2>(this CombinedResult<SecurityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2>(this CombinedResult<T1, SecurityConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2>(this CombinedResult<T1, T2, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, T3, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3>(this CombinedResult<SecurityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, T3, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3>(this CombinedResult<T1, SecurityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, T3, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3>(this CombinedResult<T1, T2, SecurityConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SecurityConfigurationFactory, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, T3, T4, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3, T4>(this CombinedResult<SecurityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, T3, T4, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3, T4>(this CombinedResult<T1, SecurityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, T3, T4, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SecurityConfigurationFactory, T4, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SecurityConfigurationFactory, InnerSecurityConfigurationSecurityConfigurationDataFactory> WithSecurityConfigurationData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecurityConfigurationData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityConfigurationData(combinedResult.T5, subFactoryAction).T2);
}
