// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class ParallelDataFactory(string resourceName = null, Action<Humidifier.Translate.ParallelData> factoryAction = null) : ResourceFactory<Humidifier.Translate.ParallelData>(resourceName)
{

    internal List<InnerParallelDataTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerParallelDataEncryptionKeyFactory EncryptionKeyFactory { get; set; }

    internal InnerParallelDataParallelDataConfigFactory ParallelDataConfigFactory { get; set; }

    protected override Humidifier.Translate.ParallelData Create()
    {
        var parallelDataResult = CreateParallelData();
        factoryAction?.Invoke(parallelDataResult);

        return parallelDataResult;
    }

    private Humidifier.Translate.ParallelData CreateParallelData()
    {
        var parallelDataResult = new Humidifier.Translate.ParallelData
        {
            GivenName = InputResourceName,
        };

        return parallelDataResult;
    }
    public override void CreateChildren(Humidifier.Translate.ParallelData result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.EncryptionKey ??= EncryptionKeyFactory?.Build();
        result.ParallelDataConfig ??= ParallelDataConfigFactory?.Build();
    }

} // End Of Class

public static class ParallelDataFactoryExtensions
{
    public static CombinedResult<ParallelDataFactory, InnerParallelDataTagsItemsFactory> WithTags(this ParallelDataFactory parentFactory, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerParallelDataTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ParallelDataFactory, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey(this ParallelDataFactory parentFactory, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyFactory = new InnerParallelDataEncryptionKeyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyFactory);
    }

    public static CombinedResult<ParallelDataFactory, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig(this ParallelDataFactory parentFactory, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null)
    {
        parentFactory.ParallelDataConfigFactory = new InnerParallelDataParallelDataConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParallelDataConfigFactory);
    }

    public static CombinedResult<ParallelDataFactory, T1, InnerParallelDataTagsItemsFactory> WithTags<T1>(this CombinedResult<ParallelDataFactory, T1> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, InnerParallelDataTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, InnerParallelDataTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ParallelDataFactory, T1, T2> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, InnerParallelDataTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ParallelDataFactory, T2> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, InnerParallelDataTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, T3, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ParallelDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, T3, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ParallelDataFactory, T2, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, T3, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ParallelDataFactory, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ParallelDataFactory, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, T3, T4, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ParallelDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, T3, T4, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ParallelDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, T3, T4, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ParallelDataFactory, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ParallelDataFactory, T4, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ParallelDataFactory, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ParallelDataFactory, InnerParallelDataTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1>(this CombinedResult<ParallelDataFactory, T1> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1>(this CombinedResult<T1, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<ParallelDataFactory, T1, T2> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, ParallelDataFactory, T2> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2>(this CombinedResult<T1, T2, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, T3, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<ParallelDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, T3, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, ParallelDataFactory, T2, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, T3, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, ParallelDataFactory, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ParallelDataFactory, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, T3, T4, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<ParallelDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, T3, T4, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, ParallelDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, T3, T4, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, ParallelDataFactory, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ParallelDataFactory, T4, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ParallelDataFactory, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ParallelDataFactory, InnerParallelDataEncryptionKeyFactory> WithEncryptionKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKey(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1>(this CombinedResult<ParallelDataFactory, T1> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1>(this CombinedResult<T1, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2>(this CombinedResult<ParallelDataFactory, T1, T2> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2>(this CombinedResult<T1, ParallelDataFactory, T2> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2>(this CombinedResult<T1, T2, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, T3, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3>(this CombinedResult<ParallelDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, T3, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3>(this CombinedResult<T1, ParallelDataFactory, T2, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, T3, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, ParallelDataFactory, T3> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ParallelDataFactory, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ParallelDataFactory, T1, T2, T3, T4, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3, T4>(this CombinedResult<ParallelDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ParallelDataFactory, T2, T3, T4, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, ParallelDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ParallelDataFactory, T3, T4, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ParallelDataFactory, T3, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ParallelDataFactory, T4, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ParallelDataFactory, T4> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ParallelDataFactory, InnerParallelDataParallelDataConfigFactory> WithParallelDataConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ParallelDataFactory> combinedResult, Action<Humidifier.Translate.ParallelDataTypes.ParallelDataConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelDataConfig(combinedResult.T5, subFactoryAction).T2);
}
