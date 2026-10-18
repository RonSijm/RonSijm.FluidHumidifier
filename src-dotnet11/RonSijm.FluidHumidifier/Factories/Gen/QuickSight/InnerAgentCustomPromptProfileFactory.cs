// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAgentCustomPromptProfileFactory(Action<Humidifier.QuickSight.AgentTypes.CustomPromptProfile> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AgentTypes.CustomPromptProfile>
{

    protected override Humidifier.QuickSight.AgentTypes.CustomPromptProfile Create()
    {
        var customPromptProfileResult = CreateCustomPromptProfile();
        factoryAction?.Invoke(customPromptProfileResult);

        return customPromptProfileResult;
    }

    private Humidifier.QuickSight.AgentTypes.CustomPromptProfile CreateCustomPromptProfile()
    {
        var customPromptProfileResult = new Humidifier.QuickSight.AgentTypes.CustomPromptProfile();

        return customPromptProfileResult;
    }

} // End Of Class

public static class InnerAgentCustomPromptProfileFactoryExtensions
{
}
