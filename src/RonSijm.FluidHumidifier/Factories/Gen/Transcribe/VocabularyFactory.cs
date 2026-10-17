// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class VocabularyFactory(string resourceName = null, Action<Humidifier.Transcribe.Vocabulary> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.Vocabulary>(resourceName)
{

    protected override Humidifier.Transcribe.Vocabulary Create()
    {
        var vocabularyResult = CreateVocabulary();
        factoryAction?.Invoke(vocabularyResult);

        return vocabularyResult;
    }

    private Humidifier.Transcribe.Vocabulary CreateVocabulary()
    {
        var vocabularyResult = new Humidifier.Transcribe.Vocabulary
        {
            GivenName = InputResourceName,
        };

        return vocabularyResult;
    }

} // End Of Class

public static class VocabularyFactoryExtensions
{
}
