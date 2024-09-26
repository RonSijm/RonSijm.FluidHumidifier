// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class EnvironmentFactory(string resourceName = null, Action<Humidifier.ElasticBeanstalk.Environment> factoryAction = null) : ResourceFactory<Humidifier.ElasticBeanstalk.Environment>(resourceName)
{

    internal List<InnerEnvironmentOptionSettingFactory> OptionSettingsFactories { get; set; } = [];

    internal InnerEnvironmentTierFactory TierFactory { get; set; }

    protected override Humidifier.ElasticBeanstalk.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.ElasticBeanstalk.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.ElasticBeanstalk.Environment
        {
            GivenName = InputResourceName,
        };

        return environmentResult;
    }
    public override void CreateChildren(Humidifier.ElasticBeanstalk.Environment result)
    {
        base.CreateChildren(result);

        result.OptionSettings = OptionSettingsFactories.Any() ? OptionSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.Tier ??= TierFactory?.Build();
    }

} // End Of Class

public static class EnvironmentFactoryExtensions
{
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentOptionSettingFactory> WithOptionSettings(this EnvironmentFactory parentFactory, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentOptionSettingFactory(subFactoryAction);
        parentFactory.OptionSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentFactory, InnerEnvironmentTierFactory> WithTier(this EnvironmentFactory parentFactory, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null)
    {
        parentFactory.TierFactory = new InnerEnvironmentTierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TierFactory);
    }

    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.OptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, InnerEnvironmentTierFactory> WithTier<T1>(this CombinedResult<EnvironmentFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, InnerEnvironmentTierFactory> WithTier<T1>(this CombinedResult<T1, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, WithTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, InnerEnvironmentTierFactory> WithTier<T1, T2>(this CombinedResult<EnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, InnerEnvironmentTierFactory> WithTier<T1, T2>(this CombinedResult<T1, EnvironmentFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, InnerEnvironmentTierFactory> WithTier<T1, T2>(this CombinedResult<T1, T2, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, InnerEnvironmentTierFactory> WithTier<T1, T2, T3>(this CombinedResult<EnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, InnerEnvironmentTierFactory> WithTier<T1, T2, T3>(this CombinedResult<T1, EnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, InnerEnvironmentTierFactory> WithTier<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, InnerEnvironmentTierFactory> WithTier<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentFactory, T1, T2, T3, T4, InnerEnvironmentTierFactory> WithTier<T1, T2, T3, T4>(this CombinedResult<EnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentFactory, T2, T3, T4, InnerEnvironmentTierFactory> WithTier<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentFactory, T3, T4, InnerEnvironmentTierFactory> WithTier<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentFactory, T4, InnerEnvironmentTierFactory> WithTier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentFactory, InnerEnvironmentTierFactory> WithTier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTier(combinedResult.T5, subFactoryAction));
}
