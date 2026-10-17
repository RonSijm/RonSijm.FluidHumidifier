// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicV2DataSetRelationFactory(Action<Humidifier.QuickSight.TopicV2Types.DataSetRelation> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicV2Types.DataSetRelation>
{

    internal InnerTopicV2DataSetRelationEndpointFactory LeftFactory { get; set; }

    internal InnerTopicV2DataSetRelationEndpointFactory RightFactory { get; set; }

    protected override Humidifier.QuickSight.TopicV2Types.DataSetRelation Create()
    {
        var dataSetRelationResult = CreateDataSetRelation();
        factoryAction?.Invoke(dataSetRelationResult);

        return dataSetRelationResult;
    }

    private Humidifier.QuickSight.TopicV2Types.DataSetRelation CreateDataSetRelation()
    {
        var dataSetRelationResult = new Humidifier.QuickSight.TopicV2Types.DataSetRelation();

        return dataSetRelationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TopicV2Types.DataSetRelation result)
    {
        base.CreateChildren(result);

        result.Left ??= LeftFactory?.Build();
        result.Right ??= RightFactory?.Build();
    }

} // End Of Class

public static class InnerTopicV2DataSetRelationFactoryExtensions
{
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithLeft(this InnerTopicV2DataSetRelationFactory parentFactory, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null)
    {
        parentFactory.LeftFactory = new InnerTopicV2DataSetRelationEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LeftFactory);
    }

    public static CombinedResult<InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithRight(this InnerTopicV2DataSetRelationFactory parentFactory, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null)
    {
        parentFactory.RightFactory = new InnerTopicV2DataSetRelationEndpointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RightFactory);
    }

    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithLeft(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithLeft(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2>(this CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3, T4, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3, T4>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3, T4, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3, T4, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory, T4, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithLeft<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLeft(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithRight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithRight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2>(this CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3>(this CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3, T4, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3, T4>(this CombinedResult<InnerTopicV2DataSetRelationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3, T4, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3, T4>(this CombinedResult<T1, InnerTopicV2DataSetRelationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3, T4, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTopicV2DataSetRelationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory, T4, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTopicV2DataSetRelationFactory, T4> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTopicV2DataSetRelationFactory, InnerTopicV2DataSetRelationEndpointFactory> WithRight<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTopicV2DataSetRelationFactory> combinedResult, Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRight(combinedResult.T5, subFactoryAction).T2);
}
