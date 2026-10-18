// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessHookEventBridgeTargetFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget Create()
    {
        var harnessHookEventBridgeTargetResult = CreateHarnessHookEventBridgeTarget();
        factoryAction?.Invoke(harnessHookEventBridgeTargetResult);

        return harnessHookEventBridgeTargetResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget CreateHarnessHookEventBridgeTarget()
    {
        var harnessHookEventBridgeTargetResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookEventBridgeTarget();

        return harnessHookEventBridgeTargetResult;
    }

} // End Of Class

public static class InnerHarnessHarnessHookEventBridgeTargetFactoryExtensions
{
}
