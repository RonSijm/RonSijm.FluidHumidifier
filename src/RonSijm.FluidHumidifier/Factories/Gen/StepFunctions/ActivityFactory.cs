// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.StepFunctions;

public class ActivityFactory(string resourceName = null, Action<Humidifier.StepFunctions.Activity> factoryAction = null) : ResourceFactory<Humidifier.StepFunctions.Activity>(resourceName)
{

    internal List<InnerActivityTagsEntryFactory> TagsFactories { get; set; } = [];

    internal InnerActivityEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.StepFunctions.Activity Create()
    {
        var activityResult = CreateActivity();
        factoryAction?.Invoke(activityResult);

        return activityResult;
    }

    private Humidifier.StepFunctions.Activity CreateActivity()
    {
        var activityResult = new Humidifier.StepFunctions.Activity
        {
            GivenName = InputResourceName,
        };

        return activityResult;
    }
    public override void CreateChildren(Humidifier.StepFunctions.Activity result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class ActivityFactoryExtensions
{
    public static CombinedResult<ActivityFactory, InnerActivityTagsEntryFactory> WithTags(this ActivityFactory parentFactory, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null)
    {
        var factory = new InnerActivityTagsEntryFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ActivityFactory, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration(this ActivityFactory parentFactory, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerActivityEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<ActivityFactory, T1, InnerActivityTagsEntryFactory> WithTags<T1>(this CombinedResult<ActivityFactory, T1> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, InnerActivityTagsEntryFactory> WithTags<T1>(this CombinedResult<T1, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, T2, InnerActivityTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<ActivityFactory, T1, T2> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, T2, InnerActivityTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, ActivityFactory, T2> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ActivityFactory, InnerActivityTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, T2, T3, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<ActivityFactory, T1, T2, T3> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, T2, T3, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ActivityFactory, T2, T3> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ActivityFactory, T3, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ActivityFactory, T3> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ActivityFactory, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, T2, T3, T4, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ActivityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, T2, T3, T4, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ActivityFactory, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ActivityFactory, T3, T4, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ActivityFactory, T3, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ActivityFactory, T4, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ActivityFactory, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ActivityFactory, InnerActivityTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<ActivityFactory, T1> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, T2, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<ActivityFactory, T1, T2> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, T2, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, ActivityFactory, T2> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ActivityFactory, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, T2, T3, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<ActivityFactory, T1, T2, T3> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, T2, T3, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, ActivityFactory, T2, T3> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ActivityFactory, T3, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ActivityFactory, T3> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ActivityFactory, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ActivityFactory, T1, T2, T3, T4, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<ActivityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ActivityFactory, T2, T3, T4, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ActivityFactory, T2, T3, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ActivityFactory, T3, T4, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ActivityFactory, T3, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ActivityFactory, T4, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ActivityFactory, T4> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ActivityFactory, InnerActivityEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ActivityFactory> combinedResult, Action<Humidifier.StepFunctions.ActivityTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
