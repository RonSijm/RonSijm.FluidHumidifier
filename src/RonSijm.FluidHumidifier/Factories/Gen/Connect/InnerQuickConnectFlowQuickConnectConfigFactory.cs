// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerQuickConnectFlowQuickConnectConfigFactory(Action<Humidifier.Connect.QuickConnectTypes.FlowQuickConnectConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.QuickConnectTypes.FlowQuickConnectConfig>
{

    protected override Humidifier.Connect.QuickConnectTypes.FlowQuickConnectConfig Create()
    {
        var flowQuickConnectConfigResult = CreateFlowQuickConnectConfig();
        factoryAction?.Invoke(flowQuickConnectConfigResult);

        return flowQuickConnectConfigResult;
    }

    private Humidifier.Connect.QuickConnectTypes.FlowQuickConnectConfig CreateFlowQuickConnectConfig()
    {
        var flowQuickConnectConfigResult = new Humidifier.Connect.QuickConnectTypes.FlowQuickConnectConfig();

        return flowQuickConnectConfigResult;
    }

} // End Of Class

public static class InnerQuickConnectFlowQuickConnectConfigFactoryExtensions
{
}
