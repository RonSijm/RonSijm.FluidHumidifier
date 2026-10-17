// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicV2DataSetReferenceFactory(Action<Humidifier.QuickSight.TopicV2Types.DataSetReference> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicV2Types.DataSetReference>
{

    protected override Humidifier.QuickSight.TopicV2Types.DataSetReference Create()
    {
        var dataSetReferenceResult = CreateDataSetReference();
        factoryAction?.Invoke(dataSetReferenceResult);

        return dataSetReferenceResult;
    }

    private Humidifier.QuickSight.TopicV2Types.DataSetReference CreateDataSetReference()
    {
        var dataSetReferenceResult = new Humidifier.QuickSight.TopicV2Types.DataSetReference();

        return dataSetReferenceResult;
    }

} // End Of Class

public static class InnerTopicV2DataSetReferenceFactoryExtensions
{
}
