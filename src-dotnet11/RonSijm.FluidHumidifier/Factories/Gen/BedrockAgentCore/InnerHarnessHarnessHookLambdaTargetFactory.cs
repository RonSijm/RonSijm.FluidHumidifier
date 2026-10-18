// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessHookLambdaTargetFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget Create()
    {
        var harnessHookLambdaTargetResult = CreateHarnessHookLambdaTarget();
        factoryAction?.Invoke(harnessHookLambdaTargetResult);

        return harnessHookLambdaTargetResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget CreateHarnessHookLambdaTarget()
    {
        var harnessHookLambdaTargetResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessHookLambdaTarget();

        return harnessHookLambdaTargetResult;
    }

} // End Of Class

public static class InnerHarnessHarnessHookLambdaTargetFactoryExtensions
{
}
