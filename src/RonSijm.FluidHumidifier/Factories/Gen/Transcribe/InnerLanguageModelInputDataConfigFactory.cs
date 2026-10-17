// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerLanguageModelInputDataConfigFactory(Action<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.LanguageModelTypes.InputDataConfig>
{

    protected override Humidifier.Transcribe.LanguageModelTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Transcribe.LanguageModelTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Transcribe.LanguageModelTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerLanguageModelInputDataConfigFactoryExtensions
{
}
