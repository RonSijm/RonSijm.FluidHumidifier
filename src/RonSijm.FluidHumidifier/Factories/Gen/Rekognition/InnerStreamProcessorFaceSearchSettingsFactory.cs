// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorFaceSearchSettingsFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.FaceSearchSettings> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.FaceSearchSettings>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.FaceSearchSettings Create()
    {
        var faceSearchSettingsResult = CreateFaceSearchSettings();
        factoryAction?.Invoke(faceSearchSettingsResult);

        return faceSearchSettingsResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.FaceSearchSettings CreateFaceSearchSettings()
    {
        var faceSearchSettingsResult = new Humidifier.Rekognition.StreamProcessorTypes.FaceSearchSettings();

        return faceSearchSettingsResult;
    }

} // End Of Class

public static class InnerStreamProcessorFaceSearchSettingsFactoryExtensions
{
}
