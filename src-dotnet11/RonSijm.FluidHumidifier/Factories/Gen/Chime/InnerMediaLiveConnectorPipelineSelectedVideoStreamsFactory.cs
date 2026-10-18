// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams Create()
    {
        var selectedVideoStreamsResult = CreateSelectedVideoStreams();
        factoryAction?.Invoke(selectedVideoStreamsResult);

        return selectedVideoStreamsResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams CreateSelectedVideoStreams()
    {
        var selectedVideoStreamsResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams();

        return selectedVideoStreamsResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineSelectedVideoStreamsFactoryExtensions
{
}
