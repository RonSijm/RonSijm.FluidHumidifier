// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class IPSetFactory(string resourceName = null, Action<Humidifier.GuardDuty.IPSet> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.IPSet>(resourceName)
{

    internal List<InnerIPSetTagItemFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.GuardDuty.IPSet Create()
    {
        var iPSetResult = CreateIPSet();
        factoryAction?.Invoke(iPSetResult);

        return iPSetResult;
    }

    private Humidifier.GuardDuty.IPSet CreateIPSet()
    {
        var iPSetResult = new Humidifier.GuardDuty.IPSet
        {
            GivenName = InputResourceName,
        };

        return iPSetResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.IPSet result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class IPSetFactoryExtensions
{
    public static CombinedResult<IPSetFactory, InnerIPSetTagItemFactory> WithTags(this IPSetFactory parentFactory, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerIPSetTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IPSetFactory, T1, InnerIPSetTagItemFactory> WithTags<T1>(this CombinedResult<IPSetFactory, T1> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, InnerIPSetTagItemFactory> WithTags<T1>(this CombinedResult<T1, IPSetFactory> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IPSetFactory, T1, T2, InnerIPSetTagItemFactory> WithTags<T1, T2>(this CombinedResult<IPSetFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, T2, InnerIPSetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, IPSetFactory, T2> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPSetFactory, InnerIPSetTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, IPSetFactory> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IPSetFactory, T1, T2, T3, InnerIPSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<IPSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, T2, T3, InnerIPSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, IPSetFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPSetFactory, T3, InnerIPSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, IPSetFactory, T3> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPSetFactory, InnerIPSetTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, IPSetFactory> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IPSetFactory, T1, T2, T3, T4, InnerIPSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<IPSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IPSetFactory, T2, T3, T4, InnerIPSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, IPSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IPSetFactory, T3, T4, InnerIPSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, IPSetFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IPSetFactory, T4, InnerIPSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IPSetFactory, T4> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IPSetFactory, InnerIPSetTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IPSetFactory> combinedResult, Action<Humidifier.GuardDuty.IPSetTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
