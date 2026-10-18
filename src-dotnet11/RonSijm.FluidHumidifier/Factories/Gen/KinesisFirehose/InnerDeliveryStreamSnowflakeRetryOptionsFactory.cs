// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSnowflakeRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRetryOptions Create()
    {
        var snowflakeRetryOptionsResult = CreateSnowflakeRetryOptions();
        factoryAction?.Invoke(snowflakeRetryOptionsResult);

        return snowflakeRetryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRetryOptions CreateSnowflakeRetryOptions()
    {
        var snowflakeRetryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRetryOptions();

        return snowflakeRetryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSnowflakeRetryOptionsFactoryExtensions
{
}
