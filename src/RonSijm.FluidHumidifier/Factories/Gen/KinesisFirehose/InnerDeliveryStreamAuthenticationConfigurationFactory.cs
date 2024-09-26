// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamAuthenticationConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration Create()
    {
        var authenticationConfigurationResult = CreateAuthenticationConfiguration();
        factoryAction?.Invoke(authenticationConfigurationResult);

        return authenticationConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration CreateAuthenticationConfiguration()
    {
        var authenticationConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration();

        return authenticationConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamAuthenticationConfigurationFactoryExtensions
{
}
