// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicDatasetMetadataFactory(Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicTypes.DatasetMetadata>
{

    internal InnerTopicDataAggregationFactory DataAggregationFactory { get; set; }

    protected override Humidifier.QuickSight.TopicTypes.DatasetMetadata Create()
    {
        var datasetMetadataResult = CreateDatasetMetadata();
        factoryAction?.Invoke(datasetMetadataResult);

        return datasetMetadataResult;
    }

    private Humidifier.QuickSight.TopicTypes.DatasetMetadata CreateDatasetMetadata()
    {
        var datasetMetadataResult = new Humidifier.QuickSight.TopicTypes.DatasetMetadata();

        return datasetMetadataResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TopicTypes.DatasetMetadata result)
    {
        base.CreateChildren(result);

        result.DataAggregation ??= DataAggregationFactory?.Build();
    }

} // End Of Class

public static class InnerTopicDatasetMetadataFactoryExtensions
{
    public static CombinedResult<InnerTopicDatasetMetadataFactory, InnerTopicDataAggregationFactory> WithDataAggregation(this InnerTopicDatasetMetadataFactory parentFactory, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null)
    {
        parentFactory.DataAggregationFactory = new InnerTopicDataAggregationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataAggregationFactory);
    }

    public static CombinedResult<InnerTopicDatasetMetadataFactory, T1, InnerTopicDataAggregationFactory> WithDataAggregation<T1>(this CombinedResult<InnerTopicDatasetMetadataFactory, T1> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataAggregation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicDatasetMetadataFactory, InnerTopicDataAggregationFactory> WithDataAggregation<T1>(this CombinedResult<T1, InnerTopicDatasetMetadataFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataAggregation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTopicDatasetMetadataFactory, T1, T2, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2>(this CombinedResult<InnerTopicDatasetMetadataFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicDatasetMetadataFactory, T2, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2>(this CombinedResult<T1, InnerTopicDatasetMetadataFactory, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicDatasetMetadataFactory, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2>(this CombinedResult<T1, T2, InnerTopicDatasetMetadataFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTopicDatasetMetadataFactory, T1, T2, T3, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3>(this CombinedResult<InnerTopicDatasetMetadataFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicDatasetMetadataFactory, T2, T3, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3>(this CombinedResult<T1, InnerTopicDatasetMetadataFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicDatasetMetadataFactory, T3, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicDatasetMetadataFactory, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicDatasetMetadataFactory, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicDatasetMetadataFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTopicDatasetMetadataFactory, T1, T2, T3, T4, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3, T4>(this CombinedResult<InnerTopicDatasetMetadataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTopicDatasetMetadataFactory, T2, T3, T4, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicDatasetMetadataFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTopicDatasetMetadataFactory, T3, T4, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicDatasetMetadataFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTopicDatasetMetadataFactory, T4, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicDatasetMetadataFactory, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTopicDatasetMetadataFactory, InnerTopicDataAggregationFactory> WithDataAggregation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicDatasetMetadataFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DataAggregation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataAggregation(combinedResult.T5, subFactoryAction));
}
