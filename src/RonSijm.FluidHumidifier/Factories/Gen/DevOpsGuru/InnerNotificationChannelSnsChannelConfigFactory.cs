// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class InnerNotificationChannelSnsChannelConfigFactory(Action<Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig>
{

    protected override Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig Create()
    {
        var snsChannelConfigResult = CreateSnsChannelConfig();
        factoryAction?.Invoke(snsChannelConfigResult);

        return snsChannelConfigResult;
    }

    private Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig CreateSnsChannelConfig()
    {
        var snsChannelConfigResult = new Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig();

        return snsChannelConfigResult;
    }

} // End Of Class

public static class InnerNotificationChannelSnsChannelConfigFactoryExtensions
{
}
