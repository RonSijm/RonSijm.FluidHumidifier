// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class ContainerAssociationFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.ContainerAssociation> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.ContainerAssociation>(resourceName)
{

    internal List<InnerContainerAssociationContainerMonitoringConfigurationFactory> ContainerMonitoringConfigurationsFactories { get; set; } = [];

    protected override Humidifier.NetworkFirewall.ContainerAssociation Create()
    {
        var containerAssociationResult = CreateContainerAssociation();
        factoryAction?.Invoke(containerAssociationResult);

        return containerAssociationResult;
    }

    private Humidifier.NetworkFirewall.ContainerAssociation CreateContainerAssociation()
    {
        var containerAssociationResult = new Humidifier.NetworkFirewall.ContainerAssociation
        {
            GivenName = InputResourceName,
        };

        return containerAssociationResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.ContainerAssociation result)
    {
        base.CreateChildren(result);

        result.ContainerMonitoringConfigurations = ContainerMonitoringConfigurationsFactories.Any() ? ContainerMonitoringConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ContainerAssociationFactoryExtensions
{
    public static CombinedResult<ContainerAssociationFactory, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations(this ContainerAssociationFactory parentFactory, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null)
    {
        var factory = new InnerContainerAssociationContainerMonitoringConfigurationFactory(subFactoryAction);
        parentFactory.ContainerMonitoringConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContainerAssociationFactory, T1, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1>(this CombinedResult<ContainerAssociationFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContainerAssociationFactory, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1>(this CombinedResult<T1, ContainerAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ContainerAssociationFactory, T1, T2, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2>(this CombinedResult<ContainerAssociationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContainerAssociationFactory, T2, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2>(this CombinedResult<T1, ContainerAssociationFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContainerAssociationFactory, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2>(this CombinedResult<T1, T2, ContainerAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ContainerAssociationFactory, T1, T2, T3, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3>(this CombinedResult<ContainerAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContainerAssociationFactory, T2, T3, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3>(this CombinedResult<T1, ContainerAssociationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContainerAssociationFactory, T3, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, ContainerAssociationFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContainerAssociationFactory, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ContainerAssociationFactory, T1, T2, T3, T4, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3, T4>(this CombinedResult<ContainerAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ContainerAssociationFactory, T2, T3, T4, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, ContainerAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ContainerAssociationFactory, T3, T4, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerAssociationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ContainerAssociationFactory, T4, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerAssociationFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ContainerAssociationFactory, InnerContainerAssociationContainerMonitoringConfigurationFactory> WithContainerMonitoringConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerAssociationFactory> combinedResult, Action<Humidifier.NetworkFirewall.ContainerAssociationTypes.ContainerMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMonitoringConfigurations(combinedResult.T5, subFactoryAction).T2);
}
