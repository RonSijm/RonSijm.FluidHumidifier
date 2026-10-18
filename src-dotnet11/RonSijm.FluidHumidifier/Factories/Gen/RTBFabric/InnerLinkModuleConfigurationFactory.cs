// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkModuleConfigurationFactory(Action<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.ModuleConfiguration>
{

    internal InnerLinkModuleParametersFactory ModuleParametersFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkTypes.ModuleConfiguration Create()
    {
        var moduleConfigurationResult = CreateModuleConfiguration();
        factoryAction?.Invoke(moduleConfigurationResult);

        return moduleConfigurationResult;
    }

    private Humidifier.RTBFabric.LinkTypes.ModuleConfiguration CreateModuleConfiguration()
    {
        var moduleConfigurationResult = new Humidifier.RTBFabric.LinkTypes.ModuleConfiguration();

        return moduleConfigurationResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkTypes.ModuleConfiguration result)
    {
        base.CreateChildren(result);

        result.ModuleParameters ??= ModuleParametersFactory?.Build();
    }

} // End Of Class

public static class InnerLinkModuleConfigurationFactoryExtensions
{
    public static CombinedResult<InnerLinkModuleConfigurationFactory, InnerLinkModuleParametersFactory> WithModuleParameters(this InnerLinkModuleConfigurationFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null)
    {
        parentFactory.ModuleParametersFactory = new InnerLinkModuleParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModuleParametersFactory);
    }

    public static CombinedResult<InnerLinkModuleConfigurationFactory, T1, InnerLinkModuleParametersFactory> WithModuleParameters<T1>(this CombinedResult<InnerLinkModuleConfigurationFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithModuleParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleConfigurationFactory, InnerLinkModuleParametersFactory> WithModuleParameters<T1>(this CombinedResult<T1, InnerLinkModuleConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithModuleParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleConfigurationFactory, T1, T2, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2>(this CombinedResult<InnerLinkModuleConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleConfigurationFactory, T2, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2>(this CombinedResult<T1, InnerLinkModuleConfigurationFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleConfigurationFactory, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2>(this CombinedResult<T1, T2, InnerLinkModuleConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleConfigurationFactory, T1, T2, T3, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3>(this CombinedResult<InnerLinkModuleConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleConfigurationFactory, T2, T3, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3>(this CombinedResult<T1, InnerLinkModuleConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleConfigurationFactory, T3, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkModuleConfigurationFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkModuleConfigurationFactory, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkModuleConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkModuleConfigurationFactory, T1, T2, T3, T4, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3, T4>(this CombinedResult<InnerLinkModuleConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkModuleConfigurationFactory, T2, T3, T4, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkModuleConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkModuleConfigurationFactory, T3, T4, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkModuleConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkModuleConfigurationFactory, T4, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkModuleConfigurationFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkModuleConfigurationFactory, InnerLinkModuleParametersFactory> WithModuleParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkModuleConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.ModuleParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModuleParameters(combinedResult.T5, subFactoryAction).T2);
}
