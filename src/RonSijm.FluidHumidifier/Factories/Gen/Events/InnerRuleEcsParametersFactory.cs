// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleEcsParametersFactory(Action<Humidifier.Events.RuleTypes.EcsParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.EcsParameters>
{

    internal InnerRuleNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    protected override Humidifier.Events.RuleTypes.EcsParameters Create()
    {
        var ecsParametersResult = CreateEcsParameters();
        factoryAction?.Invoke(ecsParametersResult);

        return ecsParametersResult;
    }

    private Humidifier.Events.RuleTypes.EcsParameters CreateEcsParameters()
    {
        var ecsParametersResult = new Humidifier.Events.RuleTypes.EcsParameters();

        return ecsParametersResult;
    }
    public override void CreateChildren(Humidifier.Events.RuleTypes.EcsParameters result)
    {
        base.CreateChildren(result);

        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRuleEcsParametersFactoryExtensions
{
    public static CombinedResult<InnerRuleEcsParametersFactory, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration(this InnerRuleEcsParametersFactory parentFactory, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerRuleNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<InnerRuleEcsParametersFactory, T1, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<InnerRuleEcsParametersFactory, T1> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleEcsParametersFactory, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, InnerRuleEcsParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleEcsParametersFactory, T1, T2, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<InnerRuleEcsParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleEcsParametersFactory, T2, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, InnerRuleEcsParametersFactory, T2> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleEcsParametersFactory, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRuleEcsParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleEcsParametersFactory, T1, T2, T3, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<InnerRuleEcsParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleEcsParametersFactory, T2, T3, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRuleEcsParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleEcsParametersFactory, T3, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleEcsParametersFactory, T3> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleEcsParametersFactory, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleEcsParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleEcsParametersFactory, T1, T2, T3, T4, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRuleEcsParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleEcsParametersFactory, T2, T3, T4, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleEcsParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleEcsParametersFactory, T3, T4, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleEcsParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleEcsParametersFactory, T4, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleEcsParametersFactory, T4> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleEcsParametersFactory, InnerRuleNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleEcsParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction));
}
