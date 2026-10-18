// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamRedshiftRetryOptionsFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.RedshiftRetryOptions> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.RedshiftRetryOptions>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.RedshiftRetryOptions Create()
    {
        var redshiftRetryOptionsResult = CreateRedshiftRetryOptions();
        factoryAction?.Invoke(redshiftRetryOptionsResult);

        return redshiftRetryOptionsResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.RedshiftRetryOptions CreateRedshiftRetryOptions()
    {
        var redshiftRetryOptionsResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.RedshiftRetryOptions();

        return redshiftRetryOptionsResult;
    }

} // End Of Class

public static class InnerDeliveryStreamRedshiftRetryOptionsFactoryExtensions
{
}
