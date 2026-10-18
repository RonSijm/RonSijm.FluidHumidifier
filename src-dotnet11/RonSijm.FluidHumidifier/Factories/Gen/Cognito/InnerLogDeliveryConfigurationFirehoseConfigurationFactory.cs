// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerLogDeliveryConfigurationFirehoseConfigurationFactory(Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration>
{

    protected override Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration Create()
    {
        var firehoseConfigurationResult = CreateFirehoseConfiguration();
        factoryAction?.Invoke(firehoseConfigurationResult);

        return firehoseConfigurationResult;
    }

    private Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration CreateFirehoseConfiguration()
    {
        var firehoseConfigurationResult = new Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration();

        return firehoseConfigurationResult;
    }

} // End Of Class

public static class InnerLogDeliveryConfigurationFirehoseConfigurationFactoryExtensions
{
}
