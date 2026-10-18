// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactory(Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting>
{

    protected override Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting Create()
    {
        var medicalTranscriptionSettingResult = CreateMedicalTranscriptionSetting();
        factoryAction?.Invoke(medicalTranscriptionSettingResult);

        return medicalTranscriptionSettingResult;
    }

    private Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting CreateMedicalTranscriptionSetting()
    {
        var medicalTranscriptionSettingResult = new Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting();

        return medicalTranscriptionSettingResult;
    }

} // End Of Class

public static class InnerMedicalTranscriptionJobMedicalTranscriptionSettingFactoryExtensions
{
}
