// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineMeetingEventsConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration Create()
    {
        var meetingEventsConcatenationConfigurationResult = CreateMeetingEventsConcatenationConfiguration();
        factoryAction?.Invoke(meetingEventsConcatenationConfigurationResult);

        return meetingEventsConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration CreateMeetingEventsConcatenationConfiguration()
    {
        var meetingEventsConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration();

        return meetingEventsConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineMeetingEventsConcatenationConfigurationFactoryExtensions
{
}
