// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class ProtectConfigurationFactory(string resourceName = null, Action<Humidifier.SMSVOICE.ProtectConfiguration> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.ProtectConfiguration>(resourceName)
{

    internal InnerProtectConfigurationCountryRuleSetFactory CountryRuleSetFactory { get; set; }

    protected override Humidifier.SMSVOICE.ProtectConfiguration Create()
    {
        var protectConfigurationResult = CreateProtectConfiguration();
        factoryAction?.Invoke(protectConfigurationResult);

        return protectConfigurationResult;
    }

    private Humidifier.SMSVOICE.ProtectConfiguration CreateProtectConfiguration()
    {
        var protectConfigurationResult = new Humidifier.SMSVOICE.ProtectConfiguration
        {
            GivenName = InputResourceName,
        };

        return protectConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SMSVOICE.ProtectConfiguration result)
    {
        base.CreateChildren(result);

        result.CountryRuleSet ??= CountryRuleSetFactory?.Build();
    }

} // End Of Class

public static class ProtectConfigurationFactoryExtensions
{
    public static CombinedResult<ProtectConfigurationFactory, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet(this ProtectConfigurationFactory parentFactory, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null)
    {
        parentFactory.CountryRuleSetFactory = new InnerProtectConfigurationCountryRuleSetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CountryRuleSetFactory);
    }

    public static CombinedResult<ProtectConfigurationFactory, T1, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1>(this CombinedResult<ProtectConfigurationFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProtectConfigurationFactory, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1>(this CombinedResult<T1, ProtectConfigurationFactory> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ProtectConfigurationFactory, T1, T2, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2>(this CombinedResult<ProtectConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProtectConfigurationFactory, T2, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2>(this CombinedResult<T1, ProtectConfigurationFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProtectConfigurationFactory, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2>(this CombinedResult<T1, T2, ProtectConfigurationFactory> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ProtectConfigurationFactory, T1, T2, T3, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3>(this CombinedResult<ProtectConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProtectConfigurationFactory, T2, T3, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3>(this CombinedResult<T1, ProtectConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProtectConfigurationFactory, T3, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3>(this CombinedResult<T1, T2, ProtectConfigurationFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProtectConfigurationFactory, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProtectConfigurationFactory> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ProtectConfigurationFactory, T1, T2, T3, T4, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3, T4>(this CombinedResult<ProtectConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ProtectConfigurationFactory, T2, T3, T4, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3, T4>(this CombinedResult<T1, ProtectConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ProtectConfigurationFactory, T3, T4, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProtectConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ProtectConfigurationFactory, T4, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProtectConfigurationFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ProtectConfigurationFactory, InnerProtectConfigurationCountryRuleSetFactory> WithCountryRuleSet<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProtectConfigurationFactory> combinedResult, Action<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCountryRuleSet(combinedResult.T5, subFactoryAction).T2);
}
