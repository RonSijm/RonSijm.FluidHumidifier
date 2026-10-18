// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAgentCustomPromptInputParametersFactory(Action<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters>
{

    protected override Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters Create()
    {
        var customPromptInputParametersResult = CreateCustomPromptInputParameters();
        factoryAction?.Invoke(customPromptInputParametersResult);

        return customPromptInputParametersResult;
    }

    private Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters CreateCustomPromptInputParameters()
    {
        var customPromptInputParametersResult = new Humidifier.QuickSight.AgentTypes.CustomPromptInputParameters();

        return customPromptInputParametersResult;
    }

} // End Of Class

public static class InnerAgentCustomPromptInputParametersFactoryExtensions
{
}
