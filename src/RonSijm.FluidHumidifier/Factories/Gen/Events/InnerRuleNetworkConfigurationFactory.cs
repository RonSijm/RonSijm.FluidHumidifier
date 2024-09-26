// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleNetworkConfigurationFactory(Action<Humidifier.Events.RuleTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.NetworkConfiguration>
{

    internal InnerRuleAwsVpcConfigurationFactory AwsVpcConfigurationFactory { get; set; }

    protected override Humidifier.Events.RuleTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.Events.RuleTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.Events.RuleTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Events.RuleTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.AwsVpcConfiguration ??= AwsVpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRuleNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRuleNetworkConfigurationFactory, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration(this InnerRuleNetworkConfigurationFactory parentFactory, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.AwsVpcConfigurationFactory = new InnerRuleAwsVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsVpcConfigurationFactory);
    }

    public static CombinedResult<InnerRuleNetworkConfigurationFactory, T1, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1>(this CombinedResult<InnerRuleNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleNetworkConfigurationFactory, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1>(this CombinedResult<T1, InnerRuleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleNetworkConfigurationFactory, T1, T2, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2>(this CombinedResult<InnerRuleNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleNetworkConfigurationFactory, T2, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2>(this CombinedResult<T1, InnerRuleNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleNetworkConfigurationFactory, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRuleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleNetworkConfigurationFactory, T1, T2, T3, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<InnerRuleNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleNetworkConfigurationFactory, T2, T3, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRuleNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleNetworkConfigurationFactory, T3, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleNetworkConfigurationFactory, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleNetworkConfigurationFactory, T1, T2, T3, T4, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRuleNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleNetworkConfigurationFactory, T2, T3, T4, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleNetworkConfigurationFactory, T3, T4, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleNetworkConfigurationFactory, T4, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleNetworkConfigurationFactory, InnerRuleAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleNetworkConfigurationFactory> combinedResult, Action<Humidifier.Events.RuleTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T5, subFactoryAction));
}
