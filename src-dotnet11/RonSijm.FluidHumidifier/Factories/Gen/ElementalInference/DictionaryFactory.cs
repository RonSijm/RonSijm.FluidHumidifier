// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElementalInference;

public class DictionaryFactory(string resourceName = null, Action<Humidifier.ElementalInference.Dictionary> factoryAction = null) : ResourceFactory<Humidifier.ElementalInference.Dictionary>(resourceName)
{

    protected override Humidifier.ElementalInference.Dictionary Create()
    {
        var dictionaryResult = CreateDictionary();
        factoryAction?.Invoke(dictionaryResult);

        return dictionaryResult;
    }

    private Humidifier.ElementalInference.Dictionary CreateDictionary()
    {
        var dictionaryResult = new Humidifier.ElementalInference.Dictionary
        {
            GivenName = InputResourceName,
        };

        return dictionaryResult;
    }

} // End Of Class

public static class DictionaryFactoryExtensions
{
}
