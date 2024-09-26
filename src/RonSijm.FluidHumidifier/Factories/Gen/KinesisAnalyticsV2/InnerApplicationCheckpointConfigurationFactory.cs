// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationCheckpointConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration Create()
    {
        var checkpointConfigurationResult = CreateCheckpointConfiguration();
        factoryAction?.Invoke(checkpointConfigurationResult);

        return checkpointConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration CreateCheckpointConfiguration()
    {
        var checkpointConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.CheckpointConfiguration();

        return checkpointConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationCheckpointConfigurationFactoryExtensions
{
}
