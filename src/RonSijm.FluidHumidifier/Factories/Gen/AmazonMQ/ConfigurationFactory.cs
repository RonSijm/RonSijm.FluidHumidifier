// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class ConfigurationFactory(string resourceName = null, Action<Humidifier.AmazonMQ.Configuration> factoryAction = null) : ResourceFactory<Humidifier.AmazonMQ.Configuration>(resourceName)
{

    internal List<InnerConfigurationTagsEntryFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.AmazonMQ.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.AmazonMQ.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.AmazonMQ.Configuration
        {
            GivenName = InputResourceName,
        };

        return configurationResult;
    }
    public override void CreateChildren(Humidifier.AmazonMQ.Configuration result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ConfigurationFactoryExtensions
{
    public static CombinedResult<ConfigurationFactory, InnerConfigurationTagsEntryFactory> WithTags(this ConfigurationFactory parentFactory, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null)
    {
        var factory = new InnerConfigurationTagsEntryFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigurationFactory, T1, InnerConfigurationTagsEntryFactory> WithTags<T1>(this CombinedResult<ConfigurationFactory, T1> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, InnerConfigurationTagsEntryFactory> WithTags<T1>(this CombinedResult<T1, ConfigurationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationFactory, T1, T2, InnerConfigurationTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<ConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, T2, InnerConfigurationTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, ConfigurationFactory, T2> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationFactory, InnerConfigurationTagsEntryFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ConfigurationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationFactory, T1, T2, T3, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<ConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, T2, T3, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationFactory, T3, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationFactory, T3> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationFactory, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationFactory, T1, T2, T3, T4, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationFactory, T2, T3, T4, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationFactory, T3, T4, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationFactory, T4, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationFactory, T4> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationFactory, InnerConfigurationTagsEntryFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationFactory> combinedResult, Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
