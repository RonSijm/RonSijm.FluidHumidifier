// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHubV2;

public class InnerServiceInputSourceDefinitionFactory(Action<Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition>
{

    internal InnerServiceResourceConfigurationFactory ResourceConfigurationFactory { get; set; }

    protected override Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition Create()
    {
        var inputSourceDefinitionResult = CreateInputSourceDefinition();
        factoryAction?.Invoke(inputSourceDefinitionResult);

        return inputSourceDefinitionResult;
    }

    private Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition CreateInputSourceDefinition()
    {
        var inputSourceDefinitionResult = new Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition();

        return inputSourceDefinitionResult;
    }
    public override void CreateChildren(Humidifier.ResilienceHubV2.ServiceTypes.InputSourceDefinition result)
    {
        base.CreateChildren(result);

        result.ResourceConfiguration ??= ResourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceInputSourceDefinitionFactoryExtensions
{
    public static CombinedResult<InnerServiceInputSourceDefinitionFactory, InnerServiceResourceConfigurationFactory> WithResourceConfiguration(this InnerServiceInputSourceDefinitionFactory parentFactory, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null)
    {
        parentFactory.ResourceConfigurationFactory = new InnerServiceResourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceConfigurationFactory);
    }

    public static CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1>(this CombinedResult<InnerServiceInputSourceDefinitionFactory, T1> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1>(this CombinedResult<T1, InnerServiceInputSourceDefinitionFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, T2, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2>(this CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, T2, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, T2> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceInputSourceDefinitionFactory, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceInputSourceDefinitionFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, T2, T3, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, T2, T3, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceInputSourceDefinitionFactory, T3, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceInputSourceDefinitionFactory, T3> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceInputSourceDefinitionFactory, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceInputSourceDefinitionFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, T2, T3, T4, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceInputSourceDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, T2, T3, T4, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceInputSourceDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceInputSourceDefinitionFactory, T3, T4, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceInputSourceDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceInputSourceDefinitionFactory, T4, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceInputSourceDefinitionFactory, T4> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceInputSourceDefinitionFactory, InnerServiceResourceConfigurationFactory> WithResourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceInputSourceDefinitionFactory> combinedResult, Action<Humidifier.ResilienceHubV2.ServiceTypes.ResourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceConfiguration(combinedResult.T5, subFactoryAction).T2);
}
