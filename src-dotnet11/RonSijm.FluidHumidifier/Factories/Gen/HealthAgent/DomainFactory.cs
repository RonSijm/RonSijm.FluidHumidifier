// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthAgent;

public class DomainFactory(string resourceName = null, Action<Humidifier.HealthAgent.Domain> factoryAction = null) : ResourceFactory<Humidifier.HealthAgent.Domain>(resourceName)
{

    internal List<InnerDomainTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.HealthAgent.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.HealthAgent.Domain CreateDomain()
    {
        var domainResult = new Humidifier.HealthAgent.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.HealthAgent.Domain result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainTagsItemsFactory> WithTags(this DomainFactory parentFactory, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerDomainTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DomainFactory, T1, InnerDomainTagsItemsFactory> WithTags<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, InnerDomainTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.HealthAgent.DomainTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
