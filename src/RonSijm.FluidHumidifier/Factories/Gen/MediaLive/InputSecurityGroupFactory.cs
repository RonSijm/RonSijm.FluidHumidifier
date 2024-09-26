// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InputSecurityGroupFactory(string resourceName = null, Action<Humidifier.MediaLive.InputSecurityGroup> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.InputSecurityGroup>(resourceName)
{

    internal List<InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WhitelistRulesFactories { get; set; } = [];

    protected override Humidifier.MediaLive.InputSecurityGroup Create()
    {
        var inputSecurityGroupResult = CreateInputSecurityGroup();
        factoryAction?.Invoke(inputSecurityGroupResult);

        return inputSecurityGroupResult;
    }

    private Humidifier.MediaLive.InputSecurityGroup CreateInputSecurityGroup()
    {
        var inputSecurityGroupResult = new Humidifier.MediaLive.InputSecurityGroup
        {
            GivenName = InputResourceName,
        };

        return inputSecurityGroupResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.InputSecurityGroup result)
    {
        base.CreateChildren(result);

        result.WhitelistRules = WhitelistRulesFactories.Any() ? WhitelistRulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InputSecurityGroupFactoryExtensions
{
    public static CombinedResult<InputSecurityGroupFactory, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules(this InputSecurityGroupFactory parentFactory, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null)
    {
        var factory = new InnerInputSecurityGroupInputWhitelistRuleCidrFactory(subFactoryAction);
        parentFactory.WhitelistRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InputSecurityGroupFactory, T1, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1>(this CombinedResult<InputSecurityGroupFactory, T1> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, WithWhitelistRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputSecurityGroupFactory, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1>(this CombinedResult<T1, InputSecurityGroupFactory> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, WithWhitelistRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InputSecurityGroupFactory, T1, T2, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2>(this CombinedResult<InputSecurityGroupFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputSecurityGroupFactory, T2, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2>(this CombinedResult<T1, InputSecurityGroupFactory, T2> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InputSecurityGroupFactory, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2>(this CombinedResult<T1, T2, InputSecurityGroupFactory> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InputSecurityGroupFactory, T1, T2, T3, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3>(this CombinedResult<InputSecurityGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputSecurityGroupFactory, T2, T3, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3>(this CombinedResult<T1, InputSecurityGroupFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InputSecurityGroupFactory, T3, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3>(this CombinedResult<T1, T2, InputSecurityGroupFactory, T3> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InputSecurityGroupFactory, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, InputSecurityGroupFactory> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InputSecurityGroupFactory, T1, T2, T3, T4, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3, T4>(this CombinedResult<InputSecurityGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InputSecurityGroupFactory, T2, T3, T4, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3, T4>(this CombinedResult<T1, InputSecurityGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InputSecurityGroupFactory, T3, T4, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, InputSecurityGroupFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InputSecurityGroupFactory, T4, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InputSecurityGroupFactory, T4> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InputSecurityGroupFactory, InnerInputSecurityGroupInputWhitelistRuleCidrFactory> WithWhitelistRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InputSecurityGroupFactory> combinedResult, Action<Humidifier.MediaLive.InputSecurityGroupTypes.InputWhitelistRuleCidr> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWhitelistRules(combinedResult.T5, subFactoryAction));
}
