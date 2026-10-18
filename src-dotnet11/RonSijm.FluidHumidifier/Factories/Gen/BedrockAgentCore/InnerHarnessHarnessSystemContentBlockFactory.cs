// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSystemContentBlockFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock Create()
    {
        var harnessSystemContentBlockResult = CreateHarnessSystemContentBlock();
        factoryAction?.Invoke(harnessSystemContentBlockResult);

        return harnessSystemContentBlockResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock CreateHarnessSystemContentBlock()
    {
        var harnessSystemContentBlockResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSystemContentBlock();

        return harnessSystemContentBlockResult;
    }

} // End Of Class

public static class InnerHarnessHarnessSystemContentBlockFactoryExtensions
{
}
