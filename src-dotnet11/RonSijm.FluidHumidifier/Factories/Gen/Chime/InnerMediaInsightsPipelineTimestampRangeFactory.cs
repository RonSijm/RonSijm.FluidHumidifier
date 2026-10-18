// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineTimestampRangeFactory(Action<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange>
{

    protected override Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange Create()
    {
        var timestampRangeResult = CreateTimestampRange();
        factoryAction?.Invoke(timestampRangeResult);

        return timestampRangeResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange CreateTimestampRange()
    {
        var timestampRangeResult = new Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange();

        return timestampRangeResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineTimestampRangeFactoryExtensions
{
}
