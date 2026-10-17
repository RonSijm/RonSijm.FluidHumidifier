// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaLiveConnectorPipelineVideoAttributeFactory(Action<Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute>
{

    protected override Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute Create()
    {
        var videoAttributeResult = CreateVideoAttribute();
        factoryAction?.Invoke(videoAttributeResult);

        return videoAttributeResult;
    }

    private Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute CreateVideoAttribute()
    {
        var videoAttributeResult = new Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute();

        return videoAttributeResult;
    }

} // End Of Class

public static class InnerMediaLiveConnectorPipelineVideoAttributeFactoryExtensions
{
}
