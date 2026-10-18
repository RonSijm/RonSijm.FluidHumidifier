// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineKinesisVideoStreamSourceRuntimeConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration>
{

    protected override Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration Create()
    {
        var kinesisVideoStreamSourceRuntimeConfigurationResult = CreateKinesisVideoStreamSourceRuntimeConfiguration();
        factoryAction?.Invoke(kinesisVideoStreamSourceRuntimeConfigurationResult);

        return kinesisVideoStreamSourceRuntimeConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration CreateKinesisVideoStreamSourceRuntimeConfiguration()
    {
        var kinesisVideoStreamSourceRuntimeConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration();

        return kinesisVideoStreamSourceRuntimeConfigurationResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineKinesisVideoStreamSourceRuntimeConfigurationFactoryExtensions
{
}
