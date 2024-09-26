// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSnowflakeBufferingHintsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeBufferingHints> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeBufferingHints>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeBufferingHints Create()
    {
        var snowflakeBufferingHintsResult = CreateSnowflakeBufferingHints();
        factoryAction?.Invoke(snowflakeBufferingHintsResult);

        return snowflakeBufferingHintsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeBufferingHints CreateSnowflakeBufferingHints()
    {
        var snowflakeBufferingHintsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeBufferingHints();

        return snowflakeBufferingHintsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSnowflakeBufferingHintsFactoryExtensions
{
}
