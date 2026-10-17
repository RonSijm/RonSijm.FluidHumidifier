// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class TrustedEntitySetFactory(string resourceName = null, Action<Humidifier.GuardDuty.TrustedEntitySet> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.TrustedEntitySet>(resourceName)
{

    internal List<InnerTrustedEntitySetTagItemFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.GuardDuty.TrustedEntitySet Create()
    {
        var trustedEntitySetResult = CreateTrustedEntitySet();
        factoryAction?.Invoke(trustedEntitySetResult);

        return trustedEntitySetResult;
    }

    private Humidifier.GuardDuty.TrustedEntitySet CreateTrustedEntitySet()
    {
        var trustedEntitySetResult = new Humidifier.GuardDuty.TrustedEntitySet
        {
            GivenName = InputResourceName,
        };

        return trustedEntitySetResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.TrustedEntitySet result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TrustedEntitySetFactoryExtensions
{
    public static CombinedResult<TrustedEntitySetFactory, InnerTrustedEntitySetTagItemFactory> WithTags(this TrustedEntitySetFactory parentFactory, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerTrustedEntitySetTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrustedEntitySetFactory, T1, InnerTrustedEntitySetTagItemFactory> WithTags<T1>(this CombinedResult<TrustedEntitySetFactory, T1> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustedEntitySetFactory, InnerTrustedEntitySetTagItemFactory> WithTags<T1>(this CombinedResult<T1, TrustedEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TrustedEntitySetFactory, T1, T2, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2>(this CombinedResult<TrustedEntitySetFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustedEntitySetFactory, T2, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, TrustedEntitySetFactory, T2> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrustedEntitySetFactory, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, TrustedEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TrustedEntitySetFactory, T1, T2, T3, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<TrustedEntitySetFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustedEntitySetFactory, T2, T3, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, TrustedEntitySetFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrustedEntitySetFactory, T3, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, TrustedEntitySetFactory, T3> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrustedEntitySetFactory, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrustedEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TrustedEntitySetFactory, T1, T2, T3, T4, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<TrustedEntitySetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TrustedEntitySetFactory, T2, T3, T4, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, TrustedEntitySetFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TrustedEntitySetFactory, T3, T4, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrustedEntitySetFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TrustedEntitySetFactory, T4, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrustedEntitySetFactory, T4> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TrustedEntitySetFactory, InnerTrustedEntitySetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrustedEntitySetFactory> combinedResult, Action<Humidifier.GuardDuty.TrustedEntitySetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
