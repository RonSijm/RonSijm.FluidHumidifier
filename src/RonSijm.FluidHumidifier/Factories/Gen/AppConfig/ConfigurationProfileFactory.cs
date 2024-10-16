// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class ConfigurationProfileFactory(string resourceName = null, Action<Humidifier.AppConfig.ConfigurationProfile> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.ConfigurationProfile>(resourceName)
{

    internal List<InnerConfigurationProfileValidatorsFactory> ValidatorsFactories { get; set; } = [];

    internal List<InnerConfigurationProfileTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.AppConfig.ConfigurationProfile Create()
    {
        var configurationProfileResult = CreateConfigurationProfile();
        factoryAction?.Invoke(configurationProfileResult);

        return configurationProfileResult;
    }

    private Humidifier.AppConfig.ConfigurationProfile CreateConfigurationProfile()
    {
        var configurationProfileResult = new Humidifier.AppConfig.ConfigurationProfile
        {
            GivenName = InputResourceName,
        };

        return configurationProfileResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.ConfigurationProfile result)
    {
        base.CreateChildren(result);

        result.Validators = ValidatorsFactories.Any() ? ValidatorsFactories.Select(x => x.Build()).ToList() : null;
        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ConfigurationProfileFactoryExtensions
{
    public static CombinedResult<ConfigurationProfileFactory, InnerConfigurationProfileValidatorsFactory> WithValidators(this ConfigurationProfileFactory parentFactory, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null)
    {
        var factory = new InnerConfigurationProfileValidatorsFactory(subFactoryAction);
        parentFactory.ValidatorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigurationProfileFactory, InnerConfigurationProfileTagsFactory> WithTags(this ConfigurationProfileFactory parentFactory, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerConfigurationProfileTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigurationProfileFactory, T1, InnerConfigurationProfileValidatorsFactory> WithValidators<T1>(this CombinedResult<ConfigurationProfileFactory, T1> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidators(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, InnerConfigurationProfileValidatorsFactory> WithValidators<T1>(this CombinedResult<T1, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidators(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, T2, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2>(this CombinedResult<ConfigurationProfileFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, T2, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2>(this CombinedResult<T1, ConfigurationProfileFactory, T2> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationProfileFactory, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2>(this CombinedResult<T1, T2, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, T2, T3, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3>(this CombinedResult<ConfigurationProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, T2, T3, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3>(this CombinedResult<T1, ConfigurationProfileFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationProfileFactory, T3, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationProfileFactory, T3> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationProfileFactory, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, T2, T3, T4, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3, T4>(this CombinedResult<ConfigurationProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, T2, T3, T4, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationProfileFactory, T3, T4, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationProfileFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationProfileFactory, T4, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationProfileFactory, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationProfileFactory, InnerConfigurationProfileValidatorsFactory> WithValidators<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Validators> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidators(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, InnerConfigurationProfileTagsFactory> WithTags<T1>(this CombinedResult<ConfigurationProfileFactory, T1> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, InnerConfigurationProfileTagsFactory> WithTags<T1>(this CombinedResult<T1, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, T2, InnerConfigurationProfileTagsFactory> WithTags<T1, T2>(this CombinedResult<ConfigurationProfileFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, T2, InnerConfigurationProfileTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, ConfigurationProfileFactory, T2> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationProfileFactory, InnerConfigurationProfileTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, T2, T3, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<ConfigurationProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, T2, T3, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ConfigurationProfileFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationProfileFactory, T3, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationProfileFactory, T3> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationProfileFactory, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationProfileFactory, T1, T2, T3, T4, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ConfigurationProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationProfileFactory, T2, T3, T4, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationProfileFactory, T3, T4, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationProfileFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationProfileFactory, T4, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationProfileFactory, T4> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationProfileFactory, InnerConfigurationProfileTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationProfileFactory> combinedResult, Action<Humidifier.AppConfig.ConfigurationProfileTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
