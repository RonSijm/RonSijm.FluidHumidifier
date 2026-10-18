// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SNS;

public class InnerTopicLoggingConfigFactory(Action<Humidifier.SNS.TopicTypes.LoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SNS.TopicTypes.LoggingConfig>
{

    protected override Humidifier.SNS.TopicTypes.LoggingConfig Create()
    {
        var loggingConfigResult = CreateLoggingConfig();
        factoryAction?.Invoke(loggingConfigResult);

        return loggingConfigResult;
    }

    private Humidifier.SNS.TopicTypes.LoggingConfig CreateLoggingConfig()
    {
        var loggingConfigResult = new Humidifier.SNS.TopicTypes.LoggingConfig();

        return loggingConfigResult;
    }

} // End Of Class

public static class InnerTopicLoggingConfigFactoryExtensions
{
}
