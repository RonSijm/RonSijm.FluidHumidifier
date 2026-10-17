// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSkillGitAuthFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth Create()
    {
        var harnessSkillGitAuthResult = CreateHarnessSkillGitAuth();
        factoryAction?.Invoke(harnessSkillGitAuthResult);

        return harnessSkillGitAuthResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth CreateHarnessSkillGitAuth()
    {
        var harnessSkillGitAuthResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth();

        return harnessSkillGitAuthResult;
    }

} // End Of Class

public static class InnerHarnessHarnessSkillGitAuthFactoryExtensions
{
}
