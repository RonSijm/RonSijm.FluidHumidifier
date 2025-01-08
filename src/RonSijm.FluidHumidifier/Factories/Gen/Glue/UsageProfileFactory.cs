// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class UsageProfileFactory(string resourceName = null, Action<Humidifier.Glue.UsageProfile> factoryAction = null) : ResourceFactory<Humidifier.Glue.UsageProfile>(resourceName)
{

    internal InnerUsageProfileProfileConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.Glue.UsageProfile Create()
    {
        var usageProfileResult = CreateUsageProfile();
        factoryAction?.Invoke(usageProfileResult);

        return usageProfileResult;
    }

    private Humidifier.Glue.UsageProfile CreateUsageProfile()
    {
        var usageProfileResult = new Humidifier.Glue.UsageProfile
        {
            GivenName = InputResourceName,
        };

        return usageProfileResult;
    }
    public override void CreateChildren(Humidifier.Glue.UsageProfile result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class UsageProfileFactoryExtensions
{
    public static CombinedResult<UsageProfileFactory, InnerUsageProfileProfileConfigurationFactory> WithConfiguration(this UsageProfileFactory parentFactory, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerUsageProfileProfileConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<UsageProfileFactory, T1, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1>(this CombinedResult<UsageProfileFactory, T1> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsageProfileFactory, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, UsageProfileFactory> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UsageProfileFactory, T1, T2, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<UsageProfileFactory, T1, T2> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsageProfileFactory, T2, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, UsageProfileFactory, T2> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsageProfileFactory, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, UsageProfileFactory> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UsageProfileFactory, T1, T2, T3, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<UsageProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsageProfileFactory, T2, T3, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, UsageProfileFactory, T2, T3> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsageProfileFactory, T3, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, UsageProfileFactory, T3> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsageProfileFactory, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, UsageProfileFactory> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UsageProfileFactory, T1, T2, T3, T4, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<UsageProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsageProfileFactory, T2, T3, T4, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, UsageProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsageProfileFactory, T3, T4, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, UsageProfileFactory, T3, T4> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsageProfileFactory, T4, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UsageProfileFactory, T4> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UsageProfileFactory, InnerUsageProfileProfileConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UsageProfileFactory> combinedResult, Action<Humidifier.Glue.UsageProfileTypes.ProfileConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
