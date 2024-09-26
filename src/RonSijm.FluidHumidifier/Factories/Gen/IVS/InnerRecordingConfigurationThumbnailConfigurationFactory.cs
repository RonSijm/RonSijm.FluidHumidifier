// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerRecordingConfigurationThumbnailConfigurationFactory(Action<Humidifier.IVS.RecordingConfigurationTypes.ThumbnailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.RecordingConfigurationTypes.ThumbnailConfiguration>
{

    protected override Humidifier.IVS.RecordingConfigurationTypes.ThumbnailConfiguration Create()
    {
        var thumbnailConfigurationResult = CreateThumbnailConfiguration();
        factoryAction?.Invoke(thumbnailConfigurationResult);

        return thumbnailConfigurationResult;
    }

    private Humidifier.IVS.RecordingConfigurationTypes.ThumbnailConfiguration CreateThumbnailConfiguration()
    {
        var thumbnailConfigurationResult = new Humidifier.IVS.RecordingConfigurationTypes.ThumbnailConfiguration();

        return thumbnailConfigurationResult;
    }

} // End Of Class

public static class InnerRecordingConfigurationThumbnailConfigurationFactoryExtensions
{
}
