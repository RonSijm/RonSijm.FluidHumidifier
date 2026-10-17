// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class VocabularyFilterFactory(string resourceName = null, Action<Humidifier.Transcribe.VocabularyFilter> factoryAction = null) : ResourceFactory<Humidifier.Transcribe.VocabularyFilter>(resourceName)
{

    protected override Humidifier.Transcribe.VocabularyFilter Create()
    {
        var vocabularyFilterResult = CreateVocabularyFilter();
        factoryAction?.Invoke(vocabularyFilterResult);

        return vocabularyFilterResult;
    }

    private Humidifier.Transcribe.VocabularyFilter CreateVocabularyFilter()
    {
        var vocabularyFilterResult = new Humidifier.Transcribe.VocabularyFilter
        {
            GivenName = InputResourceName,
        };

        return vocabularyFilterResult;
    }

} // End Of Class

public static class VocabularyFilterFactoryExtensions
{
}
