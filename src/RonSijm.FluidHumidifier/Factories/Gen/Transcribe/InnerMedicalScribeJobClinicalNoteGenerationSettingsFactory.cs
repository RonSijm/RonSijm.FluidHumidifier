// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerMedicalScribeJobClinicalNoteGenerationSettingsFactory(Action<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings>
{

    protected override Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings Create()
    {
        var clinicalNoteGenerationSettingsResult = CreateClinicalNoteGenerationSettings();
        factoryAction?.Invoke(clinicalNoteGenerationSettingsResult);

        return clinicalNoteGenerationSettingsResult;
    }

    private Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings CreateClinicalNoteGenerationSettings()
    {
        var clinicalNoteGenerationSettingsResult = new Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings();

        return clinicalNoteGenerationSettingsResult;
    }

} // End Of Class

public static class InnerMedicalScribeJobClinicalNoteGenerationSettingsFactoryExtensions
{
}
