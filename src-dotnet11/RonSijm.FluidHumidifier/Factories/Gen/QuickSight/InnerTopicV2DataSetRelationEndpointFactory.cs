// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicV2DataSetRelationEndpointFactory(Action<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint>
{

    protected override Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint Create()
    {
        var dataSetRelationEndpointResult = CreateDataSetRelationEndpoint();
        factoryAction?.Invoke(dataSetRelationEndpointResult);

        return dataSetRelationEndpointResult;
    }

    private Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint CreateDataSetRelationEndpoint()
    {
        var dataSetRelationEndpointResult = new Humidifier.QuickSight.TopicV2Types.DataSetRelationEndpoint();

        return dataSetRelationEndpointResult;
    }

} // End Of Class

public static class InnerTopicV2DataSetRelationEndpointFactoryExtensions
{
}
