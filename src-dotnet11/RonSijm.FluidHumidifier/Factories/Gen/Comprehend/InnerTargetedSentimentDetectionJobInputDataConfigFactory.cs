// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerTargetedSentimentDetectionJobInputDataConfigFactory(Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig>
{

    protected override Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerTargetedSentimentDetectionJobInputDataConfigFactoryExtensions
{
}
