// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicDataAggregationFactory(Action<Humidifier.QuickSight.TopicTypes.DataAggregation> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicTypes.DataAggregation>
{

    protected override Humidifier.QuickSight.TopicTypes.DataAggregation Create()
    {
        var dataAggregationResult = CreateDataAggregation();
        factoryAction?.Invoke(dataAggregationResult);

        return dataAggregationResult;
    }

    private Humidifier.QuickSight.TopicTypes.DataAggregation CreateDataAggregation()
    {
        var dataAggregationResult = new Humidifier.QuickSight.TopicTypes.DataAggregation();

        return dataAggregationResult;
    }

} // End Of Class

public static class InnerTopicDataAggregationFactoryExtensions
{
}
