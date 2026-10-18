// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamTableCreationConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.TableCreationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.TableCreationConfiguration>
{

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.TableCreationConfiguration Create()
    {
        var tableCreationConfigurationResult = CreateTableCreationConfiguration();
        factoryAction?.Invoke(tableCreationConfigurationResult);

        return tableCreationConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.TableCreationConfiguration CreateTableCreationConfiguration()
    {
        var tableCreationConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.TableCreationConfiguration();

        return tableCreationConfigurationResult;
    }

} // End Of Class

public static class InnerDeliveryStreamTableCreationConfigurationFactoryExtensions
{
}
