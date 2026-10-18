// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerAgentSpaceCodeReviewSettingsFactory(Action<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings>
{

    protected override Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings Create()
    {
        var codeReviewSettingsResult = CreateCodeReviewSettings();
        factoryAction?.Invoke(codeReviewSettingsResult);

        return codeReviewSettingsResult;
    }

    private Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings CreateCodeReviewSettings()
    {
        var codeReviewSettingsResult = new Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings();

        return codeReviewSettingsResult;
    }

} // End Of Class

public static class InnerAgentSpaceCodeReviewSettingsFactoryExtensions
{
}
