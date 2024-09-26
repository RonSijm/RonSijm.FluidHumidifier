// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerEncoderConfigurationVideoFactory(Action<Humidifier.IVS.EncoderConfigurationTypes.Video> factoryAction = null) : SubResourceFactory<Humidifier.IVS.EncoderConfigurationTypes.Video>
{

    protected override Humidifier.IVS.EncoderConfigurationTypes.Video Create()
    {
        var videoResult = CreateVideo();
        factoryAction?.Invoke(videoResult);

        return videoResult;
    }

    private Humidifier.IVS.EncoderConfigurationTypes.Video CreateVideo()
    {
        var videoResult = new Humidifier.IVS.EncoderConfigurationTypes.Video();

        return videoResult;
    }

} // End Of Class

public static class InnerEncoderConfigurationVideoFactoryExtensions
{
}
