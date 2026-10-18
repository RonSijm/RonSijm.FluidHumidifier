// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerDominantLanguageDetectionJobInputDataConfigFactory(Action<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig>
{

    protected override Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerDominantLanguageDetectionJobInputDataConfigFactoryExtensions
{
}
