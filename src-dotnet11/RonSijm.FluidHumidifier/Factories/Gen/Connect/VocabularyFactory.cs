// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class VocabularyFactory(string resourceName = null, Action<Humidifier.Connect.Vocabulary> factoryAction = null) : ResourceFactory<Humidifier.Connect.Vocabulary>(resourceName)
{

    protected override Humidifier.Connect.Vocabulary Create()
    {
        var vocabularyResult = CreateVocabulary();
        factoryAction?.Invoke(vocabularyResult);

        return vocabularyResult;
    }

    private Humidifier.Connect.Vocabulary CreateVocabulary()
    {
        var vocabularyResult = new Humidifier.Connect.Vocabulary
        {
            GivenName = InputResourceName,
        };

        return vocabularyResult;
    }

} // End Of Class

public static class VocabularyFactoryExtensions
{
}
