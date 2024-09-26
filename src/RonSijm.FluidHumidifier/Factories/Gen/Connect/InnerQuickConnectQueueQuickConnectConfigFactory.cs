// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQuickConnectQueueQuickConnectConfigFactory(Action<Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig>
{

    protected override Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig Create()
    {
        var queueQuickConnectConfigResult = CreateQueueQuickConnectConfig();
        factoryAction?.Invoke(queueQuickConnectConfigResult);

        return queueQuickConnectConfigResult;
    }

    private Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig CreateQueueQuickConnectConfig()
    {
        var queueQuickConnectConfigResult = new Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig();

        return queueQuickConnectConfigResult;
    }

} // End Of Class

public static class InnerQuickConnectQueueQuickConnectConfigFactoryExtensions
{
}
