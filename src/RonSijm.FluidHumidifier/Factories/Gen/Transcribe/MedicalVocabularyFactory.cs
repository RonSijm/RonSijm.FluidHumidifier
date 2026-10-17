// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class MedicalVocabularyFactory(string resourceName = null, Action<Humidifier.Transcribe.MedicalVocabulary> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.MedicalVocabulary>(resourceName)
{

    protected override Humidifier.Transcribe.MedicalVocabulary Create()
    {
        var medicalVocabularyResult = CreateMedicalVocabulary();
        factoryAction?.Invoke(medicalVocabularyResult);

        return medicalVocabularyResult;
    }

    private Humidifier.Transcribe.MedicalVocabulary CreateMedicalVocabulary()
    {
        var medicalVocabularyResult = new Humidifier.Transcribe.MedicalVocabulary
        {
            GivenName = InputResourceName,
        };

        return medicalVocabularyResult;
    }

} // End Of Class

public static class MedicalVocabularyFactoryExtensions
{
}
