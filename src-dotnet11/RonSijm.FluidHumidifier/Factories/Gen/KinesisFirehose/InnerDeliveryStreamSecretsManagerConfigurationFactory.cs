// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamSecretsManagerConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration Create()
    {
        var secretsManagerConfigurationResult = CreateSecretsManagerConfiguration();
        factoryAction?.Invoke(secretsManagerConfigurationResult);

        return secretsManagerConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration CreateSecretsManagerConfiguration()
    {
        var secretsManagerConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration();

        return secretsManagerConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamSecretsManagerConfigurationFactoryExtensions
{
}
