// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class SessionFactory(string resourceName = null, Action<Humidifier.Wisdom.Session> factoryAction = null) : ResourceFactory<Humidifier.Wisdom.Session>(resourceName)
{

    internal List<InnerSessionTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.Wisdom.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.Wisdom.Session CreateSession()
    {
        var sessionResult = new Humidifier.Wisdom.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.Session result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SessionFactoryExtensions
{
    public static CombinedResult<SessionFactory, InnerSessionTagsItemsFactory> WithTags(this SessionFactory parentFactory, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerSessionTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SessionFactory, T1, InnerSessionTagsItemsFactory> WithTags<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.Wisdom.SessionTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
