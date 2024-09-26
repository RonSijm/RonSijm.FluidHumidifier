// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorDataSharingPreferenceFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.DataSharingPreference> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.DataSharingPreference>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.DataSharingPreference Create()
    {
        var dataSharingPreferenceResult = CreateDataSharingPreference();
        factoryAction?.Invoke(dataSharingPreferenceResult);

        return dataSharingPreferenceResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.DataSharingPreference CreateDataSharingPreference()
    {
        var dataSharingPreferenceResult = new Humidifier.Rekognition.StreamProcessorTypes.DataSharingPreference();

        return dataSharingPreferenceResult;
    }

} // End Of Class

public static class InnerStreamProcessorDataSharingPreferenceFactoryExtensions
{
}
