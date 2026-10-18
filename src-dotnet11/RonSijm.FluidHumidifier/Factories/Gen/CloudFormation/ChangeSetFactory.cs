// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class ChangeSetFactory(string resourceName = null, Action<Humidifier.CloudFormation.ChangeSet> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.ChangeSet>(resourceName)
{

    internal List<InnerChangeSetTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.CloudFormation.ChangeSet Create()
    {
        var changeSetResult = CreateChangeSet();
        factoryAction?.Invoke(changeSetResult);

        return changeSetResult;
    }

    private Humidifier.CloudFormation.ChangeSet CreateChangeSet()
    {
        var changeSetResult = new Humidifier.CloudFormation.ChangeSet
        {
            GivenName = InputResourceName,
        };

        return changeSetResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.ChangeSet result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ChangeSetFactoryExtensions
{
    public static CombinedResult<ChangeSetFactory, InnerChangeSetTagsItemsFactory> WithTags(this ChangeSetFactory parentFactory, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerChangeSetTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChangeSetFactory, T1, InnerChangeSetTagsItemsFactory> WithTags<T1>(this CombinedResult<ChangeSetFactory, T1> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChangeSetFactory, InnerChangeSetTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ChangeSetFactory> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ChangeSetFactory, T1, T2, InnerChangeSetTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ChangeSetFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChangeSetFactory, T2, InnerChangeSetTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ChangeSetFactory, T2> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChangeSetFactory, InnerChangeSetTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ChangeSetFactory> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ChangeSetFactory, T1, T2, T3, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ChangeSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChangeSetFactory, T2, T3, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ChangeSetFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChangeSetFactory, T3, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ChangeSetFactory, T3> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChangeSetFactory, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChangeSetFactory> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ChangeSetFactory, T1, T2, T3, T4, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ChangeSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ChangeSetFactory, T2, T3, T4, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ChangeSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ChangeSetFactory, T3, T4, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChangeSetFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ChangeSetFactory, T4, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChangeSetFactory, T4> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ChangeSetFactory, InnerChangeSetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChangeSetFactory> combinedResult, Action<Humidifier.CloudFormation.ChangeSetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
