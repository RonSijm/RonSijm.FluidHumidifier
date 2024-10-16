// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigRuleSourceFactory(Action<Humidifier.Config.ConfigRuleTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigRuleTypes.Source>
{

    internal InnerConfigRuleCustomPolicyDetailsFactory CustomPolicyDetailsFactory { get; set; }

    protected override Humidifier.Config.ConfigRuleTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.Config.ConfigRuleTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.Config.ConfigRuleTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.Config.ConfigRuleTypes.Source result)
    {
        base.CreateChildren(result);

        result.CustomPolicyDetails ??= CustomPolicyDetailsFactory?.Build();
    }

} // End Of Class

public static class InnerConfigRuleSourceFactoryExtensions
{
    public static CombinedResult<InnerConfigRuleSourceFactory, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails(this InnerConfigRuleSourceFactory parentFactory, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null)
    {
        parentFactory.CustomPolicyDetailsFactory = new InnerConfigRuleCustomPolicyDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomPolicyDetailsFactory);
    }

    public static CombinedResult<InnerConfigRuleSourceFactory, T1, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1>(this CombinedResult<InnerConfigRuleSourceFactory, T1> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigRuleSourceFactory, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1>(this CombinedResult<T1, InnerConfigRuleSourceFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigRuleSourceFactory, T1, T2, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2>(this CombinedResult<InnerConfigRuleSourceFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigRuleSourceFactory, T2, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2>(this CombinedResult<T1, InnerConfigRuleSourceFactory, T2> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigRuleSourceFactory, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2>(this CombinedResult<T1, T2, InnerConfigRuleSourceFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigRuleSourceFactory, T1, T2, T3, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3>(this CombinedResult<InnerConfigRuleSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigRuleSourceFactory, T2, T3, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3>(this CombinedResult<T1, InnerConfigRuleSourceFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigRuleSourceFactory, T3, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigRuleSourceFactory, T3> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigRuleSourceFactory, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigRuleSourceFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigRuleSourceFactory, T1, T2, T3, T4, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3, T4>(this CombinedResult<InnerConfigRuleSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigRuleSourceFactory, T2, T3, T4, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigRuleSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigRuleSourceFactory, T3, T4, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigRuleSourceFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigRuleSourceFactory, T4, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigRuleSourceFactory, T4> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigRuleSourceFactory, InnerConfigRuleCustomPolicyDetailsFactory> WithCustomPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigRuleSourceFactory> combinedResult, Action<Humidifier.Config.ConfigRuleTypes.CustomPolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPolicyDetails(combinedResult.T5, subFactoryAction));
}
