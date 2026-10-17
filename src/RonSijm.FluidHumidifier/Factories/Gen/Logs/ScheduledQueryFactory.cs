// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class ScheduledQueryFactory(string resourceName = null, Action<Humidifier.Logs.ScheduledQuery> factoryAction = null) : ResourceFactory<Humidifier.Logs.ScheduledQuery>(resourceName)
{

    internal List<InnerScheduledQueryTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerScheduledQueryDestinationConfigurationFactory DestinationConfigurationFactory { get; set; }

    protected override Humidifier.Logs.ScheduledQuery Create()
    {
        var scheduledQueryResult = CreateScheduledQuery();
        factoryAction?.Invoke(scheduledQueryResult);

        return scheduledQueryResult;
    }

    private Humidifier.Logs.ScheduledQuery CreateScheduledQuery()
    {
        var scheduledQueryResult = new Humidifier.Logs.ScheduledQuery
        {
            GivenName = InputResourceName,
        };

        return scheduledQueryResult;
    }
    public override void CreateChildren(Humidifier.Logs.ScheduledQuery result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.DestinationConfiguration ??= DestinationConfigurationFactory?.Build();
    }

} // End Of Class

public static class ScheduledQueryFactoryExtensions
{
    public static CombinedResult<ScheduledQueryFactory, InnerScheduledQueryTagsItemsFactory> WithTags(this ScheduledQueryFactory parentFactory, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerScheduledQueryTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ScheduledQueryFactory, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration(this ScheduledQueryFactory parentFactory, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationConfigurationFactory = new InnerScheduledQueryDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigurationFactory);
    }

    public static CombinedResult<ScheduledQueryFactory, T1, InnerScheduledQueryTagsItemsFactory> WithTags<T1>(this CombinedResult<ScheduledQueryFactory, T1> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, InnerScheduledQueryTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, T2, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ScheduledQueryFactory, T1, T2> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, T2, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ScheduledQueryFactory, T2> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledQueryFactory, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, T2, T3, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ScheduledQueryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, T2, T3, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ScheduledQueryFactory, T2, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledQueryFactory, T3, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ScheduledQueryFactory, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledQueryFactory, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, T2, T3, T4, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ScheduledQueryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, T2, T3, T4, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ScheduledQueryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledQueryFactory, T3, T4, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduledQueryFactory, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledQueryFactory, T4, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduledQueryFactory, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ScheduledQueryFactory, InnerScheduledQueryTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<ScheduledQueryFactory, T1> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<T1, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, T2, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<ScheduledQueryFactory, T1, T2> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, T2, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, ScheduledQueryFactory, T2> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledQueryFactory, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, T2, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, T2, T3, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<ScheduledQueryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, T2, T3, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, ScheduledQueryFactory, T2, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledQueryFactory, T3, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ScheduledQueryFactory, T3> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledQueryFactory, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ScheduledQueryFactory, T1, T2, T3, T4, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<ScheduledQueryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledQueryFactory, T2, T3, T4, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ScheduledQueryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledQueryFactory, T3, T4, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduledQueryFactory, T3, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledQueryFactory, T4, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduledQueryFactory, T4> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ScheduledQueryFactory, InnerScheduledQueryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduledQueryFactory> combinedResult, Action<Humidifier.Logs.ScheduledQueryTypes.DestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
