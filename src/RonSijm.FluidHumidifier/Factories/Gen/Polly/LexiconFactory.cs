// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Polly;

public class LexiconFactory(string resourceName = null, Action<Humidifier.Polly.Lexicon> factoryAction = null) : ResourceFactory<Humidifier.Polly.Lexicon>(resourceName)
{

    protected override Humidifier.Polly.Lexicon Create()
    {
        var lexiconResult = CreateLexicon();
        factoryAction?.Invoke(lexiconResult);

        return lexiconResult;
    }

    private Humidifier.Polly.Lexicon CreateLexicon()
    {
        var lexiconResult = new Humidifier.Polly.Lexicon
        {
            GivenName = InputResourceName,
        };

        return lexiconResult;
    }

} // End Of Class

public static class LexiconFactoryExtensions
{
}
