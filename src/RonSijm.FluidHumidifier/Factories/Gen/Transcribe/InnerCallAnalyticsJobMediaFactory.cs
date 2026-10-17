// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerCallAnalyticsJobMediaFactory(Action<Humidifier.Transcribe.CallAnalyticsJobTypes.Media> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.CallAnalyticsJobTypes.Media>
{

    protected override Humidifier.Transcribe.CallAnalyticsJobTypes.Media Create()
    {
        var mediaResult = CreateMedia();
        factoryAction?.Invoke(mediaResult);

        return mediaResult;
    }

    private Humidifier.Transcribe.CallAnalyticsJobTypes.Media CreateMedia()
    {
        var mediaResult = new Humidifier.Transcribe.CallAnalyticsJobTypes.Media();

        return mediaResult;
    }

} // End Of Class

public static class InnerCallAnalyticsJobMediaFactoryExtensions
{
}
