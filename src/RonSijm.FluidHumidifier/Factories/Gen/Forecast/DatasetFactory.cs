// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Forecast;

public class DatasetFactory(string resourceName = null, Action<Humidifier.Forecast.Dataset> factoryAction = null) : ResourceFactory<Humidifier.Forecast.Dataset>(resourceName)
{

    internal List<InnerDatasetTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerDatasetSchemaFactory SchemaFactory { get; set; }

    internal InnerDatasetEncryptionConfigFactory EncryptionConfigFactory { get; set; }

    protected override Humidifier.Forecast.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.Forecast.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.Forecast.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.Forecast.Dataset result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.Schema ??= SchemaFactory?.Build();
        result.EncryptionConfig ??= EncryptionConfigFactory?.Build();
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
    public static CombinedResult<DatasetFactory, InnerDatasetTagsItemsFactory> WithTags(this DatasetFactory parentFactory, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerDatasetTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DatasetFactory, InnerDatasetSchemaFactory> WithSchema(this DatasetFactory parentFactory, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null)
    {
        parentFactory.SchemaFactory = new InnerDatasetSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaFactory);
    }

    public static CombinedResult<DatasetFactory, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig(this DatasetFactory parentFactory, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigFactory = new InnerDatasetEncryptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigFactory);
    }

    public static CombinedResult<DatasetFactory, T1, InnerDatasetTagsItemsFactory> WithTags<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, InnerDatasetSchemaFactory> WithSchema<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetSchemaFactory> WithSchema<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetEncryptionConfigFactory> WithEncryptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.Forecast.DatasetTypes.EncryptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfig(combinedResult.T5, subFactoryAction));
}
