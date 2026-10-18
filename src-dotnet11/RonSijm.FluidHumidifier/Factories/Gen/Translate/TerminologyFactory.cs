// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class TerminologyFactory(string resourceName = null, Action<Humidifier.Translate.Terminology> factoryAction = null) : ResourceFactory<Humidifier.Translate.Terminology>(resourceName)
{

    internal List<InnerTerminologyTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerTerminologyEncryptionKeyFactory EncryptionKeyFactory { get; set; }

    internal InnerTerminologyTerminologyDataFactory TerminologyDataFactory { get; set; }

    protected override Humidifier.Translate.Terminology Create()
    {
        var terminologyResult = CreateTerminology();
        factoryAction?.Invoke(terminologyResult);

        return terminologyResult;
    }

    private Humidifier.Translate.Terminology CreateTerminology()
    {
        var terminologyResult = new Humidifier.Translate.Terminology
        {
            GivenName = InputResourceName,
        };

        return terminologyResult;
    }
    public override void CreateChildren(Humidifier.Translate.Terminology result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.EncryptionKey ??= EncryptionKeyFactory?.Build();
        result.TerminologyData ??= TerminologyDataFactory?.Build();
    }

} // End Of Class

public static class TerminologyFactoryExtensions
{
    public static CombinedResult<TerminologyFactory, InnerTerminologyTagsItemsFactory> WithTags(this TerminologyFactory parentFactory, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerTerminologyTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TerminologyFactory, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey(this TerminologyFactory parentFactory, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyFactory = new InnerTerminologyEncryptionKeyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyFactory);
    }

    public static CombinedResult<TerminologyFactory, InnerTerminologyTerminologyDataFactory> WithTerminologyData(this TerminologyFactory parentFactory, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null)
    {
        parentFactory.TerminologyDataFactory = new InnerTerminologyTerminologyDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TerminologyDataFactory);
    }

    public static CombinedResult<TerminologyFactory, T1, InnerTerminologyTagsItemsFactory> WithTags<T1>(this CombinedResult<TerminologyFactory, T1> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, InnerTerminologyTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, InnerTerminologyTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<TerminologyFactory, T1, T2> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, InnerTerminologyTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, TerminologyFactory, T2> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, InnerTerminologyTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, T3, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<TerminologyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, T3, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, TerminologyFactory, T2, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, T3, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, TerminologyFactory, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TerminologyFactory, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, T3, T4, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<TerminologyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, T3, T4, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, TerminologyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, T3, T4, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, TerminologyFactory, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TerminologyFactory, T4, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TerminologyFactory, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TerminologyFactory, InnerTerminologyTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1>(this CombinedResult<TerminologyFactory, T1> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1>(this CombinedResult<T1, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<TerminologyFactory, T1, T2> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, TerminologyFactory, T2> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, T2, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, T3, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<TerminologyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, T3, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, TerminologyFactory, T2, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, T3, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, TerminologyFactory, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TerminologyFactory, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, T3, T4, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<TerminologyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, T3, T4, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, TerminologyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, T3, T4, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, TerminologyFactory, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TerminologyFactory, T4, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TerminologyFactory, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TerminologyFactory, InnerTerminologyEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1>(this CombinedResult<TerminologyFactory, T1> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, WithTerminologyData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1>(this CombinedResult<T1, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, WithTerminologyData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2>(this CombinedResult<TerminologyFactory, T1, T2> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2>(this CombinedResult<T1, TerminologyFactory, T2> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2>(this CombinedResult<T1, T2, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, T3, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3>(this CombinedResult<TerminologyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, T3, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3>(this CombinedResult<T1, TerminologyFactory, T2, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, T3, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3>(this CombinedResult<T1, T2, TerminologyFactory, T3> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TerminologyFactory, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3>(this CombinedResult<T1, T2, T3, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TerminologyFactory, T1, T2, T3, T4, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3, T4>(this CombinedResult<TerminologyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TerminologyFactory, T2, T3, T4, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3, T4>(this CombinedResult<T1, TerminologyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TerminologyFactory, T3, T4, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3, T4>(this CombinedResult<T1, T2, TerminologyFactory, T3, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TerminologyFactory, T4, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TerminologyFactory, T4> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TerminologyFactory, InnerTerminologyTerminologyDataFactory> WithTerminologyData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TerminologyFactory> combinedResult, Action<Humidifier.Translate.TerminologyTypes.TerminologyData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTerminologyData(combinedResult.T5, subFactoryAction).T2);
}
