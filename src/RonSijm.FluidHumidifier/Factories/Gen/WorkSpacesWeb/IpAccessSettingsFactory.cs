// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class IpAccessSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.IpAccessSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.IpAccessSettings>(resourceName)
{

    internal List<InnerIpAccessSettingsIpRuleFactory> IpRulesFactories { get; set; } = [];

    protected override Humidifier.WorkSpacesWeb.IpAccessSettings Create()
    {
        var ipAccessSettingsResult = CreateIpAccessSettings();
        factoryAction?.Invoke(ipAccessSettingsResult);

        return ipAccessSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.IpAccessSettings CreateIpAccessSettings()
    {
        var ipAccessSettingsResult = new Humidifier.WorkSpacesWeb.IpAccessSettings
        {
            GivenName = InputResourceName,
        };

        return ipAccessSettingsResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesWeb.IpAccessSettings result)
    {
        base.CreateChildren(result);

        result.IpRules = IpRulesFactories.Any() ? IpRulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IpAccessSettingsFactoryExtensions
{
    public static CombinedResult<IpAccessSettingsFactory, InnerIpAccessSettingsIpRuleFactory> WithIpRules(this IpAccessSettingsFactory parentFactory, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null)
    {
        var factory = new InnerIpAccessSettingsIpRuleFactory(subFactoryAction);
        parentFactory.IpRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IpAccessSettingsFactory, T1, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1>(this CombinedResult<IpAccessSettingsFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IpAccessSettingsFactory, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1>(this CombinedResult<T1, IpAccessSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IpAccessSettingsFactory, T1, T2, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2>(this CombinedResult<IpAccessSettingsFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IpAccessSettingsFactory, T2, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2>(this CombinedResult<T1, IpAccessSettingsFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IpAccessSettingsFactory, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2>(this CombinedResult<T1, T2, IpAccessSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IpAccessSettingsFactory, T1, T2, T3, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3>(this CombinedResult<IpAccessSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IpAccessSettingsFactory, T2, T3, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3>(this CombinedResult<T1, IpAccessSettingsFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IpAccessSettingsFactory, T3, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3>(this CombinedResult<T1, T2, IpAccessSettingsFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IpAccessSettingsFactory, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, IpAccessSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IpAccessSettingsFactory, T1, T2, T3, T4, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3, T4>(this CombinedResult<IpAccessSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IpAccessSettingsFactory, T2, T3, T4, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3, T4>(this CombinedResult<T1, IpAccessSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IpAccessSettingsFactory, T3, T4, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, IpAccessSettingsFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IpAccessSettingsFactory, T4, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IpAccessSettingsFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IpAccessSettingsFactory, InnerIpAccessSettingsIpRuleFactory> WithIpRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IpAccessSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.IpAccessSettingsTypes.IpRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpRules(combinedResult.T5, subFactoryAction));
}
