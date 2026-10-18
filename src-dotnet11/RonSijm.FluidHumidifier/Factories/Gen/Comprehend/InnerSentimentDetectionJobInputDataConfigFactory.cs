// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerSentimentDetectionJobInputDataConfigFactory(Action<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig>
{

    protected override Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Comprehend.SentimentDetectionJobTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerSentimentDetectionJobInputDataConfigFactoryExtensions
{
}
