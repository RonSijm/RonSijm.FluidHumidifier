// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessHookSnsTargetFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget Create()
    {
        var harnessHookSnsTargetResult = CreateHarnessHookSnsTarget();
        factoryAction?.Invoke(harnessHookSnsTargetResult);

        return harnessHookSnsTargetResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget CreateHarnessHookSnsTarget()
    {
        var harnessHookSnsTargetResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookSnsTarget();

        return harnessHookSnsTargetResult;
    }

} // End Of Class

public static class InnerHarnessHarnessHookSnsTargetFactoryExtensions
{
}
