// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSnowflakeVpcConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeVpcConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeVpcConfiguration Create()
    {
        var snowflakeVpcConfigurationResult = CreateSnowflakeVpcConfiguration();
        factoryAction?.Invoke(snowflakeVpcConfigurationResult);

        return snowflakeVpcConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeVpcConfiguration CreateSnowflakeVpcConfiguration()
    {
        var snowflakeVpcConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeVpcConfiguration();

        return snowflakeVpcConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSnowflakeVpcConfigurationFactoryExtensions
{
}
