// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineSelectedVideoStreamsFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams Create()
    {
        var selectedVideoStreamsResult = CreateSelectedVideoStreams();
        factoryAction?.Invoke(selectedVideoStreamsResult);

        return selectedVideoStreamsResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams CreateSelectedVideoStreams()
    {
        var selectedVideoStreamsResult = new Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams();

        return selectedVideoStreamsResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineSelectedVideoStreamsFactoryExtensions
{
}
