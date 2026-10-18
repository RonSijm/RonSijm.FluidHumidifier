// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineVideoAttributeFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.VideoAttribute> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.VideoAttribute>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.VideoAttribute Create()
    {
        var videoAttributeResult = CreateVideoAttribute();
        factoryAction?.Invoke(videoAttributeResult);

        return videoAttributeResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.VideoAttribute CreateVideoAttribute()
    {
        var videoAttributeResult = new Humidifier.Chime.MediaCapturePipelineTypes.VideoAttribute();

        return videoAttributeResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineVideoAttributeFactoryExtensions
{
}
