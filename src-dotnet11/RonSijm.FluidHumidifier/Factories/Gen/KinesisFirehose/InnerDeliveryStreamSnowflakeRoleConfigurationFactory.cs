// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSnowflakeRoleConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRoleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRoleConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRoleConfiguration Create()
    {
        var snowflakeRoleConfigurationResult = CreateSnowflakeRoleConfiguration();
        factoryAction?.Invoke(snowflakeRoleConfigurationResult);

        return snowflakeRoleConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRoleConfiguration CreateSnowflakeRoleConfiguration()
    {
        var snowflakeRoleConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SnowflakeRoleConfiguration();

        return snowflakeRoleConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSnowflakeRoleConfigurationFactoryExtensions
{
}
