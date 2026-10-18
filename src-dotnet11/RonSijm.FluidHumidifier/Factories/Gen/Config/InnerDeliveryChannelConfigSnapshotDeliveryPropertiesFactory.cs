// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactory(Action<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties> factoryAction = null) : SubResourceFactory<Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties>
{

    protected override Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties Create()
    {
        var configSnapshotDeliveryPropertiesResult = CreateConfigSnapshotDeliveryProperties();
        factoryAction?.Invoke(configSnapshotDeliveryPropertiesResult);

        return configSnapshotDeliveryPropertiesResult;
    }

    private Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties CreateConfigSnapshotDeliveryProperties()
    {
        var configSnapshotDeliveryPropertiesResult = new Humidifier.Config.DeliveryChannelTypes.ConfigSnapshotDeliveryProperties();

        return configSnapshotDeliveryPropertiesResult;
    }

} // End Of Class

public static class InnerDeliveryChannelConfigSnapshotDeliveryPropertiesFactoryExtensions
{
}
