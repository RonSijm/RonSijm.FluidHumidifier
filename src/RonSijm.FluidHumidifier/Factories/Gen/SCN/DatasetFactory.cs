// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class DatasetFactory(string resourceName = null, Action<Humidifier.SCN.Dataset> factoryAction = null) : ResourceFactory<Humidifier.SCN.Dataset>(resourceName)
{

    internal InnerDatasetSchemaFactory SchemaFactory { get; set; }

    internal InnerDatasetPartitionSpecFactory PartitionSpecFactory { get; set; }

    protected override Humidifier.SCN.Dataset Create()
    {
        var datasetResult = CreateDataset();
        factoryAction?.Invoke(datasetResult);

        return datasetResult;
    }

    private Humidifier.SCN.Dataset CreateDataset()
    {
        var datasetResult = new Humidifier.SCN.Dataset
        {
            GivenName = InputResourceName,
        };

        return datasetResult;
    }
    public override void CreateChildren(Humidifier.SCN.Dataset result)
    {
        base.CreateChildren(result);

        result.Schema ??= SchemaFactory?.Build();
        result.PartitionSpec ??= PartitionSpecFactory?.Build();
    }

} // End Of Class

public static class DatasetFactoryExtensions
{
    public static CombinedResult<DatasetFactory, InnerDatasetSchemaFactory> WithSchema(this DatasetFactory parentFactory, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null)
    {
        parentFactory.SchemaFactory = new InnerDatasetSchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaFactory);
    }

    public static CombinedResult<DatasetFactory, InnerDatasetPartitionSpecFactory> WithPartitionSpec(this DatasetFactory parentFactory, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null)
    {
        parentFactory.PartitionSpecFactory = new InnerDatasetPartitionSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PartitionSpecFactory);
    }

    public static CombinedResult<DatasetFactory, T1, InnerDatasetSchemaFactory> WithSchema<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetSchemaFactory> WithSchema<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetSchemaFactory> WithSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.Schema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchema(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1>(this CombinedResult<DatasetFactory, T1> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithPartitionSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1>(this CombinedResult<T1, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithPartitionSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2>(this CombinedResult<DatasetFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2>(this CombinedResult<T1, DatasetFactory, T2> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2>(this CombinedResult<T1, T2, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3>(this CombinedResult<DatasetFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3>(this CombinedResult<T1, DatasetFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3>(this CombinedResult<T1, T2, DatasetFactory, T3> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetFactory, T1, T2, T3, T4, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3, T4>(this CombinedResult<DatasetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetFactory, T2, T3, T4, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3, T4>(this CombinedResult<T1, DatasetFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetFactory, T3, T4, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetFactory, T4, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetFactory, T4> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetFactory, InnerDatasetPartitionSpecFactory> WithPartitionSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetFactory> combinedResult, Action<Humidifier.SCN.DatasetTypes.PartitionSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionSpec(combinedResult.T5, subFactoryAction).T2);
}
