// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineConfigurationKinesisDataStreamSinkConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KinesisDataStreamSinkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KinesisDataStreamSinkConfiguration>
{

    protected override Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KinesisDataStreamSinkConfiguration Create()
    {
        var kinesisDataStreamSinkConfigurationResult = CreateKinesisDataStreamSinkConfiguration();
        factoryAction?.Invoke(kinesisDataStreamSinkConfigurationResult);

        return kinesisDataStreamSinkConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KinesisDataStreamSinkConfiguration CreateKinesisDataStreamSinkConfiguration()
    {
        var kinesisDataStreamSinkConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KinesisDataStreamSinkConfiguration();

        return kinesisDataStreamSinkConfigurationResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineConfigurationKinesisDataStreamSinkConfigurationFactoryExtensions
{
}
