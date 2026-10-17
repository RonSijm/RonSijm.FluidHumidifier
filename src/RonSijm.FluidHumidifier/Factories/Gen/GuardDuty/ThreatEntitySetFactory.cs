// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class ThreatEntitySetFactory(string resourceName = null, Action<Humidifier.GuardDuty.ThreatEntitySet> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.ThreatEntitySet>(resourceName)
{

    internal List<InnerThreatEntitySetTagItemFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.GuardDuty.ThreatEntitySet Create()
    {
        var threatEntitySetResult = CreateThreatEntitySet();
        factoryAction?.Invoke(threatEntitySetResult);

        return threatEntitySetResult;
    }

    private Humidifier.GuardDuty.ThreatEntitySet CreateThreatEntitySet()
    {
        var threatEntitySetResult = new Humidifier.GuardDuty.ThreatEntitySet
        {
            GivenName = InputResourceName,
        };

        return threatEntitySetResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.ThreatEntitySet result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ThreatEntitySetFactoryExtensions
{
    public static CombinedResult<ThreatEntitySetFactory, InnerThreatEntitySetTagItemFactory> WithTags(this ThreatEntitySetFactory parentFactory, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerThreatEntitySetTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ThreatEntitySetFactory, T1, InnerThreatEntitySetTagItemFactory> WithTags<T1>(this CombinedResult<ThreatEntitySetFactory, T1> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThreatEntitySetFactory, InnerThreatEntitySetTagItemFactory> WithTags<T1>(this CombinedResult<T1, ThreatEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ThreatEntitySetFactory, T1, T2, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2>(this CombinedResult<ThreatEntitySetFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThreatEntitySetFactory, T2, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, ThreatEntitySetFactory, T2> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ThreatEntitySetFactory, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ThreatEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ThreatEntitySetFactory, T1, T2, T3, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<ThreatEntitySetFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThreatEntitySetFactory, T2, T3, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ThreatEntitySetFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ThreatEntitySetFactory, T3, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ThreatEntitySetFactory, T3> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ThreatEntitySetFactory, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThreatEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ThreatEntitySetFactory, T1, T2, T3, T4, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ThreatEntitySetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ThreatEntitySetFactory, T2, T3, T4, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ThreatEntitySetFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ThreatEntitySetFactory, T3, T4, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThreatEntitySetFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ThreatEntitySetFactory, T4, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThreatEntitySetFactory, T4> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ThreatEntitySetFactory, InnerThreatEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThreatEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.ThreatEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
